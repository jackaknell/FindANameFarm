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
using FindANameFarm.BasicClasses;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Forms
{
    public partial class CropForm : Form
    {

        private CropsBank _cropsBank = CropsBank.GetInst();
        public CropForm()
        {
            InitializeComponent();
            ShowCrops(_cropsBank.CropsList);
            refresh();
        }

        private void CropForm_Load(object sender, EventArgs e)
        {
            listCrops.View = View.Details;
            listCrops.FullRowSelect = true;

            listCrops.Columns.Add("Id", 50);
            listCrops.Columns.Add("Crop Name", 100);
            listCrops.Columns.Add("Crop Stock", 100);

        }

        private void listCrops_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string CropId = listCrops.SelectedItems[0].SubItems[0].Text;
            string CropName = listCrops.SelectedItems[0].SubItems[1].Text;
            string CropStock = listCrops.SelectedItems[0].SubItems[2].Text;

            txtCropId.Text = CropId;
            txtCropName.Text = CropName;
            

        }

        public void ShowCrops(List<Crops> CropsList)
        {
            listCrops.Items.Clear();

            foreach (Crops crops in CropsList)
            {
                ListViewItem lvItem = new ListViewItem(crops.CropId.ToString());
              
                lvItem.SubItems.Add(crops.CropName.ToString());
                lvItem.SubItems.Add(crops.CropStock.ToString());
                

                listCrops.Items.Add(lvItem);
            };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Crops addCrops = new Crops();
            addCrops.CropName = txtCropName.Text;
           

            _cropsBank?.AddCropToList(addCrops);

            Refresh();
        }

        private void refresh()
        {
            _cropsBank.RefreshConnection();
            ShowCrops(_cropsBank.CropsList);
        }

        private void resetForm()
        {
            txtCropName.Text = "";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Crops editCrop = new Crops();
            editCrop.CropName = txtCropName.Text;
           

            _cropsBank.UpdateCrop(editCrop);

            refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
