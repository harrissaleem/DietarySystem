using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietarySystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblStatus.Visible = false;
            TogglePanels(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("sad") && txtPassword.Text.Equals("sad"))
            {
                this.Close();
                FrmScheduling frmSch = new FrmScheduling();
                frmSch.Show();
            }
            else
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Wromg credentials";
            }                        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration frm = new frmRegistration();
            frm.Show();
                        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            TogglePanels(2);
        }

        void TogglePanels(int i)
        {
            pnlLogin.Visible = false;
            pnlForgot.Visible = false;
            switch (i)
            {
                
                case 1:
                    pnlLogin.Visible = true;
                    break;

                case 2:
                    pnlForgot.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TogglePanels(1);
        }
    }
}
