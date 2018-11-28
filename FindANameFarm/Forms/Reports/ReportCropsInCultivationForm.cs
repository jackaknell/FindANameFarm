using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;

namespace FindANameFarm.Forms.Reports
{

    public partial class ReportCropsInCultivationForm : Form
    {
        
        private List<WorkTaskReport> CropsInCultivation { get; set; }
        private readonly ReportBank _report= ReportBank.GetInst();
        public ReportCropsInCultivationForm() => InitializeComponent();

        private void ReportCropsInCultivationForm_Load(object sender, EventArgs e)
        {
            ShowCropsInCultivation();

            
        }

        private void ShowCropsInCultivation()
        {
            

            listCropsInCultivation.Items.Clear();
            CropsInCultivation = _report.GetCropsInCultivation();
            
            foreach (WorkTaskReport crops in CropsInCultivation)
            {
                ListViewItem lvItem = new ListViewItem(crops.CropName);
                lvItem.SubItems.Add(crops.FieldName);
                lvItem.SubItems.Add(crops.TaskStartDate.ToShortDateString());
                lvItem.SubItems.Add(crops.TaskEndDate.ToShortDateString());
                lvItem.SubItems.Add(crops.ExpectedYield.ToString());
                lvItem.SubItems.Add(crops.TaskEndDate.ToShortDateString());
                lvItem.SubItems.Add(crops.QuantityRequired.ToString());
                lvItem.SubItems.Add(crops.ExpectedHarvestDate.ToShortDateString());
                lvItem.SubItems.Add(crops.ExpectedYield.ToString());
                lvItem.SubItems.Add(crops.TaskId.ToString());
                lvItem.SubItems.Add(crops.TaskStatus);
                listCropsInCultivation.Items.Add(lvItem);
            }
        }

        private void listCropsInCultivation_MouseClick(object sender, MouseEventArgs e)
        {
            string cropName = listCropsInCultivation.SelectedItems[0].SubItems[0].Text;
            string fieldName = listCropsInCultivation.SelectedItems[0].SubItems[1].Text;
            string startDate = listCropsInCultivation.SelectedItems[0].SubItems[2].Text;
            string finishDate = listCropsInCultivation.SelectedItems[0].SubItems[3].Text;
            string expectedYield = listCropsInCultivation.SelectedItems[0].SubItems[4].Text;

            txtCropName.Text = cropName;
            txtFieldName.Text = fieldName;
            txtStartDate.Text = startDate;
            txtEndDate.Text = finishDate;
            txtExpectedYield.Text = expectedYield;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
