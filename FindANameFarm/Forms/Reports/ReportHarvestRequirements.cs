using FindANameFarm.Banks;
using FindANameFarm.WorkTaskClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindANameFarm.Forms.Reports
{
    /// <summary>
    /// Author: Jack
    /// Date: Dec 2018
    /// </summary>
    public partial class ReportHarvestRequirements : Form
    {

    
        private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();


        public ReportHarvestRequirements()
        {
            InitializeComponent();
            ShowExistingHarvestTasks();
        }

        //Show harvest tasks
        private void ShowExistingHarvestTasks()
        {
            list.Items.Clear();
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
                list.Items.Add(lvItem);
            }
        }
        //close the form.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
