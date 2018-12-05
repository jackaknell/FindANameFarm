namespace FindANameFarm.Forms
{
    partial class TreatmentTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreatmentTaskForm));
            this.gbTaskVehiclesAndStaff = new System.Windows.Forms.GroupBox();
            this.listTaskVehicles = new System.Windows.Forms.ListView();
            this.listTaskStaff = new System.Windows.Forms.ListView();
            this.lblLabourers = new System.Windows.Forms.Label();
            this.lblVehiclesAssigned = new System.Windows.Forms.Label();
            this.cbFertTreatTaskStaffList = new System.Windows.Forms.ComboBox();
            this.btnRemoveLabourerFromTask = new System.Windows.Forms.Button();
            this.gbVehicleSelection = new System.Windows.Forms.GroupBox();
            this.lblFertTreatTaskVehicleCat = new System.Windows.Forms.Label();
            this.cbFertTreatTaskVehicleList = new System.Windows.Forms.ComboBox();
            this.btnVehicleAdd = new System.Windows.Forms.Button();
            this.cbVehicleCatList = new System.Windows.Forms.ComboBox();
            this.cbVehicleDriver = new System.Windows.Forms.ComboBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblFertTreatTaskVehicle = new System.Windows.Forms.Label();
            this.btnFertTreatTaskAddWorker = new System.Windows.Forms.Button();
            this.btnRemoveVehicleFromTask = new System.Windows.Forms.Button();
            this.lblLabourersAssigned = new System.Windows.Forms.Label();
            this.listExistingFertTreatTasks = new System.Windows.Forms.ListView();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbFertTreatTask = new System.Windows.Forms.GroupBox();
            this.lblTaskStatus = new System.Windows.Forms.Label();
            this.cbTaskStatus = new System.Windows.Forms.ComboBox();
            this.txtTaskId = new System.Windows.Forms.TextBox();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.nudTaskQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTaskQuantity = new System.Windows.Forms.Label();
            this.lblTaskDurationUnit = new System.Windows.Forms.Label();
            this.nudTaskDuration = new System.Windows.Forms.NumericUpDown();
            this.dtpTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.lblTaskFinish = new System.Windows.Forms.Label();
            this.lblTaskDuration = new System.Windows.Forms.Label();
            this.cbTaskFertTreat = new System.Windows.Forms.ComboBox();
            this.cbTaskField = new System.Windows.Forms.ComboBox();
            this.lblTaskFertTreat = new System.Windows.Forms.Label();
            this.lblTaskField = new System.Windows.Forms.Label();
            this.dtpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.lblTaskStart = new System.Windows.Forms.Label();
            this.gbTaskVehiclesAndStaff.SuspendLayout();
            this.gbVehicleSelection.SuspendLayout();
            this.gbFertTreatTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaskVehiclesAndStaff
            // 
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskVehicles);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.listTaskStaff);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.lblLabourers);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.lblVehiclesAssigned);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.cbFertTreatTaskStaffList);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnRemoveLabourerFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.gbVehicleSelection);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnFertTreatTaskAddWorker);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.btnRemoveVehicleFromTask);
            this.gbTaskVehiclesAndStaff.Controls.Add(this.lblLabourersAssigned);
            this.gbTaskVehiclesAndStaff.Location = new System.Drawing.Point(457, 25);
            this.gbTaskVehiclesAndStaff.Name = "gbTaskVehiclesAndStaff";
            this.gbTaskVehiclesAndStaff.Size = new System.Drawing.Size(411, 617);
            this.gbTaskVehiclesAndStaff.TabIndex = 47;
            this.gbTaskVehiclesAndStaff.TabStop = false;
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
            // lblLabourers
            // 
            this.lblLabourers.AutoSize = true;
            this.lblLabourers.Location = new System.Drawing.Point(17, 16);
            this.lblLabourers.Name = "lblLabourers";
            this.lblLabourers.Size = new System.Drawing.Size(57, 13);
            this.lblLabourers.TabIndex = 8;
            this.lblLabourers.Text = "Labourers:";
            // 
            // lblVehiclesAssigned
            // 
            this.lblVehiclesAssigned.AutoSize = true;
            this.lblVehiclesAssigned.Location = new System.Drawing.Point(23, 390);
            this.lblVehiclesAssigned.Name = "lblVehiclesAssigned";
            this.lblVehiclesAssigned.Size = new System.Drawing.Size(133, 13);
            this.lblVehiclesAssigned.TabIndex = 19;
            this.lblVehiclesAssigned.Text = "Vehicles assigened to task";
            // 
            // cbFertTreatTaskStaffList
            // 
            this.cbFertTreatTaskStaffList.FormattingEnabled = true;
            this.cbFertTreatTaskStaffList.Location = new System.Drawing.Point(80, 11);
            this.cbFertTreatTaskStaffList.Name = "cbFertTreatTaskStaffList";
            this.cbFertTreatTaskStaffList.Size = new System.Drawing.Size(121, 21);
            this.cbFertTreatTaskStaffList.TabIndex = 13;
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
            this.gbVehicleSelection.Controls.Add(this.lblFertTreatTaskVehicleCat);
            this.gbVehicleSelection.Controls.Add(this.cbFertTreatTaskVehicleList);
            this.gbVehicleSelection.Controls.Add(this.btnVehicleAdd);
            this.gbVehicleSelection.Controls.Add(this.cbVehicleCatList);
            this.gbVehicleSelection.Controls.Add(this.cbVehicleDriver);
            this.gbVehicleSelection.Controls.Add(this.lblDriver);
            this.gbVehicleSelection.Controls.Add(this.lblFertTreatTaskVehicle);
            this.gbVehicleSelection.Location = new System.Drawing.Point(22, 255);
            this.gbVehicleSelection.Name = "gbVehicleSelection";
            this.gbVehicleSelection.Size = new System.Drawing.Size(376, 127);
            this.gbVehicleSelection.TabIndex = 35;
            this.gbVehicleSelection.TabStop = false;
            // 
            // lblFertTreatTaskVehicleCat
            // 
            this.lblFertTreatTaskVehicleCat.AutoSize = true;
            this.lblFertTreatTaskVehicleCat.Location = new System.Drawing.Point(1, 18);
            this.lblFertTreatTaskVehicleCat.Name = "lblFertTreatTaskVehicleCat";
            this.lblFertTreatTaskVehicleCat.Size = new System.Drawing.Size(87, 13);
            this.lblFertTreatTaskVehicleCat.TabIndex = 36;
            this.lblFertTreatTaskVehicleCat.Text = "Vehicle Category";
            // 
            // cbFertTreatTaskVehicleList
            // 
            this.cbFertTreatTaskVehicleList.FormattingEnabled = true;
            this.cbFertTreatTaskVehicleList.Location = new System.Drawing.Point(149, 36);
            this.cbFertTreatTaskVehicleList.Name = "cbFertTreatTaskVehicleList";
            this.cbFertTreatTaskVehicleList.Size = new System.Drawing.Size(121, 21);
            this.cbFertTreatTaskVehicleList.TabIndex = 17;
            // 
            // btnVehicleAdd
            // 
            this.btnVehicleAdd.Location = new System.Drawing.Point(276, 88);
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
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(1, 93);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(38, 13);
            this.lblDriver.TabIndex = 21;
            this.lblDriver.Text = "Driver:";
            // 
            // lblFertTreatTaskVehicle
            // 
            this.lblFertTreatTaskVehicle.AutoSize = true;
            this.lblFertTreatTaskVehicle.Location = new System.Drawing.Point(1, 39);
            this.lblFertTreatTaskVehicle.Name = "lblFertTreatTaskVehicle";
            this.lblFertTreatTaskVehicle.Size = new System.Drawing.Size(50, 13);
            this.lblFertTreatTaskVehicle.TabIndex = 9;
            this.lblFertTreatTaskVehicle.Text = "Vehicles:";
            // 
            // btnFertTreatTaskAddWorker
            // 
            this.btnFertTreatTaskAddWorker.Location = new System.Drawing.Point(216, 11);
            this.btnFertTreatTaskAddWorker.Name = "btnFertTreatTaskAddWorker";
            this.btnFertTreatTaskAddWorker.Size = new System.Drawing.Size(91, 23);
            this.btnFertTreatTaskAddWorker.TabIndex = 14;
            this.btnFertTreatTaskAddWorker.Text = "Add Worker";
            this.btnFertTreatTaskAddWorker.UseVisualStyleBackColor = true;
            this.btnFertTreatTaskAddWorker.Click += new System.EventHandler(this.btnFertTreatTaskAddWorker_Click);
            // 
            // btnRemoveVehicleFromTask
            // 
            this.btnRemoveVehicleFromTask.Location = new System.Drawing.Point(26, 564);
            this.btnRemoveVehicleFromTask.Name = "btnRemoveVehicleFromTask";
            this.btnRemoveVehicleFromTask.Size = new System.Drawing.Size(164, 23);
            this.btnRemoveVehicleFromTask.TabIndex = 27;
            this.btnRemoveVehicleFromTask.Text = "Remove Vehicle from task";
            this.btnRemoveVehicleFromTask.UseVisualStyleBackColor = true;
            this.btnRemoveVehicleFromTask.Click += new System.EventHandler(this.btnRemoveVehicleFromTask_Click);
            // 
            // lblLabourersAssigned
            // 
            this.lblLabourersAssigned.AutoSize = true;
            this.lblLabourersAssigned.Location = new System.Drawing.Point(19, 47);
            this.lblLabourersAssigned.Name = "lblLabourersAssigned";
            this.lblLabourersAssigned.Size = new System.Drawing.Size(131, 13);
            this.lblLabourersAssigned.TabIndex = 16;
            this.lblLabourersAssigned.Text = "Labours assigened to task";
            // 
            // listExistingFertTreatTasks
            // 
            this.listExistingFertTreatTasks.GridLines = true;
            this.listExistingFertTreatTasks.Location = new System.Drawing.Point(889, 25);
            this.listExistingFertTreatTasks.Name = "listExistingFertTreatTasks";
            this.listExistingFertTreatTasks.Size = new System.Drawing.Size(324, 566);
            this.listExistingFertTreatTasks.TabIndex = 46;
            this.listExistingFertTreatTasks.UseCompatibleStateImageBehavior = false;
            this.listExistingFertTreatTasks.View = System.Windows.Forms.View.Details;
            this.listExistingFertTreatTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listExistingFertTreatTasks_MouseClick);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(317, 597);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(125, 45);
            this.btnClearForm.TabIndex = 45;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(165, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 45);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update Treatment task";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(889, 597);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 45);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 597);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(125, 45);
            this.btnCreate.TabIndex = 42;
            this.btnCreate.Text = "Create Treatment task";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbFertTreatTask
            // 
            this.gbFertTreatTask.Controls.Add(this.lblTaskStatus);
            this.gbFertTreatTask.Controls.Add(this.cbTaskStatus);
            this.gbFertTreatTask.Controls.Add(this.txtTaskId);
            this.gbFertTreatTask.Controls.Add(this.lblTaskId);
            this.gbFertTreatTask.Controls.Add(this.nudTaskQuantity);
            this.gbFertTreatTask.Controls.Add(this.lblTaskQuantity);
            this.gbFertTreatTask.Controls.Add(this.lblTaskDurationUnit);
            this.gbFertTreatTask.Controls.Add(this.nudTaskDuration);
            this.gbFertTreatTask.Controls.Add(this.dtpTaskFinish);
            this.gbFertTreatTask.Controls.Add(this.lblTaskFinish);
            this.gbFertTreatTask.Controls.Add(this.lblTaskDuration);
            this.gbFertTreatTask.Controls.Add(this.cbTaskFertTreat);
            this.gbFertTreatTask.Controls.Add(this.cbTaskField);
            this.gbFertTreatTask.Controls.Add(this.lblTaskFertTreat);
            this.gbFertTreatTask.Controls.Add(this.lblTaskField);
            this.gbFertTreatTask.Controls.Add(this.dtpTaskStart);
            this.gbFertTreatTask.Controls.Add(this.lblTaskStart);
            this.gbFertTreatTask.Location = new System.Drawing.Point(12, 25);
            this.gbFertTreatTask.Name = "gbFertTreatTask";
            this.gbFertTreatTask.Size = new System.Drawing.Size(430, 548);
            this.gbFertTreatTask.TabIndex = 41;
            this.gbFertTreatTask.TabStop = false;
            this.gbFertTreatTask.Enter += new System.EventHandler(this.gbFertTreatTask_Enter);
            // 
            // lblTaskStatus
            // 
            this.lblTaskStatus.AutoSize = true;
            this.lblTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskStatus.Location = new System.Drawing.Point(35, 483);
            this.lblTaskStatus.Name = "lblTaskStatus";
            this.lblTaskStatus.Size = new System.Drawing.Size(175, 20);
            this.lblTaskStatus.TabIndex = 43;
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
            this.cbTaskStatus.Location = new System.Drawing.Point(216, 485);
            this.cbTaskStatus.Name = "cbTaskStatus";
            this.cbTaskStatus.Size = new System.Drawing.Size(164, 21);
            this.cbTaskStatus.TabIndex = 42;
            this.cbTaskStatus.SelectedIndexChanged += new System.EventHandler(this.cbTaskStatus_SelectedIndexChanged);
            // 
            // txtTaskId
            // 
            this.txtTaskId.Location = new System.Drawing.Point(196, 17);
            this.txtTaskId.Name = "txtTaskId";
            this.txtTaskId.ReadOnly = true;
            this.txtTaskId.Size = new System.Drawing.Size(200, 20);
            this.txtTaskId.TabIndex = 31;
            this.txtTaskId.TextChanged += new System.EventHandler(this.txtTaskId_TextChanged);
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(26, 20);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(45, 13);
            this.lblTaskId.TabIndex = 30;
            this.lblTaskId.Text = "Task ID";
            // 
            // nudTaskQuantity
            // 
            this.nudTaskQuantity.Location = new System.Drawing.Point(196, 292);
            this.nudTaskQuantity.Name = "nudTaskQuantity";
            this.nudTaskQuantity.Size = new System.Drawing.Size(200, 20);
            this.nudTaskQuantity.TabIndex = 29;
            // 
            // lblTaskQuantity
            // 
            this.lblTaskQuantity.AutoSize = true;
            this.lblTaskQuantity.Location = new System.Drawing.Point(24, 294);
            this.lblTaskQuantity.Name = "lblTaskQuantity";
            this.lblTaskQuantity.Size = new System.Drawing.Size(87, 13);
            this.lblTaskQuantity.TabIndex = 28;
            this.lblTaskQuantity.Text = "Quantity Needed";
            // 
            // lblTaskDurationUnit
            // 
            this.lblTaskDurationUnit.AutoSize = true;
            this.lblTaskDurationUnit.Location = new System.Drawing.Point(352, 348);
            this.lblTaskDurationUnit.Name = "lblTaskDurationUnit";
            this.lblTaskDurationUnit.Size = new System.Drawing.Size(44, 13);
            this.lblTaskDurationUnit.TabIndex = 25;
            this.lblTaskDurationUnit.Text = "in hours";
            // 
            // nudTaskDuration
            // 
            this.nudTaskDuration.Location = new System.Drawing.Point(196, 346);
            this.nudTaskDuration.Name = "nudTaskDuration";
            this.nudTaskDuration.Size = new System.Drawing.Size(120, 20);
            this.nudTaskDuration.TabIndex = 24;
            // 
            // dtpTaskFinish
            // 
            this.dtpTaskFinish.Location = new System.Drawing.Point(196, 121);
            this.dtpTaskFinish.Name = "dtpTaskFinish";
            this.dtpTaskFinish.Size = new System.Drawing.Size(200, 20);
            this.dtpTaskFinish.TabIndex = 12;
            // 
            // lblTaskFinish
            // 
            this.lblTaskFinish.AutoSize = true;
            this.lblTaskFinish.Location = new System.Drawing.Point(26, 127);
            this.lblTaskFinish.Name = "lblTaskFinish";
            this.lblTaskFinish.Size = new System.Drawing.Size(63, 13);
            this.lblTaskFinish.TabIndex = 11;
            this.lblTaskFinish.Text = "Finish Date:";
            // 
            // lblTaskDuration
            // 
            this.lblTaskDuration.AutoSize = true;
            this.lblTaskDuration.Location = new System.Drawing.Point(24, 348);
            this.lblTaskDuration.Name = "lblTaskDuration";
            this.lblTaskDuration.Size = new System.Drawing.Size(70, 13);
            this.lblTaskDuration.TabIndex = 10;
            this.lblTaskDuration.Text = "Job Duration:";
            // 
            // cbTaskFertTreat
            // 
            this.cbTaskFertTreat.FormattingEnabled = true;
            this.cbTaskFertTreat.Location = new System.Drawing.Point(196, 236);
            this.cbTaskFertTreat.Name = "cbTaskFertTreat";
            this.cbTaskFertTreat.Size = new System.Drawing.Size(200, 21);
            this.cbTaskFertTreat.TabIndex = 7;
            // 
            // cbTaskField
            // 
            this.cbTaskField.FormattingEnabled = true;
            this.cbTaskField.Location = new System.Drawing.Point(196, 176);
            this.cbTaskField.Name = "cbTaskField";
            this.cbTaskField.Size = new System.Drawing.Size(200, 21);
            this.cbTaskField.TabIndex = 4;
            // 
            // lblTaskFertTreat
            // 
            this.lblTaskFertTreat.AutoSize = true;
            this.lblTaskFertTreat.Location = new System.Drawing.Point(24, 240);
            this.lblTaskFertTreat.Name = "lblTaskFertTreat";
            this.lblTaskFertTreat.Size = new System.Drawing.Size(101, 13);
            this.lblTaskFertTreat.TabIndex = 3;
            this.lblTaskFertTreat.Text = "Treatment/Fertiliser:";
            // 
            // lblTaskField
            // 
            this.lblTaskField.AutoSize = true;
            this.lblTaskField.Location = new System.Drawing.Point(26, 179);
            this.lblTaskField.Name = "lblTaskField";
            this.lblTaskField.Size = new System.Drawing.Size(32, 13);
            this.lblTaskField.TabIndex = 2;
            this.lblTaskField.Text = "Field:";
            // 
            // dtpTaskStart
            // 
            this.dtpTaskStart.Location = new System.Drawing.Point(196, 70);
            this.dtpTaskStart.Name = "dtpTaskStart";
            this.dtpTaskStart.Size = new System.Drawing.Size(200, 20);
            this.dtpTaskStart.TabIndex = 1;
            // 
            // lblTaskStart
            // 
            this.lblTaskStart.AutoSize = true;
            this.lblTaskStart.Location = new System.Drawing.Point(26, 76);
            this.lblTaskStart.Name = "lblTaskStart";
            this.lblTaskStart.Size = new System.Drawing.Size(68, 13);
            this.lblTaskStart.TabIndex = 0;
            this.lblTaskStart.Text = "Date of task:";
            // 
            // TreatmentTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1247, 658);
            this.Controls.Add(this.gbTaskVehiclesAndStaff);
            this.Controls.Add(this.listExistingFertTreatTasks);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbFertTreatTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreatmentTaskForm";
            this.Text = "Create Treatment Task ";
            this.Load += new System.EventHandler(this.TreatmentTaskForm_Load);
            this.gbTaskVehiclesAndStaff.ResumeLayout(false);
            this.gbTaskVehiclesAndStaff.PerformLayout();
            this.gbVehicleSelection.ResumeLayout(false);
            this.gbVehicleSelection.PerformLayout();
            this.gbFertTreatTask.ResumeLayout(false);
            this.gbFertTreatTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaskDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaskVehiclesAndStaff;
        private System.Windows.Forms.ListView listTaskVehicles;
        private System.Windows.Forms.ListView listTaskStaff;
        private System.Windows.Forms.Label lblLabourers;
        private System.Windows.Forms.Label lblVehiclesAssigned;
        private System.Windows.Forms.ComboBox cbFertTreatTaskStaffList;
        private System.Windows.Forms.Button btnRemoveLabourerFromTask;
        private System.Windows.Forms.GroupBox gbVehicleSelection;
        private System.Windows.Forms.Label lblFertTreatTaskVehicleCat;
        private System.Windows.Forms.ComboBox cbFertTreatTaskVehicleList;
        private System.Windows.Forms.Button btnVehicleAdd;
        private System.Windows.Forms.ComboBox cbVehicleCatList;
        private System.Windows.Forms.ComboBox cbVehicleDriver;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblFertTreatTaskVehicle;
        private System.Windows.Forms.Button btnFertTreatTaskAddWorker;
        private System.Windows.Forms.Button btnRemoveVehicleFromTask;
        private System.Windows.Forms.Label lblLabourersAssigned;
        private System.Windows.Forms.ListView listExistingFertTreatTasks;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox gbFertTreatTask;
        private System.Windows.Forms.TextBox txtTaskId;
        private System.Windows.Forms.Label lblTaskId;
        private System.Windows.Forms.NumericUpDown nudTaskQuantity;
        private System.Windows.Forms.Label lblTaskQuantity;
        private System.Windows.Forms.Label lblTaskDurationUnit;
        private System.Windows.Forms.NumericUpDown nudTaskDuration;
        private System.Windows.Forms.DateTimePicker dtpTaskFinish;
        private System.Windows.Forms.Label lblTaskFinish;
        private System.Windows.Forms.Label lblTaskDuration;
        private System.Windows.Forms.ComboBox cbTaskFertTreat;
        private System.Windows.Forms.ComboBox cbTaskField;
        private System.Windows.Forms.Label lblTaskFertTreat;
        private System.Windows.Forms.Label lblTaskField;
        private System.Windows.Forms.DateTimePicker dtpTaskStart;
        private System.Windows.Forms.Label lblTaskStart;
        private System.Windows.Forms.Label lblTaskStatus;
        private System.Windows.Forms.ComboBox cbTaskStatus;
    }
}