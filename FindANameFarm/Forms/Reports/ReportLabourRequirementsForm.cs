using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.WorkTaskClasses;

namespace FindANameFarm.Forms
{
    /// <summary>
    /// Author: Jack
    /// Date: Dec 2018
    /// </summary>
    public partial class ReportLabourRequirementsForm : Form
    {

        private readonly StaffBank _staffBank = StaffBank.GetInst();
        private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();

        public ReportLabourRequirementsForm()
        {
            InitializeComponent();
            ShowStaff(_staffBank.StaffList);
            ShowExistingHarvestTasks();
        }
        //show the staff list
        public void ShowStaff(List<Staff> staffList)
        {
            listStaff.Items.Clear();

            foreach (Staff staff in staffList)
            {
                ListViewItem lvItem = new ListViewItem(staff.StaffId.ToString());
                lvItem.SubItems.Add(staff.FirstName);
                lvItem.SubItems.Add(staff.SurName);
                lvItem.SubItems.Add(staff.Gender);
                lvItem.SubItems.Add(staff.Email);
                lvItem.SubItems.Add(staff.Role);
                lvItem.SubItems.Add(staff.Contact);
                lvItem.SubItems.Add(staff.ImageFile);
                lvItem.SubItems.Add(staff.Password);

                listStaff.Items.Add(lvItem);

            }
        }

        //show the harvest list
        private void ShowExistingHarvestTasks()
        {
            listWorkTasks.Items.Clear();
            List<WorkTasks> workTaskList = _workTask.WorkTaskList;

            foreach (var workTask in workTaskList)
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
                listWorkTasks.Items.Add(lvItem);
            }
        }
        //close the form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
