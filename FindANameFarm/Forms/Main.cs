using System;
using System.Windows.Forms;

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
            formAllreadyOpen(manageStaff);
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehicleForm manageVehicles = new VehicleForm();
            formAllreadyOpen(manageVehicles);
        }

        private void cropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CropForm manageCrops = new CropForm();
            formAllreadyOpen(manageCrops);
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageForm manageStorage = new StorageForm();
            formAllreadyOpen(manageStorage);
        }

        private void fertiliserAndTreatmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FertiliserAndTreatmentForm managerFertiliserAndTreatments= new FertiliserAndTreatmentForm();
            formAllreadyOpen(managerFertiliserAndTreatments);
        }

        private void fieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldsForm manageFields = new FieldsForm();
            formAllreadyOpen(manageFields);
        }

        private void sowingTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SowingTaskForm createSowingTask = new SowingTaskForm();
            formAllreadyOpen(createSowingTask);
        }

        private void harvestTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarvestTaskForm createHarvestTask = new HarvestTaskForm();
            formAllreadyOpen(createHarvestTask);
        }

        private void fertiliserTreatmentTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreatmentTaskForm createTreatment = new TreatmentTaskForm();
            formAllreadyOpen(createTreatment);
    
        }

        private void viewLabourRequirmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportLabourRequirementsForm viewLabourRequirements = new ReportLabourRequirementsForm();
            formAllreadyOpen(viewLabourRequirements);
        }

        private void viewHarvestTimeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarvestTimeTableForm viewHarvestTimeTable = new HarvestTimeTableForm();
            formAllreadyOpen(viewHarvestTimeTable);
        }

        private void viewCropsCurrentlyInCultivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportCropsInCultivationForm viewCropsInCultivation = new ReportCropsInCultivationForm();
            formAllreadyOpen(viewCropsInCultivation);
        }

        private void viewStockLevelsAndPlannedUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStockLevelsForms viewStockLevels = new ReportStockLevelsForms();
            formAllreadyOpen(viewStockLevels);
        }

        private void viewAvailableStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAvailableStorageForm viewAvailableStorage = new ReportAvailableStorageForm();
            formAllreadyOpen(viewAvailableStorage);
        }
        private void formAllreadyOpen(Form formToOpen)
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

        
    }
}
