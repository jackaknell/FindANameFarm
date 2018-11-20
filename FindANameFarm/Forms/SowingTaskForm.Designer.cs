﻿namespace FindANameFarm.Forms
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
            this.btnCreateSowingTask = new System.Windows.Forms.Button();
            this.gbSowingTask = new System.Windows.Forms.GroupBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.nudExpectedYeild = new System.Windows.Forms.NumericUpDown();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.btnUpdateSowingTask = new System.Windows.Forms.Button();
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
            this.btnVehicleAdd = new System.Windows.Forms.Button();
            this.cbVehicleCatList = new System.Windows.Forms.ComboBox();
            this.cbVehicleDriver = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSowingTaskVehicle = new System.Windows.Forms.Label();
            this.txtRemoveVehicleFromTask = new System.Windows.Forms.Button();
            this.btnRemoveLabourerFromTask = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSowingTaskAddWorker = new System.Windows.Forms.Button();
            this.cbSowingTaskStaffList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listExistingSowingTasks = new System.Windows.Forms.ListView();
            this.listTaskVehicles = new System.Windows.Forms.ListView();
            this.listTaskStaff = new System.Windows.Forms.ListView();
            this.gbTaskVehiclesAndStaff = new System.Windows.Forms.GroupBox();
            this.gbSowingTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).BeginInit();
            this.gbVehicleSelection.SuspendLayout();
            this.gbTaskVehiclesAndStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseSowingTask
            // 
            this.btnCloseSowingTask.Location = new System.Drawing.Point(1230, 658);
            this.btnCloseSowingTask.Name = "btnCloseSowingTask";
            this.btnCloseSowingTask.Size = new System.Drawing.Size(125, 45);
            this.btnCloseSowingTask.TabIndex = 11;
            this.btnCloseSowingTask.Text = "Close Form";
            this.btnCloseSowingTask.UseVisualStyleBackColor = true;
            this.btnCloseSowingTask.Click += new System.EventHandler(this.btnCloseSowingTask_Click);
            // 
            // btnCreateSowingTask
            // 
            this.btnCreateSowingTask.Location = new System.Drawing.Point(19, 553);
            this.btnCreateSowingTask.Name = "btnCreateSowingTask";
            this.btnCreateSowingTask.Size = new System.Drawing.Size(125, 45);
            this.btnCreateSowingTask.TabIndex = 10;
            this.btnCreateSowingTask.Text = "Create sowing task";
            this.btnCreateSowingTask.UseVisualStyleBackColor = true;
            this.btnCreateSowingTask.Click += new System.EventHandler(this.btnCreateSowingTask_Click);
            // 
            // gbSowingTask
            // 
            this.gbSowingTask.Controls.Add(this.btnResetForm);
            this.gbSowingTask.Controls.Add(this.nudExpectedYeild);
            this.gbSowingTask.Controls.Add(this.lblTaskId);
            this.gbSowingTask.Controls.Add(this.btnUpdateSowingTask);
            this.gbSowingTask.Controls.Add(this.txtTaskID);
            this.gbSowingTask.Controls.Add(this.nudQuantity);
            this.gbSowingTask.Controls.Add(this.btnCreateSowingTask);
            this.gbSowingTask.Controls.Add(this.label20);
            this.gbSowingTask.Controls.Add(this.dtpFinishDate);
            this.gbSowingTask.Controls.Add(this.label19);
            this.gbSowingTask.Controls.Add(this.label18);
            this.gbSowingTask.Controls.Add(this.label17);
            this.gbSowingTask.Controls.Add(this.nudJobDuration);
            this.gbSowingTask.Controls.Add(this.label12);
            this.gbSowingTask.Controls.Add(this.dtpExpectedHarvestDate);
            this.gbSowingTask.Controls.Add(this.label8);
            this.gbSowingTask.Controls.Add(this.label7);
            this.gbSowingTask.Controls.Add(this.cbSowingTaskCropList);
            this.gbSowingTask.Controls.Add(this.cbSowingTaskFieldList);
            this.gbSowingTask.Controls.Add(this.label4);
            this.gbSowingTask.Controls.Add(this.label3);
            this.gbSowingTask.Controls.Add(this.dtpStartDate);
            this.gbSowingTask.Controls.Add(this.label2);
            this.gbSowingTask.Location = new System.Drawing.Point(17, 35);
            this.gbSowingTask.Name = "gbSowingTask";
            this.gbSowingTask.Size = new System.Drawing.Size(466, 610);
            this.gbSowingTask.TabIndex = 8;
            this.gbSowingTask.TabStop = false;
            this.gbSowingTask.Enter += new System.EventHandler(this.gbSowingTask_Enter);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(318, 553);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(125, 45);
            this.btnResetForm.TabIndex = 39;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // nudExpectedYeild
            // 
            this.nudExpectedYeild.Location = new System.Drawing.Point(173, 492);
            this.nudExpectedYeild.Name = "nudExpectedYeild";
            this.nudExpectedYeild.ReadOnly = true;
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
            // btnUpdateSowingTask
            // 
            this.btnUpdateSowingTask.Location = new System.Drawing.Point(172, 553);
            this.btnUpdateSowingTask.Name = "btnUpdateSowingTask";
            this.btnUpdateSowingTask.Size = new System.Drawing.Size(125, 45);
            this.btnUpdateSowingTask.TabIndex = 13;
            this.btnUpdateSowingTask.Text = "Update sowing task";
            this.btnUpdateSowingTask.UseVisualStyleBackColor = true;
            this.btnUpdateSowingTask.Click += new System.EventHandler(this.btnUpdateSowingTask_Click);
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(172, 16);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.ReadOnly = true;
            this.txtTaskID.Size = new System.Drawing.Size(100, 20);
            this.txtTaskID.TabIndex = 36;
            this.txtTaskID.TextChanged += new System.EventHandler(this.txtTaskID_TextChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(172, 318);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
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
            this.nudJobDuration.ReadOnly = true;
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
            this.cbSowingTaskCropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSowingTaskCropList.FormattingEnabled = true;
            this.cbSowingTaskCropList.Location = new System.Drawing.Point(172, 257);
            this.cbSowingTaskCropList.Name = "cbSowingTaskCropList";
            this.cbSowingTaskCropList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskCropList.TabIndex = 7;
            // 
            // cbSowingTaskFieldList
            // 
            this.cbSowingTaskFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.gbVehicleSelection.Controls.Add(this.btnVehicleAdd);
            this.gbVehicleSelection.Controls.Add(this.cbVehicleCatList);
            this.gbVehicleSelection.Controls.Add(this.cbVehicleDriver);
            this.gbVehicleSelection.Controls.Add(this.label11);
            this.gbVehicleSelection.Controls.Add(this.lblSowingTaskVehicle);
            this.gbVehicleSelection.Location = new System.Drawing.Point(22, 255);
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
            // btnVehicleAdd
            // 
            this.btnVehicleAdd.Location = new System.Drawing.Point(291, 88);
            this.btnVehicleAdd.Name = "btnVehicleAdd";
            this.btnVehicleAdd.Size = new System.Drawing.Size(91, 23);
            this.btnVehicleAdd.TabIndex = 23;
            this.btnVehicleAdd.Text = "Add Vehicle";
            this.btnVehicleAdd.UseVisualStyleBackColor = true;
            this.btnVehicleAdd.Click += new System.EventHandler(this.btnVehicleAdd_Click);
            // 
            // cbVehicleCatList
            // 
            this.cbVehicleCatList.FormattingEnabled = true;
            this.cbVehicleCatList.Location = new System.Drawing.Point(149, 11);
            this.cbVehicleCatList.Name = "cbVehicleCatList";
            this.cbVehicleCatList.Size = new System.Drawing.Size(121, 21);
            this.cbVehicleCatList.TabIndex = 35;
            this.cbVehicleCatList.SelectedIndexChanged += new System.EventHandler(this.cbVehicleCatList_SelectedIndexChanged);
            // 
            // cbVehicleDriver
            // 
            this.cbVehicleDriver.FormattingEnabled = true;
            this.cbVehicleDriver.Location = new System.Drawing.Point(149, 90);
            this.cbVehicleDriver.Name = "cbVehicleDriver";
            this.cbVehicleDriver.Size = new System.Drawing.Size(121, 21);
            this.cbVehicleDriver.TabIndex = 22;
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
            // txtRemoveVehicleFromTask
            // 
            this.txtRemoveVehicleFromTask.Location = new System.Drawing.Point(26, 564);
            this.txtRemoveVehicleFromTask.Name = "txtRemoveVehicleFromTask";
            this.txtRemoveVehicleFromTask.Size = new System.Drawing.Size(164, 23);
            this.txtRemoveVehicleFromTask.TabIndex = 27;
            this.txtRemoveVehicleFromTask.Text = "Remove Vehicle from task";
            this.txtRemoveVehicleFromTask.UseVisualStyleBackColor = true;
            this.txtRemoveVehicleFromTask.Click += new System.EventHandler(this.txtRemoveVehicleFromTask_Click);
            // 
            // btnRemoveLabourerFromTask
            // 
            this.btnRemoveLabourerFromTask.Location = new System.Drawing.Point(20, 217);
            this.btnRemoveLabourerFromTask.Name = "btnRemoveLabourerFromTask";
            this.btnRemoveLabourerFromTask.Size = new System.Drawing.Size(162, 23);
            this.btnRemoveLabourerFromTask.TabIndex = 26;
            this.btnRemoveLabourerFromTask.Text = "Remove labourer from task";
            this.btnRemoveLabourerFromTask.UseVisualStyleBackColor = true;
            this.btnRemoveLabourerFromTask.Click += new System.EventHandler(this.btnRemoveLabourerFromTask_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vehicles assigened to task";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Labours assigened to task";
            // 
            // btnSowingTaskAddWorker
            // 
            this.btnSowingTaskAddWorker.Location = new System.Drawing.Point(216, 11);
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
            this.cbSowingTaskStaffList.Location = new System.Drawing.Point(80, 11);
            this.cbSowingTaskStaffList.Name = "cbSowingTaskStaffList";
            this.cbSowingTaskStaffList.Size = new System.Drawing.Size(121, 21);
            this.cbSowingTaskStaffList.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Labourers:";
            // 
            // listExistingSowingTasks
            // 
            this.listExistingSowingTasks.GridLines = true;
            this.listExistingSowingTasks.Location = new System.Drawing.Point(976, 46);
            this.listExistingSowingTasks.Name = "listExistingSowingTasks";
            this.listExistingSowingTasks.Size = new System.Drawing.Size(379, 599);
            this.listExistingSowingTasks.TabIndex = 36;
            this.listExistingSowingTasks.UseCompatibleStateImageBehavior = false;
            this.listExistingSowingTasks.View = System.Windows.Forms.View.Details;
            this.listExistingSowingTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listExistingSowingTasks_MouseClick);
            // 
            // listTaskVehicles
            // 
            this.listTaskVehicles.GridLines = true;
            this.listTaskVehicles.Location = new System.Drawing.Point(26, 412);
            this.listTaskVehicles.Name = "listTaskVehicles";
            this.listTaskVehicles.Size = new System.Drawing.Size(289, 136);
            this.listTaskVehicles.TabIndex = 37;
            this.listTaskVehicles.UseCompatibleStateImageBehavior = false;
            this.listTaskVehicles.View = System.Windows.Forms.View.Details;
            // 
            // listTaskStaff
            // 
            this.listTaskStaff.GridLines = true;
            this.listTaskStaff.Location = new System.Drawing.Point(22, 76);
            this.listTaskStaff.Name = "listTaskStaff";
            this.listTaskStaff.Size = new System.Drawing.Size(281, 125);
            this.listTaskStaff.TabIndex = 38;
            this.listTaskStaff.UseCompatibleStateImageBehavior = false;
            this.listTaskStaff.View = System.Windows.Forms.View.Details;
            // 
            // gbTaskVehiclesAndStaff
            // 
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskVehicles);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskStaff);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label5);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label10);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.cbSowingTaskStaffList);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnRemoveLabourerFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.gbVehicleSelection);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnSowingTaskAddWorker);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.txtRemoveVehicleFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label9);
            this.gbTaskVehiclesAndStaff.Location = new System.Drawing.Point(504, 35);
            this.gbTaskVehiclesAndStaff.Name = "gbTaskVehiclesAndStaff";
            this.gbTaskVehiclesAndStaff.Size = new System.Drawing.Size(452, 610);
            this.gbTaskVehiclesAndStaff.TabIndex = 39;
            this.gbTaskVehiclesAndStaff.TabStop = false;
            // 
            // SowingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 722);
            this.Controls.Add(this.gbTaskVehiclesAndStaff);
            this.Controls.Add(this.listExistingSowingTasks);
            this.Controls.Add(this.btnCloseSowingTask);
            this.Controls.Add(this.gbSowingTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SowingTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sowing Task Form";
            this.Load += new System.EventHandler(this.SowingTaskForm_Load);
            this.gbSowingTask.ResumeLayout(false);
            this.gbSowingTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).EndInit();
            this.gbVehicleSelection.ResumeLayout(false);
            this.gbVehicleSelection.PerformLayout();
            this.gbTaskVehiclesAndStaff.ResumeLayout(false);
            this.gbTaskVehiclesAndStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseSowingTask;
        private System.Windows.Forms.Button btnCreateSowingTask;
        private System.Windows.Forms.GroupBox gbSowingTask;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button txtRemoveVehicleFromTask;
        private System.Windows.Forms.Button btnRemoveLabourerFromTask;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudJobDuration;
        private System.Windows.Forms.Button btnVehicleAdd;
        private System.Windows.Forms.ComboBox cbVehicleDriver;
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
        private System.Windows.Forms.ComboBox cbVehicleCatList;
        private System.Windows.Forms.GroupBox gbVehicleSelection;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.NumericUpDown nudExpectedYeild;
        private System.Windows.Forms.ListView listExistingSowingTasks;
        private System.Windows.Forms.ListView listTaskVehicles;
        private System.Windows.Forms.ListView listTaskStaff;
        private System.Windows.Forms.GroupBox gbTaskVehiclesAndStaff;
        private System.Windows.Forms.Button btnResetForm;
    }
}