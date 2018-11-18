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
    public partial class FrmScheduling : Form
    {
        Labellers lbl;
        AddUser use;
        public FrmScheduling()
        {
            InitializeComponent();
            TogglePanels(99);
            this.WindowState = FormWindowState.Maximized;
        }

        private void createBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePanels(1);
        }

        void TogglePanels(int i)
        {
            pnlCancel.Visible = false;
            pnlCreate.Visible = false;
            lblCurrentBook.Visible = false;

            if(lbl != null)
            lbl.Hide();

            if (use != null)
            {
                use.Hide();
            }
                
            switch (i)
            {
                case 1:
                    pnlCreate.Visible = true;
                    btnSubmit.Text = "Submit";
                    break;

                case 2:
                    pnlCreate.Visible = true;
                    btnSubmit.Text = "Update";
                    lblCurrentBook.Visible = true;
                    break;

                case 3:
                    pnlCancel.Visible = true;
                    break;

                case 4:
                    if (lbl == null)
                    {
                        lbl = new Labellers();
                        lbl.MdiParent = this;
                        lbl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                        lbl.Dock = DockStyle.Fill;
                    }
                    lbl.Show();
                    break;

                case 5:
                    if (use == null)
                    {
                        use = new AddUser();
                        use.MdiParent = this;
                        use.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                        use.Dock = DockStyle.Fill;
                    }
                    use.Show();
                    break;
                default:
                    break;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePanels(2);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePanels(3);
        }

        private void labellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePanels(4);
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePanels(5);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your booking has been created", "Successful");
            TogglePanels(99);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your booking has been cancelled", "Successful");
            TogglePanels(99);
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you really wish to Logout?", "Logout", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
            else
            {

            }

           
        }
    }
}
