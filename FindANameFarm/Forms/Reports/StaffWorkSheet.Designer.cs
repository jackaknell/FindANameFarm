namespace FindANameFarm.Forms
{
    partial class StaffWorkSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffWorkSheet));
            this.btnViewStorage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listLabourerTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCurrentStaffName = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCrop = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtCrop = new System.Windows.Forms.TextBox();
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.listDrivingTasks = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblViewLabourTasks = new System.Windows.Forms.Label();
            this.lblStaffDrivingTasks = new System.Windows.Forms.Label();
            this.txtTaskType = new System.Windows.Forms.TextBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.txtHarvestDate = new System.Windows.Forms.TextBox();
            this.lblHarvestDate = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtYield = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblExpectedYield = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnViewStorage
            // 
            this.btnViewStorage.Location = new System.Drawing.Point(47, 602);
            this.btnViewStorage.Name = "btnViewStorage";
            this.btnViewStorage.Size = new System.Drawing.Size(132, 48);
            this.btnViewStorage.TabIndex = 0;
            this.btnViewStorage.Text = "View Storage";
            this.btnViewStorage.UseVisualStyleBackColor = true;
            this.btnViewStorage.Click += new System.EventHandler(this.btnViewStorage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(383, 602);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 48);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // listLabourerTasks
            // 
            this.listLabourerTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listLabourerTasks.FullRowSelect = true;
            this.listLabourerTasks.GridLines = true;
            this.listLabourerTasks.Location = new System.Drawing.Point(41, 110);
            this.listLabourerTasks.Name = "listLabourerTasks";
            this.listLabourerTasks.Size = new System.Drawing.Size(486, 164);
            this.listLabourerTasks.TabIndex = 2;
            this.listLabourerTasks.UseCompatibleStateImageBehavior = false;
            this.listLabourerTasks.View = System.Windows.Forms.View.Details;
            this.listLabourerTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listLaboutTasks_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task Type";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Start Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Field";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Crop";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Job Duration";
            this.columnHeader5.Width = 100;
            // 
            // lblCurrentStaffName
            // 
            this.lblCurrentStaffName.AutoSize = true;
            this.lblCurrentStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStaffName.Location = new System.Drawing.Point(46, 28);
            this.lblCurrentStaffName.Name = "lblCurrentStaffName";
            this.lblCurrentStaffName.Size = new System.Drawing.Size(0, 24);
            this.lblCurrentStaffName.TabIndex = 3;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(567, 213);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(56, 13);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task ID:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(567, 281);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(73, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start  Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(567, 315);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 13);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrop.Location = new System.Drawing.Point(567, 349);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(37, 13);
            this.lblCrop.TabIndex = 7;
            this.lblCrop.Text = "Crop:";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(567, 383);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(38, 13);
            this.lblField.TabIndex = 8;
            this.lblField.Text = "Field:";
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(686, 210);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(187, 20);
            this.txtTaskId.TabIndex = 10;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(686, 278);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(187, 20);
            this.txtStartDate.TabIndex = 11;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(686, 312);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(187, 20);
            this.txtEndDate.TabIndex = 12;
            // 
            // txtCrop
            // 
            this.txtCrop.Location = new System.Drawing.Point(686, 346);
            this.txtCrop.Name = "txtCrop";
            this.txtCrop.ReadOnly = true;
            this.txtCrop.Size = new System.Drawing.Size(187, 20);
            this.txtCrop.TabIndex = 13;
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(686, 380);
            this.txtField.Name = "txtField";
            this.txtField.ReadOnly = true;
            this.txtField.Size = new System.Drawing.Size(187, 20);
            this.txtField.TabIndex = 14;
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(686, 414);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.ReadOnly = true;
            this.txtTreatment.Size = new System.Drawing.Size(187, 20);
            this.txtTreatment.TabIndex = 18;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatment.Location = new System.Drawing.Point(567, 417);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(68, 13);
            this.lblTreatment.TabIndex = 16;
            this.lblTreatment.Text = "Treatment:";
            // 
            // listDrivingTasks
            // 
            this.listDrivingTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listDrivingTasks.FullRowSelect = true;
            this.listDrivingTasks.GridLines = true;
            this.listDrivingTasks.Location = new System.Drawing.Point(38, 348);
            this.listDrivingTasks.Name = "listDrivingTasks";
            this.listDrivingTasks.Size = new System.Drawing.Size(430, 164);
            this.listDrivingTasks.TabIndex = 19;
            this.listDrivingTasks.UseCompatibleStateImageBehavior = false;
            this.listDrivingTasks.View = System.Windows.Forms.View.Details;
            this.listDrivingTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listDrivingTasks_MouseClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vehicle Name";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Task Type";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Start Date";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Field";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Crop";
            this.columnHeader10.Width = 75;
            // 
            // lblViewLabourTasks
            // 
            this.lblViewLabourTasks.AutoSize = true;
            this.lblViewLabourTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewLabourTasks.Location = new System.Drawing.Point(41, 93);
            this.lblViewLabourTasks.Name = "lblViewLabourTasks";
            this.lblViewLabourTasks.Size = new System.Drawing.Size(84, 13);
            this.lblViewLabourTasks.TabIndex = 20;
            this.lblViewLabourTasks.Text = "Labour Tasks";
            // 
            // lblStaffDrivingTasks
            // 
            this.lblStaffDrivingTasks.AutoSize = true;
            this.lblStaffDrivingTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDrivingTasks.Location = new System.Drawing.Point(38, 332);
            this.lblStaffDrivingTasks.Name = "lblStaffDrivingTasks";
            this.lblStaffDrivingTasks.Size = new System.Drawing.Size(85, 13);
            this.lblStaffDrivingTasks.TabIndex = 21;
            this.lblStaffDrivingTasks.Text = "Driving Tasks";
            // 
            // txtTaskType
            // 
            this.txtTaskType.Location = new System.Drawing.Point(686, 244);
            this.txtTaskType.Name = "txtTaskType";
            this.txtTaskType.ReadOnly = true;
            this.txtTaskType.Size = new System.Drawing.Size(187, 20);
            this.txtTaskType.TabIndex = 23;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskType.Location = new System.Drawing.Point(567, 247);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(75, 13);
            this.lblTaskType.TabIndex = 22;
            this.lblTaskType.Text = "Task Name:";
            // 
            // txtHarvestDate
            // 
            this.txtHarvestDate.Location = new System.Drawing.Point(686, 565);
            this.txtHarvestDate.Name = "txtHarvestDate";
            this.txtHarvestDate.ReadOnly = true;
            this.txtHarvestDate.Size = new System.Drawing.Size(187, 20);
            this.txtHarvestDate.TabIndex = 31;
            // 
            // lblHarvestDate
            // 
            this.lblHarvestDate.AutoSize = true;
            this.lblHarvestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarvestDate.Location = new System.Drawing.Point(537, 565);
            this.lblHarvestDate.Name = "lblHarvestDate";
            this.lblHarvestDate.Size = new System.Drawing.Size(143, 13);
            this.lblHarvestDate.TabIndex = 30;
            this.lblHarvestDate.Text = "Expected Harvest Date:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(686, 448);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(187, 20);
            this.txtDuration.TabIndex = 29;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(686, 633);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(187, 20);
            this.txtQuantity.TabIndex = 28;
            // 
            // txtYield
            // 
            this.txtYield.Location = new System.Drawing.Point(686, 599);
            this.txtYield.Name = "txtYield";
            this.txtYield.ReadOnly = true;
            this.txtYield.Size = new System.Drawing.Size(187, 20);
            this.txtYield.TabIndex = 27;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(567, 451);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(83, 13);
            this.lblDuration.TabIndex = 26;
            this.lblDuration.Text = "Job Duration:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(537, 637);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(113, 13);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "Quantity Required:";
            // 
            // lblExpectedYield
            // 
            this.lblExpectedYield.AutoSize = true;
            this.lblExpectedYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectedYield.Location = new System.Drawing.Point(537, 602);
            this.lblExpectedYield.Name = "lblExpectedYield";
            this.lblExpectedYield.Size = new System.Drawing.Size(96, 13);
            this.lblExpectedYield.TabIndex = 24;
            this.lblExpectedYield.Text = "Expected Yield:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(615, 90);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(26, 13);
            this.lblDateTo.TabIndex = 35;
            this.lblDateTo.Text = "To:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(605, 48);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(38, 13);
            this.lblDateFrom.TabIndex = 34;
            this.lblDateFrom.Text = "From:";
            // 
            // dtDateTo
            // 
            this.dtDateTo.Location = new System.Drawing.Point(662, 90);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtDateTo.TabIndex = 33;
            this.dtDateTo.ValueChanged += new System.EventHandler(this.dtDateTo_ValueChanged);
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Location = new System.Drawing.Point(662, 48);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtDateFrom.TabIndex = 32;
            this.dtDateFrom.ValueChanged += new System.EventHandler(this.dtDateTo_ValueChanged);
            // 
            // StaffWorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 726);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.txtHarvestDate);
            this.Controls.Add(this.lblHarvestDate);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtYield);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblExpectedYield);
            this.Controls.Add(this.txtTaskType);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblStaffDrivingTasks);
            this.Controls.Add(this.lblViewLabourTasks);
            this.Controls.Add(this.listDrivingTasks);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtCrop);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtTaskId);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblCurrentStaffName);
            this.Controls.Add(this.listLabourerTasks);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewStorage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffWorkSheet";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Work Sheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffWorkSheet_FormClosing);
            this.Load += new System.EventHandler(this.StaffWorkSheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewStorage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListView listLabourerTasks;
        private System.Windows.Forms.Label lblCurrentStaffName;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtCrop;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.ListView listDrivingTasks;
        private System.Windows.Forms.Label lblViewLabourTasks;
        private System.Windows.Forms.Label lblStaffDrivingTasks;
        private System.Windows.Forms.TextBox txtTaskType;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.TextBox txtHarvestDate;
        private System.Windows.Forms.Label lblHarvestDate;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtYield;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblExpectedYield;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}