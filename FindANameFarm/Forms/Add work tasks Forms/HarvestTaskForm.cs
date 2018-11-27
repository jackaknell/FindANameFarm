using FindANameFarm.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FindANameFarm.WorkTaskClasses;


namespace FindANameFarm.Forms
{
    public partial class HarvestTaskForm : Form
    {

        private readonly FieldBank _field = FieldBank.GetInst();
        private readonly StaffBank _staff = StaffBank.GetInst();
        private readonly CropsBank _crop = CropsBank.GetInst();
        private readonly VehicleBank _vehicleBank = VehicleBank.GetInst();
        private readonly WorkTaskBank _workTask = WorkTaskBank.GetInst();
        private string _taskType = "Harvesting";

        public HarvestTaskForm()
        {
            InitializeComponent();
            //ResetForm();

            Refresh();
        }

        private void HarvestTaskForm_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = !string.IsNullOrEmpty(txtHarvestID.Text);
            
        }

       
    }
}
