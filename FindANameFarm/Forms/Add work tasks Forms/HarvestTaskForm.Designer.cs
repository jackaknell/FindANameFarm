namespace FindANameFarm.Forms
{
    partial class HarvestTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarvestTaskForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHarvestID = new System.Windows.Forms.TextBox();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtCrop = new System.Windows.Forms.TextBox();
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblHarvestDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtYeild = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nudJobDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cbVehicles = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.cbLabourers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseHarvestTask = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.listExistingSowingTasks = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHarvestID);
            this.groupBox1.Controls.Add(this.lblTaskID);
            this.groupBox1.Controls.Add(this.txtField);
            this.groupBox1.Controls.Add(this.txtCrop);
            this.groupBox1.Controls.Add(this.btnAddStorage);
            this.groupBox1.Controls.Add(this.cbStorage);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.lblHarvestDate);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtYeild);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudJobDuration);
            this.groupBox1.Controls.Add(this.btnAddVehicle);
            this.groupBox1.Controls.Add(this.cbDriver);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.cbVehicles);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnAddWorker);
            this.groupBox1.Controls.Add(this.cbLabourers);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 600);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // txtHarvestID
            // 
            this.txtHarvestID.Location = new System.Drawing.Point(97, 27);
            this.txtHarvestID.Name = "txtHarvestID";
            this.txtHarvestID.Size = new System.Drawing.Size(131, 20);
            this.txtHarvestID.TabIndex = 41;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Location = new System.Drawing.Point(18, 30);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(73, 13);
            this.lblTaskID.TabIndex = 40;
            this.lblTaskID.Text = "Harvest Date:";
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(128, 160);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(100, 20);
            this.txtField.TabIndex = 39;
            // 
            // txtCrop
            // 
            this.txtCrop.Location = new System.Drawing.Point(128, 195);
            this.txtCrop.Name = "txtCrop";
            this.txtCrop.Size = new System.Drawing.Size(100, 20);
            this.txtCrop.TabIndex = 38;
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.Location = new System.Drawing.Point(253, 397);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(91, 23);
            this.btnAddStorage.TabIndex = 37;
            this.btnAddStorage.Text = "Add Storage";
            this.btnAddStorage.UseVisualStyleBackColor = true;
            // 
            // cbStorage
            // 
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Location = new System.Drawing.Point(111, 399);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(121, 21);
            this.cbStorage.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 402);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Storage Container:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(143, 76);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 34;
            // 
            // lblHarvestDate
            // 
            this.lblHarvestDate.AutoSize = true;
            this.lblHarvestDate.Location = new System.Drawing.Point(7, 76);
            this.lblHarvestDate.Name = "lblHarvestDate";
            this.lblHarvestDate.Size = new System.Drawing.Size(73, 13);
            this.lblHarvestDate.TabIndex = 33;
            this.lblHarvestDate.Text = "Harvest Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(144, 114);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Finish Date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(223, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Volume m2";
            // 
            // txtYeild
            // 
            this.txtYeild.Location = new System.Drawing.Point(112, 485);
            this.txtYeild.Name = "txtYeild";
            this.txtYeild.Size = new System.Drawing.Size(100, 20);
            this.txtYeild.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 487);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Expected Yeild:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(406, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Remove selected from list";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(408, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Remove selected from list";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "in hours";
            // 
            // nudJobDuration
            // 
            this.nudJobDuration.Location = new System.Drawing.Point(112, 444);
            this.nudJobDuration.Name = "nudJobDuration";
            this.nudJobDuration.Size = new System.Drawing.Size(120, 20);
            this.nudJobDuration.TabIndex = 24;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(253, 355);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(91, 23);
            this.btnAddVehicle.TabIndex = 23;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            // 
            // cbDriver
            // 
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(111, 357);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(121, 21);
            this.cbDriver.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Driver:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vehicles assigened to task";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(406, 114);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 147);
            this.listBox2.TabIndex = 18;
            // 
            // cbVehicles
            // 
            this.cbVehicles.FormattingEnabled = true;
            this.cbVehicles.Location = new System.Drawing.Point(111, 303);
            this.cbVehicles.Name = "cbVehicles";
            this.cbVehicles.Size = new System.Drawing.Size(121, 21);
            this.cbVehicles.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Labours assigened to task";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(406, 335);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 147);
            this.listBox1.TabIndex = 15;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(253, 247);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(91, 23);
            this.btnAddWorker.TabIndex = 14;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // cbLabourers
            // 
            this.cbLabourers.FormattingEnabled = true;
            this.cbLabourers.Location = new System.Drawing.Point(111, 249);
            this.cbLabourers.Name = "cbLabourers";
            this.cbLabourers.Size = new System.Drawing.Size(121, 21);
            this.cbLabourers.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Job Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vehicles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Labourers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Field:";
            // 
            // btnCloseHarvestTask
            // 
            this.btnCloseHarvestTask.Location = new System.Drawing.Point(909, 638);
            this.btnCloseHarvestTask.Name = "btnCloseHarvestTask";
            this.btnCloseHarvestTask.Size = new System.Drawing.Size(75, 23);
            this.btnCloseHarvestTask.TabIndex = 51;
            this.btnCloseHarvestTask.Text = "Close";
            this.btnCloseHarvestTask.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(199, 638);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(118, 638);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 48;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // listExistingSowingTasks
            // 
            this.listExistingSowingTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listExistingSowingTasks.FullRowSelect = true;
            this.listExistingSowingTasks.GridLines = true;
            this.listExistingSowingTasks.Location = new System.Drawing.Point(695, 13);
            this.listExistingSowingTasks.Name = "listExistingSowingTasks";
            this.listExistingSowingTasks.Size = new System.Drawing.Size(368, 599);
            this.listExistingSowingTasks.TabIndex = 53;
            this.listExistingSowingTasks.UseCompatibleStateImageBehavior = false;
            this.listExistingSowingTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Task Type";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Start Date";
            this.columnHeader8.Width = 150;
            // 
            // HarvestTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 667);
            this.Controls.Add(this.listExistingSowingTasks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseHarvestTask);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HarvestTaskForm";
            this.Text = "Create Harvest Task";
            this.Load += new System.EventHandler(this.HarvestTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.TextBox txtCrop;
        private System.Windows.Forms.Button btnAddStorage;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblHarvestDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtYeild;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudJobDuration;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox cbVehicles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ComboBox cbLabourers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseHarvestTask;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtHarvestID;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.ListView listExistingSowingTasks;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}