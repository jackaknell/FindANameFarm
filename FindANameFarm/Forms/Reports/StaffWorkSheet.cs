using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FindANameFarm.Forms
{
    public partial class StaffWorkSheet : Form
    {
        private readonly ReportBank _report = ReportBank.GetInst();
        public int StaffId { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public StaffWorkSheet(Staff labourer)
        {
          
            StaffId = labourer.StaffId;
            InitializeComponent();
            dtDateTo.Value = dtDateTo.Value.AddDays(10);
            lblCurrentStaffName.Text = ("Welcome: " +labourer.FirstName+ " " +labourer.SurName);
        }

        private void StaffWorkSheet_Load(object sender, EventArgs e)
        {
            ShowLabourerWorkTasks();
            ShowLabourerDrivingTasks();

        }

     
        private void ShowLabourerWorkTasks()
        {
          


            listLabourerTasks.Items.Clear();
            List<WorkTaskReport> staffWorkTasks = _report.GetStaffWorkTasks(StaffId, StartTime, FinishTime);

           
            foreach (WorkTaskReport workTasks in staffWorkTasks)
            {
                ListViewItem lvItem = new ListViewItem(workTasks.TaskType);
                lvItem.SubItems.Add(workTasks.TaskStartDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.FieldName);
                lvItem.SubItems.Add(workTasks.CropName);
                lvItem.SubItems.Add(workTasks.JobDuration.ToString());
                lvItem.SubItems.Add(workTasks.TaskEndDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.QuantityRequired.ToString());                        
                lvItem.SubItems.Add(workTasks.ExpectedHarvestDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.ExpectedYield.ToString());              
                lvItem.SubItems.Add(workTasks.TaskId.ToString());
                lvItem.SubItems.Add(workTasks.TreatmentName);
                listLabourerTasks.Items.Add(lvItem);

            
            }

            StaffListRefresh();
        }

        private void listLaboutTasks_MouseClick(object sender, MouseEventArgs e)
        {
            string taskType = listLabourerTasks.SelectedItems[0].SubItems[0].Text;
            string startDate = listLabourerTasks.SelectedItems[0].SubItems[1].Text;
            string fieldName = listLabourerTasks.SelectedItems[0].SubItems[2].Text;
            string cropName = listLabourerTasks.SelectedItems[0].SubItems[3].Text;
            string jobDuration = listLabourerTasks.SelectedItems[0].SubItems[4].Text;
            string finishDate = listLabourerTasks.SelectedItems[0].SubItems[5].Text;
            string quantityRequired = listLabourerTasks.SelectedItems[0].SubItems[6].Text;
            string expectedHarvestDate = listLabourerTasks.SelectedItems[0].SubItems[7].Text;
            string expectedYield = listLabourerTasks.SelectedItems[0].SubItems[8].Text;
            string taskId = listLabourerTasks.SelectedItems[0].SubItems[9].Text;
            string treatment = listLabourerTasks.SelectedItems[0].SubItems[10].Text;


            txtTaskId.Text = taskId;
            txtTaskType.Text = taskType;
            txtStartDate.Text = startDate;
            txtEndDate.Text = finishDate;
            txtQuantity.Text = quantityRequired;
            txtCrop.Text = cropName;
            txtField.Text = fieldName;
            txtDuration.Text = jobDuration;
            txtHarvestDate.Text = expectedHarvestDate;
            txtYield.Text = expectedYield;
            txtTreatment.Text = treatment;

        }
        private void ShowLabourerDrivingTasks()
        {
     Debug.Write(FinishTime);

            listDrivingTasks.Items.Clear();

            List<WorkTaskReport> vehicleWorkTasks = _report.GetVehicleWorkTasks(StaffId, StartTime, FinishTime);

            foreach (WorkTaskReport workTasks in vehicleWorkTasks)
            {
                ListViewItem lvItem = new ListViewItem(workTasks.TaskType);
                lvItem.SubItems.Add(workTasks.VehicleName);
                lvItem.SubItems.Add(workTasks.TaskStartDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.FieldName);
                lvItem.SubItems.Add(workTasks.CropName);
                lvItem.SubItems.Add(workTasks.JobDuration.ToString());
                lvItem.SubItems.Add(workTasks.TaskEndDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.QuantityRequired.ToString());
                lvItem.SubItems.Add(workTasks.ExpectedHarvestDate.ToShortDateString());
                lvItem.SubItems.Add(workTasks.ExpectedYield.ToString());
                lvItem.SubItems.Add(workTasks.TaskId.ToString());
                lvItem.SubItems.Add(workTasks.TreatmentName);
                listDrivingTasks.Items.Add(lvItem);


            }

            DriversListRefresh();
        }

       

        private void StaffListRefresh()
        {
            for (int i = 0; i < listLabourerTasks.Items.Count; i++)
            {
                
                    listLabourerTasks.Items[i].BackColor = Color.Lavender;
                    
                
                if (listLabourerTasks.Items[i].ToString().Contains("Sowing"))
                {
                    listLabourerTasks.Items[i].BackColor = Color.DarkKhaki;
                }

                if (listLabourerTasks.Items[i].ToString().Contains("Harvest"))
                {
                    listLabourerTasks.Items[i].BackColor = Color.BlanchedAlmond;
                }
            }
            
        }

        private void DriversListRefresh()
        {
            for (int i = 0; i < listDrivingTasks.Items.Count; i++)
            {

                listDrivingTasks.Items[i].BackColor = Color.Lavender;


                if (listDrivingTasks.Items[i].ToString().Contains("Sowing"))
                {
                    listDrivingTasks.Items[i].BackColor = Color.DarkKhaki;
                }

                if (listDrivingTasks.Items[i].ToString().Contains("Harvest"))
                {
                    listDrivingTasks.Items[i].BackColor = Color.BlanchedAlmond;
                }
            }
        }





        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void dtDateTo_ValueChanged(object sender, EventArgs e)
        {
            StartTime = dtDateFrom.Value.ToString();
            FinishTime = dtDateTo.Value.ToString();

            ShowLabourerWorkTasks();
            ShowLabourerDrivingTasks();
        }

        private void listDrivingTasks_MouseClick(object sender, MouseEventArgs e)
        {
            string taskType = listDrivingTasks.SelectedItems[0].SubItems[0].Text;
            string vehicleName = listDrivingTasks.SelectedItems[0].SubItems[1].Text;
            string startDate = listDrivingTasks.SelectedItems[0].SubItems[2].Text;
            string fieldName = listDrivingTasks.SelectedItems[0].SubItems[3].Text;
            string cropName = listDrivingTasks.SelectedItems[0].SubItems[4].Text;
            string jobDuration = listDrivingTasks.SelectedItems[0].SubItems[5].Text;
            string finishDate = listDrivingTasks.SelectedItems[0].SubItems[6].Text;
            string quantityRequired = listDrivingTasks.SelectedItems[0].SubItems[7].Text;
            string expectedHarvestDate = listDrivingTasks.SelectedItems[0].SubItems[8].Text;
            string expectedYield = listDrivingTasks.SelectedItems[0].SubItems[9].Text;
            string taskId = listDrivingTasks.SelectedItems[0].SubItems[10].Text;
            string treatment = listDrivingTasks.SelectedItems[0].SubItems[11].Text;


            txtTaskId.Text = taskId;
            txtTaskType.Text = taskType;
            txtStartDate.Text = startDate;
            txtEndDate.Text = finishDate;
            txtQuantity.Text = quantityRequired;
            txtCrop.Text = cropName;
            txtField.Text = fieldName;
            txtDuration.Text = jobDuration;
            txtHarvestDate.Text = expectedHarvestDate;
            txtYield.Text = expectedYield;
            txtTreatment.Text = treatment;
        }

        private void btnViewStorage_Click(object sender, EventArgs e)
        {
            ReportAvailableStorageForm storage = new ReportAvailableStorageForm();
            storage.Show();
        }

        private void StaffWorkSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form login = new Login();
            Hide();
            login.Show();
        }
    }
}
