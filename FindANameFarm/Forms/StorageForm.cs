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

namespace FindANameFarm.Forms
{

    public partial class StorageForm : Form
    {
        private StorageBank _storageBank = StorageBank.GetInst();
        public StorageForm()
        {
            InitializeComponent();
            refresh();
        }

      private void StorageForm_Load_1(object sender, EventArgs e)
        {
            listStorage.View = View.Details;
            listStorage.FullRowSelect = true;

            listStorage.Columns.Add("Id", 50);
            listStorage.Columns.Add("Storage Name", 50);
            listStorage.Columns.Add("capacity", 100);
            listStorage.Columns.Add("Available Storage", 100);
            listStorage.Columns.Add("Temp", 50);

        }

        private void listStorage_MouseClick(object sender, MouseEventArgs e)
        {
            string storageID = listStorage.SelectedItems[0].SubItems[0].Text;
            string storageName = listStorage.SelectedItems[0].SubItems[1].Text;
            string capacity = listStorage.SelectedItems[0].SubItems[2].Text;
            string availableStorage = listStorage.SelectedItems[0].SubItems[3].Text;
            string temp = listStorage.SelectedItems[0].SubItems[4].Text;

            txtStoreID.Text = storageID;
            nudCapacity.Text = capacity;
            nudAvailableStore.Text = availableStorage;
            nudTemp.Text = temp;
        }

        public void ShowStorage(List<Storage> storageList)
        {
            listStorage.Items.Clear();

            foreach (Storage storage in storageList)
            {
                ListViewItem lvItem = new ListViewItem(storage.StorageID.ToString());
                lvItem.SubItems.Add(storage.Capacity.ToString());
                lvItem.SubItems.Add(storage.AvailableStorage.ToString());
                lvItem.SubItems.Add(storage.Temp.ToString());

            }
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {
            Storage addStorage = new Storage
            {
                
            };
            _storageBank?.AddStorageList(addStorage);

            refresh();
            resetForm();
        }

        private void refresh()
        {
            _storageBank.RefreshConnection();
            ShowStorage(_storageBank.StorageList);
            
        }

        private void resetForm()
        {
            txtStoreID.Text = "";
            txtStoreName.Text = "";
            nudAvailableStore = "";
            nudCapacity = "";
            nudTemp = "";
            
        }

        private void btncloseStore_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {
            Storage editStorage = new Storage();
            editStorage.StorageID = txtStoreID.Text;
            editStorage.StorageName = txtStoreName.Text;
            editStorage.AvailableStorage = ;
            editStorage.Temp = ;

            _storageBank.UpdateStorage(editStorage);

            refresh();
        }
    }
}
