using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FindANameFarm
{
    public partial class StaffForm : Form
    {
        private StaffBank _staffBank = StaffBank.GetInst();
        private VehicleBank _vehicleBank = VehicleBank.GetInst();
        public StaffForm()
        {
            InitializeComponent();
           
            ShowStaff(_staffBank.StaffList);
            refresh();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            listStaff.View = View.Details;
            listStaff.FullRowSelect = true;

            listStaff.Columns.Add("ID", 50);
            listStaff.Columns.Add("First Name", 75);
            listStaff.Columns.Add("Surname", 75);
            listStaff.Columns.Add("gender", 50);
            listStaff.Columns.Add("email", 150);
            listStaff.Columns.Add("Role", 75);
            listStaff.Columns.Add("Contact Number", 100);

            listCompetencies.View = View.Details;
            listCompetencies.FullRowSelect = true;
            listCompetencies.Columns.Add("ID", 75);
        }

        public void ShowStaff(List<Staff> staffList)
        {
            this.listStaff.Items.Clear();

            foreach (Staff staff in staffList)
            {
                ListViewItem lvItem = new ListViewItem(staff.StaffId.ToString());
                lvItem.SubItems.Add(staff.FirstName);
                lvItem.SubItems.Add(staff.SurName);
                lvItem.SubItems.Add(staff.Gender);
                lvItem.SubItems.Add(staff.Email);
                lvItem.SubItems.Add(staff.Role);
                lvItem.SubItems.Add(staff.Contact);
                //lvItem.SubItems.Add(personel.age.ToString());

                this.listStaff.Items.Add(lvItem);

            }
        }
        public void showCopetencies(List<StaffAndCategory> competencies)
        {
            listCompetencies.Items.Clear();

            foreach (StaffAndCategory competency in competencies)
            {
                ListViewItem lvItem = new ListViewItem(competency.CatId.ToString());
                Debug.WriteLine(competency.CatId);

                this.listCompetencies.Items.Add(lvItem);
            }
            
        }

        private void ShowCategories()
        {
            if (cbCompetencies != null)
            {
                Debug.WriteLine("getting list");
                cbCompetencies.DataSource = _vehicleBank.Categories;
            }
            Debug.WriteLine("getting list");
            if (cbCompetencies == null) return;
            cbCompetencies.DisplayMember = "CatName";
            cbCompetencies.ValueMember = "CatId";
        }



        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string ID = listStaff.SelectedItems[0].SubItems[0].Text;
            string fName = listStaff.SelectedItems[0].SubItems[1].Text;
            string sName = listStaff.SelectedItems[0].SubItems[2].Text;
            string gender = listStaff.SelectedItems[0].SubItems[3].Text;
            string email = listStaff.SelectedItems[0].SubItems[4].Text;
            string role = listStaff.SelectedItems[0].SubItems[5].Text;
            string contact = listStaff.SelectedItems[0].SubItems[6].Text;
            
            txtId.Text = ID;
            txtfName.Text = fName;
            txtSname.Text = sName;
            cbGender.SelectedItem = gender;
            txtemail.Text = email;
            cbPosition.SelectedItem = role;
            txtContact.Text = contact;
        }

       

       

      
        private void resetForm()
        {
            txtId.Text = "";
            txtfName.Text = "";
            txtSname.Text = "";
            //txtGender.Text = "";
            txtemail.Text = "";
            cbCompetencies.SelectedIndex = -1;
            txtContact.Text = "";
        }

        private void refresh()
        {
            _vehicleBank.RefreshConnection();
            _staffBank.refreshConnection();
            ShowStaff(_staffBank.StaffList);
            ShowCategories();
          

            resetForm();

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            {
                openFileDialog1.Filter =
                    "jpeg images (*.jpg)|*.jpg|png images (*.png)|*.png|bitmap files (*.bmp)|*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileInfo Info = new FileInfo(openFileDialog1.FileName);
                    string path = Info.DirectoryName;
                    string fileName = Info.Name;

                    txtImagePath.Text = path + fileName;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int staffMemberToDelete = Convert.ToInt32(txtId.Text);
            _staffBank.deleteStaff(staffMemberToDelete);

            refresh();
            resetForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Staff editstaff = new Staff();
            editstaff.StaffId = Convert.ToInt32(txtId.Text);
            editstaff.FirstName = txtfName.Text;
            editstaff.SurName = txtSname.Text;
            editstaff.Gender = cbGender.SelectedItem.ToString();
            editstaff.Email = txtemail.Text;
            editstaff.Role = cbPosition.SelectedItem.ToString();
            editstaff.Contact = txtContact.Text;
            _staffBank.updateStaff(editstaff);

            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff addstaff = new Staff();
            addstaff.FirstName = txtfName.Text;
            addstaff.SurName = txtSname.Text;
            addstaff.Gender = cbGender.SelectedItem.ToString();
            addstaff.Email = txtemail.Text;
            addstaff.Role = cbPosition.SelectedItem.ToString();
            addstaff.Contact = txtContact.Text;

            _staffBank.AddStaffToList(addstaff);
           
            refresh();
        }

        private void btnAddCompetency_Click(object sender, EventArgs e)
        {
            StaffAndCategory competency = new StaffAndCategory();
            competency.CatId = Convert.ToInt32(cbCompetencies.SelectedValue);
            competency.StaffId = Convert.ToInt32(txtId.Text);
            _staffBank.AddCompetency(competency);
            _staffBank.GetCompetencies(Convert.ToInt32(txtId.Text));

            showCopetencies(_staffBank.CompetencyList);
        }
    }
}
