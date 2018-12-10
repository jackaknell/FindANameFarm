using FindANameFarm.Banks;
using FindANameFarm.BasicClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FindANameFarm.Forms
{
    /// <summary>
    /// Jason 
    /// creates/edits a field
    /// </summary>
    public partial class FieldsForm : Form
	{
		private FieldBank _fieldBank = FieldBank.GetInst();
        //constructor
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
			listField.Columns.Add("Field Name", 100);
			listField.Columns.Add("Field Size", 100);
			listField.Columns.Add("Suitability of Field", 100);
		}
        //shows the list of fields
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
        //allows the user to select a field and show its details
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
        //resets the form
		private void ResetForm()
		{
			txtFieldId.Text = "";
			txtFieldName.Text = "";
			nudFieldSize.Value = 0;
			txtFieldSuitability.Text = "";
		}
        //refreshes the lists/database and resets the form
		private void refresh()
		{
			_fieldBank.RefreshConnection();
			ShowField(_fieldBank.FieldList);

			ResetForm();
		}
        //adds a field to the database
		private void btnFieldCreate_Click(object sender, EventArgs e)
		{
			Fields addField = new Fields();
			addField.FieldName = txtFieldName.Text;
			addField.FieldSize = Convert.ToInt32(nudFieldSize.Value);
			addField.FieldSuitability = txtFieldSuitability.Text;

			_fieldBank.AddFieldToList(addField);
			refresh();
		}
        //updates a field in the database
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
        //closes the form
		private void btnFieldClose_Click(object sender, EventArgs e) => Close();
        //clears the form
		private void btnFieldClear_Click(object sender, EventArgs e)
		{
			_fieldBank.RefreshConnection();
			ShowField(_fieldBank.FieldList);

			ResetForm();
		}


	}
}