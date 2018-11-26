using FindANameFarm.BasicClasses;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using FindANameFarm.Banks;

namespace FindANameFarm.Forms
{
	public partial class ReportAvailableStorageForm : Form
	{
		private List<WorkTaskReport> AvailableStorage { get; set; }
		private readonly ReportBank _report = ReportBank.GetInst();
		public ReportAvailableStorageForm() => InitializeComponent();

		private void ReportAvailableStorageForm_Load(object sender, EventArgs e)
		{
			ShowAvailableStorage();
		}

		private void ShowAvailableStorage()
		{
			listAvailableStorage.Items.Clear();
			AvailableStorage = _report.GetAvailableStorage();

			foreach(WorkTaskReport storage in AvailableStorage)
			{
				ListViewItem lvItem = new ListViewItem(storage.StorageId.ToString());
				//lvItem.SubItems.Add(storage.);
				//lvItem.SubItems.Add(storage);
			}
		}
	}
}
