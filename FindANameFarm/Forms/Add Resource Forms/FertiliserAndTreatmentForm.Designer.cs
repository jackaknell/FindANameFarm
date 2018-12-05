namespace FindANameFarm.Forms
{
    partial class FertiliserAndTreatmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FertiliserAndTreatmentForm));
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuditDesc = new System.Windows.Forms.Label();
            this.lblAuditAmount = new System.Windows.Forms.Label();
            this.lblAuditDate = new System.Windows.Forms.Label();
            this.cbStorage = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listFertTreat = new System.Windows.Forms.ListView();
            this.txtFertTreatId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFertTreatUpdate = new System.Windows.Forms.Button();
            this.btnFertTreatClose = new System.Windows.Forms.Button();
            this.btnFertTreatCreate = new System.Windows.Forms.Button();
            this.nudFertTreatQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtFertTreatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFertTreatQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(443, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAuditDesc);
            this.groupBox1.Controls.Add(this.lblAuditAmount);
            this.groupBox1.Controls.Add(this.lblAuditDate);
            this.groupBox1.Controls.Add(this.cbStorage);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(67, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 268);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Storage";
            // 
            // lblAuditDesc
            // 
            this.lblAuditDesc.AutoSize = true;
            this.lblAuditDesc.Location = new System.Drawing.Point(17, 127);
            this.lblAuditDesc.Name = "lblAuditDesc";
            this.lblAuditDesc.Size = new System.Drawing.Size(60, 13);
            this.lblAuditDesc.TabIndex = 39;
            this.lblAuditDesc.Text = "Description";
            // 
            // lblAuditAmount
            // 
            this.lblAuditAmount.AutoSize = true;
            this.lblAuditAmount.Location = new System.Drawing.Point(25, 62);
            this.lblAuditAmount.Name = "lblAuditAmount";
            this.lblAuditAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAuditAmount.TabIndex = 38;
            this.lblAuditAmount.Text = "Amount";
            // 
            // lblAuditDate
            // 
            this.lblAuditDate.AutoSize = true;
            this.lblAuditDate.Location = new System.Drawing.Point(36, 24);
            this.lblAuditDate.Name = "lblAuditDate";
            this.lblAuditDate.Size = new System.Drawing.Size(30, 13);
            this.lblAuditDate.TabIndex = 37;
            this.lblAuditDate.Text = "Date";
            // 
            // cbStorage
            // 
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Location = new System.Drawing.Point(82, 87);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(200, 21);
            this.cbStorage.TabIndex = 35;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(83, 60);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown2.TabIndex = 34;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(83, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 101);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // listFertTreat
            // 
            this.listFertTreat.GridLines = true;
            this.listFertTreat.Location = new System.Drawing.Point(443, 33);
            this.listFertTreat.Name = "listFertTreat";
            this.listFertTreat.Size = new System.Drawing.Size(345, 331);
            this.listFertTreat.TabIndex = 63;
            this.listFertTreat.UseCompatibleStateImageBehavior = false;
            this.listFertTreat.View = System.Windows.Forms.View.Details;
            this.listFertTreat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listFertTreat_MouseClick);
            // 
            // txtFertTreatId
            // 
            this.txtFertTreatId.Location = new System.Drawing.Point(232, 33);
            this.txtFertTreatId.Name = "txtFertTreatId";
            this.txtFertTreatId.ReadOnly = true;
            this.txtFertTreatId.Size = new System.Drawing.Size(121, 20);
            this.txtFertTreatId.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "ID";
            // 
            // btnFertTreatUpdate
            // 
            this.btnFertTreatUpdate.Location = new System.Drawing.Point(278, 141);
            this.btnFertTreatUpdate.Name = "btnFertTreatUpdate";
            this.btnFertTreatUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnFertTreatUpdate.TabIndex = 60;
            this.btnFertTreatUpdate.Text = "Update";
            this.btnFertTreatUpdate.UseVisualStyleBackColor = true;
            this.btnFertTreatUpdate.Click += new System.EventHandler(this.btnFertTreatUpdate_Click);
            // 
            // btnFertTreatClose
            // 
            this.btnFertTreatClose.Location = new System.Drawing.Point(713, 379);
            this.btnFertTreatClose.Name = "btnFertTreatClose";
            this.btnFertTreatClose.Size = new System.Drawing.Size(75, 23);
            this.btnFertTreatClose.TabIndex = 59;
            this.btnFertTreatClose.Text = "Close";
            this.btnFertTreatClose.UseVisualStyleBackColor = true;
            this.btnFertTreatClose.Click += new System.EventHandler(this.btnFertTreatClose_Click);
            // 
            // btnFertTreatCreate
            // 
            this.btnFertTreatCreate.Location = new System.Drawing.Point(197, 141);
            this.btnFertTreatCreate.Name = "btnFertTreatCreate";
            this.btnFertTreatCreate.Size = new System.Drawing.Size(75, 23);
            this.btnFertTreatCreate.TabIndex = 58;
            this.btnFertTreatCreate.Text = "Create";
            this.btnFertTreatCreate.UseVisualStyleBackColor = true;
            this.btnFertTreatCreate.Click += new System.EventHandler(this.btnFertTreatCreate_Click);
            // 
            // nudFertTreatQuantity
            // 
            this.nudFertTreatQuantity.Location = new System.Drawing.Point(232, 94);
            this.nudFertTreatQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFertTreatQuantity.Name = "nudFertTreatQuantity";
            this.nudFertTreatQuantity.Size = new System.Drawing.Size(121, 20);
            this.nudFertTreatQuantity.TabIndex = 57;
            // 
            // txtFertTreatName
            // 
            this.txtFertTreatName.Location = new System.Drawing.Point(232, 63);
            this.txtFertTreatName.Name = "txtFertTreatName";
            this.txtFertTreatName.Size = new System.Drawing.Size(121, 20);
            this.txtFertTreatName.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Quantity";
            // 
            // FertiliserAndTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFertTreat);
            this.Controls.Add(this.txtFertTreatId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFertTreatUpdate);
            this.Controls.Add(this.btnFertTreatClose);
            this.Controls.Add(this.btnFertTreatCreate);
            this.Controls.Add(this.nudFertTreatQuantity);
            this.Controls.Add(this.txtFertTreatName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FertiliserAndTreatmentForm";
            this.Text = "Fertiliser And Treatment Management ";
            this.Load += new System.EventHandler(this.FertiliserAndTreatmentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFertTreatQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ListView listFertTreat;
		private System.Windows.Forms.TextBox txtFertTreatId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnFertTreatUpdate;
		private System.Windows.Forms.Button btnFertTreatClose;
		private System.Windows.Forms.Button btnFertTreatCreate;
		private System.Windows.Forms.NumericUpDown nudFertTreatQuantity;
		private System.Windows.Forms.TextBox txtFertTreatName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuditDesc;
        private System.Windows.Forms.Label lblAuditAmount;
        private System.Windows.Forms.Label lblAuditDate;
    }
}