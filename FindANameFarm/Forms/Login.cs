using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.Forms.Reports;
using FindANameFarm.MetaLayer;
using FindANameFarm.Properties;

namespace FindANameFarm.Forms
{
    public partial class Login : Form

    {
        private const string Log = "Login Failed ";
        private MaintenanceAndErrorLog _log = MaintenanceAndErrorLog.GetInst();
        private BusinessMetaLayer _metaLayer = BusinessMetaLayer.GetInstance();
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtLoginId;
            txtLoginId.Focus();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Staff login = new Staff();
                {
                    login.StaffId = Convert.ToInt32(txtLoginId.Text);
                    login.Password = txtLoginPassword.Text;
                }

                List<Staff> validLogin = _metaLayer.GetLogin(login);

                if (validLogin.Count == 0)
                {
                    _log.LogEntry(Log);
                    MessageBox.Show(Resources.Login_btnLogin_Click_Your_employee_number_and_password_don_t_match__please_try_again);
                    
                }
                else 
                {
                    if (validLogin[0].Role == "Manager")
                    {
                        _log.LogEntry("Manager Login:" +validLogin[0].FirstName +" "+ validLogin[0].SurName);
                        Hide();
                        Main main = new Main();
                        main.Show();

                    }
                    else
                    {
                        _log.LogEntry("Staff Login:" + validLogin[0].FirstName + " " + validLogin[0].SurName);
                        Staff labourer = validLogin[0];
                        Hide();
                        StaffWorkSheet ws = new StaffWorkSheet(labourer);
                        ws.Show();
                        
                    }
                }
            }
            catch (Exception )
            {
                _log.LogEntry(Log);
                MessageBox.Show(Resources.Error);
            }
 
        }

        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult message = MessageBox.Show(Resources.Exit_message, Resources.Exit_Title, MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
