using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiumSalon
{
    public partial class RiumSalonMain : Form
    {
        /*
         * RiumSalonMain.cs
         *      Rium Salon Coiffure Main Mangement Program
         * Revision history
         *      Junseo Yang, 2021.06.11 Created
         */

        public RiumSalonMain()
        {
            InitializeComponent();
        }

        private void btnClientDBManagement_Click(object sender, EventArgs e)
        {
            ClientDBManagement clientDBManagement = new ClientDBManagement();
            clientDBManagement.Show();
        }

        private void btnProductMangement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not prepared yet. See you sometime soon!", "Coming soon!", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youcancallmej.github.io/");
        }
    }
}
