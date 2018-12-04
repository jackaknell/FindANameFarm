using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;

namespace FindANameFarm.Forms.Reports
{
    /// <summary>
    /// ian 17/11/18
    /// </summary>
    public partial class HarvestTimeTableForm : Form
    {
        private string _taskType;
        
        private List<WorkTaskReport> HarvestTimeTable { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        private readonly ReportBank _report = ReportBank.GetInst();

        public HarvestTimeTableForm()
        {
            InitializeComponent();
            dtDateTo.Value = dtDateTo.Value.AddDays(60);
            rbAllTasks.Checked = true;

           

        }

        private void HarvestTimeTableForm_Load(object sender, EventArgs e)
        {

            ShowHarvestTimeTable();
        }

        private void ShowHarvestTimeTable()
        {
            StartTime = dtDateFrom.Value.ToString("MM-dd-yyyy");
            FinishTime = dtDateTo.Value.ToString("MM-dd-yyyy");

            listHarvestTimeTable.Items.Clear();
            HarvestTimeTable = _report.GetHarvestTimeTable(StartTime,FinishTime);

            if (_taskType == "All")
            {

                foreach (var harvestTask in HarvestTimeTable)
                    //.Where(harvestTask => (true)))

                {
                    ListBody(harvestTask);
                }

                ListRefresh();

            }
            else
            {
                foreach (var harvestTask in HarvestTimeTable.Where(harvestTask => (harvestTask.TaskType == _taskType)))

                {
                    ListBody(harvestTask);
                }

                ListRefresh();
            }
        }

        private void ListBody(WorkTaskReport harvestTask)
        {
          

            ListViewItem lvItem = new ListViewItem(harvestTask.TaskType);

            lvItem.SubItems.Add(harvestTask.TaskStartDate.ToShortDateString());
            lvItem.SubItems.Add(harvestTask.TaskEndDate.ToShortDateString());
            lvItem.SubItems.Add(harvestTask.CropName);
            lvItem.SubItems.Add(harvestTask.FieldName);
            lvItem.SubItems.Add(harvestTask.TreatmentName);
            lvItem.SubItems.Add(harvestTask.TaskId.ToString());
            listHarvestTimeTable.Items.Add(lvItem);
        }

        private void ListRefresh()
        {
            for (int i = 0; i < listHarvestTimeTable.Items.Count; i++)
            {
                listHarvestTimeTable.Items[i].BackColor = Color.Lavender;

                if (listHarvestTimeTable.Items[i].ToString().Contains("Sowing"))
                {
                    listHarvestTimeTable.Items[i].BackColor = Color.DarkKhaki;
                }

                if (listHarvestTimeTable.Items[i].ToString().Contains("Harvest"))
                {
                    listHarvestTimeTable.Items[i].BackColor = Color.BlanchedAlmond;
                }
            }

        }

        private void rbAllTasks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllTasks.Checked)
            {
                _taskType = "All";
            }

            if (rbFertTreatment.Checked)
            {
                _taskType = "Treatment";
            }

            if (rbHarvest.Checked)
            {
                _taskType = "Harvest";
            }

            if (rbSowingTasks.Checked)
            {
                _taskType = "Sowing";
            }

            ShowHarvestTimeTable();
        }

        private void adDateTo_ValueChanged(object sender, EventArgs e)
        {
            StartTime = dtDateFrom.Value.ToString("MM-dd-yyyy");
            FinishTime = dtDateTo.Value.ToString("MM-dd-yyyy");

        
            ShowHarvestTimeTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
