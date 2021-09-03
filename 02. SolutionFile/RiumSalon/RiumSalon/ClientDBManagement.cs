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
            RebuildClientList();
        }

        // RebuildStockList displays the ClientName and returns the StockId as the ListBox’s value.
        // The Client names are displayed in alphabetical order.
        private void RebuildClientList(int clientId = 0)
        {
            List<JSClient> clients = JSClient.JSGetClients();

            // The Client names are displayed in alphabetical order.
            clients = clients.OrderBy(a => a.ClientName).ToList();

            // it displays the ClientName and returns the StockId as the ListBox’s value
            lstboxNavClient.DisplayMember = "ClientName";
            lstboxNavClient.ValueMember = "ClientId";
            lstboxNavClient.DataSource = clients;

            // clientId type is integer => SelectedValue Type = integer
            if (clientId != 0)
                lstboxNavClient.SelectedValue = clientId;
        }

        // lstboxNav_SelectedIndexChanged is for When the user selects a Client, that Client’s properties are loaded to the input areas.
        private void lstboxNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageProfile.Text = "";

            // When the user selects a Client, that Client’s properties are loaded to the input areas.
            JSClient client = JSClient.JSGetByClientId(int.Parse(lstboxNavClient.SelectedValue.ToString()));
            if (client != null)
            {
                txtClientId.Text = client.ClientId.ToString();
                txtName.Text = client.ClientName.ToString();
                txtPhone.Text = client.ClientPhone.ToString();
                txtEmail.Text = client.ClientEmail.ToString();
                rtxtNotes.Text = client.ClientNotes.ToString();

                // When a record is selected in the ListBox, this should shout “this is an update!”.
                lblMessageProfile.Text += "This is an update.\n";

                // Display Visit Hsitory
                RebuildVisitRecordList(client.ClientId);
            }
            else
            {
                lblMessageProfile.Text = $"The ClientId not found: {lstboxNavClient.SelectedValue}";
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
            lblMessageProfile.Text = "";

            txtClientId.Text = "0";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            rtxtNotes.Text = "";

            lblMessageProfile.Text += "This is a new record.\n";
        }

        // btnSaveProfile_Click creates a new JSClient object, loads it from the input areas
        // and passes it to the object’s Add or Update method
        // It checks for numbers and Booleans before stuffing them into the object’s properties.
        // Error messages and Exceptions are displayed in a red label or a rich text box, one line per message.
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            lblMessageProfile.Text = "";

            JSClient client = new JSClient();

            // Validation might be here....
            if (int.TryParse(txtClientId.Text, out int clientId))
            {
                client.ClientId = clientId;
            }
            else
            {
                lblMessageProfile.Text += "ClientId should be a integer number.\n";
            }

            // Validation might be here....
            client.ClientName = txtName.Text;
            client.ClientPhone = txtPhone.Text;
            client.ClientEmail = txtEmail.Text;
            client.ClientNotes = rtxtNotes.Text;

            if (lblMessageProfile.Text != "")
            {
                return;
            }

            try
            {
                int index = lstboxNavClient.SelectedIndex;

                // When the user successfully adds a new Stock or updates an existing Stock: 
                // The ListBox needs to be reloaded and resorted, and the modified/new record selected.
                if (client.ClientId == 0)
                {
                    client.JSAdd(client);
                    RebuildClientList(client.ClientId);
                    lblMessageProfile.Text = $"The record with Name '{client.ClientName}' is added.\n";
                }
                else
                {
                    client.JSUpdate(client);
                    RebuildClientList(client.ClientId);
                    lstboxNavClient.SelectedIndex = index;
                    lblMessageProfile.Text = $"The record with Name '{client.ClientName}' is updated.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessageProfile.Text += ex.Message;
            }
        }

        // btnCancel_Click returns the input areas to their values before the user cleared or modified them.
        // What remembers the original StockId, whether it was an update or add that was cancelled?
        private void btnCancelProfile_Click(object sender, EventArgs e)
        {
            lblMessageProfile.Text = "";
            try
            {
                if (!(lstboxNavClient.SelectedIndex == -1))
                {
                    JSClient client = JSClient.JSGetByClientId(int.Parse(lstboxNavClient.SelectedValue.ToString()));
                    RebuildClientList(client.ClientId);
                    lblMessageProfile.Text = "Canceled.\n";
                }
                else
                {
                    lblMessageProfile.Text += "The list is empty.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessageProfile.Text += ex.Message;
            }
        }

        // btnDelete_Click deletes the recrod with the given StockId from the file
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            lblMessageProfile.Text = "";

            try
            {                
                // When the user deletes an existing record:
                // The ListBox needs to be reloaded, and have the record after
                // the one deleted selected (or the last record, if the user deleted the prior last record).
                if ((lstboxNavClient.SelectedIndex == -1) || txtClientId.Text == "0")
                {
                    lblMessageProfile.Text += "You should select a client to delete.\n";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want delete " + txtName.Text + "?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        int index = lstboxNavClient.SelectedIndex;

                        if (index + 1 == lstboxNavClient.Items.Count)
                        {
                            --index;
                        }

                        JSClient client = JSClient.JSGetByClientId(int.Parse(lstboxNavClient.SelectedValue.ToString()));
                        client.JSDelete(txtClientId.Text);
                        RebuildClientList();
                        lstboxNavClient.SelectedIndex = index;
                        lblMessageProfile.Text = $"The record with Client ID '{client.ClientId}' is deleted.\n";
                    }                            
                }
            }
            catch (Exception ex)
            {
                lblMessageProfile.Text += ex.Message;
            }
        }



        /* Manage Visit Record */
        // RebuildVisitRecordList displays the ClientName and returns the RecordId as the ListBox’s value.
        // The Client names are displayed in alphabetical order.
        private void RebuildVisitRecordList(int clientId = 0)
        {
            List<JSVisitRecord> jSVisitRecordsByClientId = JSVisitRecord.JSGetVisitRecordsByClientId(clientId);

            // The Client names are displayed in alphabetical order.
            jSVisitRecordsByClientId = jSVisitRecordsByClientId.OrderBy(a => a.Date).ToList();

            // it displays the ClientName and returns the RecordId as the ListBox’s value
            lstboxNavVisitRecord.DisplayMember = "Date";
            lstboxNavVisitRecord.ValueMember = "RecordId";
            lstboxNavVisitRecord.DataSource = jSVisitRecordsByClientId;
        }

        // lstboxNavVisitRecord_SelectedIndexChanged is for When the user selects a visit record, that visit record’s properties are loaded to the input areas.
        private void lstboxNavVisitRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessageVisitRecord.Text = "";

            try
            {
                // When the user selects a Visit Record, that Visit Record’s properties are loaded to the input areas.
                List<JSVisitRecord> jSVisitRecordsByClientId = JSVisitRecord.JSGetVisitRecordsByClientId(int.Parse(txtClientId.Text));

                JSVisitRecord jSVisitRecord = JSVisitRecord.JSGetByRecordId(int.Parse(lstboxNavVisitRecord.SelectedValue.ToString()));

                if (jSVisitRecord != null)
                {
                    txtRecordId.Text = jSVisitRecord.RecordId.ToString();
                    txtVisitRecordClientId.Text = jSVisitRecord.ClientId.ToString();
                    txtVisitRecordClientName.Text = jSVisitRecord.ClientName.ToString();
                    txtService.Text = jSVisitRecord.Service.ToString();
                    cmbboxWorker.SelectedItem = jSVisitRecord.Worker.ToString();
                    txtPrice.Text = jSVisitRecord.Price.ToString();
                    txtTipsDollar.Text = jSVisitRecord.Tips.ToString();
                    cmbboxMethod.SelectedItem = jSVisitRecord.Method.ToString();
                    txtGST.Text = jSVisitRecord.GST.ToString();
                    txtQST.Text = jSVisitRecord.QST.ToString();
                    txtTotal.Text = jSVisitRecord.Total.ToString();
                    dtDate.Value = jSVisitRecord.Date;
                    dtStart.Text = jSVisitRecord.Start;
                    dtEnd.Text = jSVisitRecord.End;
                    cmbboxStatus.SelectedItem = jSVisitRecord.Status.ToString();
                    rtxtSpecialRequest.Text = jSVisitRecord.SpecialRequest.ToString();

                    // When a record is selected in the ListBox, this should shout “this is an update!”.
                    lblMessageVisitRecord.Text += "This is an update.\n";
                }
                else
                {
                    lblMessageVisitRecord.Text = $"The Visit Record is empty.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessageVisitRecord.Text += ex.Message;
            }
        }

        // btnClearInputs_Click ready the input areas for a new record.
        // It also signals “this is a new record”.
        // RecordId should be set to zero for a new item.
        private void btnClearVisitHistory_Click(object sender, EventArgs e)
        {
            lblMessageVisitRecord.Text = "";

            txtRecordId.Text = "0";
            txtVisitRecordClientId.Text = txtClientId.Text;
            txtVisitRecordClientName.Text = txtName.Text;
            txtService.Text = "";
            txtPrice.Text = "";
            txtTipsDollar.Text = "";
            txtGST.Text = "";
            txtQST.Text = "";
            txtTotal.Text = "";
            rtxtSpecialRequest.Text = "";

            lblMessageVisitRecord.Text += "This is a new record.\n";
        }

        // btnSaveProfile_Click creates a new JSClient object, loads it from the input areas
        // and passes it to the object’s Add or Update method
        // It checks for numbers and Booleans before stuffing them into the object’s properties.
        // Error messages and Exceptions are displayed in a red label or a rich text box, one line per message.
        private void btnSaveVisitHistory_Click(object sender, EventArgs e)
        {
            lblMessageVisitRecord.Text = "";

            JSVisitRecord jSVisitRecord = new JSVisitRecord();

            // Validation might be here....
            if (int.TryParse(txtRecordId.Text, out int recordId))
            {
                jSVisitRecord.RecordId = recordId;
            }
            else
            {
                lblMessageVisitRecord.Text += "RecordId should be a integer number.\n";
            }

            // Validation might be here....
            if (int.TryParse(txtVisitRecordClientId.Text, out int visitRecordClientId))
            {
                jSVisitRecord.ClientId = visitRecordClientId;
            }
            else
            {
                lblMessageVisitRecord.Text += "Client ID should be a integer number.\n";
            }
            jSVisitRecord.ClientName = txtVisitRecordClientName.Text;
            jSVisitRecord.Service = txtService.Text;
            jSVisitRecord.Worker = cmbboxWorker.Text;
            
            if (Double.TryParse(txtPrice.Text, out Double price))
            {
                jSVisitRecord.Price = price;
            }
            else
            {
                lblMessageVisitRecord.Text += "Price should be a double number.\n";
            }
            if (Double.TryParse(txtTipsDollar.Text, out Double tip))
            {
                jSVisitRecord.Tips = tip;
            }
            else
            {
                lblMessageVisitRecord.Text += "Tips should be a double number.\n";
            }
            jSVisitRecord.Method = cmbboxMethod.Text;
            if (Double.TryParse(txtGST.Text, out Double gst))
            {
                jSVisitRecord.GST = gst;
            }
            else
            {
                lblMessageVisitRecord.Text += "GST should be a double number.\n";
            }
            if (Double.TryParse(txtQST.Text, out Double qst))
            {
                jSVisitRecord.QST = qst;
            }
            else
            {
                lblMessageVisitRecord.Text += "QST should be a double number.\n";
            }
            if (Double.TryParse(txtTotal.Text, out Double total))
            {
                jSVisitRecord.Total = total;
            }
            else
            {
                lblMessageVisitRecord.Text += "Total should be a double number.\n";
            }
            if (DateTime.TryParse(dtDate.Text, out DateTime dtdate))
            {
                jSVisitRecord.Date = dtdate;
            }
            else
            {
                lblMessageVisitRecord.Text += "Date should be in a Date format.\n";
            }
            
            jSVisitRecord.Start = dtStart.Text;
            jSVisitRecord.End = dtEnd.Text;
            jSVisitRecord.Status= cmbboxStatus.Text;
            jSVisitRecord.SpecialRequest = rtxtSpecialRequest.Text;


            if (lblMessageVisitRecord.Text != "")
            {
                return;
            }

            try
            {
                // When the user successfully adds a new Stock or updates an existing Stock: 
                // The ListBox needs to be reloaded and resorted, and the modified/new record selected.
                if (jSVisitRecord.RecordId == 0)
                {
                    jSVisitRecord.JSAdd(jSVisitRecord);
                    RebuildVisitRecordList(jSVisitRecord.ClientId);
                    lblMessageVisitRecord.Text = $"The Visit Record with ClientName '{jSVisitRecord.ClientName}' is added.\n";
                }
                else
                {
                    jSVisitRecord.JSUpdate(jSVisitRecord);

                    int index = lstboxNavVisitRecord.SelectedIndex;
                    RebuildVisitRecordList(jSVisitRecord.ClientId);
                    lstboxNavVisitRecord.SelectedIndex = index;
                    lblMessageVisitRecord.Text = $"The Visit Record with ClientName '{jSVisitRecord.ClientName}' is updated.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessageVisitRecord.Text += ex.Message;
            }
        }

        // btnCancelVisitHistory_Click returns the input areas to their values before the user cleared or modified them.
        // What remembers the original StockId, whether it was an update or add that was cancelled?
        private void btnCancelVisitHistory_Click(object sender, EventArgs e)
        {
            lblMessageVisitRecord.Text = "";
            try
            {
                int index = lstboxNavVisitRecord.SelectedIndex;

                if (lstboxNavVisitRecord.SelectedIndex != -1)
                {
                    
                    JSVisitRecord jSVisitRecord = JSVisitRecord.JSGetByRecordId(int.Parse(lstboxNavVisitRecord.SelectedIndex.ToString()));
                    RebuildVisitRecordList(jSVisitRecord.ClientId);
                    lstboxNavVisitRecord.SelectedIndex = index;
                    lblMessageProfile.Text = "Canceled.\n";
                }
                else
                {
                    lblMessageProfile.Text += "The list is empty.\n";
                }
            }
            catch (Exception ex)
            {
                lblMessageProfile.Text += ex.Message;
            }
        }

        // btnCalculate_Click calculates and autofill GST, QST and Total
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblMessageVisitRecord.Text = "";

            // Validation for Calculation
            if (Double.TryParse(txtPrice.Text, out Double price) && Double.TryParse(txtTipsDollar.Text, out Double tip))
            {
                Double gst = Math.Round(price * 0.05, 2);
                Double qst = Math.Round(price * 0.09975, 2);

                txtGST.Text = gst.ToString();
                txtQST.Text = qst.ToString();
                txtTotal.Text = (price + tip + gst + qst).ToString();
            }
            else
            {
                lblMessageVisitRecord.Text += "The Price/Tips is empty.\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtService.Text = "Women's Haircut";
            cmbboxWorker.Text = "Marie";
            txtPrice.Text = "119";
            txtTipsDollar.Text = "27.36";
            cmbboxMethod.Text = "VISA";
            txtGST.Text = "5.95";
            txtQST.Text = "11.87";
            txtTotal.Text = "164.18";
            cmbboxStatus.Text = "confirmed";
        }

        // btnDelete_Click deletes the recrod with the given StockId from the file
        private void btnDeleteVisitHistory_Click(object sender, EventArgs e)
        {

            lblMessageVisitRecord.Text = "";

            try
            {
                // When the user deletes an existing record:
                // The ListBox needs to be reloaded, and have the record after
                // the one deleted selected (or the last record, if the user deleted the prior last record).
                if (txtRecordId.Text == "0" || txtRecordId.Text == "")
                {
                    lblMessageVisitRecord.Text += "You should select a client to delete.\n";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want delete Visit Record with Record ID '" + txtRecordId.Text + "'?", "Delete Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        int index = lstboxNavVisitRecord.SelectedIndex;

                        if (index + 1 == lstboxNavVisitRecord.Items.Count)
                        {
                            --index;
                        }

                        
                        JSVisitRecord jSVisitRecord = JSVisitRecord.JSGetByRecordId(int.Parse(lstboxNavVisitRecord.SelectedIndex.ToString()));
                        jSVisitRecord.JSDelete(txtRecordId.Text);
                        RebuildVisitRecordList();
                        lstboxNavVisitRecord.SelectedIndex = index;
                        lblMessageVisitRecord.Text = $"The record with Record ID '{jSVisitRecord.RecordId}' is deleted.\n";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessageVisitRecord.Text += ex.Message;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
