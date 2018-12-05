﻿using System;
using System.Windows.Forms;
using FindANameFarm.Forms.Add_Resource_Forms;
using FindANameFarm.Forms.Add_work_tasks_Forms;
using FindANameFarm.Forms.Reports;
using FindANameFarm.Properties;

namespace FindANameFarm.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm manageStaff = new StaffForm();
            FormAllreadyOpen(manageStaff);
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleForm manageVehicles = new VehicleForm();
            FormAllreadyOpen(manageVehicles);
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CropForm manageCrops = new CropForm();
            FormAllreadyOpen(manageCrops);
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm manageStorage = new StorageForm();
            FormAllreadyOpen(manageStorage);
        }

        private void fertiliserAndTreatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FertiliserAndTreatmentForm managerFertiliserAndTreatments= new FertiliserAndTreatmentForm();
            FormAllreadyOpen(managerFertiliserAndTreatments);
        }

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldsForm manageFields = new FieldsForm();
            FormAllreadyOpen(manageFields);
        }

        private void sowingTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SowingTaskForm createSowingTask = new SowingTaskForm();
            FormAllreadyOpen(createSowingTask);
        }

        private void harvestTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarvestTaskForm createHarvestTask = new HarvestTaskForm();
            FormAllreadyOpen(createHarvestTask);
        }

        private void fertiliserTreatmentTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentTaskForm createTreatment = new TreatmentTaskForm();
            FormAllreadyOpen(createTreatment);
    
        }

        private void viewLabourRequirmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportLabourRequirementsForm viewLabourRequirements = new ReportLabourRequirementsForm();
            FormAllreadyOpen(viewLabourRequirements);
        }

        private void viewHarvestTimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarvestTimeTableForm viewHarvestTimeTable = new HarvestTimeTableForm();
            FormAllreadyOpen(viewHarvestTimeTable);
        }

        private void viewCropsCurrentlyInCultivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCropsInCultivationForm viewCropsInCultivation = new ReportCropsInCultivationForm();
            FormAllreadyOpen(viewCropsInCultivation);
        }

        private void viewStockLevelsAndPlannedUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ReportStockLevelsForms viewStockLevels = new ReportStockLevelsForms();
           // formAllreadyOpen(viewStockLevels);
        }

        private void viewAvailableStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAvailableStorageForm viewAvailableStorage = new ReportAvailableStorageForm();
            FormAllreadyOpen(viewAvailableStorage);
        }
        private void FormAllreadyOpen(Form formToOpen)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formToOpen.GetType())
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = formToOpen;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               
                    DialogResult message = MessageBox.Show(Resources.Exit_message, Resources.Exit_Title, MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            Hide();
            login.Show();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            
            this.BackgroundImage = Properties.Resources.farm_image__2_;
            
        }

        private void viewCurrentHarvestRequirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportHarvestRequirements viewHarvestReport = new ReportHarvestRequirements();
            FormAllreadyOpen(viewHarvestReport);
        }
    }
}
