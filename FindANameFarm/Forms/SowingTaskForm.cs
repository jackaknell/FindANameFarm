using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.Forms
{
    
    public partial class SowingTaskForm : Form
    {
        private FieldBank _field = FieldBank.GetInst();
        private StaffBank _staff = StaffBank.GetInst(); 
        private CropsBank _crop = CropsBank.GetInst();
        private VehicleBank _vehicle = VehicleBank.GetInst();
        private WorkTaskBank _workTask = WorkTaskBank.GetInst(); 
        private string _taskType ="Sowing";

        
        public SowingTaskForm()
        {
            InitializeComponent();
           showExistingSowingTasks();
        }
        private void SowingTaskForm_Load(object sender, EventArgs e)
        {
            listExistingSowingTasks.View = View.Details;
            listExistingSowingTasks.FullRowSelect = true;

            listExistingSowingTasks.Columns.Add("Id", 50);
            listExistingSowingTasks.Columns.Add("Task Type", 150);
            listExistingSowingTasks.Columns.Add("Start Date", 150);


            listTaskStaff.View = View.Details;
            listTaskStaff.FullRowSelect = true;
            listTaskStaff.Columns.Add("Id", 25);
            listTaskStaff.Columns.Add("First Name", 75);
            listTaskStaff.Columns.Add("Surname", 60);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            showFields();
            showStaff();
            ShowCrop();
            ShowVehicle();
        }

        public void showFields()
        {
            if (cbSowingTaskFieldList !=null)
            {
                cbSowingTaskFieldList.DataSource = _field.FieldList;
            }

            if (cbSowingTaskFieldList == null) return;
            cbSowingTaskFieldList.DisplayMember = "FieldName";
            cbSowingTaskFieldList.ValueMember = "FieldId";
        }

        public void showStaff()
        {
            if (cbSowingTaskStaffList != null)
            {
                cbSowingTaskStaffList.DataSource = _staff.StaffList;
            }

            if (cbSowingTaskStaffList == null) return;
            cbSowingTaskStaffList.DisplayMember = "FirstName";
            cbSowingTaskStaffList.ValueMember = "StaffId";
        }

        public void ShowCrop()
        {
            if (cbSowingTaskCropList != null)
            {
                cbSowingTaskCropList.DataSource = _crop.CropsList;
            }

            if (cbSowingTaskCropList == null) return;
            cbSowingTaskCropList.DisplayMember = "CropName";
            cbSowingTaskCropList.ValueMember = "CropId";
        }

        public void ShowVehicle()
        {
            if (cbSowingTaskVehicleList != null)
            {
                cbSowingTaskVehicleList.DataSource = _vehicle.VehicleList;
            }

            if (cbSowingTaskVehicleList == null) return;
            cbSowingTaskVehicleList.DisplayMember = "VehicleName";
            cbSowingTaskVehicleList.ValueMember = "VehicleId";
        }
        private void btnCloseSowingTask_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void showStaffOnTask()
        {
            _workTask.GetWorkTaskStaff(Convert.ToInt32(txtTaskID.Text));

            listTaskStaff.Items.Clear();

            foreach (Staff SelectedTaskStaffList in _workTask.taskStaff)
            {
                ListViewItem lvItem = new ListViewItem(SelectedTaskStaffList.StaffId.ToString());
                lvItem.SubItems.Add(SelectedTaskStaffList.FirstName);
                lvItem.SubItems.Add(SelectedTaskStaffList.SurName);

                listTaskStaff.Items.Add(lvItem);
            }
           
        }
        private void btnSowingTaskAddWorker_Click(object sender, EventArgs e)
        {
            TaskStaff taskstaff = new TaskStaff();
            taskstaff.TaskId = Convert.ToInt32(txtTaskID.Text);
            taskstaff.staffId = Convert.ToInt32(cbSowingTaskStaffList.SelectedValue);
           
            _workTask.AddStaffToTask(taskstaff);


            showStaffOnTask();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            WorkTasks addWorkTask = new WorkTasks();

            addWorkTask.TaskType = _taskType;
            addWorkTask.TaskStartDate = dtpStartDate.Value;
            addWorkTask.TaskEndDate = dtpFinishDate.Value;
            addWorkTask.FieldId = Convert.ToInt32(cbSowingTaskFieldList.SelectedValue);
            addWorkTask.CropId = Convert.ToInt32(cbSowingTaskCropList.SelectedValue);
            addWorkTask.QuantityRequired = Convert.ToInt32(nudQuantity.Value);
            addWorkTask.JobDuration = Convert.ToInt32(nudJobDuration.Value);
            addWorkTask.ExpectedHarvestDate = dtpExpectedHarvestDate.Value;
            addWorkTask.ExpectedYield = Convert.ToInt32(nudExpectedYeild.Value);

            Debug.WriteLine(addWorkTask.ExpectedHarvestDate);
            _workTask.AddWorkTaskToList(addWorkTask);
           
            refresh();
        }

        private void refresh()
        {
            _workTask.refreshConnection();
            showExistingSowingTasks();
        }

        private void showExistingSowingTasks()
        {
            //if (cbExistingSowingTask != null)
            //{
            //    cbExistingSowingTask.DataSource = _workTask.WorkTaskList;
            //}

            //if (cbExistingSowingTask == null) return;
            //cbExistingSowingTask.DisplayMember = "TaskType";
            //cbExistingSowingTask.ValueMember = "TaskId";

            listExistingSowingTasks.Items.Clear();
            List<WorkTasks> workTaskList =_workTask.WorkTaskList;
            

            foreach (var workTask in workTaskList.Where(workTask => (workTask.TaskType =="Sowing")))
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
                listExistingSowingTasks.Items.Add(lvItem);

                
            }
            

        }

        private void listExistingSowingTasks_MouseClick(object sender, MouseEventArgs e)
        {
            string ID = listExistingSowingTasks.SelectedItems[0].SubItems[0].Text;
            string StartDate = listExistingSowingTasks.SelectedItems[0].SubItems[2].Text;
            string FinishDate = listExistingSowingTasks.SelectedItems[0].SubItems[3].Text;
            string Quantity = listExistingSowingTasks.SelectedItems[0].SubItems[4].Text;
            string JobDuration = listExistingSowingTasks.SelectedItems[0].SubItems[5].Text;
            string ExpectedHarvestdate = listExistingSowingTasks.SelectedItems[0].SubItems[6].Text;
            string ExpectedYield = listExistingSowingTasks.SelectedItems[0].SubItems[7].Text;
            string FieldId = listExistingSowingTasks.SelectedItems[0].SubItems[8].Text;
            string CropId = listExistingSowingTasks.SelectedItems[0].SubItems[9].Text;

            txtTaskID.Text = ID;
            dtpStartDate.Text = StartDate;
            dtpFinishDate.Text = FinishDate;
            nudQuantity.Value = Convert.ToInt32(Quantity);
            nudJobDuration.Value = Convert.ToInt32(JobDuration);
            dtpExpectedHarvestDate.Text = ExpectedHarvestdate;
            nudExpectedYeild.Text = ExpectedYield;
            cbSowingTaskFieldList.SelectedValue = Convert.ToInt32(FieldId);
            cbSowingTaskCropList.SelectedValue= Convert.ToInt32(CropId);

            showStaffOnTask();
        }

       
    }
}
