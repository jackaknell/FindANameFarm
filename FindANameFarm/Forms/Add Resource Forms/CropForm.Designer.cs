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
            this.rbSeed = new System.Windows.Forms.RadioButton();
            this.rbCrop = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(30, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 300);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Storage";
            // 
            // lblAuditDesc
            // 
            this.lblAuditDesc.AutoSize = true;
            this.lblAuditDesc.Location = new System.Drawing.Point(3, 127);
            this.lblAuditDesc.Name = "lblAuditDesc";
            this.lblAuditDesc.Size = new System.Drawing.Size(60, 13);
            this.lblAuditDesc.TabIndex = 48;
            this.lblAuditDesc.Text = "Description";
            // 
            // lblAuditAmount
            // 
            this.lblAuditAmount.AutoSize = true;
            this.lblAuditAmount.Location = new System.Drawing.Point(11, 62);
            this.lblAuditAmount.Name = "lblAuditAmount";
            this.lblAuditAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAuditAmount.TabIndex = 47;
            this.lblAuditAmount.Text = "Amount";
            // 
            // lblAuditDate
            // 
            this.lblAuditDate.AutoSize = true;
            this.lblAuditDate.Location = new System.Drawing.Point(22, 24);
            this.lblAuditDate.Name = "lblAuditDate";
            this.lblAuditDate.Size = new System.Drawing.Size(30, 13);
            this.lblAuditDate.TabIndex = 46;
            this.lblAuditDate.Text = "Date";
            // 
            // cbStorage
            // 
            this.cbStorage.FormattingEnabled = true;
            this.cbStorage.Location = new System.Drawing.Point(68, 87);
            this.cbStorage.Name = "cbStorage";
            this.cbStorage.Size = new System.Drawing.Size(200, 21);
            this.cbStorage.TabIndex = 45;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(69, 60);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown2.TabIndex = 44;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(69, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 101);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // CropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(801, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.rbCrop);
            this.Controls.Add(this.rbSeed);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.RadioButton rbSeed;
        private System.Windows.Forms.RadioButton rbCrop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuditDesc;
        private System.Windows.Forms.Label lblAuditAmount;
        private System.Windows.Forms.Label lblAuditDate;
        private System.Windows.Forms.ComboBox cbStorage;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}