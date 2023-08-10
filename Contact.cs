using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Classes
{
     class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }

        static string constring = ConfigurationManager.ConnectionStrings["contactDB"].ConnectionString;


        //show all contacts method
        public DataTable SelectContact()
        {
            //Create db connection and datatable
            SqlConnection con = new SqlConnection(constring);
            DataTable db = new DataTable();

            //Query the table
            try
            {
                string searchQ = "SELECT * FROM Contact";
                SqlCommand cmd = new SqlCommand(searchQ,con);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                con.Open();
                adapt.Fill(db);
            }
            catch (Exception e)
            {

            }
            finally 
            { 
                con.Close(); 
            }
            return db;

        }


        //insert method
        public bool Insert( Contact contact)
        {
            bool Inserted = false;
            //Create db connection and datatable
            SqlConnection con = new SqlConnection(constring);
            DataTable db = new DataTable();

            //Insert new contact
            //Query the table
            try
            {
                string searchQ = "INSERT INTO Contact(FirstName,LastName,Email,Phone,Gender) VALUES (@FirstName,@LastName,@Email,@Phone,@Gender)";
                SqlCommand cmd = new SqlCommand(searchQ, con);
                cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.Parameters.AddWithValue("@Phone", contact.Phone);
                cmd.Parameters.AddWithValue("@Gender", contact.Gender);
                
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    Inserted = true;
                }
                else
                {
                    Inserted=false;
                }
                
            }
            catch (Exception e)
            {

            }
            finally
            {
                con.Close();
            }




            return Inserted;
        }

      

        //update current contact
        public bool Update( Contact contact )
        {
            //Create db connection and datatable
            SqlConnection con = new SqlConnection(constring);
            bool Updated = false;

            try
            {
                string searchQ = "UPDATE Contact SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone,Gender=@Gender WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(searchQ, con);
                cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@LastName", contact.LastName);
                cmd.Parameters.AddWithValue("@Email", contact.Email);
                cmd.Parameters.AddWithValue("@Phone", contact.Phone);
                cmd.Parameters.AddWithValue("@Gender", contact.Gender);
                cmd.Parameters.AddWithValue("@Id", contact.Id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Updated= true;
                }
                else
                {
                    Updated= false;
                }
            }
            catch ( Exception e ) 
            {

            }
            finally
            {
                con.Close() ;
            }



            return Updated;
        }

        public bool Delete( Contact contact )
        {
            SqlConnection con = new SqlConnection(constring);
            bool Deleted = false;
            try{
                string searchQ = "DELETE FROM Contact WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(searchQ, con);
                cmd.Parameters.AddWithValue("@Id", contact.Id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Deleted = true;
                }
                else
                {
                    Deleted = false;
                }
            }
            catch( Exception e )
            {

            }
            finally
            {
                con.Close();
            }
            return Deleted;
        }

    }
}
