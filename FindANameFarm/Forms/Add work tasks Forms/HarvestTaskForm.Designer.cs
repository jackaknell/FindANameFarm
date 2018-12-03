namespace FindANameFarm.Forms.Add_work_tasks_Forms
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
            this.btnCloseHarvestTask = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbSowingTask = new System.Windows.Forms.GroupBox();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.cbTaskStatus = new System.Windows.Forms.ComboBox();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.nudExpectedYeild = new System.Windows.Forms.NumericUpDown();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudJobDuration = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExpectedHarvestDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHarvestTaskCropList = new System.Windows.Forms.ComboBox();
            this.cbHarvestTaskFieldList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTaskVehiclesAndStaff = new System.Windows.Forms.GroupBox();
            this.listTaskVehicles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listTaskStaff = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHarvestTaskStaffList = new System.Windows.Forms.ComboBox();
            this.btnRemoveLabourerFromTask = new System.Windows.Forms.Button();
            this.gbVehicleSelection = new System.Windows.Forms.GroupBox();
            this.lblSowingTaskVehicleCat = new System.Windows.Forms.Label();
            this.cbHarvestTaskVehicleList = new System.Windows.Forms.ComboBox();
            this.btnVehicleAdd = new System.Windows.Forms.Button();
            this.cbVehicleCatList = new System.Windows.Forms.ComboBox();
            this.cbVehicleDriver = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSowingTaskVehicle = new System.Windows.Forms.Label();
            this.btnHarvestTaskAddWorker = new System.Windows.Forms.Button();
            this.txtRemoveVehicleFromTask = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listExistingHarvestTasks = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSowingTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).BeginInit();
            this.gbTaskVehiclesAndStaff.SuspendLayout();
            this.gbVehicleSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseHarvestTask
            // 
            this.btnCloseHarvestTask.Location = new System.Drawing.Point(1294, 653);
            this.btnCloseHarvestTask.Name = "btnCloseHarvestTask";
            this.btnCloseHarvestTask.Size = new System.Drawing.Size(75, 23);
            this.btnCloseHarvestTask.TabIndex = 51;
            this.btnCloseHarvestTask.Text = "Close";
            this.btnCloseHarvestTask.UseVisualStyleBackColor = true;
            this.btnCloseHarvestTask.Click += new System.EventHandler(this.btnCloseHarvestTask_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 615);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(25, 615);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 48;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // gbSowingTask
            // 
            this.gbSowingTask.Controls.Add(this.lblTaskStatus);
            this.gbSowingTask.Controls.Add(this.cbTaskStatus);
            this.gbSowingTask.Controls.Add(this.btnUpdate);
            this.gbSowingTask.Controls.Add(this.btnCreate);
            this.gbSowingTask.Controls.Add(this.btnResetForm);
            this.gbSowingTask.Controls.Add(this.nudExpectedYeild);
            this.gbSowingTask.Controls.Add(this.lblTaskId);
            this.gbSowingTask.Controls.Add(this.txtTaskID);
            this.gbSowingTask.Controls.Add(this.nudQuantity);
            this.gbSowingTask.Controls.Add(this.label20);
            this.gbSowingTask.Controls.Add(this.dtpFinishDate);
            this.gbSowingTask.Controls.Add(this.label19);
            this.gbSowingTask.Controls.Add(this.label17);
            this.gbSowingTask.Controls.Add(this.nudJobDuration);
            this.gbSowingTask.Controls.Add(this.label12);
            this.gbSowingTask.Controls.Add(this.dtpExpectedHarvestDate);
            this.gbSowingTask.Controls.Add(this.label8);
            this.gbSowingTask.Controls.Add(this.label7);
            this.gbSowingTask.Controls.Add(this.cbHarvestTaskCropList);
            this.gbSowingTask.Controls.Add(this.cbHarvestTaskFieldList);
            this.gbSowingTask.Controls.Add(this.label4);
            this.gbSowingTask.Controls.Add(this.label3);
            this.gbSowingTask.Controls.Add(this.dtpStartDate);
            this.gbSowingTask.Controls.Add(this.label2);
            this.gbSowingTask.Location = new System.Drawing.Point(21, 12);
            this.gbSowingTask.Name = "gbSowingTask";
            this.gbSowingTask.Size = new System.Drawing.Size(419, 664);
            this.gbSowingTask.TabIndex = 52;
            this.gbSowingTask.TabStop = false;
            this.gbSowingTask.Enter += new System.EventHandler(this.gbSowingTask_Enter);
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatus.Location = new System.Drawing.Point(22, 554);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(175, 20);
            this.lblTaskStatus.TabIndex = 41;
            this.lblTaskStatus.Text = "Task Current Status:";
            // 
            // cbTaskStatus
            // 
            this.cbTaskStatus.FormattingEnabled = true;
            this.cbTaskStatus.Items.AddRange(new object[] {
            "Not Started",
            "Task Started",
            "Task Finished",
            "Unable To Complete Task"});
            this.cbTaskStatus.Location = new System.Drawing.Point(203, 556);
            this.cbTaskStatus.Name = "cbTaskStatus";
            this.cbTaskStatus.Size = new System.Drawing.Size(164, 21);
            this.cbTaskStatus.TabIndex = 40;
            this.cbTaskStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(218, 615);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 39;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click_1);
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
            this.label12.Location = new System.Drawing.Point(298, 380);
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
            // cbHarvestTaskCropList
            // 
            this.cbHarvestTaskCropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHarvestTaskCropList.FormattingEnabled = true;
            this.cbHarvestTaskCropList.Location = new System.Drawing.Point(172, 257);
            this.cbHarvestTaskCropList.Name = "cbHarvestTaskCropList";
            this.cbHarvestTaskCropList.Size = new System.Drawing.Size(121, 21);
            this.cbHarvestTaskCropList.TabIndex = 7;
            // 
            // cbHarvestTaskFieldList
            // 
            this.cbHarvestTaskFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHarvestTaskFieldList.FormattingEnabled = true;
            this.cbHarvestTaskFieldList.Location = new System.Drawing.Point(172, 196);
            this.cbHarvestTaskFieldList.Name = "cbHarvestTaskFieldList";
            this.cbHarvestTaskFieldList.Size = new System.Drawing.Size(121, 21);
            this.cbHarvestTaskFieldList.TabIndex = 4;
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
            // gbTaskVehiclesAndStaff
            // 
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskVehicles);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskStaff);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label5);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label10);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.cbHarvestTaskStaffList);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnRemoveLabourerFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.gbVehicleSelection);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnHarvestTaskAddWorker);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.txtRemoveVehicleFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.label9);
            this.gbTaskVehiclesAndStaff.Location = new System.Drawing.Point(466, 28);
            this.gbTaskVehiclesAndStaff.Name = "gbTaskVehiclesAndStaff";
            this.gbTaskVehiclesAndStaff.Size = new System.Drawing.Size(452, 610);
            this.gbTaskVehiclesAndStaff.TabIndex = 53;
            this.gbTaskVehiclesAndStaff.TabStop = false;
            // 
            // listTaskVehicles
            // 
            this.listTaskVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listTaskVehicles.FullRowSelect = true;
            this.listTaskVehicles.GridLines = true;
            this.listTaskVehicles.Location = new System.Drawing.Point(26, 412);
            this.listTaskVehicles.Name = "listTaskVehicles";
            this.listTaskVehicles.Size = new System.Drawing.Size(289, 136);
            this.listTaskVehicles.TabIndex = 37;
            this.listTaskVehicles.UseCompatibleStateImageBehavior = false;
            this.listTaskVehicles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vehicle Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Driver";
            this.columnHeader2.Width = 100;
            // 
            // listTaskStaff
            // 
            this.listTaskStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listTaskStaff.FullRowSelect = true;
            this.listTaskStaff.GridLines = true;
            this.listTaskStaff.Location = new System.Drawing.Point(26, 76);
            this.listTaskStaff.Name = "listTaskStaff";
            this.listTaskStaff.Size = new System.Drawing.Size(345, 125);
            this.listTaskStaff.TabIndex = 38;
            this.listTaskStaff.UseCompatibleStateImageBehavior = false;
            this.listTaskStaff.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "First Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Surname";
            this.columnHeader5.Width = 150;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Vehicles assigened to task";
            // 
            // cbHarvestTaskStaffList
            // 
            this.cbHarvestTaskStaffList.FormattingEnabled = true;
            this.cbHarvestTaskStaffList.Location = new System.Drawing.Point(80, 11);
            this.cbHarvestTaskStaffList.Name = "cbHarvestTaskStaffList";
            this.cbHarvestTaskStaffList.Size = new System.Drawing.Size(121, 21);
            this.cbHarvestTaskStaffList.TabIndex = 13;
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
            // gbVehicleSelection
            // 
            this.gbVehicleSelection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbVehicleSelection.Controls.Add(this.lblSowingTaskVehicleCat);
            this.gbVehicleSelection.Controls.Add(this.cbHarvestTaskVehicleList);
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
            // cbHarvestTaskVehicleList
            // 
            this.cbHarvestTaskVehicleList.FormattingEnabled = true;
            this.cbHarvestTaskVehicleList.Location = new System.Drawing.Point(149, 36);
            this.cbHarvestTaskVehicleList.Name = "cbHarvestTaskVehicleList";
            this.cbHarvestTaskVehicleList.Size = new System.Drawing.Size(121, 21);
            this.cbHarvestTaskVehicleList.TabIndex = 17;
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
            // btnHarvestTaskAddWorker
            // 
            this.btnHarvestTaskAddWorker.Location = new System.Drawing.Point(216, 11);
            this.btnHarvestTaskAddWorker.Name = "btnHarvestTaskAddWorker";
            this.btnHarvestTaskAddWorker.Size = new System.Drawing.Size(91, 23);
            this.btnHarvestTaskAddWorker.TabIndex = 14;
            this.btnHarvestTaskAddWorker.Text = "Add Worker";
            this.btnHarvestTaskAddWorker.UseVisualStyleBackColor = true;
            this.btnHarvestTaskAddWorker.Click += new System.EventHandler(this.btnHarvestTaskAddWorker_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Labours assigened to task";
            // 
            // listExistingHarvestTasks
            // 
            this.listExistingHarvestTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listExistingHarvestTasks.FullRowSelect = true;
            this.listExistingHarvestTasks.GridLines = true;
            this.listExistingHarvestTasks.Location = new System.Drawing.Point(977, 28);
            this.listExistingHarvestTasks.Name = "listExistingHarvestTasks";
            this.listExistingHarvestTasks.Size = new System.Drawing.Size(368, 599);
            this.listExistingHarvestTasks.TabIndex = 53;
            this.listExistingHarvestTasks.UseCompatibleStateImageBehavior = false;
            this.listExistingHarvestTasks.View = System.Windows.Forms.View.Details;
            this.listExistingHarvestTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listExistingHarvestTasks_MouseClick);
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
            this.ClientSize = new System.Drawing.Size(1381, 688);
            this.Controls.Add(this.gbTaskVehiclesAndStaff);
            this.Controls.Add(this.listExistingHarvestTasks);
            this.Controls.Add(this.gbSowingTask);
            this.Controls.Add(this.btnCloseHarvestTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HarvestTaskForm";
            this.Text = "Create Harvest Task";
            this.gbSowingTask.ResumeLayout(false);
            this.gbSowingTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpectedYeild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJobDuration)).EndInit();
            this.gbTaskVehiclesAndStaff.ResumeLayout(false);
            this.gbTaskVehiclesAndStaff.PerformLayout();
            this.gbVehicleSelection.ResumeLayout(false);
            this.gbVehicleSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseHarvestTask;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbSowingTask;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.ComboBox cbTaskStatus;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.NumericUpDown nudExpectedYeild;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudJobDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExpectedHarvestDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbHarvestTaskCropList;
        private System.Windows.Forms.ComboBox cbHarvestTaskFieldList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTaskVehiclesAndStaff;
        private System.Windows.Forms.ListView listTaskVehicles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listTaskStaff;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbHarvestTaskStaffList;
        private System.Windows.Forms.Button btnRemoveLabourerFromTask;
        private System.Windows.Forms.GroupBox gbVehicleSelection;
        private System.Windows.Forms.Label lblSowingTaskVehicleCat;
        private System.Windows.Forms.ComboBox cbHarvestTaskVehicleList;
        private System.Windows.Forms.Button btnVehicleAdd;
        private System.Windows.Forms.ComboBox cbVehicleCatList;
        private System.Windows.Forms.ComboBox cbVehicleDriver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSowingTaskVehicle;
        private System.Windows.Forms.Button btnHarvestTaskAddWorker;
        private System.Windows.Forms.Button txtRemoveVehicleFromTask;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listExistingHarvestTasks;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}