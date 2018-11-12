namespace FindANameFarm.Forms
{
    partial class SowingTaskForm
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
            this.btnCloseSowingTask = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudExpectedYeild = new System.Windows.Forms.NumericUpDown();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudJobDuration = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExpectedHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSowingTaskCropList = new System.Windows.Forms.ComboBox();
            this.cbSowingTaskFieldList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVehicleSelection = new System.Windows.Forms.GroupBox();
            this.lblSowingTaskVehicleCat = new System.Windows.Forms.Label();
            this.cbSowingTaskVehicleList = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSowingTaskVehicle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSowingTaskAddWorker = new System.Windows.Forms.Button();
            this.cbSowingTaskStaffList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateSowingTask = new System.Windows.Forms.Button();
            this.listExistingSowingTasks = new System.Windows.Forms.ListView();
            this.listTaskVehicles = new System.Windows.Forms.ListView();
            this.listTaskStaff = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).BeginInit();
            this.gbVehicleSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseSowingTask
            // 
            this.btnCloseSowingTask.Location = new System.Drawing.Point(784, 711);
            this.btnCloseSowingTask.Name = "btnCloseSowingTask";
            this.btnCloseSowingTask.Size = new System.Drawing.Size(125, 45);
            this.btnCloseSowingTask.TabIndex = 11;
            this.btnCloseSowingTask.Text = "Close Form";
            this.btnCloseSowingTask.UseVisualStyleBackColor = true;
            this.btnCloseSowingTask.Click += new System.EventHandler(this.btnCloseSowingTask_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 711);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "Create sowing task";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudExpectedYeild);
            this.groupBox1.Controls.Add(this.lblTaskId);
            this.groupBox1.Controls.Add(this.txtTaskID);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.dtpFinishDate);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nudJobDuration);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpExpectedHarvestDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbSowingTaskCropList);
            this.groupBox1.Controls.Add(this.cbSowingTaskFieldList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 580);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudExpectedYeild
            // 
            this.nudExpectedYeild.Location = new System.Drawing.Point(173, 492);
            this.nudExpectedYeild.Name = "nudExpectedYeild";
            this.nudExpectedYeild.Size = new System.Drawing.Size(120, 20);
            this.nudExpectedYeild.TabIndex = 38;
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(23, 22);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(45, 13);
            this.lblTaskId.TabIndex = 37;
            this.lblTaskId.Text = "Task ID";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(172, 16);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.ReadOnly = true;
            this.txtTaskID.Size = new System.Drawing.Size(100, 20);
            this.txtTaskID.TabIndex = 36;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(172, 318);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 317);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Quantity Needed";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(172, 136);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFinishDate.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Finish Date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(328, 503);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Volume m2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 494);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Expected Yield:";
            // 
            // nudJobDuration
            // 
            this.nudJobDuration.Location = new System.Drawing.Point(172, 378);
            this.nudJobDuration.Name = "nudJobDuration";
            this.nudJobDuration.Size = new System.Drawing.Size(120, 20);
            this.nudJobDuration.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "in hours";
            // 
            // dtpExpectedHarvestDate
            // 
            this.dtpExpectedHarvestDate.Location = new System.Drawing.Point(172, 438);
            this.dtpExpectedHarvestDate.Name = "dtpExpectedHarvestDate";
            this.dtpExpectedHarvestDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExpectedHarvestDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Expected Harvest Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Job Duration:";
            // 
            // cbSowingTaskCropList
            // 
            this.cbSowingTaskCropList.FormattingEnabled = true;
            this.cbSowingTaskCropList.Location = new System.Drawing.Point(172, 257);
            this.cbSowingTaskCropList.Name = "cbSowingTaskCropList";
            this.cbSowingTaskCropList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskCropList.TabIndex = 7;
            // 
            // cbSowingTaskFieldList
            // 
            this.cbSowingTaskFieldList.FormattingEnabled = true;
            this.cbSowingTaskFieldList.Location = new System.Drawing.Point(172, 196);
            this.cbSowingTaskFieldList.Name = "cbSowingTaskFieldList";
            this.cbSowingTaskFieldList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskFieldList.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crop:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Field:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(172, 76);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "date of task:";
            // 
            // gbVehicleSelection
            // 
            this.gbVehicleSelection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbVehicleSelection.Controls.Add(this.lblSowingTaskVehicleCat);
            this.gbVehicleSelection.Controls.Add(this.cbSowingTaskVehicleList);
            this.gbVehicleSelection.Controls.Add(this.button5);
            this.gbVehicleSelection.Controls.Add(this.comboBox2);
            this.gbVehicleSelection.Controls.Add(this.comboBox6);
            this.gbVehicleSelection.Controls.Add(this.label11);
            this.gbVehicleSelection.Controls.Add(this.lblSowingTaskVehicle);
            this.gbVehicleSelection.Location = new System.Drawing.Point(527, 301);
            this.gbVehicleSelection.Name = "gbVehicleSelection";
            this.gbVehicleSelection.Size = new System.Drawing.Size(399, 127);
            this.gbVehicleSelection.TabIndex = 35;
            this.gbVehicleSelection.TabStop = false;
            // 
            // lblSowingTaskVehicleCat
            // 
            this.lblSowingTaskVehicleCat.AutoSize = true;
            this.lblSowingTaskVehicleCat.Location = new System.Drawing.Point(1, 18);
            this.lblSowingTaskVehicleCat.Name = "lblSowingTaskVehicleCat";
            this.lblSowingTaskVehicleCat.Size = new System.Drawing.Size(87, 13);
            this.lblSowingTaskVehicleCat.TabIndex = 36;
            this.lblSowingTaskVehicleCat.Text = "Vehicle Category";
            // 
            // cbSowingTaskVehicleList
            // 
            this.cbSowingTaskVehicleList.FormattingEnabled = true;
            this.cbSowingTaskVehicleList.Location = new System.Drawing.Point(149, 36);
            this.cbSowingTaskVehicleList.Name = "cbSowingTaskVehicleList";
            this.cbSowingTaskVehicleList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskVehicleList.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(291, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Add Vehicle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 35;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(149, 90);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Driver:";
            // 
            // lblSowingTaskVehicle
            // 
            this.lblSowingTaskVehicle.AutoSize = true;
            this.lblSowingTaskVehicle.Location = new System.Drawing.Point(1, 39);
            this.lblSowingTaskVehicle.Name = "lblSowingTaskVehicle";
            this.lblSowingTaskVehicle.Size = new System.Drawing.Size(50, 13);
            this.lblSowingTaskVehicle.TabIndex = 9;
            this.lblSowingTaskVehicle.Text = "Vehicles:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(531, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Remove selected from list";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Remove selected from list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(528, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vehicles assigened to task";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Labours assigened to task";
            // 
            // btnSowingTaskAddWorker
            // 
            this.btnSowingTaskAddWorker.Location = new System.Drawing.Point(721, 57);
            this.btnSowingTaskAddWorker.Name = "btnSowingTaskAddWorker";
            this.btnSowingTaskAddWorker.Size = new System.Drawing.Size(91, 23);
            this.btnSowingTaskAddWorker.TabIndex = 14;
            this.btnSowingTaskAddWorker.Text = "Add Worker";
            this.btnSowingTaskAddWorker.UseVisualStyleBackColor = true;
            this.btnSowingTaskAddWorker.Click += new System.EventHandler(this.btnSowingTaskAddWorker_Click);
            // 
            // cbSowingTaskStaffList
            // 
            this.cbSowingTaskStaffList.FormattingEnabled = true;
            this.cbSowingTaskStaffList.Location = new System.Drawing.Point(585, 57);
            this.cbSowingTaskStaffList.Name = "cbSowingTaskStaffList";
            this.cbSowingTaskStaffList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskStaffList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Labourers:";
            // 
            // btnUpdateSowingTask
            // 
            this.btnUpdateSowingTask.Location = new System.Drawing.Point(316, 711);
            this.btnUpdateSowingTask.Name = "btnUpdateSowingTask";
            this.btnUpdateSowingTask.Size = new System.Drawing.Size(125, 45);
            this.btnUpdateSowingTask.TabIndex = 13;
            this.btnUpdateSowingTask.Text = "Update sowing task";
            this.btnUpdateSowingTask.UseVisualStyleBackColor = true;
            // 
            // listExistingSowingTasks
            // 
            this.listExistingSowingTasks.GridLines = true;
            this.listExistingSowingTasks.Location = new System.Drawing.Point(978, 111);
            this.listExistingSowingTasks.Name = "listExistingSowingTasks";
            this.listExistingSowingTasks.Size = new System.Drawing.Size(320, 493);
            this.listExistingSowingTasks.TabIndex = 36;
            this.listExistingSowingTasks.UseCompatibleStateImageBehavior = false;
            this.listExistingSowingTasks.View = System.Windows.Forms.View.Details;
            this.listExistingSowingTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listExistingSowingTasks_MouseClick);
            // 
            // listTaskVehicles
            // 
            this.listTaskVehicles.GridLines = true;
            this.listTaskVehicles.Location = new System.Drawing.Point(531, 458);
            this.listTaskVehicles.Name = "listTaskVehicles";
            this.listTaskVehicles.Size = new System.Drawing.Size(289, 136);
            this.listTaskVehicles.TabIndex = 37;
            this.listTaskVehicles.UseCompatibleStateImageBehavior = false;
            this.listTaskVehicles.View = System.Windows.Forms.View.Details;
            // 
            // listTaskStaff
            // 
            this.listTaskStaff.GridLines = true;
            this.listTaskStaff.Location = new System.Drawing.Point(527, 122);
            this.listTaskStaff.Name = "listTaskStaff";
            this.listTaskStaff.Size = new System.Drawing.Size(281, 125);
            this.listTaskStaff.TabIndex = 38;
            this.listTaskStaff.UseCompatibleStateImageBehavior = false;
            this.listTaskStaff.View = System.Windows.Forms.View.Details;
            // 
            // SowingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 778);
            this.Controls.Add(this.listTaskStaff);
            this.Controls.Add(this.listTaskVehicles);
            this.Controls.Add(this.listExistingSowingTasks);
            this.Controls.Add(this.btnUpdateSowingTask);
            this.Controls.Add(this.gbVehicleSelection);
            this.Controls.Add(this.btnCloseSowingTask);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSowingTaskAddWorker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSowingTaskStaffList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Name = "SowingTaskForm";
            this.Text = "SowingTask";
            this.Load += new System.EventHandler(this.SowingTaskForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).EndInit();
            this.gbVehicleSelection.ResumeLayout(false);
            this.gbVehicleSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseSowingTask;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudJobDuration;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSowingTaskVehicleList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSowingTaskAddWorker;
        private System.Windows.Forms.ComboBox cbSowingTaskStaffList;
        private System.Windows.Forms.DateTimePicker dtpExpectedHarvestDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSowingTaskVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSowingTaskCropList;
        private System.Windows.Forms.ComboBox cbSowingTaskFieldList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnUpdateSowingTask;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSowingTaskVehicleCat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox gbVehicleSelection;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.NumericUpDown nudExpectedYeild;
        private System.Windows.Forms.ListView listExistingSowingTasks;
        private System.Windows.Forms.ListView listTaskVehicles;
        private System.Windows.Forms.ListView listTaskStaff;
    }
}