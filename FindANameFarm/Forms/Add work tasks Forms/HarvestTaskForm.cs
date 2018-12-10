using System;
using System.Collections.Generic;
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
   /// Author: Jack
   /// Date: Nov 2018
   /// Description: harvest task form.
   /// </summary>
    public partial class HarvestTaskForm : Form
    {
        private readonly FieldBank _field = FieldBank.GetInst();
        private readonly StaffBank _staff = StaffBank.GetInst();
        private readonly CropsBank _crop = CropsBank.GetInst();
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();
        private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();
        private string _taskType = "Harvest";

        public HarvestTaskForm()
        {
            InitializeComponent();
            ResetForm();

            refresh();


        }
        //load the form
        private void HarvestTaskForm_Load(object sender, EventArgs e)
        {
            gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrWhiteSpace(txtTaskID.Text);

            btnUpdate.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);

            ShowExistingHarvestTasks();

            ResetForm();
        }
        //dont enable to fields if it is not populated.
        private void txtTaskID_TextChanged(object sender, EventArgs e)
        {
            gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);

            btnUpdate.Enabled = !string.IsNullOrEmpty(txtTaskID.Text);
        }
        
      // show fields
        private void ShowFields()
        {
            if (cbHarvestTaskFieldList != null)
            {
                cbHarvestTaskFieldList.DataSource = _field.FieldList;
            }

            if (cbHarvestTaskFieldList == null) return;
            cbHarvestTaskFieldList.DisplayMember = "FieldName";
            cbHarvestTaskFieldList.ValueMember = "FieldId";
        }
        //show the staff
        private void ShowStaff()
        {
            if (cbHarvestTaskStaffList != null)
            {
                cbHarvestTaskStaffList.DataSource = _staff.StaffList;
            }

            if (cbHarvestTaskStaffList == null) return;
            cbHarvestTaskStaffList.DisplayMember = "FirstName";
            cbHarvestTaskStaffList.ValueMember = "StaffId";
        }

        //show the crops
        private void ShowCrop()
        {
            List<Crops> seeds = new List<Crops>();

            foreach (var seed in _crop.CropsList.Where(seed => !seed.CropName.Contains("Seed")))
            {
                seeds.Add(seed);
            }
            if (cbHarvestTaskCropList != null)
            {
                cbHarvestTaskCropList.DataSource = seeds;
                
            }

            if (cbHarvestTaskCropList == null) return;
            cbHarvestTaskCropList.DisplayMember = "CropName";
            cbHarvestTaskCropList.ValueMember = "CropId";
        }
        //show categories
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
        //show any ecisting harvest tasks
        private void ShowExistingHarvestTasks()
        {
            listExistingHarvestTasks.Items.Clear();
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
                listExistingHarvestTasks.Items.Add(lvItem);
            }
        }
        // show vehicles
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



            cbHarvestTaskVehicleList.DataSource = filteredList;

            cbHarvestTaskVehicleList.DisplayMember = "VehicleName";
            cbHarvestTaskVehicleList.ValueMember = "VehicleId";
        }
        //show vehicles driver
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

       //show staff on current task
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
        // show vehicles in task
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
        //refresh connection to database.
        private void refresh()
        {
            _workTask.RefreshConnection();
            ShowExistingHarvestTasks();
            ShowCategories();
        }
        //reset form
        private void ResetForm()
        {

            txtTaskID.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpFinishDate.Value = DateTime.Now;
            cbHarvestTaskFieldList.SelectedIndex = -1;
            cbHarvestTaskCropList.SelectedIndex = -1;
            nudQuantity.Value = 0;
            nudJobDuration.Value = 0;
         
            nudExpectedYeild.Value = 0;
            cbTaskStatus.SelectedIndex = 0;

        }

        //button that will add worker to harevs task, and merge with the database.
        private void btnHarvestTaskAddWorker_Click(object sender, EventArgs e)
        {


            TaskStaff taskStaff = new TaskStaff
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                StaffId = Convert.ToInt32(cbHarvestTaskStaffList.SelectedValue)
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
        // show categories.
        private void cbVehicleCatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCategories();
        }
        ////button that will add any new entry, and merge with the database.
        private void btnVehicleAdd_Click(object sender, EventArgs e)
        {
            TaskVehiclesAndDrivers taskVehicle = new TaskVehiclesAndDrivers
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                VehicleId = Convert.ToInt32(cbHarvestTaskVehicleList.SelectedValue),
                DriverId = Convert.ToInt32(cbVehicleDriver.SelectedValue)
            };
            //checks to see if item is already on task.
            bool alreadyOnTask = _workTask.CurrentVehicleAndDriverList.Any(x => x.VehicleId == taskVehicle.VehicleId && x.DriverId == taskVehicle.DriverId);

            if (Convert.ToInt32(cbHarvestTaskVehicleList.SelectedValue) == 0)
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
        //remove vehicle from the task
        private void txtRemoveVehicleFromTask_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[4].Text);
                int workTaskId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[2].Text);
                int staffId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[3].Text);

                TaskVehiclesAndDrivers vehicleToDelete = new TaskVehiclesAndDrivers
                {
                    VehicleId = vehicleId,
                    TaskId = workTaskId,
                    DriverId = staffId
                };


                _workTask.DeleteVehicleAndDriverFromTask(vehicleToDelete);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.SelectVehicleFirst);
                Console.WriteLine(exception);

            }

        }
        //removew the labouer from the task
        private void btnRemoveLabourerFromTask_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = Convert.ToInt32(listTaskStaff.SelectedItems[0].SubItems[0].Text);
                int workTaskId = Convert.ToInt32(txtTaskID.Text);

                TaskStaff staffToDelete = new TaskStaff { StaffId = staffId, TaskId = workTaskId };

                _workTask.StaffToDeleteFromTask(staffToDelete);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.SelectStaffMemberFirst);
                Console.WriteLine(exception);

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTaskStatus.SelectedIndex == 0)
                lblTaskStatus.ForeColor = Color.Blue;

            if (cbTaskStatus.SelectedIndex == 1)
            {
                lblTaskStatus.ForeColor = Color.Yellow;
               
            }

            if (cbTaskStatus.SelectedIndex == 2)
                lblTaskStatus.ForeColor = Color.Green;

            if (cbTaskStatus.SelectedIndex == 3)
                lblTaskStatus.ForeColor = Color.Red;

        }
        //close the form
        private void btnCloseHarvestTask_Click(object sender, EventArgs e)
        {
            Close();
        }


        //button that will creat an entry, and merge with the database.
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            WorkTasks addWorkTask = new WorkTasks
            {
                TaskType = _taskType,
                TaskStartDate = dtpStartDate.Value,
                TaskEndDate = dtpFinishDate.Value,
                FieldId = Convert.ToInt32(cbHarvestTaskFieldList.SelectedValue),
                CropId = Convert.ToInt32(cbHarvestTaskCropList.SelectedValue),
                QuantityRequired = Convert.ToInt32(nudQuantity.Value),
                JobDuration = Convert.ToInt32(nudJobDuration.Value),
             
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
        //button that will update any changes, and merge with the database.
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            WorkTasks editWorkTask = new WorkTasks
            {
                TaskId = Convert.ToInt32(txtTaskID.Text),
                TaskType = "Harvest",
                TaskStartDate = dtpStartDate.Value,
                TaskEndDate = dtpFinishDate.Value,
                FieldId = Convert.ToInt32(cbHarvestTaskFieldList.SelectedValue),
                CropId = Convert.ToInt32(cbHarvestTaskCropList.SelectedValue),
                QuantityRequired = Convert.ToInt32(nudQuantity.Value),
                JobDuration = Convert.ToInt32(nudJobDuration.Value),
             
                ExpectedYield = Convert.ToInt32(nudExpectedYeild.Value),
                TaskStatus = cbTaskStatus.SelectedItem.ToString()
            };
            _workTask.UpdateWorkTask(editWorkTask);


            refresh();
        }
        //button eill reset the form
        private void btnResetForm_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }
        // show the field, staff, crop and category
        private void gbSowingTask_Enter(object sender, EventArgs e)
        {
            ShowFields();
            ShowStaff();
            ShowCrop();
            ShowCategories();
        }
        //show a list of existing harvest tasks.
        private void listExistingHarvestTasks_MouseClick(object sender, MouseEventArgs e)
        {
            string id = listExistingHarvestTasks.SelectedItems[0].SubItems[0].Text;
            string startDate = listExistingHarvestTasks.SelectedItems[0].SubItems[2].Text;
            string finishDate = listExistingHarvestTasks.SelectedItems[0].SubItems[3].Text;
            string quantity = listExistingHarvestTasks.SelectedItems[0].SubItems[4].Text;
            string jobDuration = listExistingHarvestTasks.SelectedItems[0].SubItems[5].Text;
            string expectedHarvestDate = listExistingHarvestTasks.SelectedItems[0].SubItems[6].Text;
            string expectedYield = listExistingHarvestTasks.SelectedItems[0].SubItems[7].Text;
            string fieldId = listExistingHarvestTasks.SelectedItems[0].SubItems[8].Text;
            string cropId = listExistingHarvestTasks.SelectedItems[0].SubItems[9].Text;
            string status = listExistingHarvestTasks.SelectedItems[0].SubItems[10].Text;

            txtTaskID.Text = id;
            dtpStartDate.Text = startDate;
            dtpFinishDate.Text = finishDate;
            nudQuantity.Value = Convert.ToInt32(quantity);
            nudJobDuration.Value = Convert.ToInt32(jobDuration);
         
            nudExpectedYeild.Text = expectedYield;
            cbHarvestTaskFieldList.SelectedValue = Convert.ToInt32(fieldId);
            cbHarvestTaskCropList.SelectedValue = Convert.ToInt32(cropId);
            cbTaskStatus.SelectedItem = status;

            ShowStaffOnTask();
            ShowVehiclesInTask();
            ShowVehicle();
        }
    }
}