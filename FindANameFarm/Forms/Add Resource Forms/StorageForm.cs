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
            ShowStorage(_storageBank.StorageList);
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
            txtStoreName.Text = storageName;
            nudCapacity.Value = Convert.ToInt32(capacity);
            nudAvailableStore.Value = Convert.ToInt32(availableStorage);
            nudTemp.Value = Convert.ToInt32(temp);
        }

        public void ShowStorage(List<Storage> storageList)
        {
            listStorage.Items.Clear();

            foreach (Storage storage in storageList)
            {
                ListViewItem lvItem = new ListViewItem(storage.StorageID.ToString());
                lvItem.SubItems.Add(storage.StorageName.ToString());
                lvItem.SubItems.Add(storage.Capacity.ToString());
                lvItem.SubItems.Add(storage.AvailableStorage.ToString());
                lvItem.SubItems.Add(storage.Temp.ToString());

                listStorage.Items.Add(lvItem);

            }
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {
            Storage addStorage = new Storage();
            addStorage.StorageName = txtStoreName.Text;
            addStorage.AvailableStorage = Convert.ToInt32(nudAvailableStore.Value);
            addStorage.Capacity = Convert.ToInt32(nudCapacity.Value);
            addStorage.Temp = Convert.ToInt32(nudTemp.Value);
                
            
            _storageBank?.AddStorageToList(addStorage);

            refresh();
            
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
            nudAvailableStore.Value = 0;
            nudCapacity.Value = 0;
            nudTemp.Value = 0;
            
        }

        private void btncloseStore_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {

            try
            {

                Storage editStorage = new Storage();

                editStorage.StorageID = Convert.ToInt32(txtStoreID.Text);
                editStorage.StorageName = txtStoreName.Text;
                editStorage.AvailableStorage = Convert.ToInt32(nudAvailableStore.Value);
                editStorage.Capacity = Convert.ToInt32(nudCapacity.Value);
                editStorage.Temp = Convert.ToInt32(nudTemp.Value);

                _storageBank.UpdateStorage(editStorage);
            }

            catch (Exception exception)
            {
                MessageBox.Show("Select a Storage container to update.");
                
            }

            

            refresh();
        }
    }
}
