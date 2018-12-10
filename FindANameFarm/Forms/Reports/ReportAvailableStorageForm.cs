using FindANameFarm.BasicClasses;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using FindANameFarm.Banks;

namespace FindANameFarm.Forms
{
	/// <summary>
	/// jason, Dec 2018
	/// report to show the available storage and what the planned usage is
	/// </summary>
	public partial class ReportAvailableStorageForm : Form
	{
	    private readonly StorageBank _storage = StorageBank.GetInst();
        public ReportAvailableStorageForm()
		{
			InitializeComponent();
		    ShowStorage(_storage.StorageList);
        }

    
		//displays the storage in the listview
	    public void ShowStorage(List<Storage> storageList)
	    {
	        listAvailableStorage.Items.Clear();

	        foreach (Storage storage in storageList)
	        {
	            ListViewItem lvItem = new ListViewItem(storage.StorageID.ToString());
	            lvItem.SubItems.Add(storage.StorageName);
	            lvItem.SubItems.Add(storage.Capacity.ToString());
	            lvItem.SubItems.Add(storage.AvailableStorage.ToString());
	            lvItem.SubItems.Add(storage.Temp.ToString());
	            lvItem.SubItems.Add(storage.Storing);

	            listAvailableStorage.Items.Add(lvItem);

	        }
	    }


		//puts th list view information into the relevant box
        private void listAvailableStorage_MouseClick_1(object sender, MouseEventArgs e)
        {
            string storageID = listAvailableStorage.SelectedItems[0].SubItems[0].Text;
            string storageName = listAvailableStorage.SelectedItems[0].SubItems[1].Text;
            string capacity = listAvailableStorage.SelectedItems[0].SubItems[2].Text;
            string availableStorage = listAvailableStorage.SelectedItems[0].SubItems[3].Text;
            string temp = listAvailableStorage.SelectedItems[0].SubItems[4].Text;
            string storing = listAvailableStorage.SelectedItems[0].SubItems[5].Text;

            txtId.Text = storageID;
            txtCapacity.Text = capacity;
            txtAvailable.Text = availableStorage;
            txtTemp.Text = temp;
            txtStoring.Text = storing;

        }
		//loads the form and sets column sizes
        private void ReportAvailableStorageForm_Load_1(object sender, EventArgs e)
        {
            listAvailableStorage.View = View.Details;
            listAvailableStorage.FullRowSelect = true;

            listAvailableStorage.Columns.Add("Id", 50);
            listAvailableStorage.Columns.Add("Storage Name", 50);
            listAvailableStorage.Columns.Add("capacity", 100);
            listAvailableStorage.Columns.Add("Available Storage", 100);
            listAvailableStorage.Columns.Add("Temp", 50);
        }
    }
}
