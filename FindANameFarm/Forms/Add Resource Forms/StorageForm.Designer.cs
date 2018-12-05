namespace FindANameFarm.Forms
{
    partial class StorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForm));
            this.btncloseStore = new System.Windows.Forms.Button();
            this.btnUpdateStore = new System.Windows.Forms.Button();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.nudTemp = new System.Windows.Forms.NumericUpDown();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblAvailableStore = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.btnCreateStore = new System.Windows.Forms.Button();
            this.listStorage = new System.Windows.Forms.ListView();
            this.nudAvailableStore = new System.Windows.Forms.NumericUpDown();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btncloseStore
            // 
            this.btncloseStore.Location = new System.Drawing.Point(732, 406);
            this.btncloseStore.Name = "btncloseStore";
            this.btncloseStore.Size = new System.Drawing.Size(75, 23);
            this.btncloseStore.TabIndex = 32;
            this.btncloseStore.Text = "Close";
            this.btncloseStore.UseVisualStyleBackColor = true;
            this.btncloseStore.Click += new System.EventHandler(this.btncloseStore_Click);
            // 
            // btnUpdateStore
            // 
            this.btnUpdateStore.Location = new System.Drawing.Point(142, 289);
            this.btnUpdateStore.Name = "btnUpdateStore";
            this.btnUpdateStore.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStore.TabIndex = 31;
            this.btnUpdateStore.Text = "Update";
            this.btnUpdateStore.UseVisualStyleBackColor = true;
            this.btnUpdateStore.Click += new System.EventHandler(this.btnUpdateStore_Click);
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(135, 139);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.ReadOnly = true;
            this.nudCapacity.Size = new System.Drawing.Size(159, 20);
            this.nudCapacity.TabIndex = 30;
            // 
            // nudTemp
            // 
            this.nudTemp.Location = new System.Drawing.Point(135, 211);
            this.nudTemp.Name = "nudTemp";
            this.nudTemp.ReadOnly = true;
            this.nudTemp.Size = new System.Drawing.Size(159, 20);
            this.nudTemp.TabIndex = 29;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(58, 213);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(34, 13);
            this.lblTemp.TabIndex = 28;
            this.lblTemp.Text = "Temp";
            // 
            // lblAvailableStore
            // 
            this.lblAvailableStore.AutoSize = true;
            this.lblAvailableStore.Location = new System.Drawing.Point(39, 180);
            this.lblAvailableStore.Name = "lblAvailableStore";
            this.lblAvailableStore.Size = new System.Drawing.Size(90, 13);
            this.lblAvailableStore.TabIndex = 26;
            this.lblAvailableStore.Text = "Available Storage";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(58, 141);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(48, 13);
            this.lblCapacity.TabIndex = 24;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(58, 72);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(58, 13);
            this.lblStoreID.TabIndex = 23;
            this.lblStoreID.Text = "Storage ID";
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(135, 72);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.ReadOnly = true;
            this.txtStoreID.Size = new System.Drawing.Size(159, 20);
            this.txtStoreID.TabIndex = 22;
            // 
            // btnCreateStore
            // 
            this.btnCreateStore.Location = new System.Drawing.Point(61, 289);
            this.btnCreateStore.Name = "btnCreateStore";
            this.btnCreateStore.Size = new System.Drawing.Size(75, 23);
            this.btnCreateStore.TabIndex = 21;
            this.btnCreateStore.Text = "Create";
            this.btnCreateStore.UseVisualStyleBackColor = true;
            this.btnCreateStore.Click += new System.EventHandler(this.btnCreateStore_Click);
            // 
            // listStorage
            // 
            this.listStorage.GridLines = true;
            this.listStorage.Location = new System.Drawing.Point(363, 12);
            this.listStorage.Name = "listStorage";
            this.listStorage.Size = new System.Drawing.Size(442, 375);
            this.listStorage.TabIndex = 20;
            this.listStorage.UseCompatibleStateImageBehavior = false;
            this.listStorage.View = System.Windows.Forms.View.Details;
            this.listStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listStorage_MouseClick);
            // 
            // nudAvailableStore
            // 
            this.nudAvailableStore.Location = new System.Drawing.Point(135, 178);
            this.nudAvailableStore.Name = "nudAvailableStore";
            this.nudAvailableStore.ReadOnly = true;
            this.nudAvailableStore.Size = new System.Drawing.Size(159, 20);
            this.nudAvailableStore.TabIndex = 33;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(54, 106);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(75, 13);
            this.lblStoreName.TabIndex = 35;
            this.lblStoreName.Text = "Storage Name";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(135, 103);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(159, 20);
            this.txtStoreName.TabIndex = 34;
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(300, 141);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(20, 13);
            this.lblKG.TabIndex = 36;
            this.lblKG.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "C";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(363, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(819, 456);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.nudAvailableStore);
            this.Controls.Add(this.btncloseStore);
            this.Controls.Add(this.btnUpdateStore);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.nudTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblAvailableStore);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStoreID);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.btnCreateStore);
            this.Controls.Add(this.listStorage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            this.Load += new System.EventHandler(this.StorageForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAvailableStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncloseStore;
        private System.Windows.Forms.Button btnUpdateStore;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.NumericUpDown nudTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblAvailableStore;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Button btnCreateStore;
        private System.Windows.Forms.ListView listStorage;
        private System.Windows.Forms.NumericUpDown nudAvailableStore;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}