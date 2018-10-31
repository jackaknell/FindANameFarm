namespace FindANameFarm.Forms
{
    partial class VehicleForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtAddCategory = new System.Windows.Forms.TextBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.cbVehicleCategory = new System.Windows.Forms.ComboBox();
            this.lblVehicleCategory = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.listVehicles = new System.Windows.Forms.ListView();
            this.lblCategorySelection = new System.Windows.Forms.Label();
            this.cbVehicleCategoryList = new System.Windows.Forms.ComboBox();
            this.gbCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(693, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(265, 389);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteVehicle.TabIndex = 21;
            this.btnDeleteVehicle.Text = "Delete Selected Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(40, 389);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateVehicle.TabIndex = 20;
            this.btnUpdateVehicle.Text = "Update selected vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(46, 168);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(135, 23);
            this.btnCreateVehicle.TabIndex = 19;
            this.btnCreateVehicle.Text = "Create New Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Location = new System.Drawing.Point(139, 73);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(121, 20);
            this.txtVehicleType.TabIndex = 18;
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(139, 27);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.ReadOnly = true;
            this.txtVehicleId.Size = new System.Drawing.Size(121, 20);
            this.txtVehicleId.TabIndex = 17;
            this.txtVehicleId.TextChanged += new System.EventHandler(this.txtVehicleId_TextChanged);
            // 
            // gbCategories
            // 
            this.gbCategories.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbCategories.Controls.Add(this.btnDeleteCategory);
            this.gbCategories.Controls.Add(this.btnAddCategory);
            this.gbCategories.Controls.Add(this.txtAddCategory);
            this.gbCategories.Controls.Add(this.lblAddCategory);
            this.gbCategories.Controls.Add(this.cbVehicleCategory);
            this.gbCategories.Controls.Add(this.lblVehicleCategory);
            this.gbCategories.Location = new System.Drawing.Point(40, 222);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(360, 113);
            this.gbCategories.TabIndex = 16;
            this.gbCategories.TabStop = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(272, 25);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 8;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(272, 69);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 7;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtAddCategory
            // 
            this.txtAddCategory.Location = new System.Drawing.Point(132, 69);
            this.txtAddCategory.Name = "txtAddCategory";
            this.txtAddCategory.Size = new System.Drawing.Size(121, 20);
            this.txtAddCategory.TabIndex = 6;
            this.txtAddCategory.TextChanged += new System.EventHandler(this.txtAddCategory_TextChanged);
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(9, 69);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(74, 13);
            this.lblAddCategory.TabIndex = 5;
            this.lblAddCategory.Text = "Add Category:";
            // 
            // cbVehicleCategory
            // 
            this.cbVehicleCategory.FormattingEnabled = true;
            this.cbVehicleCategory.Location = new System.Drawing.Point(132, 25);
            this.cbVehicleCategory.Name = "cbVehicleCategory";
            this.cbVehicleCategory.Size = new System.Drawing.Size(121, 21);
            this.cbVehicleCategory.TabIndex = 4;
            // 
            // lblVehicleCategory
            // 
            this.lblVehicleCategory.AutoSize = true;
            this.lblVehicleCategory.Location = new System.Drawing.Point(6, 25);
            this.lblVehicleCategory.Name = "lblVehicleCategory";
            this.lblVehicleCategory.Size = new System.Drawing.Size(90, 13);
            this.lblVehicleCategory.TabIndex = 3;
            this.lblVehicleCategory.Text = "Vehicle Category:";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(46, 76);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(72, 13);
            this.lblVehicleType.TabIndex = 15;
            this.lblVehicleType.Text = "Vehicle Type:";
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.Location = new System.Drawing.Point(46, 30);
            this.lblVehicleId.Name = "lblVehicleId";
            this.lblVehicleId.Size = new System.Drawing.Size(59, 13);
            this.lblVehicleId.TabIndex = 14;
            this.lblVehicleId.Text = "Vehicle ID:";
            // 
            // listVehicles
            // 
            this.listVehicles.GridLines = true;
            this.listVehicles.Location = new System.Drawing.Point(467, -1);
            this.listVehicles.Name = "listVehicles";
            this.listVehicles.Size = new System.Drawing.Size(301, 378);
            this.listVehicles.TabIndex = 13;
            this.listVehicles.UseCompatibleStateImageBehavior = false;
            this.listVehicles.View = System.Windows.Forms.View.Details;
            this.listVehicles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listVehicles_MouseClick);
            // 
            // lblCategorySelection
            // 
            this.lblCategorySelection.AutoSize = true;
            this.lblCategorySelection.Location = new System.Drawing.Point(46, 122);
            this.lblCategorySelection.Name = "lblCategorySelection";
            this.lblCategorySelection.Size = new System.Drawing.Size(85, 13);
            this.lblCategorySelection.TabIndex = 24;
            this.lblCategorySelection.Text = "Select Category:";
            // 
            // cbVehicleCategoryList
            // 
            this.cbVehicleCategoryList.FormattingEnabled = true;
            this.cbVehicleCategoryList.Location = new System.Drawing.Point(139, 119);
            this.cbVehicleCategoryList.Name = "cbVehicleCategoryList";
            this.cbVehicleCategoryList.Size = new System.Drawing.Size(121, 21);
            this.cbVehicleCategoryList.TabIndex = 25;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.cbVehicleCategoryList);
            this.Controls.Add(this.lblCategorySelection);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.txtVehicleId);
            this.Controls.Add(this.gbCategories);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblVehicleId);
            this.Controls.Add(this.listVehicles);
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.gbCategories.ResumeLayout(false);
            this.gbCategories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtAddCategory;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.ComboBox cbVehicleCategory;
        private System.Windows.Forms.Label lblVehicleCategory;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblVehicleId;
        private System.Windows.Forms.ListView listVehicles;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblCategorySelection;
        private System.Windows.Forms.ComboBox cbVehicleCategoryList;
    }
}