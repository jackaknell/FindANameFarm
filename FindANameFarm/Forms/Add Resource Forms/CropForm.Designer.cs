namespace FindANameFarm.Forms.Add_Resource_Forms
{ 
    partial class CropForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CropForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCropName = new System.Windows.Forms.TextBox();
            this.listCrops = new System.Windows.Forms.ListView();
            this.lblCropName = new System.Windows.Forms.Label();
            this.txtCropId = new System.Windows.Forms.TextBox();
            this.lblCropId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAuditDesc = new System.Windows.Forms.Label();
            this.lblAuditAmount = new System.Windows.Forms.Label();
            this.lblAuditDate = new System.Windows.Forms.Label();
            this.nudCropAudit = new System.Windows.Forms.NumericUpDown();
            this.rtbCropAudit = new System.Windows.Forms.RichTextBox();
            this.dtpCropAudit = new System.Windows.Forms.DateTimePicker();
            this.rbSeed = new System.Windows.Forms.RadioButton();
            this.rbCrop = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropAudit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(608, 503);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 487);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(70, 487);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCropName
            // 
            this.txtCropName.Location = new System.Drawing.Point(115, 53);
            this.txtCropName.Name = "txtCropName";
            this.txtCropName.Size = new System.Drawing.Size(100, 20);
            this.txtCropName.TabIndex = 23;
            // 
            // listCrops
            // 
            this.listCrops.GridLines = true;
            this.listCrops.Location = new System.Drawing.Point(345, 15);
            this.listCrops.Name = "listCrops";
            this.listCrops.Size = new System.Drawing.Size(430, 421);
            this.listCrops.TabIndex = 22;
            this.listCrops.UseCompatibleStateImageBehavior = false;
            this.listCrops.View = System.Windows.Forms.View.Details;
            this.listCrops.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listCrops_MouseClick);
            // 
            // lblCropName
            // 
            this.lblCropName.AutoSize = true;
            this.lblCropName.Location = new System.Drawing.Point(49, 56);
            this.lblCropName.Name = "lblCropName";
            this.lblCropName.Size = new System.Drawing.Size(60, 13);
            this.lblCropName.TabIndex = 21;
            this.lblCropName.Text = "Crop Name";
            // 
            // txtCropId
            // 
            this.txtCropId.Location = new System.Drawing.Point(117, 12);
            this.txtCropId.Name = "txtCropId";
            this.txtCropId.ReadOnly = true;
            this.txtCropId.Size = new System.Drawing.Size(100, 20);
            this.txtCropId.TabIndex = 31;
            // 
            // lblCropId
            // 
            this.lblCropId.AutoSize = true;
            this.lblCropId.Location = new System.Drawing.Point(51, 15);
            this.lblCropId.Name = "lblCropId";
            this.lblCropId.Size = new System.Drawing.Size(41, 13);
            this.lblCropId.TabIndex = 30;
            this.lblCropId.Text = "Crop Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblAuditDesc);
            this.groupBox1.Controls.Add(this.lblAuditAmount);
            this.groupBox1.Controls.Add(this.lblAuditDate);
            this.groupBox1.Controls.Add(this.nudCropAudit);
            this.groupBox1.Controls.Add(this.rtbCropAudit);
            this.groupBox1.Controls.Add(this.dtpCropAudit);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 278);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audit";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(227, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblAuditDesc
            // 
            this.lblAuditDesc.AutoSize = true;
            this.lblAuditDesc.Location = new System.Drawing.Point(39, 125);
            this.lblAuditDesc.Name = "lblAuditDesc";
            this.lblAuditDesc.Size = new System.Drawing.Size(60, 13);
            this.lblAuditDesc.TabIndex = 36;
            this.lblAuditDesc.Text = "Description";
            // 
            // lblAuditAmount
            // 
            this.lblAuditAmount.AutoSize = true;
            this.lblAuditAmount.Location = new System.Drawing.Point(54, 62);
            this.lblAuditAmount.Name = "lblAuditAmount";
            this.lblAuditAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAuditAmount.TabIndex = 35;
            this.lblAuditAmount.Text = "Amount";
            // 
            // lblAuditDate
            // 
            this.lblAuditDate.AutoSize = true;
            this.lblAuditDate.Location = new System.Drawing.Point(55, 19);
            this.lblAuditDate.Name = "lblAuditDate";
            this.lblAuditDate.Size = new System.Drawing.Size(30, 13);
            this.lblAuditDate.TabIndex = 34;
            this.lblAuditDate.Text = "Date";
            // 
            // nudCropAudit
            // 
            this.nudCropAudit.Location = new System.Drawing.Point(103, 55);
            this.nudCropAudit.Name = "nudCropAudit";
            this.nudCropAudit.Size = new System.Drawing.Size(200, 20);
            this.nudCropAudit.TabIndex = 34;
            // 
            // rtbCropAudit
            // 
            this.rtbCropAudit.Location = new System.Drawing.Point(105, 90);
            this.rtbCropAudit.Name = "rtbCropAudit";
            this.rtbCropAudit.Size = new System.Drawing.Size(200, 101);
            this.rtbCropAudit.TabIndex = 33;
            this.rtbCropAudit.Text = "";
            // 
            // dtpCropAudit
            // 
            this.dtpCropAudit.Location = new System.Drawing.Point(102, 19);
            this.dtpCropAudit.Name = "dtpCropAudit";
            this.dtpCropAudit.Size = new System.Drawing.Size(200, 20);
            this.dtpCropAudit.TabIndex = 0;
            // 
            // rbSeed
            // 
            this.rbSeed.AutoSize = true;
            this.rbSeed.Location = new System.Drawing.Point(239, 55);
            this.rbSeed.Name = "rbSeed";
            this.rbSeed.Size = new System.Drawing.Size(50, 17);
            this.rbSeed.TabIndex = 33;
            this.rbSeed.TabStop = true;
            this.rbSeed.Text = "Seed";
            this.rbSeed.UseVisualStyleBackColor = true;
            // 
            // rbCrop
            // 
            this.rbCrop.AutoSize = true;
            this.rbCrop.Location = new System.Drawing.Point(239, 79);
            this.rbCrop.Name = "rbCrop";
            this.rbCrop.Size = new System.Drawing.Size(47, 17);
            this.rbCrop.TabIndex = 34;
            this.rbCrop.TabStop = true;
            this.rbCrop.Text = "Crop";
            this.rbCrop.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(456, 503);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Clear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 538);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbCrop);
            this.Controls.Add(this.rbSeed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCropId);
            this.Controls.Add(this.lblCropId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtCropName);
            this.Controls.Add(this.listCrops);
            this.Controls.Add(this.lblCropName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CropForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop & Seeds";
            this.Load += new System.EventHandler(this.CropForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropAudit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCropName;
        private System.Windows.Forms.ListView listCrops;
        private System.Windows.Forms.Label lblCropName;
        private System.Windows.Forms.TextBox txtCropId;
        private System.Windows.Forms.Label lblCropId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCropAudit;
        private System.Windows.Forms.RichTextBox rtbCropAudit;
        private System.Windows.Forms.DateTimePicker dtpCropAudit;
        private System.Windows.Forms.Label lblAuditDate;
        private System.Windows.Forms.Label lblAuditDesc;
        private System.Windows.Forms.Label lblAuditAmount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbSeed;
        private System.Windows.Forms.RadioButton rbCrop;
        private System.Windows.Forms.Button btnReset;
    }
}