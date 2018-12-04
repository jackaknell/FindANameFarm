using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;
using FindANameFarm.Properties;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.Forms.Add_work_tasks_Forms
{
    /// <summary>
    /// ian 17/11/18
    /// sowing task form controls
    /// </summary>
    public partial class SowingTaskForm : Form
    {
        private readonly FieldBank _field = FieldBank.GetInst();
        private readonly StaffBank _staff = StaffBank.GetInst();
        private readonly CropsBank _crop = CropsBank.GetInst();
        private readonly StorageBank _storage = StorageBank.GetInst();
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();
        private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();
        private string _taskType = "Sowing";

        public SowingTaskForm()
        {
            InitializeComponent();
            ResetForm();

            refresh();
        }

        private void SowingTaskForm_Load(object sender, EventArgs e)
        {
            gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrWhiteSpace(txtTaskID.Text);

            btnUpdateSowingTask.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);

            ShowExistingSowingTasks();

            ResetForm();
        }

        private void txtTaskID_TextChanged(object sender, EventArgs e)
        {
            gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);

            btnUpdateSowingTask.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);
        }
        //calls the methods to display the task drop down fields
        private void gbSowingTask_Enter(object sender, EventArgs e)
        {
            ShowFields();
            ShowStaff();
            ShowCrop();
            ShowCategories();
            ShowStorage();
        }

        private void ShowFields()
        {
            if (cbSowingTaskFieldList != null)
            {
                cbSowingTaskFieldList.DataSource = _field.FieldList;
            }

            if (cbSowingTaskFieldList == null) return;
            cbSowingTaskFieldList.DisplayMember = "FieldName";
            cbSowingTaskFieldList.ValueMember = "FieldId";
        }

        private void ShowStorage()
        {
            if (cbStorage != null)
            {
                cbStorage.DataSource = _storage.StorageList;
            }

            if (cbStorage == null) return;
            cbStorage.DisplayMember = "StorageName";
            cbStorage.ValueMember = "storageId";
        }
        private void ShowStaff()
        {
            if (cbSowingTaskStaffList != null)
            {
                cbSowingTaskStaffList.DataSource = _staff.StaffList;
            }

            if (cbSowingTaskStaffList == null) return;
            cbSowingTaskStaffList.DisplayMember = "FirstName";
            cbSowingTaskStaffList.ValueMember = "StaffId";
        }

       // foreach (var workTask in workTaskList.Where(workTask => (workTask.TaskType == _taskType)))
        private void ShowCrop()
        {
            List<Crops>seeds = new List<Crops>();

            foreach (var seed in _crop.CropsList.Where(seed =>seed.CropName.Contains("Seed")))
            {
                seeds.Add(seed);
            }
            if (cbSowingTaskCropList != null)
            {
                cbSowingTaskCropList.DataSource = seeds;
                //_crop.CropsList;
            }

            if (cbSowingTaskCropList == null) return;
            cbSowingTaskCropList.DisplayMember = "CropName";
            cbSowingTaskCropList.ValueMember = "CropId";
        }

        private void ShowCategories()
        {
            if (cbVehicleCatList != null)
            {
                cbVehicleCatList.DataSource = _vehicleBank.Categories;

            }

            if (cbVehicleCatList == null) return;
            cbVehicleCatList.DisplayMember = "CatName";
            cbVehicleCatList.ValueMember = "CatId";

            ShowVehicle();
            ShowVehicleDriver();
        }

        private void ShowExistingSowingTasks()
        {
            listExistingSowingTasks.Items.Clear();
            List<WorkTasks> workTaskList = _workTask.WorkTaskList;

            foreach (var workTask in workTaskList.Where(workTask => workTask.TaskType == _taskType))
            {
                ListViewItem lvItem = new ListViewItem(workTask.TaskId.ToString());
                lvItem.SubItems.Add(workTask.TaskType);
                lvItem.SubItems.Add(workTask.TaskStartDate.ToLongDateString());
                lvItem.SubItems.Add(workTask.TaskEndDate.ToLongDateString());
                lvItem.SubItems.Add(workTask.QuantityRequired.ToString());
                lvItem.SubItems.Add(workTask.JobDuration.ToString());
                lvItem.SubItems.Add(workTask.ExpectedHarvestDate.ToLongDateString());
                lvItem.SubItems.Add(workTask.ExpectedYield.ToString());
                lvItem.SubItems.Add(workTask.FieldId.ToString());
                lvItem.SubItems.Add(workTask.CropId.ToString());
                lvItem.SubItems.Add(workTask.TaskStatus);
                listExistingSowingTasks.Items.Add(lvItem);
            }
        }

        private void ShowVehicle()
        {
            List<Vehicles> filteredList = new List<Vehicles>();

            foreach (var v in _vehicleBank.VehicleList.Where(v => (v.Category == Convert.ToInt32(cbVehicleCatList.SelectedValue))))
            {
                Vehicles vehicle = new Vehicles
                {
                    VehicleId = v.VehicleId,
                    VehicleName = v.VehicleName,
                    Category = v.Category,

                };
                filteredList.Add(vehicle);

            }

            //refreshes vehicle list  with a blank string when a new category is selected with no vehicles in it
            if (filteredList.Count == 0)
            {

                Vehicles vehicle = new Vehicles
                {
                    VehicleId = 0,
                    VehicleName = "",
                    Category = 0

                };
                filteredList.Add(vehicle);
            }



            cbSowingTaskVehicleList.DataSource = filteredList;

            cbSowingTaskVehicleList.DisplayMember = "VehicleName";
            cbSowingTaskVehicleList.ValueMember = "VehicleId";
        }

        private void ShowVehicleDriver()
        {

            List<VehicleAndDriver> filteredList = new List<VehicleAndDriver>();
            _vehicleBank.GetDrivers();
            foreach (var d in _vehicleBank.Drivers.Where(d => (d.categoryId == Convert.ToInt32(cbVehicleCatList.SelectedValue))))
            {
                VehicleAndDriver category = new VehicleAndDriver
                {
                    categoryId = d.categoryId,
                    staffId = d.staffId,
                    firstName = d.firstName,

                };
                filteredList.Add(category);
            }
            if (cbVehicleDriver != null)
            {

                cbVehicleDriver.DataSource = filteredList;

            }

            if (cbVehicleDriver == null) return;
            cbVehicleDriver.DisplayMember = "FirstName";
            cbVehicleDriver.ValueMember = "StaffId";
        }

        private void btnCloseSowingTask_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ShowStaffOnTask()
        {
            _workTask.GetWorkTaskStaff(Convert.ToInt32(txtTaskID.Text));

            listTaskStaff.Items.Clear();

            foreach (Staff selectedTaskStaffList in _workTask.TaskStaff)
            {
                ListViewItem lvItem = new ListViewItem(selectedTaskStaffList.StaffId.ToString());
                lvItem.SubItems.Add(selectedTaskStaffList.FirstName);
                lvItem.SubItems.Add(selectedTaskStaffList.SurName);


                listTaskStaff.Items.Add(lvItem);
            }

        }

        private void ShowVehiclesInTask()
        {
            _workTask.GetWorkTaskVehicles(Convert.ToInt32(txtTaskID.Text));

            listTaskVehicles.Items.Clear();


            foreach (TaskVehiclesAndDrivers selectedTaskVehicleAndDriver in _workTask.CurrentVehicleAndDriverList)
            {
                ListViewItem lvItem = new ListViewItem(selectedTaskVehicleAndDriver.VehicleName);
                lvItem.SubItems.Add(selectedTaskVehicleAndDriver.DriverName);
                lvItem.SubItems.Add(selectedTaskVehicleAndDriver.TaskId.ToString());
                lvItem.SubItems.Add(selectedTaskVehicleAndDriver.DriverId.ToString());
                lvItem.SubItems.Add(selectedTaskVehicleAndDriver.VehicleId.ToString());
                listTaskVehicles.Items.Add(lvItem);
            }

        }

        private void refresh()
        {
            _workTask.RefreshConnection();
            ShowExistingSowingTasks();
            ShowCategories();
        }

        private void ResetForm()
        {

            txtTaskID.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpFinishDate.Value = DateTime.Now;
            cbSowingTaskFieldList.SelectedIndex = -1;
            cbSowingTaskCropList.SelectedIndex = -1;
            nudQuantity.Value = 0;
            nudJobDuration.Value = 0;
            dtpExpectedHarvestDate.Value = DateTime.Now;
            nudExpectedYeild.Value = 0;
            cbTaskStatus.SelectedIndex = 0;

        }

        private void listExistingSowingTasks_MouseClick(object sender, MouseEventArgs e)
        {
            string id = listExistingSowingTasks.SelectedItems[0].SubItems[0].Text;
            string startDate = listExistingSowingTasks.SelectedItems[0].SubItems[2].Text;
            string finishDate = listExistingSowingTasks.SelectedItems[0].SubItems[3].Text;
            string quantity = listExistingSowingTasks.SelectedItems[0].SubItems[4].Text;
            string jobDuration = listExistingSowingTasks.SelectedItems[0].SubItems[5].Text;
            string expectedHarvestDate = listExistingSowingTasks.SelectedItems[0].SubItems[6].Text;
            string expectedYield = listExistingSowingTasks.SelectedItems[0].SubItems[7].Text;
            string fieldId = listExistingSowingTasks.SelectedItems[0].SubItems[8].Text;
            string cropId = listExistingSowingTasks.SelectedItems[0].SubItems[9].Text;
            string status = listExistingSowingTasks.SelectedItems[0].SubItems[10].Text;

            txtTaskID.Text = id;
            dtpStartDate.Text = startDate;
            dtpFinishDate.Text = finishDate;
            nudQuantity.Value = Convert.ToInt32(quantity);
            nudJobDuration.Value = Convert.ToInt32(jobDuration);
            dtpExpectedHarvestDate.Text = expectedHarvestDate;
            nudExpectedYeild.Text = expectedYield;
            cbSowingTaskFieldList.SelectedValue = Convert.ToInt32(fieldId);
            cbSowingTaskCropList.SelectedValue = Convert.ToInt32(cropId);
            cbTaskStatus.SelectedItem = status;

            ShowStaffOnTask();
            ShowVehiclesInTask();
            ShowVehicle();
        }

        private void btnCreateSowingTask_Click(object sender, EventArgs e)
        {
            WorkTasks addWorkTask = new WorkTasks
            {
                TaskType = _taskType,
                TaskStartDate = dtpStartDate.Value,
                TaskEndDate = dtpFinishDate.Value,
                FieldId = Convert.ToInt32(cbSowingTaskFieldList.SelectedValue),
                CropId = Convert.ToInt32(cbSowingTaskCropList.SelectedValue),
                QuantityRequired = Convert.ToInt32(nudQuantity.Value),
                JobDuration = Convert.ToInt32(nudJobDuration.Value),
                ExpectedHarvestDate = dtpExpectedHarvestDate.Value,
                ExpectedYield = Convert.ToInt32(nudExpectedYeild.Value),
                TaskStatus = cbTaskStatus.SelectedItem.ToString()
            };


            if (addWorkTask.TaskEndDate < addWorkTask.TaskStartDate)
            {
                MessageBox.Show(Resources.CheckDates);
            }
            else
            {
                _workTask.AddWorkTaskToList(addWorkTask);

                refresh();
            }

            int taskNumber = (_workTask.WorkTaskList.Count) - 1;

            txtTaskID.Text = _workTask.WorkTaskList[taskNumber].TaskId.ToString();
        }

        private void btnSowingTaskAddWorker_Click(object sender, EventArgs e)
        {


            TaskStaff taskStaff = new TaskStaff
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                StaffId = Convert.ToInt32(cbSowingTaskStaffList.SelectedValue)
            };


            bool alreadyOnTask = _workTask.TaskStaff.Any(x => x.StaffId == taskStaff.StaffId);

            if (alreadyOnTask == false)
            {
                _workTask.AddStaffToTask(taskStaff);


                ShowStaffOnTask();
            }
            else
            {
                MessageBox.Show(Resources.StaffMemberExists);
            }

        }

        private void cbVehicleCatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            TaskVehiclesAndDrivers taskVehicle = new TaskVehiclesAndDrivers
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                VehicleId = Convert.ToInt32(cbSowingTaskVehicleList.SelectedValue),
                DriverId = Convert.ToInt32(cbVehicleDriver.SelectedValue)
            };

            bool alreadyOnTask = _workTask.CurrentVehicleAndDriverList.Any(x => x.VehicleId == taskVehicle.VehicleId && x.DriverId == taskVehicle.DriverId);

            if (Convert.ToInt32(cbSowingTaskVehicleList.SelectedValue) == 0)
            {
                MessageBox.Show(Resources.SelectVehicleCat);
            }

            if (alreadyOnTask == false)
            {
                _workTask.AddVehicleToTask(taskVehicle);

                ShowVehiclesInTask();

            }
            else
            {
                MessageBox.Show(Resources.StaffOrVehicleExist);
            }

        }

        private void txtRemoveVehicleFromTask_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[4].Text);
                int workTaskId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[2].Text);
                int staffId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[3].Text);

                TaskVehiclesAndDrivers vehicleToDelete = new TaskVehiclesAndDrivers
                {
                    VehicleId = vehicleId, TaskId = workTaskId, DriverId = staffId
                };


                _workTask.DeleteVehicleAndDriverFromTask(vehicleToDelete);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.SelectVehicleFirst);
                Console.WriteLine(exception);

            }

        }

        private void btnRemoveLabourerFromTask_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = Convert.ToInt32(listTaskStaff.SelectedItems[0].SubItems[0].Text);
                int workTaskId = Convert.ToInt32(txtTaskID.Text);

                TaskStaff staffToDelete = new TaskStaff {StaffId = staffId, TaskId = workTaskId};

                _workTask.StaffToDeleteFromTask(staffToDelete);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.SelectStaffMemberFirst);
                Console.WriteLine(exception);

            }
        }

        private void btnUpdateSowingTask_Click(object sender, EventArgs e)
        {
            WorkTasks editWorkTask = new WorkTasks
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                TaskType = "Sowing",
                TaskStartDate = dtpStartDate.Value,
                TaskEndDate = dtpFinishDate.Value,
                FieldId = Convert.ToInt32(cbSowingTaskFieldList.SelectedValue),
                CropId = Convert.ToInt32(cbSowingTaskCropList.SelectedValue),
                QuantityRequired = Convert.ToInt32(nudQuantity.Value),
                JobDuration = Convert.ToInt32(nudJobDuration.Value),
                ExpectedHarvestDate = dtpExpectedHarvestDate.Value,
                ExpectedYield = Convert.ToInt32(nudExpectedYeild.Value),
                TaskStatus = cbTaskStatus.SelectedItem.ToString()
            };
            _workTask.UpdateWorkTask(editWorkTask);


            refresh();

        }

        private void alterstorage()
        {
            _storage.StorageList[cbStorage.SelectedIndex].AvailableStorage -= Convert.ToInt32(nudQuantity.Value);
            _storage.StorageList[cbStorage.SelectedIndex].Storing = cbSowingTaskCropList.DisplayMember;
            Debug.WriteLine(_storage.StorageList[cbStorage.SelectedIndex].Storing);
            _storage.UpdateStorage(_storage.StorageList[cbStorage.SelectedIndex]);
            
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTaskStatus.SelectedIndex == 0)
                lblTaskStatus.ForeColor = Color.Blue;

            if (cbTaskStatus.SelectedIndex == 1)
            {
                lblTaskStatus.ForeColor = Color.Orange;
                alterstorage();
                //TODO Call storage method to adjust stock (does not exist 27/11/18)
            }

            if (cbTaskStatus.SelectedIndex == 2)
                lblTaskStatus.ForeColor = Color.Green;

            if (cbTaskStatus.SelectedIndex == 3)
                lblTaskStatus.ForeColor = Color.Red;

        }
    }
}