
namespace RiumSalon
{
    partial class ClientDBManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDBManagement));
            this.lstboxNavClient = new System.Windows.Forms.ListBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtxtNotes = new System.Windows.Forms.RichTextBox();
            this.btnClearProfile = new System.Windows.Forms.Button();
            this.btnCancelProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.grpboxEditVisitRecordManually = new System.Windows.Forms.GroupBox();
            this.cmbboxService = new System.Windows.Forms.ComboBox();
            this.cmbboxTipsPercent = new System.Windows.Forms.ComboBox();
            this.lblTipsDollar = new System.Windows.Forms.Label();
            this.lblMessageVisitRecord = new System.Windows.Forms.Label();
            this.cmbboxStatus = new System.Windows.Forms.ComboBox();
            this.lblVisitRecordClientName = new System.Windows.Forms.Label();
            this.txtVisitRecordClientName = new System.Windows.Forms.TextBox();
            this.lblVisitRecordClientId = new System.Windows.Forms.Label();
            this.txtVisitRecordClientId = new System.Windows.Forms.TextBox();
            this.cmbboxWorker = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbboxMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTipsPercent = new System.Windows.Forms.Label();
            this.txtTipsDollar = new System.Windows.Forms.TextBox();
            this.lblQST = new System.Windows.Forms.Label();
            this.txtQST = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.btnDeleteVisitHistory = new System.Windows.Forms.Button();
            this.lblSpecialRequest2 = new System.Windows.Forms.Label();
            this.btnCancelVisitHistory = new System.Windows.Forms.Button();
            this.rtxtSpecialRequest = new System.Windows.Forms.RichTextBox();
            this.btnSaveVisitHistory = new System.Windows.Forms.Button();
            this.lblSpecialRequest1 = new System.Windows.Forms.Label();
            this.btnClearVisitHistory = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblRecordId = new System.Windows.Forms.Label();
            this.txtRecordId = new System.Windows.Forms.TextBox();
            this.grpboxClientProfile = new System.Windows.Forms.GroupBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.grpboxNav = new System.Windows.Forms.GroupBox();
            this.grpboxViewVisitRecord = new System.Windows.Forms.GroupBox();
            this.lstboxNavVisitRecord = new System.Windows.Forms.ListBox();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessageProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.grpboxEditVisitRecordManually.SuspendLayout();
            this.grpboxClientProfile.SuspendLayout();
            this.grpboxNav.SuspendLayout();
            this.grpboxViewVisitRecord.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxNavClient
            // 
            this.lstboxNavClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstboxNavClient.FormattingEnabled = true;
            this.lstboxNavClient.ItemHeight = 20;
            this.lstboxNavClient.Location = new System.Drawing.Point(3, 21);
            this.lstboxNavClient.Name = "lstboxNavClient";
            this.lstboxNavClient.Size = new System.Drawing.Size(168, 238);
            this.lstboxNavClient.TabIndex = 0;
            this.lstboxNavClient.SelectedIndexChanged += new System.EventHandler(this.lstboxNav_SelectedIndexChanged);
            // 
            // lblClientId
            // 
            this.lblClientId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(6, 21);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(56, 20);
            this.lblClientId.TabIndex = 99;
            this.lblClientId.Text = "Client ID";
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(68, 21);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(383, 25);
            this.txtClientId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.Location = new System.Drawing.Point(68, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(383, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 20);
            this.lblName.TabIndex = 99;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 20);
            this.lblPhone.TabIndex = 99;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(68, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(383, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 20);
            this.lblEmail.TabIndex = 99;
            this.lblEmail.Text = "E-Mail";
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.AccessibleDescription = "Profile Picture";
            this.picProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picProfilePicture.ErrorImage = null;
            this.picProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.Image")));
            this.picProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.InitialImage")));
            this.picProfilePicture.Location = new System.Drawing.Point(457, 21);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.Size = new System.Drawing.Size(134, 129);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePicture.TabIndex = 13;
            this.picProfilePicture.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(6, 160);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 20);
            this.lblNotes.TabIndex = 99;
            this.lblNotes.Text = "Notes";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtxtNotes.Location = new System.Drawing.Point(68, 161);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(523, 59);
            this.rtxtNotes.TabIndex = 4;
            this.rtxtNotes.Text = "";
            // 
            // btnClearProfile
            // 
            this.btnClearProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProfile.Location = new System.Drawing.Point(253, 226);
            this.btnClearProfile.Name = "btnClearProfile";
            this.btnClearProfile.Size = new System.Drawing.Size(80, 30);
            this.btnClearProfile.TabIndex = 6;
            this.btnClearProfile.Text = "Clear";
            this.btnClearProfile.UseVisualStyleBackColor = true;
            this.btnClearProfile.Click += new System.EventHandler(this.btnClearProfile_Click);
            // 
            // btnCancelProfile
            // 
            this.btnCancelProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProfile.Location = new System.Drawing.Point(425, 226);
            this.btnCancelProfile.Name = "btnCancelProfile";
            this.btnCancelProfile.Size = new System.Drawing.Size(80, 30);
            this.btnCancelProfile.TabIndex = 8;
            this.btnCancelProfile.Text = "Cancel";
            this.btnCancelProfile.UseVisualStyleBackColor = true;
            this.btnCancelProfile.Click += new System.EventHandler(this.btnCancelProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteProfile.Location = new System.Drawing.Point(339, 226);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteProfile.TabIndex = 7;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // grpboxEditVisitRecordManually
            // 
            this.grpboxEditVisitRecordManually.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxEditVisitRecordManually.Controls.Add(this.cmbboxService);
            this.grpboxEditVisitRecordManually.Controls.Add(this.cmbboxTipsPercent);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblTipsDollar);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblMessageVisitRecord);
            this.grpboxEditVisitRecordManually.Controls.Add(this.cmbboxStatus);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblVisitRecordClientName);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtVisitRecordClientName);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblVisitRecordClientId);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtVisitRecordClientId);
            this.grpboxEditVisitRecordManually.Controls.Add(this.cmbboxWorker);
            this.grpboxEditVisitRecordManually.Controls.Add(this.btnCalculate);
            this.grpboxEditVisitRecordManually.Controls.Add(this.cmbboxMethod);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblMethod);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblTotal);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtTotal);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblTipsPercent);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtTipsDollar);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblQST);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtQST);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblGST);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtGST);
            this.grpboxEditVisitRecordManually.Controls.Add(this.btnDeleteVisitHistory);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblSpecialRequest2);
            this.grpboxEditVisitRecordManually.Controls.Add(this.btnCancelVisitHistory);
            this.grpboxEditVisitRecordManually.Controls.Add(this.rtxtSpecialRequest);
            this.grpboxEditVisitRecordManually.Controls.Add(this.btnSaveVisitHistory);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblSpecialRequest1);
            this.grpboxEditVisitRecordManually.Controls.Add(this.btnClearVisitHistory);
            this.grpboxEditVisitRecordManually.Controls.Add(this.dtEnd);
            this.grpboxEditVisitRecordManually.Controls.Add(this.dtStart);
            this.grpboxEditVisitRecordManually.Controls.Add(this.dtDate);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblStatus);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblEnd);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblStart);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblDate);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblWorker);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblPrice);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtPrice);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblService);
            this.grpboxEditVisitRecordManually.Controls.Add(this.lblRecordId);
            this.grpboxEditVisitRecordManually.Controls.Add(this.txtRecordId);
            this.grpboxEditVisitRecordManually.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxEditVisitRecordManually.Location = new System.Drawing.Point(183, 335);
            this.grpboxEditVisitRecordManually.Name = "grpboxEditVisitRecordManually";
            this.grpboxEditVisitRecordManually.Size = new System.Drawing.Size(598, 323);
            this.grpboxEditVisitRecordManually.TabIndex = 22;
            this.grpboxEditVisitRecordManually.TabStop = false;
            this.grpboxEditVisitRecordManually.Text = "Edit Visit Record Manually";
            // 
            // cmbboxService
            // 
            this.cmbboxService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxService.FormattingEnabled = true;
            this.cmbboxService.Items.AddRange(new object[] {
            "Men\'s Bleaching Color",
            "Men\'s Color",
            "Men\'s Perm",
            "Men\'s Sidedown-Perm",
            "Men\'s Haircut",
            "Women\'s Botox Treatment",
            "Women\'s Balayage, Hightlights, Ombre & Color with Design",
            "Women\'s Root Touch Up (Less than 3cm)",
            "Women\'s Color",
            "Women\'s Root Volume / Bang Perm",
            "Women\'s Straight & Wave Permanent",
            "Women\'s Wave / Straight Permanent",
            "Women\'s Blowdry & Styling",
            "Women\'s Bang Cut",
            "Women\'s Haircut"});
            this.cmbboxService.Location = new System.Drawing.Point(78, 66);
            this.cmbboxService.Name = "cmbboxService";
            this.cmbboxService.Size = new System.Drawing.Size(238, 28);
            this.cmbboxService.TabIndex = 100;
            this.cmbboxService.SelectedIndexChanged += new System.EventHandler(this.cmbboxService_SelectedIndexChanged);
            // 
            // cmbboxTipsPercent
            // 
            this.cmbboxTipsPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxTipsPercent.FormattingEnabled = true;
            this.cmbboxTipsPercent.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25"});
            this.cmbboxTipsPercent.Location = new System.Drawing.Point(246, 99);
            this.cmbboxTipsPercent.Name = "cmbboxTipsPercent";
            this.cmbboxTipsPercent.Size = new System.Drawing.Size(70, 28);
            this.cmbboxTipsPercent.TabIndex = 3;
            this.cmbboxTipsPercent.SelectedIndexChanged += new System.EventHandler(this.cmbboxTipsPercent_SelectedIndexChanged);
            // 
            // lblTipsDollar
            // 
            this.lblTipsDollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipsDollar.AutoSize = true;
            this.lblTipsDollar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipsDollar.Location = new System.Drawing.Point(322, 101);
            this.lblTipsDollar.Name = "lblTipsDollar";
            this.lblTipsDollar.Size = new System.Drawing.Size(49, 20);
            this.lblTipsDollar.TabIndex = 99;
            this.lblTipsDollar.Text = "Tips($)";
            // 
            // lblMessageVisitRecord
            // 
            this.lblMessageVisitRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageVisitRecord.AutoSize = true;
            this.lblMessageVisitRecord.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblMessageVisitRecord.ForeColor = System.Drawing.Color.Red;
            this.lblMessageVisitRecord.Location = new System.Drawing.Point(155, 15);
            this.lblMessageVisitRecord.Name = "lblMessageVisitRecord";
            this.lblMessageVisitRecord.Size = new System.Drawing.Size(17, 17);
            this.lblMessageVisitRecord.TabIndex = 80;
            this.lblMessageVisitRecord.Text = "...";
            // 
            // cmbboxStatus
            // 
            this.cmbboxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxStatus.FormattingEnabled = true;
            this.cmbboxStatus.Items.AddRange(new object[] {
            "confirmed",
            "pending",
            "canceled"});
            this.cmbboxStatus.Location = new System.Drawing.Point(427, 159);
            this.cmbboxStatus.Name = "cmbboxStatus";
            this.cmbboxStatus.Size = new System.Drawing.Size(165, 28);
            this.cmbboxStatus.TabIndex = 10;
            // 
            // lblVisitRecordClientName
            // 
            this.lblVisitRecordClientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisitRecordClientName.AutoSize = true;
            this.lblVisitRecordClientName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitRecordClientName.Location = new System.Drawing.Point(322, 40);
            this.lblVisitRecordClientName.Name = "lblVisitRecordClientName";
            this.lblVisitRecordClientName.Size = new System.Drawing.Size(43, 20);
            this.lblVisitRecordClientName.TabIndex = 99;
            this.lblVisitRecordClientName.Text = "Name";
            // 
            // txtVisitRecordClientName
            // 
            this.txtVisitRecordClientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisitRecordClientName.Location = new System.Drawing.Point(382, 37);
            this.txtVisitRecordClientName.Name = "txtVisitRecordClientName";
            this.txtVisitRecordClientName.Size = new System.Drawing.Size(210, 25);
            this.txtVisitRecordClientName.TabIndex = 78;
            // 
            // lblVisitRecordClientId
            // 
            this.lblVisitRecordClientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisitRecordClientId.AutoSize = true;
            this.lblVisitRecordClientId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitRecordClientId.Location = new System.Drawing.Point(169, 39);
            this.lblVisitRecordClientId.Name = "lblVisitRecordClientId";
            this.lblVisitRecordClientId.Size = new System.Drawing.Size(56, 20);
            this.lblVisitRecordClientId.TabIndex = 99;
            this.lblVisitRecordClientId.Text = "Client ID";
            // 
            // txtVisitRecordClientId
            // 
            this.txtVisitRecordClientId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVisitRecordClientId.Location = new System.Drawing.Point(231, 37);
            this.txtVisitRecordClientId.Name = "txtVisitRecordClientId";
            this.txtVisitRecordClientId.Size = new System.Drawing.Size(85, 25);
            this.txtVisitRecordClientId.TabIndex = 76;
            // 
            // cmbboxWorker
            // 
            this.cmbboxWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxWorker.FormattingEnabled = true;
            this.cmbboxWorker.Items.AddRange(new object[] {
            "Daniel",
            "Marie"});
            this.cmbboxWorker.Location = new System.Drawing.Point(382, 66);
            this.cmbboxWorker.Name = "cmbboxWorker";
            this.cmbboxWorker.Size = new System.Drawing.Size(85, 28);
            this.cmbboxWorker.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(462, 128);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbboxMethod
            // 
            this.cmbboxMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbboxMethod.FormattingEnabled = true;
            this.cmbboxMethod.Items.AddRange(new object[] {
            "Master",
            "American Express",
            "VISA",
            "PayPal",
            "Apple Pay",
            "Interac",
            "Debit"});
            this.cmbboxMethod.Location = new System.Drawing.Point(515, 97);
            this.cmbboxMethod.Name = "cmbboxMethod";
            this.cmbboxMethod.Size = new System.Drawing.Size(77, 28);
            this.cmbboxMethod.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(458, 101);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(51, 20);
            this.lblMethod.TabIndex = 99;
            this.lblMethod.Text = "Method";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(322, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 20);
            this.lblTotal.TabIndex = 99;
            this.lblTotal.Text = "Total($)";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Location = new System.Drawing.Point(382, 130);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(70, 25);
            this.txtTotal.TabIndex = 69;
            // 
            // lblTipsPercent
            // 
            this.lblTipsPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipsPercent.AutoSize = true;
            this.lblTipsPercent.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipsPercent.Location = new System.Drawing.Point(154, 101);
            this.lblTipsPercent.Name = "lblTipsPercent";
            this.lblTipsPercent.Size = new System.Drawing.Size(53, 20);
            this.lblTipsPercent.TabIndex = 99;
            this.lblTipsPercent.Text = "Tips(%)";
            // 
            // txtTipsDollar
            // 
            this.txtTipsDollar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipsDollar.Location = new System.Drawing.Point(382, 99);
            this.txtTipsDollar.Name = "txtTipsDollar";
            this.txtTipsDollar.Size = new System.Drawing.Size(70, 25);
            this.txtTipsDollar.TabIndex = 4;
            this.txtTipsDollar.TextChanged += new System.EventHandler(this.txtTipsDollar_TextChanged);
            // 
            // lblQST
            // 
            this.lblQST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQST.AutoSize = true;
            this.lblQST.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQST.Location = new System.Drawing.Point(154, 132);
            this.lblQST.Name = "lblQST";
            this.lblQST.Size = new System.Drawing.Size(86, 20);
            this.lblQST.TabIndex = 99;
            this.lblQST.Text = "QST(9.975%)";
            // 
            // txtQST
            // 
            this.txtQST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQST.Location = new System.Drawing.Point(246, 130);
            this.txtQST.Name = "txtQST";
            this.txtQST.Size = new System.Drawing.Size(70, 25);
            this.txtQST.TabIndex = 65;
            // 
            // lblGST
            // 
            this.lblGST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(7, 132);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(62, 20);
            this.lblGST.TabIndex = 99;
            this.lblGST.Text = "GST(5%)";
            // 
            // txtGST
            // 
            this.txtGST.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGST.Location = new System.Drawing.Point(78, 130);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(70, 25);
            this.txtGST.TabIndex = 63;
            // 
            // btnDeleteVisitHistory
            // 
            this.btnDeleteVisitHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVisitHistory.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteVisitHistory.Location = new System.Drawing.Point(343, 290);
            this.btnDeleteVisitHistory.Name = "btnDeleteVisitHistory";
            this.btnDeleteVisitHistory.Size = new System.Drawing.Size(80, 30);
            this.btnDeleteVisitHistory.TabIndex = 14;
            this.btnDeleteVisitHistory.Text = "Delete";
            this.btnDeleteVisitHistory.UseVisualStyleBackColor = true;
            this.btnDeleteVisitHistory.Click += new System.EventHandler(this.btnDeleteVisitHistory_Click);
            // 
            // lblSpecialRequest2
            // 
            this.lblSpecialRequest2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialRequest2.AutoSize = true;
            this.lblSpecialRequest2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRequest2.Location = new System.Drawing.Point(8, 215);
            this.lblSpecialRequest2.Name = "lblSpecialRequest2";
            this.lblSpecialRequest2.Size = new System.Drawing.Size(55, 20);
            this.lblSpecialRequest2.TabIndex = 99;
            this.lblSpecialRequest2.Text = "Request";
            // 
            // btnCancelVisitHistory
            // 
            this.btnCancelVisitHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelVisitHistory.Location = new System.Drawing.Point(429, 290);
            this.btnCancelVisitHistory.Name = "btnCancelVisitHistory";
            this.btnCancelVisitHistory.Size = new System.Drawing.Size(80, 30);
            this.btnCancelVisitHistory.TabIndex = 15;
            this.btnCancelVisitHistory.Text = "Cancel";
            this.btnCancelVisitHistory.UseVisualStyleBackColor = true;
            this.btnCancelVisitHistory.Click += new System.EventHandler(this.btnCancelVisitHistory_Click);
            // 
            // rtxtSpecialRequest
            // 
            this.rtxtSpecialRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtSpecialRequest.Location = new System.Drawing.Point(78, 192);
            this.rtxtSpecialRequest.Name = "rtxtSpecialRequest";
            this.rtxtSpecialRequest.Size = new System.Drawing.Size(514, 92);
            this.rtxtSpecialRequest.TabIndex = 11;
            this.rtxtSpecialRequest.Text = "";
            // 
            // btnSaveVisitHistory
            // 
            this.btnSaveVisitHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVisitHistory.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveVisitHistory.Location = new System.Drawing.Point(512, 290);
            this.btnSaveVisitHistory.Name = "btnSaveVisitHistory";
            this.btnSaveVisitHistory.Size = new System.Drawing.Size(80, 30);
            this.btnSaveVisitHistory.TabIndex = 12;
            this.btnSaveVisitHistory.Text = "Save";
            this.btnSaveVisitHistory.UseVisualStyleBackColor = true;
            this.btnSaveVisitHistory.Click += new System.EventHandler(this.btnSaveVisitHistory_Click);
            // 
            // lblSpecialRequest1
            // 
            this.lblSpecialRequest1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpecialRequest1.AutoSize = true;
            this.lblSpecialRequest1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRequest1.Location = new System.Drawing.Point(8, 194);
            this.lblSpecialRequest1.Name = "lblSpecialRequest1";
            this.lblSpecialRequest1.Size = new System.Drawing.Size(51, 20);
            this.lblSpecialRequest1.TabIndex = 99;
            this.lblSpecialRequest1.Text = "Special";
            // 
            // btnClearVisitHistory
            // 
            this.btnClearVisitHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVisitHistory.Location = new System.Drawing.Point(257, 290);
            this.btnClearVisitHistory.Name = "btnClearVisitHistory";
            this.btnClearVisitHistory.Size = new System.Drawing.Size(80, 30);
            this.btnClearVisitHistory.TabIndex = 13;
            this.btnClearVisitHistory.Text = "Clear";
            this.btnClearVisitHistory.UseVisualStyleBackColor = true;
            this.btnClearVisitHistory.Click += new System.EventHandler(this.btnClearVisitHistory_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(312, 161);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(60, 25);
            this.dtEnd.TabIndex = 9;
            // 
            // dtStart
            // 
            this.dtStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(209, 161);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(60, 25);
            this.dtStart.TabIndex = 8;
            // 
            // dtDate
            // 
            this.dtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDate.CustomFormat = "";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(78, 161);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(85, 25);
            this.dtDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(378, 163);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 20);
            this.lblStatus.TabIndex = 99;
            this.lblStatus.Text = "Status";
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(275, 163);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(31, 20);
            this.lblEnd.TabIndex = 99;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(169, 163);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 20);
            this.lblStart.TabIndex = 99;
            this.lblStart.Text = "Start";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 20);
            this.lblDate.TabIndex = 99;
            this.lblDate.Text = "Date";
            // 
            // lblWorker
            // 
            this.lblWorker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(322, 70);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 20);
            this.lblWorker.TabIndex = 99;
            this.lblWorker.Text = "Worker";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(8, 101);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 99;
            this.lblPrice.Text = "Price($)";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(78, 99);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(70, 25);
            this.txtPrice.TabIndex = 2;
            // 
            // lblService
            // 
            this.lblService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(7, 70);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(50, 20);
            this.lblService.TabIndex = 99;
            this.lblService.Text = "Service";
            // 
            // lblRecordId
            // 
            this.lblRecordId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecordId.AutoSize = true;
            this.lblRecordId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordId.Location = new System.Drawing.Point(7, 39);
            this.lblRecordId.Name = "lblRecordId";
            this.lblRecordId.Size = new System.Drawing.Size(65, 20);
            this.lblRecordId.TabIndex = 99;
            this.lblRecordId.Text = "Record ID";
            // 
            // txtRecordId
            // 
            this.txtRecordId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRecordId.Enabled = false;
            this.txtRecordId.Location = new System.Drawing.Point(78, 37);
            this.txtRecordId.Name = "txtRecordId";
            this.txtRecordId.Size = new System.Drawing.Size(85, 25);
            this.txtRecordId.TabIndex = 23;
            // 
            // grpboxClientProfile
            // 
            this.grpboxClientProfile.Controls.Add(this.btnSaveProfile);
            this.grpboxClientProfile.Controls.Add(this.txtPhone);
            this.grpboxClientProfile.Controls.Add(this.lblClientId);
            this.grpboxClientProfile.Controls.Add(this.btnDeleteProfile);
            this.grpboxClientProfile.Controls.Add(this.txtClientId);
            this.grpboxClientProfile.Controls.Add(this.btnCancelProfile);
            this.grpboxClientProfile.Controls.Add(this.lblName);
            this.grpboxClientProfile.Controls.Add(this.txtName);
            this.grpboxClientProfile.Controls.Add(this.btnClearProfile);
            this.grpboxClientProfile.Controls.Add(this.lblPhone);
            this.grpboxClientProfile.Controls.Add(this.rtxtNotes);
            this.grpboxClientProfile.Controls.Add(this.lblNotes);
            this.grpboxClientProfile.Controls.Add(this.lblEmail);
            this.grpboxClientProfile.Controls.Add(this.txtEmail);
            this.grpboxClientProfile.Controls.Add(this.picProfilePicture);
            this.grpboxClientProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxClientProfile.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxClientProfile.Location = new System.Drawing.Point(183, 67);
            this.grpboxClientProfile.Name = "grpboxClientProfile";
            this.grpboxClientProfile.Size = new System.Drawing.Size(598, 262);
            this.grpboxClientProfile.TabIndex = 23;
            this.grpboxClientProfile.TabStop = false;
            this.grpboxClientProfile.Text = "Client Profile";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveProfile.Location = new System.Drawing.Point(509, 226);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(80, 30);
            this.btnSaveProfile.TabIndex = 5;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhone.Location = new System.Drawing.Point(68, 89);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(383, 25);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // grpboxNav
            // 
            this.grpboxNav.Controls.Add(this.lstboxNavClient);
            this.grpboxNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxNav.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxNav.Location = new System.Drawing.Point(3, 67);
            this.grpboxNav.Name = "grpboxNav";
            this.grpboxNav.Size = new System.Drawing.Size(174, 262);
            this.grpboxNav.TabIndex = 24;
            this.grpboxNav.TabStop = false;
            this.grpboxNav.Text = "Client List";
            // 
            // grpboxViewVisitRecord
            // 
            this.grpboxViewVisitRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxViewVisitRecord.Controls.Add(this.lstboxNavVisitRecord);
            this.grpboxViewVisitRecord.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxViewVisitRecord.Location = new System.Drawing.Point(3, 335);
            this.grpboxViewVisitRecord.Name = "grpboxViewVisitRecord";
            this.grpboxViewVisitRecord.Size = new System.Drawing.Size(174, 323);
            this.grpboxViewVisitRecord.TabIndex = 62;
            this.grpboxViewVisitRecord.TabStop = false;
            this.grpboxViewVisitRecord.Text = "View Visit Record";
            // 
            // lstboxNavVisitRecord
            // 
            this.lstboxNavVisitRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstboxNavVisitRecord.FormattingEnabled = true;
            this.lstboxNavVisitRecord.ItemHeight = 20;
            this.lstboxNavVisitRecord.Location = new System.Drawing.Point(3, 21);
            this.lstboxNavVisitRecord.Name = "lstboxNavVisitRecord";
            this.lstboxNavVisitRecord.Size = new System.Drawing.Size(168, 299);
            this.lstboxNavVisitRecord.TabIndex = 1;
            this.lstboxNavVisitRecord.SelectedIndexChanged += new System.EventHandler(this.lstboxNavVisitRecord_SelectedIndexChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(224, 1029);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(158, 13);
            this.lblCopyright.TabIndex = 63;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "Copyright © Junseo Yang 2021 ";
            this.lblCopyright.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.tableLayoutPanel1.Controls.Add(this.grpboxNav, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpboxClientProfile, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grpboxEditVisitRecordManually, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpboxViewVisitRecord, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 661);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitle, 2);
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 30);
            this.lblTitle.Size = new System.Drawing.Size(778, 64);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Client DB Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessageProfile
            // 
            this.lblMessageProfile.AutoSize = true;
            this.lblMessageProfile.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblMessageProfile.ForeColor = System.Drawing.Color.Red;
            this.lblMessageProfile.Location = new System.Drawing.Point(502, 35);
            this.lblMessageProfile.Name = "lblMessageProfile";
            this.lblMessageProfile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessageProfile.Size = new System.Drawing.Size(17, 17);
            this.lblMessageProfile.TabIndex = 64;
            this.lblMessageProfile.Text = "...";
            this.lblMessageProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientDBManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.lblMessageProfile);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCopyright);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "ClientDBManagement";
            this.Text = "Rium Salon Coiffure - Client DB Management";
            this.Load += new System.EventHandler(this.ClientDBManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.grpboxEditVisitRecordManually.ResumeLayout(false);
            this.grpboxEditVisitRecordManually.PerformLayout();
            this.grpboxClientProfile.ResumeLayout(false);
            this.grpboxClientProfile.PerformLayout();
            this.grpboxNav.ResumeLayout(false);
            this.grpboxViewVisitRecord.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxNavClient;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picProfilePicture;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtxtNotes;
        private System.Windows.Forms.Button btnClearProfile;
        private System.Windows.Forms.Button btnCancelProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.GroupBox grpboxEditVisitRecordManually;
        private System.Windows.Forms.GroupBox grpboxClientProfile;
        private System.Windows.Forms.GroupBox grpboxNav;
        private System.Windows.Forms.Label lblRecordId;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblSpecialRequest2;
        private System.Windows.Forms.RichTextBox rtxtSpecialRequest;
        private System.Windows.Forms.Label lblSpecialRequest1;
        private System.Windows.Forms.GroupBox grpboxViewVisitRecord;
        private System.Windows.Forms.Button btnDeleteVisitHistory;
        private System.Windows.Forms.Button btnCancelVisitHistory;
        private System.Windows.Forms.Button btnSaveVisitHistory;
        private System.Windows.Forms.Button btnClearVisitHistory;
        private System.Windows.Forms.LinkLabel lblCopyright;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTipsPercent;
        private System.Windows.Forms.TextBox txtTipsDollar;
        private System.Windows.Forms.Label lblQST;
        private System.Windows.Forms.TextBox txtQST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.ComboBox cmbboxMethod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbboxWorker;
        private System.Windows.Forms.Label lblVisitRecordClientId;
        private System.Windows.Forms.TextBox txtVisitRecordClientId;
        private System.Windows.Forms.Label lblVisitRecordClientName;
        private System.Windows.Forms.TextBox txtVisitRecordClientName;
        private System.Windows.Forms.ComboBox cmbboxStatus;
        private System.Windows.Forms.Label lblMessageVisitRecord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMessageProfile;
        private System.Windows.Forms.Label lblTipsDollar;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstboxNavVisitRecord;
        private System.Windows.Forms.ComboBox cmbboxTipsPercent;
        private System.Windows.Forms.ComboBox cmbboxService;
    }
}