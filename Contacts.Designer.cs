namespace Contacts
{
    partial class Contacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.txtContactFname = new System.Windows.Forms.TextBox();
            this.lblContactFname = new System.Windows.Forms.Label();
            this.txtContactLname = new System.Windows.Forms.TextBox();
            this.lblContactLname = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.cmbContactGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.lblFindContacts = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(398, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(85, 141);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(26, 20);
            this.lblContactID.TabIndex = 1;
            this.lblContactID.Text = "ID";
            this.lblContactID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContactID
            // 
            this.txtContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactID.Location = new System.Drawing.Point(120, 139);
            this.txtContactID.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.ReadOnly = true;
            this.txtContactID.Size = new System.Drawing.Size(135, 26);
            this.txtContactID.TabIndex = 2;
            this.txtContactID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContactFname
            // 
            this.txtContactFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactFname.Location = new System.Drawing.Point(120, 178);
            this.txtContactFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactFname.Name = "txtContactFname";
            this.txtContactFname.Size = new System.Drawing.Size(135, 26);
            this.txtContactFname.TabIndex = 4;
            // 
            // lblContactFname
            // 
            this.lblContactFname.AutoSize = true;
            this.lblContactFname.BackColor = System.Drawing.Color.Transparent;
            this.lblContactFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFname.Location = new System.Drawing.Point(22, 180);
            this.lblContactFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactFname.Name = "lblContactFname";
            this.lblContactFname.Size = new System.Drawing.Size(86, 20);
            this.lblContactFname.TabIndex = 3;
            this.lblContactFname.Text = "First Name";
            this.lblContactFname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtContactLname
            // 
            this.txtContactLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactLname.Location = new System.Drawing.Point(120, 213);
            this.txtContactLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactLname.Name = "txtContactLname";
            this.txtContactLname.Size = new System.Drawing.Size(135, 26);
            this.txtContactLname.TabIndex = 6;
            // 
            // lblContactLname
            // 
            this.lblContactLname.AutoSize = true;
            this.lblContactLname.BackColor = System.Drawing.Color.Transparent;
            this.lblContactLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactLname.Location = new System.Drawing.Point(24, 217);
            this.lblContactLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactLname.Name = "lblContactLname";
            this.lblContactLname.Size = new System.Drawing.Size(86, 20);
            this.lblContactLname.TabIndex = 5;
            this.lblContactLname.Text = "Last Name";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactEmail.Location = new System.Drawing.Point(120, 250);
            this.txtContactEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(135, 26);
            this.txtContactEmail.TabIndex = 8;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPhone.Location = new System.Drawing.Point(54, 252);
            this.lblContactPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(48, 20);
            this.lblContactPhone.TabIndex = 7;
            this.lblContactPhone.Text = "Email";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPhone.Location = new System.Drawing.Point(120, 286);
            this.txtContactPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(135, 26);
            this.txtContactPhone.TabIndex = 10;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEmail.Location = new System.Drawing.Point(54, 288);
            this.lblContactEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(55, 20);
            this.lblContactEmail.TabIndex = 9;
            this.lblContactEmail.Text = "Phone";
            // 
            // cmbContactGender
            // 
            this.cmbContactGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContactGender.FormattingEnabled = true;
            this.cmbContactGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbContactGender.Location = new System.Drawing.Point(120, 320);
            this.cmbContactGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbContactGender.Name = "cmbContactGender";
            this.cmbContactGender.Size = new System.Drawing.Size(100, 28);
            this.cmbContactGender.TabIndex = 11;
            this.cmbContactGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gender";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(293, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(507, 404);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(717, 404);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvContacts
            // 
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContacts.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvContacts.Location = new System.Drawing.Point(293, 139);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 62;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.Size = new System.Drawing.Size(511, 250);
            this.dgvContacts.TabIndex = 16;
            this.dgvContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
            this.dgvContacts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContacts_RowHeaderMouseClick);
            // 
            // lblFindContacts
            // 
            this.lblFindContacts.AutoSize = true;
            this.lblFindContacts.BackColor = System.Drawing.Color.Transparent;
            this.lblFindContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindContacts.Location = new System.Drawing.Point(296, 115);
            this.lblFindContacts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFindContacts.Name = "lblFindContacts";
            this.lblFindContacts.Size = new System.Drawing.Size(100, 20);
            this.lblFindContacts.TabIndex = 17;
            this.lblFindContacts.Text = "Find Contact";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFind.Location = new System.Drawing.Point(398, 111);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(406, 26);
            this.txtFind.TabIndex = 18;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 458);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.lblFindContacts);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbContactGender);
            this.Controls.Add(this.txtContactPhone);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.txtContactLname);
            this.Controls.Add(this.lblContactLname);
            this.Controls.Add(this.txtContactFname);
            this.Controls.Add(this.lblContactFname);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Contacts";
            this.ShowIcon = false;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.TextBox txtContactFname;
        private System.Windows.Forms.Label lblContactFname;
        private System.Windows.Forms.TextBox txtContactLname;
        private System.Windows.Forms.Label lblContactLname;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.ComboBox cmbContactGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Label lblFindContacts;
        private System.Windows.Forms.TextBox txtFind;
    }
}

