using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindANameFarm.BasicClasses;
using FindANameFarm.Banks;

namespace FindANameFarm.Forms
{
	public partial class FertiliserAndTreatmentForm : Form
	{

		private FertTreatBank _fertTreatBank = FertTreatBank.GetInst();

		public FertiliserAndTreatmentForm()
		{
			InitializeComponent();
			ShowFertTreat(_fertTreatBank.FertTreatList);
			refresh();
		}

		private void FertiliserAndTreatmentForm_Load(object sender, EventArgs e)
		{
			listFertTreat.View = View.Details;
			listFertTreat.FullRowSelect = true;

			listFertTreat.Columns.Add("ID", 50);
			listFertTreat.Columns.Add("Fertiliser/Treatment Name", 175);
			listFertTreat.Columns.Add("Quantity", 75);
		}

		public void ShowFertTreat(List<FertiliserAndTreatment> fertTreatList)
		{
			listFertTreat.Items.Clear();

			foreach (FertiliserAndTreatment fertTreat in fertTreatList)
			{
				ListViewItem lvItem = new ListViewItem(fertTreat.FertTreatId.ToString());
				lvItem.SubItems.Add(fertTreat.FertTreatName);
				lvItem.SubItems.Add(fertTreat.FertTreatQuantity.ToString());

				listFertTreat.Items.Add(lvItem);
			}
		}

		private void listFertTreat_MouseClick(object sender, MouseEventArgs e)
		{
			string ID = listFertTreat.SelectedItems[0].SubItems[0].Text;
			string fTName = listFertTreat.SelectedItems[0].SubItems[1].Text;
			string fTQuantity = listFertTreat.SelectedItems[0].SubItems[2].Text;

			txtFertTreatId.Text = ID;
			txtFertTreatName.Text = fTName;
			nudFertTreatQuantity.Value = Convert.ToInt32(fTQuantity);
		}

		private void ResetForm()
		{
			txtFertTreatId.Text = "";
			txtFertTreatName.Text = "";
			nudFertTreatQuantity.Value = 0;
		}

		private void refresh()
		{
			_fertTreatBank.RefreshConnection();
			ShowFertTreat(_fertTreatBank.FertTreatList);

			ResetForm();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_fertTreatBank.RefreshConnection();
			ShowFertTreat(_fertTreatBank.FertTreatList);

			ResetForm();
		}

		private void btnFertTreatCreate_Click(object sender, EventArgs e)
		{
			FertiliserAndTreatment addFertTreat = new FertiliserAndTreatment();
			addFertTreat.FertTreatName = txtFertTreatName.Text;
			addFertTreat.FertTreatQuantity = Convert.ToInt32(nudFertTreatQuantity.Value);

			_fertTreatBank.AddFertTreatToList(addFertTreat);
			refresh();
		}

		private void btnFertTreatUpdate_Click(object sender, EventArgs e)
		{
			FertiliserAndTreatment editFertTreat = new FertiliserAndTreatment();
			editFertTreat.FertTreatId = Convert.ToInt32(txtFertTreatId.Text);
			editFertTreat.FertTreatName = txtFertTreatName.Text;
			editFertTreat.FertTreatQuantity = Convert.ToInt32(nudFertTreatQuantity.Value);

			_fertTreatBank.UpdateFertTreat(editFertTreat);
			refresh();
		}

		private void btnFertTreatClose_Click(object sender, EventArgs e) => Close();




	}
}
