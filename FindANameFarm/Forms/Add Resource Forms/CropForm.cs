using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace FindANameFarm.Forms
{
    public partial class CropForm : Form
    {

        private readonly CropsBank _cropsBank = CropsBank.GetInst();
        public CropForm()
        {
            InitializeComponent();
            rbSeed.Checked = true;
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

     

        public void ShowCrops(List<Crops> cropsList)
        {
            listCrops.Items.Clear();

            foreach (Crops crops in cropsList)
            {
                ListViewItem lvItem = new ListViewItem(crops.CropId.ToString());
              
                lvItem.SubItems.Add(crops.CropName);
                lvItem.SubItems.Add(crops.CropStock.ToString());
                

                listCrops.Items.Add(lvItem);
            }
        }

        private string CheckIfSeed()
        {
            string cropName;
            if (rbSeed.Checked)
            {
                cropName = txtCropName.Text + " Seeds";
            }
            else
            {
                cropName = txtCropName.Text;
            }
            return cropName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Crops addCrops = new Crops
            {
                CropName = CheckIfSeed()
            };


            _cropsBank?.AddCropToList(addCrops);

            refresh();
            ResetForm();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Crops editCrop = new Crops
            {
                
                CropName = CheckIfSeed()
            };

            Debug.WriteLine(editCrop.CropName);
            _cropsBank.UpdateCrop(editCrop);

            refresh();
        }

        private void refresh()
        {
            _cropsBank.RefreshConnection();
            ShowCrops(_cropsBank.CropsList);
        }

        private void ResetForm()
        {
            txtCropId.Text = "";
            txtCropName.Text = "";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listCrops_MouseClick(object sender, MouseEventArgs e)
        {
            string CropId = listCrops.SelectedItems[0].SubItems[0].Text;
            string CropName = listCrops.SelectedItems[0].SubItems[1].Text;
            //string CropStock = listCrops.SelectedItems[0].SubItems[2].Text;

            txtCropId.Text = CropId;
            txtCropName.Text = CropName;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
