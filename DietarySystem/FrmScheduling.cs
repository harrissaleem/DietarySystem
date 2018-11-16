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
        User use;
        public FrmScheduling()
        {
            InitializeComponent();
            TogglePanels(99);
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
                use.Hide();
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
                    }
                    lbl.Show();
                    break;

                case 5:
                    if (use == null)
                    {
                        use = new User();
                        use.MdiParent = this;
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
    }
}
