using System;
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
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
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

                int validLogin = _metaLayer.GetLogin(login);

                if (validLogin == 0)
                {
                    MessageBox.Show(Resources.Login_btnLogin_Click_Your_employee_number_and_password_don_t_match__please_try_again);
                }
                else
                {
                    Hide();
                    Main main = new Main();
                    main.Show();
                }
            }
            catch (Exception )
            {
                MessageBox.Show(Resources.Login_btnLogin_Click_Please_enter_both_your_employee_number_and_your_password);

                
            }
           
            
     

          
        }

       
    }
}
