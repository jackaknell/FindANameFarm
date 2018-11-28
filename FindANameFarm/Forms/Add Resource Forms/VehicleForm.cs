using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FindANameFarm.Forms.Add_Resource_Forms
{
    public partial class VehicleForm : Form
    {
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();
        public VehicleForm()
        {
            InitializeComponent();
            gbCategories.Enabled = !string.IsNullOrWhiteSpace(txtVehicleId.Text);
            btnUpdateVehicle.Enabled = !string.IsNullOrWhiteSpace(txtVehicleId.Text);
            refresh();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
           
                
            listVehicles.Columns.Add("Id", 50);
            listVehicles.Columns.Add("Vehicle Name",100);
            listVehicles.Columns.Add("Vehicle Category", 100);
            
           
        }
        private void txtAddCategory_TextChanged(object sender, EventArgs e)
        {
            btnAddCategory.Enabled = !string.IsNullOrWhiteSpace(txtAddCategory.Text);
           
        }

        private void listVehicles_MouseClick(object sender, MouseEventArgs e)
        {
            string id = listVehicles.SelectedItems[0].SubItems[0].Text;
            string vehicleName = listVehicles.SelectedItems[0].SubItems[1].Text;
            string categoryName = listVehicles.SelectedItems[0].SubItems[2].Text;

            
            txtVehicleId.Text = id;
            txtVehicleType.Text = vehicleName;
            cbVehicleCategoryList.SelectedIndex = cbVehicleCategoryList.FindStringExact(categoryName);
        }

        public void ShowVehicles(List<VehicleAndCategory> vehicleList)
        {
            listVehicles.Items.Clear();
           
            foreach (VehicleAndCategory vehicle in vehicleList)
            {
                
                
 
                ListViewItem lvItem = new ListViewItem(vehicle.VehicleId.ToString());
                lvItem.SubItems.Add(vehicle.VehicleName);
                lvItem.SubItems.Add(vehicle.CategoryName);

                listVehicles.Items.Add(lvItem);
                
            }
        }

       
        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            Vehicles addVehicle = new Vehicles
            {
                VehicleName = txtVehicleType.Text,
                Category = (int) cbVehicleCategoryList.SelectedValue
            };
            _vehicleBank?.AddVehicleToList(addVehicle);

            refresh();
            ResetForm();
        }

        private void refresh()
        {
            _vehicleBank.RefreshConnection();
            ShowVehicles(_vehicleBank.VehicleAndCategoryLists);
            ShowCategories(cbVehicleCategory);
            ShowCategories(cbVehicleCategoryList);
            ResetForm();
        }

        private void ShowCategories(ComboBox vehicleCategory)
        {
            if (vehicleCategory != null)
            {
                vehicleCategory.DataSource = _vehicleBank.Categories;
            }

            if (vehicleCategory == null) return;
            vehicleCategory.DisplayMember = "CatName";
            vehicleCategory.ValueMember = "CatId";
        }

        private void ResetForm()
        {
            txtVehicleId.Text = "";
            txtVehicleType.Text = "";
            cbVehicleCategory.SelectedIndex = -1;
            cbVehicleCategoryList.SelectedIndex = -1;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
          
                _vehicleBank?.AddCategoryToDb(txtAddCategory.Text);
            
            refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            Vehicles editVehicle = new Vehicles
            {
                VehicleId = Convert.ToInt32(txtVehicleId.Text),
                VehicleName = txtVehicleType.Text,
                Category = Convert.ToInt32(cbVehicleCategoryList.SelectedValue)
            };


            _vehicleBank.UpdateVehicle(editVehicle);

            refresh();
        }

        private void txtVehicleId_TextChanged(object sender, EventArgs e)
        {
            btnUpdateVehicle.Enabled = !string.IsNullOrWhiteSpace(txtVehicleId.Text);         
            gbCategories.Enabled = !string.IsNullOrWhiteSpace(txtVehicleId.Text);
            btnAddCategory.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

