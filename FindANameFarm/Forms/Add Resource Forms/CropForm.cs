using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Forms.Add_Resource_Forms
{
    public partial class CropForm : Form
    {
        private readonly StorageBank _storage = StorageBank.GetInst();
        private readonly CropsBank _cropsBank = CropsBank.GetInst();
        public CropForm()
        {
            InitializeComponent();
            rbSeed.Checked = true;
            ShowStorage();
            ShowCrops(_cropsBank.CropsList);
            refresh();
        }
        private void ShowStorage()
        {
            if (cbStorage != null)
            {
                cbStorage.DataSource = _storage.StorageList;
            }

            if (cbStorage == null) return;
            cbStorage.DisplayMember = "StorageName";
            cbStorage.ValueMember = "StorageId";
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
            try
            {

                Crops editCrop = new Crops
                {

                    CropId = Convert.ToInt32(txtCropId.Text),
                    CropName = CheckIfSeed()

                };


                _cropsBank.UpdateCrop(editCrop);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Select a Crop item to update.");
                Console.Write(exception);
            }
           
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
