using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.BasicClasses;
using FindANameFarm.Banks;
using System.Diagnostics;


namespace FindANameFarm.Forms
{
	public partial class FieldsForm : Form
	{
		private FieldBank _fieldBank = FieldBank.GetInst();
		public FieldsForm()
		{
			InitializeComponent();

			ShowField(_fieldBank.FieldList);

			refresh();
		}

		private void FieldsForm_Load(object sender, EventArgs e)
		{
			listField.View = View.Details;
			listField.FullRowSelect = true;

			listField.Columns.Add("ID", 50);
			listField.Columns.Add("Field Name", 75);
			listField.Columns.Add("Field Size", 50);
			listField.Columns.Add("Suitability of Field", 75);
		}

		public void ShowField(List<Fields> fieldList)
		{
			listField.Items.Clear();

			foreach (Fields fields in fieldList)
			{
				ListViewItem lvItem = new ListViewItem(fields.FieldId.ToString());
				lvItem.SubItems.Add(fields.FieldName);
				lvItem.SubItems.Add(fields.FieldSize.ToString());
				lvItem.SubItems.Add(fields.FieldSuitability);

				listField.Items.Add(lvItem);
			}

		}

		private void listField_MouseClick_1(object sender, MouseEventArgs e)
		{
			string ID = listField.SelectedItems[0].SubItems[0].Text;
			string fName = listField.SelectedItems[0].SubItems[1].Text;
			string fSize = listField.SelectedItems[0].SubItems[2].Text;
			string fSuitability = listField.SelectedItems[0].SubItems[3].Text;

			txtFieldId.Text = ID;
			txtFieldName.Text = fName;
			nudFieldSize.Value = Convert.ToInt32(fSize);
			txtFieldSuitability.Text = fSuitability;
		}

		private void listField_MouseClick(object sender, MouseEventArgs e)
		{
			string ID = listField.SelectedItems[0].SubItems[0].Text;
			string fName = listField.SelectedItems[0].SubItems[1].Text;
			string fSize = listField.SelectedItems[0].SubItems[2].Text;
			string fSuitability = listField.SelectedItems[0].SubItems[3].Text;

			txtFieldId.Text = ID;
			txtFieldName.Text = fName;
			nudFieldSize.Value = Convert.ToInt32(fSize);
			txtFieldSuitability.Text = fSuitability;
		}

		private void ResetForm()
		{
			txtFieldId.Text = "";
			txtFieldName.Text = "";
			nudFieldSize.Value = 0;
			txtFieldSuitability.Text = "";
		}

		private void refresh()
		{
			_fieldBank.RefreshConnection();
			ShowField(_fieldBank.FieldList);

			ResetForm();
		}

		private void btnFieldCreate_Click(object sender, EventArgs e)
		{
			Fields addField = new Fields();
			addField.FieldName = txtFieldName.Text;
			addField.FieldSize = Convert.ToInt32(nudFieldSize.Value);
			addField.FieldSuitability = txtFieldSuitability.Text;

			_fieldBank.AddFieldToList(addField);
			refresh();
		}

		private void btnUpdateField_Click(object sender, EventArgs e)
        {
            try
            {
                Fields editField = new Fields();
                editField.FieldId = Convert.ToInt32(txtFieldId.Text);
                editField.FieldName = txtFieldName.Text;
                editField.FieldSize = Convert.ToInt32(nudFieldSize.Value);
                editField.FieldSuitability = txtFieldSuitability.Text;

                _fieldBank.UpdateField(editField);
                refresh();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Select a Field First");
                Console.WriteLine(exception);
            }
		}

		private void btnFieldClose_Click(object sender, EventArgs e) => Close();

		private void btnFieldClear_Click(object sender, EventArgs e)
		{
			_fieldBank.RefreshConnection();
			ShowField(_fieldBank.FieldList);

			ResetForm();
		}


	}
}