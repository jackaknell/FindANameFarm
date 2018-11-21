using System;

namespace FindANameFarm.Forms
{
    partial class FieldsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FieldsForm));
            this.txtFieldSuitability = new System.Windows.Forms.TextBox();
            this.lblFieldSuitability = new System.Windows.Forms.Label();
            this.listField = new System.Windows.Forms.ListView();
            this.txtFieldId = new System.Windows.Forms.TextBox();
            this.lblFieldId = new System.Windows.Forms.Label();
            this.btnUpdateField = new System.Windows.Forms.Button();
            this.btnFieldClose = new System.Windows.Forms.Button();
            this.btnFieldCreate = new System.Windows.Forms.Button();
            this.nudFieldSize = new System.Windows.Forms.NumericUpDown();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblFieldSize = new System.Windows.Forms.Label();
            this.btnFieldClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFieldSuitability
            // 
            this.txtFieldSuitability.Location = new System.Drawing.Point(175, 139);
            this.txtFieldSuitability.Name = "txtFieldSuitability";
            this.txtFieldSuitability.Size = new System.Drawing.Size(121, 20);
            this.txtFieldSuitability.TabIndex = 65;
            // 
            // lblFieldSuitability
            // 
            this.lblFieldSuitability.AutoSize = true;
            this.lblFieldSuitability.Location = new System.Drawing.Point(60, 142);
            this.lblFieldSuitability.Name = "lblFieldSuitability";
            this.lblFieldSuitability.Size = new System.Drawing.Size(74, 13);
            this.lblFieldSuitability.TabIndex = 64;
            this.lblFieldSuitability.Text = "Field Suitablity";
            // 
            // listField
            // 
            this.listField.GridLines = true;
            this.listField.Location = new System.Drawing.Point(317, 41);
            this.listField.Name = "listField";
            this.listField.Size = new System.Drawing.Size(424, 281);
            this.listField.TabIndex = 63;
            this.listField.UseCompatibleStateImageBehavior = false;
            this.listField.View = System.Windows.Forms.View.Details;
            this.listField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listField_MouseClick_1);
            // 
            // txtFieldId
            // 
            this.txtFieldId.Location = new System.Drawing.Point(175, 41);
            this.txtFieldId.Name = "txtFieldId";
            this.txtFieldId.ReadOnly = true;
            this.txtFieldId.Size = new System.Drawing.Size(121, 20);
            this.txtFieldId.TabIndex = 62;
            // 
            // lblFieldId
            // 
            this.lblFieldId.AutoSize = true;
            this.lblFieldId.Location = new System.Drawing.Point(60, 44);
            this.lblFieldId.Name = "lblFieldId";
            this.lblFieldId.Size = new System.Drawing.Size(18, 13);
            this.lblFieldId.TabIndex = 61;
            this.lblFieldId.Text = "ID";
            // 
            // btnUpdateField
            // 
            this.btnUpdateField.Location = new System.Drawing.Point(221, 297);
            this.btnUpdateField.Name = "btnUpdateField";
            this.btnUpdateField.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateField.TabIndex = 59;
            this.btnUpdateField.Text = "Update";
            this.btnUpdateField.UseVisualStyleBackColor = true;
            this.btnUpdateField.Click += new System.EventHandler(this.btnUpdateField_Click);
            // 
            // btnFieldClose
            // 
            this.btnFieldClose.Location = new System.Drawing.Point(640, 387);
            this.btnFieldClose.Name = "btnFieldClose";
            this.btnFieldClose.Size = new System.Drawing.Size(75, 23);
            this.btnFieldClose.TabIndex = 58;
            this.btnFieldClose.Text = "Close";
            this.btnFieldClose.UseVisualStyleBackColor = true;
            this.btnFieldClose.Click += new System.EventHandler(this.btnFieldClose_Click);
            // 
            // btnFieldCreate
            // 
            this.btnFieldCreate.Location = new System.Drawing.Point(221, 268);
            this.btnFieldCreate.Name = "btnFieldCreate";
            this.btnFieldCreate.Size = new System.Drawing.Size(75, 23);
            this.btnFieldCreate.TabIndex = 57;
            this.btnFieldCreate.Text = "Create";
            this.btnFieldCreate.UseVisualStyleBackColor = true;
            this.btnFieldCreate.Click += new System.EventHandler(this.btnFieldCreate_Click);
            // 
            // nudFieldSize
            // 
            this.nudFieldSize.Location = new System.Drawing.Point(175, 102);
            this.nudFieldSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFieldSize.Name = "nudFieldSize";
            this.nudFieldSize.Size = new System.Drawing.Size(121, 20);
            this.nudFieldSize.TabIndex = 56;
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(175, 71);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(121, 20);
            this.txtFieldName.TabIndex = 55;
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(60, 74);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(35, 13);
            this.lblFieldName.TabIndex = 54;
            this.lblFieldName.Text = "Name";
            // 
            // lblFieldSize
            // 
            this.lblFieldSize.AutoSize = true;
            this.lblFieldSize.Location = new System.Drawing.Point(60, 104);
            this.lblFieldSize.Name = "lblFieldSize";
            this.lblFieldSize.Size = new System.Drawing.Size(52, 13);
            this.lblFieldSize.TabIndex = 53;
            this.lblFieldSize.Text = "Field Size";
            // 
            // btnFieldClear
            // 
            this.btnFieldClear.Location = new System.Drawing.Point(221, 178);
            this.btnFieldClear.Name = "btnFieldClear";
            this.btnFieldClear.Size = new System.Drawing.Size(75, 23);
            this.btnFieldClear.TabIndex = 66;
            this.btnFieldClear.Text = "Clear";
            this.btnFieldClear.UseVisualStyleBackColor = true;
            this.btnFieldClear.Click += new System.EventHandler(this.btnFieldClear_Click);
            // 
            // FieldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFieldClear);
            this.Controls.Add(this.txtFieldSuitability);
            this.Controls.Add(this.lblFieldSuitability);
            this.Controls.Add(this.listField);
            this.Controls.Add(this.txtFieldId);
            this.Controls.Add(this.lblFieldId);
            this.Controls.Add(this.btnUpdateField);
            this.Controls.Add(this.btnFieldClose);
            this.Controls.Add(this.btnFieldCreate);
            this.Controls.Add(this.nudFieldSize);
            this.Controls.Add(this.txtFieldName);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.lblFieldSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FieldsForm";
            this.Text = "Field Management Form";
            this.Load += new System.EventHandler(this.FieldsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFieldSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		

		#endregion

		private System.Windows.Forms.TextBox txtFieldSuitability;
        private System.Windows.Forms.Label lblFieldSuitability;
        private System.Windows.Forms.ListView listField;
        private System.Windows.Forms.TextBox txtFieldId;
        private System.Windows.Forms.Label lblFieldId;
        private System.Windows.Forms.Button btnUpdateField;
        private System.Windows.Forms.Button btnFieldClose;
        private System.Windows.Forms.Button btnFieldCreate;
        private System.Windows.Forms.NumericUpDown nudFieldSize;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblFieldSize;
		private System.Windows.Forms.Button btnFieldClear;
	}
}