﻿namespace FindANameFarm.Forms
{
    partial class ReportLabourRequirementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportLabourRequirementsForm));
            this.listCompetencies = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCompetencies
            // 
            this.listCompetencies.GridLines = true;
            this.listCompetencies.Location = new System.Drawing.Point(34, 63);
            this.listCompetencies.Name = "listCompetencies";
            this.listCompetencies.Size = new System.Drawing.Size(232, 249);
            this.listCompetencies.TabIndex = 6;
            this.listCompetencies.UseCompatibleStateImageBehavior = false;
            this.listCompetencies.View = System.Windows.Forms.View.Details;
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(322, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 509);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Job duration (Hour\'s)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(792, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tasks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Staff";
            // 
            // ReportLabourRequirementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(879, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listCompetencies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportLabourRequirementsForm";
            this.Text = "ReportLabourRequirementsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCompetencies;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}