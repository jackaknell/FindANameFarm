using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FindANameFarm.Banks;
using FindANameFarm.Properties;

namespace FindANameFarm.Forms.Add_Resource_Forms
{
    /// <summary>
    /// Ian
    /// creates/edits a staff member
    /// </summary>
    public partial class StaffForm : Form
    {
        private readonly StaffBank _staffBank = StaffBank.GetInst();
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();

        //constructor
        public StaffForm()
        {
            InitializeComponent();
            gbCompetencies.Enabled = !string.IsNullOrWhiteSpace(txtId.Text);
            btnUpdate.Enabled = !string.IsNullOrWhiteSpace(txtId.Text);
           
            RefreshForm();
        }
        //disables group box and update btn until a staff member is selected
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            gbCompetencies.Enabled = !string.IsNullOrWhiteSpace(txtId.Text);
            btnUpdate.Enabled = !string.IsNullOrWhiteSpace(txtId.Text);
        }

        //shows the list of staff
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
       
        //shows a list of available competencies
        private void ShowCategories()
        {
            if (cbCompetencies != null)
            {
                
                cbCompetencies.DataSource = _vehicleBank.Categories;
            }
            
            if (cbCompetencies == null) return;
            cbCompetencies.DisplayMember = "CatName";
            cbCompetencies.ValueMember = "CatId";
        }

        // shows the current staff members competencies
        public void ShowCompetencies()
        {
            _staffBank.GetCompetencies(Convert.ToInt32(txtId.Text));


            listCompetencies.Items.Clear();

            foreach (CatIdAndName competency in _staffBank.StaffCompetenciesList)
            {
                ListViewItem lvItem = new ListViewItem(competency.CategoryId.ToString());
                lvItem.SubItems.Add(competency.CategoryName);


                listCompetencies.Items.Add(lvItem);
            }

        }

        //allows the user to a select a staff member to show its details
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string id = listStaff.SelectedItems[0].SubItems[0].Text;
            string fName = listStaff.SelectedItems[0].SubItems[1].Text;
            string sName = listStaff.SelectedItems[0].SubItems[2].Text;
            string gender = listStaff.SelectedItems[0].SubItems[3].Text;
            string email = listStaff.SelectedItems[0].SubItems[4].Text;
            string role = listStaff.SelectedItems[0].SubItems[5].Text;
            string contact = listStaff.SelectedItems[0].SubItems[6].Text;
            string filePath = listStaff.SelectedItems[0].SubItems[7].Text;
            string password = listStaff.SelectedItems[0].SubItems[8].Text;
            
            txtId.Text = id;
            txtfName.Text = fName;
            txtSname.Text = sName;
            cbGender.SelectedItem = gender;
            txtemail.Text = email;
            cbPosition.SelectedItem = role;
            txtContact.Text = contact;
            txtImagePath.Text = filePath;
            txtStaffPassword.Text = password;
            ShowCompetencies();
            ShowStaffImage();
            
        }
        
        //shows the staff image or the default image if unavailable
        private void ShowStaffImage()
        {
            Debug.Write(txtImagePath.Text);
            try
            {
                string filePath = txtImagePath.Text;
                Debug.Write(filePath);
                pbStaffImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbStaffImage.Load(filePath);
                //pbStaffImage.Image = filePath;
            }
            catch (Exception e)
            {
                pbStaffImage.Image = Resources.defaultImage;
                Console.WriteLine(e);
                
            }
               

        }
       
        // resets the form
        private void ResetForm()
        {
            txtId.Text = "";
            txtfName.Text = "";
            txtSname.Text = "";
            cbGender.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;
            txtemail.Text = "";
            cbCompetencies.SelectedIndex = -1;
            txtContact.Text = "";
            txtImagePath.Text = "";
            pbStaffImage.Image =Resources.defaultImage;
        }

        //refreshes the lists and the db and resets form
        private void RefreshForm()
        {
            _vehicleBank.RefreshConnection();
            _staffBank.RefreshConnection();
            ShowStaff(_staffBank.StaffList);
            ShowCategories();
            ResetForm();

        }

        //allows the user to select a path name for an image file
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            {
                openFileDialog1.Filter =
                    Resources.fileNameFilter;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileInfo info = new FileInfo(openFileDialog1.FileName);
                    string path = info.DirectoryName;
                    string fileName = info.Name;

                    txtImagePath.Text = path + fileName;
                   ShowStaffImage();
                }
            }
        }

    
        // updates the currently selected staff member
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff editStaffMember = new Staff
            {
                StaffId = Convert.ToInt32(txtId.Text),
                FirstName = txtfName.Text,
                SurName = txtSname.Text,
                Gender = cbGender.SelectedItem.ToString(),
                Email = txtemail.Text,
                Role = cbPosition.SelectedItem.ToString(),
                Contact = txtContact.Text,
                ImageFile = txtImagePath.Text
            };
            _staffBank.UpdateStaff(editStaffMember);

            RefreshForm();
            
        }

        //adds a new staff member to the db
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Staff addStaff = new Staff
                {
                    FirstName = txtfName.Text,
                    SurName = txtSname.Text,
                    Gender = cbGender.SelectedItem.ToString(),
                    Email = txtemail.Text,
                    Role = cbPosition.SelectedItem.ToString(),
                    Contact = txtContact.Text,
                    ImageFile = txtImagePath.Text,
                    Password = txtStaffPassword.Text
                };

                _staffBank.AddStaffToList(addStaff);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.tryAgain);
                Console.WriteLine(exception);
               
            }
            
          
            RefreshForm();
        }

        //adds a competency to the selected staff member
        private void btnAddCompetency_Click(object sender, EventArgs e)
        {
           
            try
            {
                StaffAndCategory competency = new StaffAndCategory
                {
                    CatId = Convert.ToInt32(cbCompetencies.SelectedValue),
                    StaffId = Convert.ToInt32(txtId.Text)
                };
                _staffBank.AddCompetency(competency);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.selectStaff);
                Console.WriteLine(exception);

            }


            ShowCompetencies();
        }

     
       //closes the staff form
        private void btnCloseStaffForm_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        //removes a competency from the selected user
        private void btnRemoveCompetency_Click(object sender, EventArgs e)
        {
            try
            {
                int staffMember = Convert.ToInt32(txtId.Text);
                int catId = Convert.ToInt32(listCompetencies.SelectedItems[0].SubItems[0].Text);

                _staffBank.DeleteStaffCompetency(staffMember, catId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Resources.deleteCompetency);
                Console.WriteLine(exception);
                
            }
            
            ShowCompetencies();
        }

      //btn reset form
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
