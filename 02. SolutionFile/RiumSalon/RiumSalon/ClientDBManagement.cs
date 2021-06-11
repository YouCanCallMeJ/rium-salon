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
    public partial class ClientDBManagement : Form
    {
        /*
         * ClientDBManagement.cs
         *      Rium Salon Coiffure Client DB Mangement Program
         * Revision history
         *      Junseo Yang, 2021.06.11 Created
         */

        public ClientDBManagement()
        {
            InitializeComponent();
        }

        private void lstboxNav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youcancallmej.github.io/");
        }
    }
}
