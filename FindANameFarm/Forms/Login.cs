using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FindANameFarm.MetaLayer;
using FindANameFarm.Properties;

namespace FindANameFarm.Forms
{
    public partial class Login : Form
    
    {
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
                    MessageBox.Show(Resources.Login_btnLogin_Click_Your_employee_number_and_password_don_t_match__please_try_again);
                }
                else 
                {
                    if (validLogin[0].Role == "Manager")
                    {
                        Hide();
                        Main main = new Main();
                        main.Show();
                    }
                    else
                    {
                        Staff labourer = validLogin[0];
                        Hide();
                        StaffWorkSheet ws = new StaffWorkSheet(labourer);
                        ws.Show();
                        
                    }
                }
            }
            catch (Exception )
            {
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
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
