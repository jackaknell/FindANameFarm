using FindANameFarm.Banks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FindANameFarm.BasicClasses;

namespace FindANameFarm.Forms
{
    /// <summary>
    /// ian 17/11/18
    /// </summary>
    public partial class HarvestTimeTableForm : Form
    {
        private string taskType;
        
        private List<WorkTaskReport> HarvestTimeTable { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        private readonly ReportBank _report = ReportBank.GetInst();

        public HarvestTimeTableForm()
        {
            InitializeComponent();
            dtDateTo.Value = dtDateTo.Value.AddDays(10);
            rbAllTasks.Checked = true;

           

        }

        private void HarvestTimeTableForm_Load(object sender, EventArgs e)
        {
          
           
      
            ShowHarvestTimeTable();
        }

        private void ShowHarvestTimeTable()
        {
            StartTime = dtDateFrom.Value.ToString();
            FinishTime = dtDateTo.Value.ToString();

            listHarvestTimeTable.Items.Clear();
            HarvestTimeTable = _report.GetHarvestTimeTable(StartTime,FinishTime);

            if (taskType == "All")
            {

                foreach (var harvestTask in HarvestTimeTable)
                    //.Where(harvestTask => (true)))

                {
                    listBody(harvestTask);
                }

                ListRefresh();

            }
            else
            {
                foreach (var harvestTask in HarvestTimeTable.Where(harvestTask => (harvestTask.TaskType == taskType)))

                {
                    listBody(harvestTask);
                }

                ListRefresh();
            }
        }

        private void listBody(WorkTaskReport harvestTask)
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
                taskType = "All";
            }

            if (rbFertTreatment.Checked)
            {
                taskType = "Treatment";
            }

            if (rbHarvest.Checked)
            {
                taskType = "Harvest";
            }

            if (rbSowingTasks.Checked)
            {
                taskType = "Sowing";
            }

            ShowHarvestTimeTable();
        }

        private void adDateTo_ValueChanged(object sender, EventArgs e)
        {
            StartTime = dtDateFrom.Value.ToString();
            FinishTime = dtDateTo.Value.ToString();

        
            ShowHarvestTimeTable();
        }
    }
}
