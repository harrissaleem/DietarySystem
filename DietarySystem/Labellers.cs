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
    public partial class Labellers : Form
    {
        public Labellers()
        {
            InitializeComponent();
            dgv.Rows.Add(new object[] { "Session1", "24/11/18 - 2:00 PM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session2", "25/11/18 - 3:00 PM", "Completed", "Done" });
            dgv.Rows.Add(new object[] { "Session3", "25/11/18 - 12:00 PM", "Editing", "Please fix few parts of the video" });
            dgv.Rows.Add(new object[] { "Session4", "25/11/18 - 8:00 AM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session5", "26/11/18 - 10:00 AM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session6", "26/11/18 - 2:00 PM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session7", "26/11/18 - 12:00 PM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session8", "26/11/18 - 8:00 AM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session9", "27/11/18 - 11:00 AM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session10", "27/11/18 - 10:00 AM", "Editing", "Videos are currently in annotation" });
            dgv.Rows.Add(new object[] { "Session11", "27/11/18 - 11:00 AM", "Editing", "Videos are currently in annotation" });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Video annotation state updated", "Successful");
        }
    }
}
