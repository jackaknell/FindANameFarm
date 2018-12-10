using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.MetaLayer;

namespace FindANameFarm.Forms.Add_Resource_Forms
{

    /// <summary>
    /// Author: Jack
    /// Date: Nov 2018
    /// Description: Crops form
    /// </summary>
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

        //Shows storage data from database.
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

        //Loads storage form with data.
        private void CropForm_Load(object sender, EventArgs e)
        {
            listCrops.View = View.Details;
            listCrops.FullRowSelect = true;

            listCrops.Columns.Add("Id", 50);
            listCrops.Columns.Add("Crop Name", 100);
            listCrops.Columns.Add("Crop Stock", 100);

        }
             
        //List and show the crops.
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
        //Check the radio button and see if it is a seed or crop.
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

        //button that will create a new entry, and merge with the database.
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
        //button that will update any changes, and merge with the database.
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

        //refreshes the connection to the database.
        private void refresh()
        {
            _cropsBank.RefreshConnection();
            ShowCrops(_cropsBank.CropsList);
        }

        //resets the from
        private void ResetForm()
        {
            txtCropId.Text = "";
            txtCropName.Text = "";
            
        }

        //Closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Displays the database contents of storage in the list view.
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
