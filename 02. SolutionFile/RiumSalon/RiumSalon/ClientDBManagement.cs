using RiumSalon.JSClasses;
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

        // ClientDBManagement_Load loads all client records on file
        private void ClientDBManagement_Load(object sender, EventArgs e)
        {
            RebuildStockList();
        }

        // RebuildStockList displays the StockName and returns the StockId as the ListBox’s value.
        // The Stock names are displayed in alphabetical order.
        private void RebuildStockList(int clientId = 0)
        {
            List<JSClient> clients = JSClient.JSGetClients();

            // The Stock names are displayed in alphabetical order.
            clients = clients.OrderBy(a => a.ClientName).ToList();

            // it displays the StockName and returns the StockId as the ListBox’s value
            lstboxNav.DisplayMember = "ClientName";
            lstboxNav.ValueMember = "ClientId";
            lstboxNav.DataSource = clients;

            // stockId type is integer => SelectedValue Type = integer
            if (clientId != 0)
                lstboxNav.SelectedValue = clientId;
        }

        // lstStock_SelectedIndexChanged is for When the user selects a Stock, that Stock’s properties are loaded to the input areas.
        private void lstboxNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            // When the user selects a Stock, that Stock’s properties are loaded to the input areas.
            JSClient client = JSClient.JSGetByClientId(int.Parse(lstboxNav.SelectedValue.ToString()));
            if (client != null)
            {
                txtClientId.Text = client.ClientId.ToString();
                txtName.Text = client.ClientName.ToString();
                txtPhone.Text = client.ClientPhone.ToString();
                txtEmail.Text = client.ClientEmail.ToString();
                rtxtNotes.Text = client.ClientNotes.ToString();

                // When a record is selected in the ListBox, this should shout “this is an update!”.
                lblMessage.Text += "This is an update.\n";
            }
            else
            {
                lblMessage.Text = $"The StockId not found: {lstboxNav.SelectedValue}";
            }
        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youcancallmej.github.io/");
        }

        // btnClearInputs_Click ready the input areas for a new record.
        // It also signals “this is a new record”.
        // StockId should be set to zero for a new item.
        private void btnClearProfile_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            txtClientId.Text = "0";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            rtxtNotes.Text = "";

            lblMessage.Text += "This is a new record.\n";
        }

        // btnSaveProfile_Click creates a new JSClient object, loads it from the input areas
        // and passes it to the object’s Add or Update method
        // It checks for numbers and Booleans before stuffing them into the object’s properties.
        // Error messages and Exceptions are displayed in a red label or a rich text box, one line per message.
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            JSClient client = new JSClient();

            // Validation might be here....
            if (int.TryParse(txtClientId.Text, out int clientId))
            {
                client.ClientId = clientId;
            }
            else
            {
                lblMessage.Text += "ClientId should be a integer number.\n";
            }

            // Validation might be here....
            client.ClientName = txtName.Text;
            client.ClientPhone = txtPhone.Text;
            client.ClientEmail = txtEmail.Text;
            client.ClientNotes = rtxtNotes.Text;            

            if (lblMessage.Text != "")
            {
                return;
            }

            try
            {
                // When the user successfully adds a new Stock or updates an existing Stock: 
                // The ListBox needs to be reloaded and resorted, and the modified/new record selected.
                if (client.ClientId == 0)
                {
                    client.JSAdd(client);
                    RebuildStockList(client.ClientId);
                    lblMessage.Text = $"The record with Name '{client.ClientName}' is added.\n";
                }
                else
                {
                    client.JSUpdate(client);
                    RebuildStockList(client.ClientId);
                    lblMessage.Text = $"The record with Name '{client.ClientName}' is updated.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text += ex.Message;
            }
        }

        // btnCancel_Click returns the input areas to their values before the user cleared or modified them.
        // What remembers the original StockId, whether it was an update or add that was cancelled?
        private void btnCancelProfile_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                if (!(lstboxNav.SelectedIndex == -1))
                {
                    JSClient stock = JSClient.JSGetByClientId(int.Parse(lstboxNav.SelectedValue.ToString()));
                    RebuildStockList(stock.ClientId);
                    lblMessage.Text = "Canceled.\n";
                }
                else
                {
                    lblMessage.Text += "The list is empty.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text += ex.Message;
            }
        }

        // btnDelete_Click deletes the recrod with the given StockId from the file
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            try
            {
                DialogResult result = MessageBox.Show("Do you want delete " + txtName.Text + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // When the user deletes an existing record:
                    // The ListBox needs to be reloaded, and have the record after
                    // the one deleted selected (or the last record, if the user deleted the prior last record).
                    int index = lstboxNav.SelectedIndex;

                    if (index + 1 == lstboxNav.Items.Count)
                    {
                        --index;
                    }

                    if ((lstboxNav.SelectedIndex == -1) || txtClientId.Text == "0")
                    {
                        lblMessage.Text += "You should select a stock to delete.\n";
                    }
                    else
                    {
                        JSClient stock = JSClient.JSGetByClientId(int.Parse(lstboxNav.SelectedValue.ToString()));
                        stock.JSDelete(txtClientId.Text);
                        RebuildStockList();
                        lstboxNav.SelectedIndex = index;
                        lblMessage.Text = $"The record with Stock ID '{stock.ClientId}' is deleted.\n";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text += ex.Message;
            }
        }
    }
}
