﻿using FindANameFarm.Banks;
using FindANameFarm.WorkTaskClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace FindANameFarm.Forms
{
	/// <summary>
	/// Jason, November 2018
	/// treatment task form
	/// </summary>
	public partial class TreatmentTaskForm : Form
	{
		private readonly FieldBank _field = FieldBank.GetInst();
		private readonly StaffBank _staff = StaffBank.GetInst();
		private readonly VehicleBank _vehicle = VehicleBank.GetInst();
		private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();
		private readonly FertTreatBank _fertTreat = FertTreatBank.GetInst();
		private string _taskType = "Treatment";

		public TreatmentTaskForm()
		{
			InitializeComponent();
			ResetForm();

			refresh();
		}
		//load the form
		private void TreatmentTaskForm_Load(object sender, EventArgs e)
		{
			gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrWhiteSpace(txtTaskId.Text);

			btnUpdate.Enabled = !string.IsNullOrEmpty(txtTaskId.Text);

			ShowExistingFertTreatTasks();

			SetUpFertTreatTaskListView();

			SetUpStaffListView();

			SetUpVehicleTaskViewList();

			ResetForm();
		}
		//don't enable the center section of the form if the rest of the form isn't populated
		private void txtTaskId_TextChanged(object sender, EventArgs e)
		{
			gbTaskVehiclesAndStaff.Enabled = !string.IsNullOrEmpty(txtTaskId.Text);

			btnUpdate.Enabled = !string.IsNullOrEmpty(txtTaskId.Text);
		}
		
		private void gbFertTreatTask_Enter(object sender, EventArgs e)
		{
			ShowFields();
			ShowStaff();
			ShowFertTreat();
			ShowCategories();
		}
		//sets up the list view column spacing
		private void SetUpVehicleTaskViewList()
		{
			listTaskVehicles.View = View.Details;
			listTaskVehicles.FullRowSelect = true;
			listTaskVehicles.Columns.Add("VehicleName", 100);
			listTaskVehicles.Columns.Add("Driver", 100);
		}
		//sets up the list view column spacing
		private void SetUpStaffListView()
		{
			listTaskStaff.View = View.Details;
			listTaskStaff.FullRowSelect = true;
			listTaskStaff.Columns.Add("Id", 25);
			listTaskStaff.Columns.Add("First Name", 75);
			listTaskStaff.Columns.Add("Surname", 60);
		}
		//sets up the list view column spacing
		private void SetUpFertTreatTaskListView()
		{
			listExistingFertTreatTasks.View = View.Details;
			listExistingFertTreatTasks.FullRowSelect = true;
			listExistingFertTreatTasks.Columns.Add("Id", 50);
			listExistingFertTreatTasks.Columns.Add("Task Type", 150);
			listExistingFertTreatTasks.Columns.Add("Start Date", 150);
		}		
		//shows the fields
		private void ShowFields()
		{
			if (cbTaskField != null)
			{
				cbTaskField.DataSource = _field.FieldList;
			}

			if (cbTaskField == null) return;
			cbTaskField.DisplayMember = "FieldName";
			cbTaskField.ValueMember = "FieldId";
		}
		//shows the staff
		private void ShowStaff()
		{
			if (cbFertTreatTaskStaffList != null)
			{
				cbFertTreatTaskStaffList.DataSource = _staff.StaffList;
			}

			if (cbFertTreatTaskStaffList == null) return;
			cbFertTreatTaskStaffList.DisplayMember = "FirstName";
			cbFertTreatTaskStaffList.ValueMember = "StaffId";
		}
		//shows treatments
		private void ShowFertTreat()
		{
			if (cbTaskFertTreat != null)
			{
				cbTaskFertTreat.DataSource = _fertTreat.FertTreatList;
			}

			if (cbTaskFertTreat == null) return;
			cbTaskFertTreat.DisplayMember = "FertTreatName";
			cbTaskFertTreat.ValueMember = "FertTreatId";
		}
		//shows categories
		private void ShowCategories()
		{
			if (cbVehicleCatList != null)
			{
				cbVehicleCatList.DataSource = _vehicle.Categories;
			}

			if (cbVehicleCatList == null) return;
			cbVehicleCatList.DisplayMember = "CatName";
			cbVehicleCatList.ValueMember = "CatId";

			ShowVehicle();
			ShowVehicleDriver();
		}
		//show existing treatments in task
		private void ShowExistingFertTreatTasks()
		{
			listExistingFertTreatTasks.Items.Clear();
			List<WorkTasks> workTaskList = _workTask.WorkTaskList;

			foreach (var workTask in workTaskList.Where(workTask => (workTask.TaskType == _taskType)))
			{
				ListViewItem lvItem = new ListViewItem(workTask.TaskId.ToString());
				lvItem.SubItems.Add(workTask.TaskType);
				lvItem.SubItems.Add(workTask.TaskStartDate.ToLongDateString());
				lvItem.SubItems.Add(workTask.TaskEndDate.ToLongDateString());
				lvItem.SubItems.Add(workTask.TreatmentId.ToString());
				lvItem.SubItems.Add(workTask.QuantityRequired.ToString());
				lvItem.SubItems.Add(workTask.JobDuration.ToString());
				lvItem.SubItems.Add(workTask.ExpectedHarvestDate.ToLongDateString());
				lvItem.SubItems.Add(workTask.ExpectedYield.ToString());
				lvItem.SubItems.Add(workTask.FieldId.ToString());
				lvItem.SubItems.Add(workTask.TaskStatus);
				listExistingFertTreatTasks.Items.Add(lvItem);
			}
		}
		//shows the vehicles
		private void ShowVehicle()
		{
			List<Vehicles> filteredList = new List<Vehicles>();

			foreach (var v in _vehicle.VehicleList.Where(v => (v.Category == Convert.ToInt32(cbVehicleCatList.SelectedValue))))
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

			cbFertTreatTaskVehicleList.DataSource = filteredList;

			cbFertTreatTaskVehicleList.DisplayMember = "VehicleName";
			cbFertTreatTaskVehicleList.ValueMember = "VehicleId";
		}
		//shows the drivers able to drive the selected vehicle
		private void ShowVehicleDriver()
		{
			List<VehicleAndDriver> filteredList = new List<VehicleAndDriver>();
			_vehicle.GetDrivers();
			foreach (var d in _vehicle.Drivers.Where(d => (d.categoryId == Convert.ToInt32(cbVehicleCatList.SelectedValue))))
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
		//shows the staff currently on the task
		public void ShowStaffOnTask()
		{
			_workTask.GetWorkTaskStaff(Convert.ToInt32(txtTaskId.Text));

			listTaskStaff.Items.Clear();

			foreach (Staff selectedTaskStaffList in _workTask.TaskStaff)
			{
				ListViewItem lvItem = new ListViewItem(selectedTaskStaffList.StaffId.ToString());
				lvItem.SubItems.Add(selectedTaskStaffList.FirstName);
				lvItem.SubItems.Add(selectedTaskStaffList.SurName);

				listTaskStaff.Items.Add(lvItem);
			}

		}
		//show vehicles in the task
		private void ShowVehiclesInTask()
		{
			_workTask.GetWorkTaskVehicles(Convert.ToInt32(txtTaskId.Text));

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
		//refresh connection to the database
		private void refresh()
		{
			_workTask.RefreshConnection();
			ShowExistingFertTreatTasks();
			ShowCategories();
		}
		//reset the form to its original state
		private void ResetForm()
		{
			txtTaskId.Text = "";
			dtpTaskStart.Value = DateTime.Now;
			dtpTaskFinish.Value = DateTime.Now;
			cbTaskField.SelectedIndex = -1;
			cbTaskFertTreat.SelectedIndex = -1;
			nudTaskQuantity.Value = 0;
			nudTaskDuration.Value = 0;
		}
		//show a list of the existing treatments tasks
		private void listExistingFertTreatTasks_MouseClick(object sender, MouseEventArgs e)
		{
			string id = listExistingFertTreatTasks.SelectedItems[0].SubItems[0].Text;
			string startDate = listExistingFertTreatTasks.SelectedItems[0].SubItems[2].Text;
			string finishDate = listExistingFertTreatTasks.SelectedItems[0].SubItems[3].Text;
			string quantity = listExistingFertTreatTasks.SelectedItems[0].SubItems[4].Text;
			string jobDuration = listExistingFertTreatTasks.SelectedItems[0].SubItems[5].Text;
			string expectedHarvestDate = listExistingFertTreatTasks.SelectedItems[0].SubItems[6].Text;
			string expectedYield = listExistingFertTreatTasks.SelectedItems[0].SubItems[7].Text;
			string fieldId = listExistingFertTreatTasks.SelectedItems[0].SubItems[8].Text;			
			string status = listExistingFertTreatTasks.SelectedItems[0].SubItems[10].Text;
			string treatmentId = listExistingFertTreatTasks.SelectedItems[0].SubItems[4].Text;

			txtTaskId.Text = id;
			dtpTaskStart.Text = startDate;
			dtpTaskFinish.Text = finishDate;
			cbTaskField.SelectedValue = Convert.ToInt32(fieldId);
			cbTaskFertTreat.Text = treatmentId;
			nudTaskQuantity.Value = Convert.ToInt32(quantity);
			nudTaskDuration.Value = Convert.ToInt32(jobDuration);


			ShowStaffOnTask();
			ShowVehiclesInTask();
			ShowVehicle();

		}
		//button to create a task and insert into the database
		private void btnCreate_Click(object sender, EventArgs e)
		{
			WorkTasks addWorkTask = new WorkTasks
			{
				TaskType = _taskType,
				TaskStartDate = dtpTaskStart.Value,
				TaskEndDate = dtpTaskFinish.Value,
				FieldId = Convert.ToInt32(cbTaskField.SelectedValue),
				TreatmentId = Convert.ToInt32(cbTaskFertTreat.SelectedValue),
				QuantityRequired = Convert.ToInt32(nudTaskQuantity.Value),
				JobDuration = Convert.ToInt32(nudTaskDuration.Value)
			};

			if (addWorkTask.TaskEndDate < addWorkTask.TaskStartDate)
			{
				MessageBox.Show("Task finish date cannot be before the start date");
			}
			else
			{
				_workTask.AddWorkTaskToList(addWorkTask);
				refresh();
			}

			int taskNumber = (_workTask.WorkTaskList.Count) - 1;

			txtTaskId.Text = _workTask.WorkTaskList[taskNumber].TaskId.ToString();
		}
		//updates the selected task id in the database with the new fields
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			WorkTasks editWorkTask = new WorkTasks();
			editWorkTask.TaskId = Convert.ToInt32(txtTaskId.Text);
			editWorkTask.TaskType = "Treatment";
			editWorkTask.TaskStartDate = dtpTaskStart.Value;
			editWorkTask.TaskEndDate = dtpTaskFinish.Value;
			editWorkTask.FieldId = Convert.ToInt32(cbTaskField.SelectedValue);
			editWorkTask.TreatmentId = Convert.ToInt32(cbFertTreatTaskStaffList.SelectedValue);
			editWorkTask.QuantityRequired = Convert.ToInt32(nudTaskQuantity.Value);
			editWorkTask.JobDuration = Convert.ToInt32(nudTaskDuration.Value);
			_workTask.UpdateWorkTask(editWorkTask);

			refresh();
		}
		//button to clear the form
		private void btnClearForm_Click(object sender, EventArgs e)
		{
			ResetForm();
		}
		//button to add a worker to the task
		private void btnFertTreatTaskAddWorker_Click(object sender, EventArgs e)
		{
			TaskStaff taskStaff = new TaskStaff
			{
				TaskId = Convert.ToInt32(txtTaskId.Text),
				StaffId = Convert.ToInt32(cbFertTreatTaskStaffList.SelectedValue)
			};


			bool alreadyOnTask = _workTask.TaskStaff.Any(x => x.StaffId == taskStaff.StaffId);

			if (alreadyOnTask == false)
			{
				_workTask.AddStaffToTask(taskStaff);


				ShowStaffOnTask();
			}
			else
			{
				MessageBox.Show("Staff Member Already on task");
			}
		}
		//button to remove a worker from a task
		private void btnRemoveLabourerFromTask_Click(object sender, EventArgs e)
		{
			try
			{
				int staffId = Convert.ToInt32(listTaskStaff.SelectedItems[0].SubItems[0].Text);
				int workTaskId = Convert.ToInt32(txtTaskId.Text);

				TaskStaff staffToDelete = new TaskStaff();

				staffToDelete.StaffId = staffId;
				staffToDelete.TaskId = workTaskId;


				_workTask.StaffToDeleteFromTask(staffToDelete);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Please Select A Staff member to remove first");
				Console.WriteLine(exception);
			}
		}
		//button to remove a vehicle from the task
		private void btnRemoveVehicleFromTask_Click(object sender, EventArgs e)
		{
			try
			{
				int vehicleId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[4].Text);
				int workTaskId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[2].Text);
				int staffId = Convert.ToInt32(listTaskVehicles.SelectedItems[0].SubItems[3].Text);

				TaskVehiclesAndDrivers vehicleToDelete = new TaskVehiclesAndDrivers();

				vehicleToDelete.VehicleId = vehicleId;
				vehicleToDelete.TaskId = workTaskId;
				vehicleToDelete.DriverId = staffId;

				_workTask.DeleteVehicleAndDriverFromTask(vehicleToDelete);
			}
			catch (Exception exception)
			{
				MessageBox.Show("Please Select A vehicle to remove first");
				Console.WriteLine(exception);

			}
		}
		//button to add a vehicle to the task
		private void btnVehicleAdd_Click(object sender, EventArgs e)
		{
			TaskVehiclesAndDrivers taskVehicle = new TaskVehiclesAndDrivers
			{
				TaskId = Convert.ToInt32(txtTaskId.Text),
				VehicleId = Convert.ToInt32(cbFertTreatTaskVehicleList.SelectedValue),
				DriverId = Convert.ToInt32(cbVehicleDriver.SelectedValue)
			};

			bool alreadyOnTask = _workTask.CurrentVehicleAndDriverList.Any(x => x.VehicleId == taskVehicle.VehicleId && x.DriverId == taskVehicle.DriverId);

			if (Convert.ToInt32(cbFertTreatTaskVehicleList.SelectedValue) == 0)
			{
				MessageBox.Show("You dont have any vehicles in that category");
			}

			if (alreadyOnTask == false)
			{
				_workTask.AddVehicleToTask(taskVehicle);

				ShowVehiclesInTask();

			}
			else
			{
				MessageBox.Show("Staff Member or vehicle Already on task");
			}
		}
		//button to close the form
		private void btnClose_Click(object sender, EventArgs e) => Close();
		//combo box to set the vehicle categories
		private void cbVehicleCatList_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowCategories();
		}
		//combo box to set the status of a task
        private void cbTaskStatus_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}