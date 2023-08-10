using Contacts.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Contacts : Form
    {

        static string connstr = ConfigurationManager.ConnectionStrings["contactDB"].ConnectionString;
        public Contacts()
        {
            InitializeComponent();
        }

        Contact c = new Contact();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            DataTable dt = c.SelectContact();
            dgvContacts.DataSource = dt;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Retrieve values

            try
            {
                if (txtContactFname.Text != null && !txtContactFname.Text.Equals(""))

                {
                    c.FirstName = txtContactFname.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a first name");
                }
                if (txtContactLname.Text != null && !txtContactLname.Text.Equals(""))
                {
                    c.LastName = txtContactLname.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a last name");
                }
                if (txtContactEmail.Text != null && !txtContactEmail.Text.Equals(""))
                {
                    c.Email = txtContactEmail.Text;
                }
                else
                {
                    MessageBox.Show("Please enter an email");
                }
                if (txtContactPhone.Text != null && !txtContactPhone.Text.Equals(""))
                {
                    c.Phone = txtContactPhone.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a phone number");
                }
                if (cmbContactGender.Text != null && !cmbContactGender.Text.Equals(""))
                {
                    c.Gender = cmbContactGender.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a gender");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please add all information");
            }

            //insert into db
            bool inserted = c.Insert(c);
            if (inserted)
            {
                MessageBox.Show("New Contact Added");
                Clear();
               
            }

            DataTable dt = c.SelectContact();
            dgvContacts.DataSource = dt;
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContacts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtContactID.Text = dgvContacts.Rows[rowIndex].Cells[0].Value.ToString();
            txtContactFname.Text = dgvContacts.Rows[rowIndex].Cells[1].Value.ToString();
            txtContactLname.Text = dgvContacts.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactEmail.Text = dgvContacts.Rows[rowIndex].Cells[3].Value.ToString();
            txtContactPhone.Text = dgvContacts.Rows[rowIndex].Cells[4].Value.ToString();
            cmbContactGender.Text = dgvContacts.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool updated = false;
            try
            {
                c.Id = int.Parse(txtContactID.Text);
                c.FirstName = txtContactFname.Text;
                c.LastName = txtContactLname.Text;
                c.Email = txtContactEmail.Text;
                c.Phone = txtContactPhone.Text;
                c.Gender = cmbContactGender.Text;
                 updated = c.Update(c);
            } catch (Exception ex) {
            
            } 
            if (updated)
            {
                MessageBox.Show("Contact updated");
                DataTable dt = c.SelectContact();
                dgvContacts.DataSource = dt;

                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact");
            }
        }

        private void Clear()
        {
            txtContactID.Text = "";
            txtContactFname.Text = "";
            txtContactLname.Text = "";
            txtContactEmail.Text = "";
            txtContactPhone.Text = "";
            cmbContactGender.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            try
            {
                c.Id = Convert.ToInt32(txtContactID.Text);
                 deleted = c.Delete(c);
            }
            catch(Exception ex)
            {
                    
            }
            if(deleted)
            {
                MessageBox.Show("Contact deleted");

                DataTable dt = c.SelectContact();
                dgvContacts.DataSource = dt;

                Clear();

            }
            else {

                MessageBox.Show("Failed to delete contact");
            }

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string keyword =txtFind.Text;
            SqlConnection con = new SqlConnection(connstr);
          
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Contact WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '%"+keyword+"%' OR Email LIKE '%"+keyword+"%' OR Phone LIKE '%"+keyword+"%'",con);
;           DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvContacts.DataSource=dt;
        }

    }
}
