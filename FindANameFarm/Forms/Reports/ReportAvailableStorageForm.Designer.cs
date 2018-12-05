namespace FindANameFarm.Forms
{
    partial class ReportAvailableStorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAvailableStorageForm));
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStoring = new System.Windows.Forms.TextBox();
            this.listAvailableStorage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(199, 214);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(158, 20);
            this.textBox6.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Planned Usage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(199, 84);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(158, 20);
            this.txtId.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Currently Storing";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(199, 188);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(158, 20);
            this.txtTemp.TabIndex = 55;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(199, 162);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(158, 20);
            this.txtAvailable.TabIndex = 54;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(199, 136);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(158, 20);
            this.txtCapacity.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Available Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Storage ID";
            // 
            // txtStoring
            // 
            this.txtStoring.Location = new System.Drawing.Point(199, 110);
            this.txtStoring.Name = "txtStoring";
            this.txtStoring.ReadOnly = true;
            this.txtStoring.Size = new System.Drawing.Size(158, 20);
            this.txtStoring.TabIndex = 48;
            // 
            // listAvailableStorage
            // 
            this.listAvailableStorage.GridLines = true;
            this.listAvailableStorage.Location = new System.Drawing.Point(439, 78);
            this.listAvailableStorage.Name = "listAvailableStorage";
            this.listAvailableStorage.Size = new System.Drawing.Size(295, 389);
            this.listAvailableStorage.TabIndex = 47;
            this.listAvailableStorage.UseCompatibleStateImageBehavior = false;
            this.listAvailableStorage.View = System.Windows.Forms.View.Details;
            this.listAvailableStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listAvailableStorage_MouseClick_1);
            // 
            // ReportAvailableStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStoring);
            this.Controls.Add(this.listAvailableStorage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportAvailableStorageForm";
            this.Text = "ReportAvailableStorageForm";
            this.Load += new System.EventHandler(this.ReportAvailableStorageForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStoring;
        private System.Windows.Forms.ListView listAvailableStorage;
    }
}