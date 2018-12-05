namespace FindANameFarm.Forms.Reports
{
    partial class HarvestTimeTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarvestTimeTableForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRadialButtons = new System.Windows.Forms.GroupBox();
            this.rbAllTasks = new System.Windows.Forms.RadioButton();
            this.rbHarvest = new System.Windows.Forms.RadioButton();
            this.rbFertTreatment = new System.Windows.Forms.RadioButton();
            this.rbSowingTasks = new System.Windows.Forms.RadioButton();
            this.listHarvestTimeTable = new System.Windows.Forms.ListView();
            this.TaskTypeHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDateHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishTimeHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CropHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TreatmentHeading = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.gbRadialButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(792, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbRadialButtons
            // 
            this.gbRadialButtons.Controls.Add(this.rbAllTasks);
            this.gbRadialButtons.Controls.Add(this.rbHarvest);
            this.gbRadialButtons.Controls.Add(this.rbFertTreatment);
            this.gbRadialButtons.Controls.Add(this.rbSowingTasks);
            this.gbRadialButtons.Location = new System.Drawing.Point(667, 126);
            this.gbRadialButtons.Name = "gbRadialButtons";
            this.gbRadialButtons.Size = new System.Drawing.Size(175, 243);
            this.gbRadialButtons.TabIndex = 4;
            this.gbRadialButtons.TabStop = false;
            // 
            // rbAllTasks
            // 
            this.rbAllTasks.AutoSize = true;
            this.rbAllTasks.Location = new System.Drawing.Point(26, 45);
            this.rbAllTasks.Name = "rbAllTasks";
            this.rbAllTasks.Size = new System.Drawing.Size(68, 17);
            this.rbAllTasks.TabIndex = 3;
            this.rbAllTasks.TabStop = true;
            this.rbAllTasks.Text = "All Tasks";
            this.rbAllTasks.UseVisualStyleBackColor = true;
            this.rbAllTasks.CheckedChanged += new System.EventHandler(this.rbAllTasks_CheckedChanged);
            // 
            // rbHarvest
            // 
            this.rbHarvest.AutoSize = true;
            this.rbHarvest.Location = new System.Drawing.Point(26, 201);
            this.rbHarvest.Name = "rbHarvest";
            this.rbHarvest.Size = new System.Drawing.Size(94, 17);
            this.rbHarvest.TabIndex = 2;
            this.rbHarvest.TabStop = true;
            this.rbHarvest.Text = "Harvest Tasks";
            this.rbHarvest.UseVisualStyleBackColor = true;
            this.rbHarvest.CheckedChanged += new System.EventHandler(this.rbAllTasks_CheckedChanged);
            // 
            // rbFertTreatment
            // 
            this.rbFertTreatment.AutoSize = true;
            this.rbFertTreatment.Location = new System.Drawing.Point(26, 149);
            this.rbFertTreatment.Name = "rbFertTreatment";
            this.rbFertTreatment.Size = new System.Drawing.Size(143, 17);
            this.rbFertTreatment.TabIndex = 1;
            this.rbFertTreatment.TabStop = true;
            this.rbFertTreatment.Text = "Fertiliser/ treatment tasks";
            this.rbFertTreatment.UseVisualStyleBackColor = true;
            this.rbFertTreatment.CheckedChanged += new System.EventHandler(this.rbAllTasks_CheckedChanged);
            // 
            // rbSowingTasks
            // 
            this.rbSowingTasks.AutoSize = true;
            this.rbSowingTasks.Location = new System.Drawing.Point(26, 97);
            this.rbSowingTasks.Name = "rbSowingTasks";
            this.rbSowingTasks.Size = new System.Drawing.Size(92, 17);
            this.rbSowingTasks.TabIndex = 0;
            this.rbSowingTasks.TabStop = true;
            this.rbSowingTasks.Text = "Sowing Tasks";
            this.rbSowingTasks.UseVisualStyleBackColor = true;
            this.rbSowingTasks.CheckedChanged += new System.EventHandler(this.rbAllTasks_CheckedChanged);
            // 
            // listHarvestTimeTable
            // 
            this.listHarvestTimeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskTypeHeading,
            this.StartDateHeading,
            this.FinishTimeHeading,
            this.CropHeading,
            this.FieldHeading,
            this.TreatmentHeading});
            this.listHarvestTimeTable.FullRowSelect = true;
            this.listHarvestTimeTable.GridLines = true;
            this.listHarvestTimeTable.Location = new System.Drawing.Point(30, 21);
            this.listHarvestTimeTable.Name = "listHarvestTimeTable";
            this.listHarvestTimeTable.Size = new System.Drawing.Size(542, 388);
            this.listHarvestTimeTable.TabIndex = 3;
            this.listHarvestTimeTable.UseCompatibleStateImageBehavior = false;
            this.listHarvestTimeTable.View = System.Windows.Forms.View.Details;
            // 
            // TaskTypeHeading
            // 
            this.TaskTypeHeading.Text = "Task Type";
            this.TaskTypeHeading.Width = 75;
            // 
            // StartDateHeading
            // 
            this.StartDateHeading.Text = "Start Date";
            this.StartDateHeading.Width = 100;
            // 
            // FinishTimeHeading
            // 
            this.FinishTimeHeading.Text = "Task Finish Date";
            this.FinishTimeHeading.Width = 100;
            // 
            // CropHeading
            // 
            this.CropHeading.Text = "Crop";
            this.CropHeading.Width = 75;
            // 
            // FieldHeading
            // 
            this.FieldHeading.Text = "Field";
            this.FieldHeading.Width = 75;
            // 
            // TreatmentHeading
            // 
            this.TreatmentHeading.Text = "Treatment / Fertiliser";
            this.TreatmentHeading.Width = 120;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Location = new System.Drawing.Point(667, 33);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtDateFrom.TabIndex = 6;
            this.dtDateFrom.ValueChanged += new System.EventHandler(this.adDateTo_ValueChanged);
            // 
            // dtDateTo
            // 
            this.dtDateTo.Location = new System.Drawing.Point(667, 75);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtDateTo.TabIndex = 7;
            this.dtDateTo.ValueChanged += new System.EventHandler(this.adDateTo_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(610, 33);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(38, 13);
            this.lblDateFrom.TabIndex = 8;
            this.lblDateFrom.Text = "From:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(620, 75);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(26, 13);
            this.lblDateTo.TabIndex = 9;
            this.lblDateTo.Text = "To:";
            // 
            // HarvestTimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(893, 469);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRadialButtons);
            this.Controls.Add(this.listHarvestTimeTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HarvestTimeTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harvest Time Table";
            this.Load += new System.EventHandler(this.HarvestTimeTableForm_Load);
            this.gbRadialButtons.ResumeLayout(false);
            this.gbRadialButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbRadialButtons;
        private System.Windows.Forms.RadioButton rbAllTasks;
        private System.Windows.Forms.RadioButton rbHarvest;
        private System.Windows.Forms.RadioButton rbFertTreatment;
        private System.Windows.Forms.RadioButton rbSowingTasks;
        private System.Windows.Forms.ListView listHarvestTimeTable;
        private System.Windows.Forms.ColumnHeader TaskTypeHeading;
        private System.Windows.Forms.ColumnHeader StartDateHeading;
        private System.Windows.Forms.ColumnHeader FinishTimeHeading;
        private System.Windows.Forms.ColumnHeader CropHeading;
        private System.Windows.Forms.ColumnHeader FieldHeading;
        private System.Windows.Forms.ColumnHeader TreatmentHeading;
        private System.Windows.Forms.DateTimePicker dtDateFrom;
        private System.Windows.Forms.DateTimePicker dtDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
    }
}