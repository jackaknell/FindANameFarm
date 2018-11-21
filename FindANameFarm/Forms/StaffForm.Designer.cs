﻿namespace FindANameFarm
{
    partial class StaffForm
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
            this.components = new System.ComponentModel.Container();
            this.listStaff = new System.Windows.Forms.ListView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblfName = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnCloseStaffForm = new System.Windows.Forms.Button();
            this.pbStaffImage = new System.Windows.Forms.PictureBox();
            this.gbCompetencies = new System.Windows.Forms.GroupBox();
            this.listCompetencies = new System.Windows.Forms.ListView();
            this.btnRemoveCompetency = new System.Windows.Forms.Button();
            this.btnAddCompetency = new System.Windows.Forms.Button();
            this.cbCompetencies = new System.Windows.Forms.ComboBox();
            this.lblCompetenciesList = new System.Windows.Forms.Label();
            this.lblCompetency = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.staffAndCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).BeginInit();
            this.gbCompetencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffAndCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listStaff
            // 
            this.listStaff.GridLines = true;
            this.listStaff.Location = new System.Drawing.Point(590, 12);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(582, 550);
            this.listStaff.TabIndex = 0;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            this.listStaff.View = System.Windows.Forms.View.Details;
            this.listStaff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(127, 46);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(175, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(127, 84);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(175, 20);
            this.txtfName.TabIndex = 2;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(127, 122);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(175, 20);
            this.txtSname.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(127, 199);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(175, 20);
            this.txtemail.TabIndex = 5;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(127, 276);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(175, 20);
            this.txtContact.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 630);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Create New Staff Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Location = new System.Drawing.Point(27, 86);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(57, 13);
            this.lblfName.TabIndex = 9;
            this.lblfName.Text = "First Name";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Location = new System.Drawing.Point(27, 125);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(49, 13);
            this.lblSname.TabIndex = 10;
            this.lblSname.Text = "Surname";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(27, 47);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(93, 13);
            this.lblEmployee.TabIndex = 11;
            this.lblEmployee.Text = "Employee Number";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(27, 164);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "gender";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(27, 203);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(31, 13);
            this.lblemail.TabIndex = 13;
            this.lblemail.Text = "email";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(27, 242);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "Position";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(27, 281);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(84, 13);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 630);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Selected Staff Member";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 630);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete Sellected Staff Member";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(127, 314);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(175, 20);
            this.txtImagePath.TabIndex = 18;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(27, 320);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(80, 13);
            this.lblImage.TabIndex = 19;
            this.lblImage.Text = "Image Location";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Manager",
            "Labourer"});
            this.cbPosition.Location = new System.Drawing.Point(127, 237);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(175, 21);
            this.cbPosition.TabIndex = 20;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(127, 160);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(175, 21);
            this.cbGender.TabIndex = 21;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(325, 314);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnCloseStaffForm
            // 
            this.btnCloseStaffForm.Location = new System.Drawing.Point(1097, 630);
            this.btnCloseStaffForm.Name = "btnCloseStaffForm";
            this.btnCloseStaffForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseStaffForm.TabIndex = 23;
            this.btnCloseStaffForm.Text = "Close";
            this.btnCloseStaffForm.UseVisualStyleBackColor = true;
            this.btnCloseStaffForm.Click += new System.EventHandler(this.btnCloseStaffForm_Click);
            // 
            // pbStaffImage
            // 
            this.pbStaffImage.Location = new System.Drawing.Point(363, 64);
            this.pbStaffImage.Name = "pbStaffImage";
            this.pbStaffImage.Size = new System.Drawing.Size(180, 173);
            this.pbStaffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStaffImage.TabIndex = 24;
            this.pbStaffImage.TabStop = false;
            // 
            // gbCompetencies
            // 
            this.gbCompetencies.Controls.Add(this.listCompetencies);
            this.gbCompetencies.Controls.Add(this.btnRemoveCompetency);
            this.gbCompetencies.Controls.Add(this.btnAddCompetency);
            this.gbCompetencies.Controls.Add(this.cbCompetencies);
            this.gbCompetencies.Controls.Add(this.lblCompetenciesList);
            this.gbCompetencies.Controls.Add(this.lblCompetency);
            this.gbCompetencies.Location = new System.Drawing.Point(12, 388);
            this.gbCompetencies.Name = "gbCompetencies";
            this.gbCompetencies.Size = new System.Drawing.Size(558, 210);
            this.gbCompetencies.TabIndex = 25;
            this.gbCompetencies.TabStop = false;
            // 
            // listCompetencies
            // 
            this.listCompetencies.GridLines = true;
            this.listCompetencies.Location = new System.Drawing.Point(346, 41);
            this.listCompetencies.Name = "listCompetencies";
            this.listCompetencies.Size = new System.Drawing.Size(187, 124);
            this.listCompetencies.TabIndex = 5;
            this.listCompetencies.UseCompatibleStateImageBehavior = false;
            this.listCompetencies.View = System.Windows.Forms.View.Details;
            // 
            // btnRemoveCompetency
            // 
            this.btnRemoveCompetency.Location = new System.Drawing.Point(346, 181);
            this.btnRemoveCompetency.Name = "btnRemoveCompetency";
            this.btnRemoveCompetency.Size = new System.Drawing.Size(187, 23);
            this.btnRemoveCompetency.TabIndex = 4;
            this.btnRemoveCompetency.Text = "Remove Selected Competency";
            this.btnRemoveCompetency.UseVisualStyleBackColor = true;
            this.btnRemoveCompetency.Click += new System.EventHandler(this.btnRemoveCompetency_Click);
            // 
            // btnAddCompetency
            // 
            this.btnAddCompetency.Location = new System.Drawing.Point(249, 33);
            this.btnAddCompetency.Name = "btnAddCompetency";
            this.btnAddCompetency.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompetency.TabIndex = 3;
            this.btnAddCompetency.Text = "Add";
            this.btnAddCompetency.UseVisualStyleBackColor = true;
            this.btnAddCompetency.Click += new System.EventHandler(this.btnAddCompetency_Click);
            // 
            // cbCompetencies
            // 
            this.cbCompetencies.FormattingEnabled = true;
            this.cbCompetencies.Location = new System.Drawing.Point(112, 33);
            this.cbCompetencies.Name = "cbCompetencies";
            this.cbCompetencies.Size = new System.Drawing.Size(121, 21);
            this.cbCompetencies.TabIndex = 2;
            // 
            // lblCompetenciesList
            // 
            this.lblCompetenciesList.AutoSize = true;
            this.lblCompetenciesList.Location = new System.Drawing.Point(343, 25);
            this.lblCompetenciesList.Name = "lblCompetenciesList";
            this.lblCompetenciesList.Size = new System.Drawing.Size(123, 13);
            this.lblCompetenciesList.TabIndex = 1;
            this.lblCompetenciesList.Text = "Employee Competencies";
            // 
            // lblCompetency
            // 
            this.lblCompetency.AutoSize = true;
            this.lblCompetency.Location = new System.Drawing.Point(19, 36);
            this.lblCompetency.Name = "lblCompetency";
            this.lblCompetency.Size = new System.Drawing.Size(91, 13);
            this.lblCompetency.TabIndex = 0;
            this.lblCompetency.Text = "Add Competency:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 359);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password";
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(127, 352);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(175, 20);
            this.txtStaffPassword.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffAndCategoryBindingSource
            // 
            this.staffAndCategoryBindingSource.DataSource = typeof(FindANameFarm.StaffAndCategory);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtStaffPassword);
            this.Controls.Add(this.gbCompetencies);
            this.Controls.Add(this.pbStaffImage);
            this.Controls.Add(this.btnCloseStaffForm);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblfName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.listStaff);
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImage)).EndInit();
            this.gbCompetencies.ResumeLayout(false);
            this.gbCompetencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffAndCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnCloseStaffForm;
        private System.Windows.Forms.PictureBox pbStaffImage;
        private System.Windows.Forms.GroupBox gbCompetencies;
        private System.Windows.Forms.Button btnRemoveCompetency;
        private System.Windows.Forms.Button btnAddCompetency;
        private System.Windows.Forms.ComboBox cbCompetencies;
        private System.Windows.Forms.Label lblCompetenciesList;
        private System.Windows.Forms.Label lblCompetency;
        private System.Windows.Forms.BindingSource staffAndCategoryBindingSource;
        private System.Windows.Forms.ListView listCompetencies;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.Button button1;
    }
}

