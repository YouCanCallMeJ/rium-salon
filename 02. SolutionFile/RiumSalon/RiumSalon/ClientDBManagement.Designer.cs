
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
            this.lstboxNav = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnCancelProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.grpboxEditVisitHistoryManually = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbboxMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTips = new System.Windows.Forms.Label();
            this.txtTips = new System.Windows.Forms.TextBox();
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblHistoryId = new System.Windows.Forms.Label();
            this.txtVisitHistoryId = new System.Windows.Forms.TextBox();
            this.grpboxClientProfile = new System.Windows.Forms.GroupBox();
            this.grpboxNav = new System.Windows.Forms.GroupBox();
            this.grpboxViewVisitHistory = new System.Windows.Forms.GroupBox();
            this.rtxtViewVisitHistory = new System.Windows.Forms.RichTextBox();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).BeginInit();
            this.grpboxEditVisitHistoryManually.SuspendLayout();
            this.grpboxClientProfile.SuspendLayout();
            this.grpboxNav.SuspendLayout();
            this.grpboxViewVisitHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxNav
            // 
            this.lstboxNav.FormattingEnabled = true;
            this.lstboxNav.ItemHeight = 20;
            this.lstboxNav.Location = new System.Drawing.Point(6, 24);
            this.lstboxNav.Name = "lstboxNav";
            this.lstboxNav.Size = new System.Drawing.Size(234, 264);
            this.lstboxNav.TabIndex = 0;
            this.lstboxNav.SelectedIndexChanged += new System.EventHandler(this.lstboxNav_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(225, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Client DB Management";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(6, 26);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(56, 20);
            this.lblClientId.TabIndex = 5;
            this.lblClientId.Text = "Client ID";
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(65, 24);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(240, 25);
            this.txtClientId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 25);
            this.txtName.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 90);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 20);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(65, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-Mail";
            // 
            // picProfilePicture
            // 
            this.picProfilePicture.AccessibleDescription = "Profile Picture";
            this.picProfilePicture.ErrorImage = null;
            this.picProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.Image")));
            this.picProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picProfilePicture.InitialImage")));
            this.picProfilePicture.Location = new System.Drawing.Point(311, 24);
            this.picProfilePicture.Name = "picProfilePicture";
            this.picProfilePicture.Size = new System.Drawing.Size(100, 121);
            this.picProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePicture.TabIndex = 13;
            this.picProfilePicture.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(6, 154);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 20);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes";
            // 
            // rtxtNotes
            // 
            this.rtxtNotes.Location = new System.Drawing.Point(65, 153);
            this.rtxtNotes.Name = "rtxtNotes";
            this.rtxtNotes.Size = new System.Drawing.Size(346, 96);
            this.rtxtNotes.TabIndex = 17;
            this.rtxtNotes.Text = "";
            // 
            // btnClearProfile
            // 
            this.btnClearProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProfile.Location = new System.Drawing.Point(65, 257);
            this.btnClearProfile.Name = "btnClearProfile";
            this.btnClearProfile.Size = new System.Drawing.Size(70, 30);
            this.btnClearProfile.TabIndex = 18;
            this.btnClearProfile.Text = "Clear";
            this.btnClearProfile.UseVisualStyleBackColor = true;
            this.btnClearProfile.Click += new System.EventHandler(this.btnClearProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.Location = new System.Drawing.Point(157, 257);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(70, 30);
            this.btnSaveProfile.TabIndex = 19;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnCancelProfile
            // 
            this.btnCancelProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelProfile.Location = new System.Drawing.Point(249, 257);
            this.btnCancelProfile.Name = "btnCancelProfile";
            this.btnCancelProfile.Size = new System.Drawing.Size(70, 30);
            this.btnCancelProfile.TabIndex = 20;
            this.btnCancelProfile.Text = "Cancel";
            this.btnCancelProfile.UseVisualStyleBackColor = true;
            this.btnCancelProfile.Click += new System.EventHandler(this.btnCancelProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProfile.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteProfile.Location = new System.Drawing.Point(341, 257);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteProfile.TabIndex = 21;
            this.btnDeleteProfile.Text = "Delete";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // grpboxEditVisitHistoryManually
            // 
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnCalculate);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.cmbboxMethod);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblMethod);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblTotal);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtTotal);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblTips);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtTips);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblQST);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtQST);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblGST);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtGST);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnDeleteVisitHistory);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblSpecialRequest2);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnCancelVisitHistory);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.rtxtSpecialRequest);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnSaveVisitHistory);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblSpecialRequest1);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnClearVisitHistory);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.dtEnd);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.dtStart);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.dtDate);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblStatus);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblEnd);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtStatus);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblStart);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblDate);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblWorker);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblPrice);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtWorker);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtPrice);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblService);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtService);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.btnSearch);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.lblHistoryId);
            this.grpboxEditVisitHistoryManually.Controls.Add(this.txtVisitHistoryId);
            this.grpboxEditVisitHistoryManually.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxEditVisitHistoryManually.Location = new System.Drawing.Point(12, 582);
            this.grpboxEditVisitHistoryManually.Name = "grpboxEditVisitHistoryManually";
            this.grpboxEditVisitHistoryManually.Size = new System.Drawing.Size(680, 328);
            this.grpboxEditVisitHistoryManually.TabIndex = 22;
            this.grpboxEditVisitHistoryManually.TabStop = false;
            this.grpboxEditVisitHistoryManually.Text = "Edit Visit History Manually";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(474, 89);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 30);
            this.btnCalculate.TabIndex = 73;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // cmbboxMethod
            // 
            this.cmbboxMethod.FormattingEnabled = true;
            this.cmbboxMethod.Items.AddRange(new object[] {
            "Master",
            "American Express",
            "VISA",
            "PayPal",
            "Apple Pay",
            "Interac",
            "Debit"});
            this.cmbboxMethod.Location = new System.Drawing.Point(347, 90);
            this.cmbboxMethod.Name = "cmbboxMethod";
            this.cmbboxMethod.Size = new System.Drawing.Size(121, 28);
            this.cmbboxMethod.TabIndex = 72;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(290, 94);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(51, 20);
            this.lblMethod.TabIndex = 70;
            this.lblMethod.Text = "Method";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(290, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 20);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(347, 123);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(53, 25);
            this.txtTotal.TabIndex = 69;
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(139, 94);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(34, 20);
            this.lblTips.TabIndex = 66;
            this.lblTips.Text = "Tips";
            // 
            // txtTips
            // 
            this.txtTips.Location = new System.Drawing.Point(229, 92);
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(53, 25);
            this.txtTips.TabIndex = 67;
            // 
            // lblQST
            // 
            this.lblQST.AutoSize = true;
            this.lblQST.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQST.Location = new System.Drawing.Point(138, 125);
            this.lblQST.Name = "lblQST";
            this.lblQST.Size = new System.Drawing.Size(86, 20);
            this.lblQST.TabIndex = 64;
            this.lblQST.Text = "QST(9.975%)";
            // 
            // txtQST
            // 
            this.txtQST.Location = new System.Drawing.Point(229, 123);
            this.txtQST.Name = "txtQST";
            this.txtQST.Size = new System.Drawing.Size(53, 25);
            this.txtQST.TabIndex = 65;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(6, 125);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(62, 20);
            this.lblGST.TabIndex = 62;
            this.lblGST.Text = "GST(5%)";
            // 
            // txtGST
            // 
            this.txtGST.Location = new System.Drawing.Point(73, 123);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(53, 25);
            this.txtGST.TabIndex = 63;
            // 
            // btnDeleteVisitHistory
            // 
            this.btnDeleteVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVisitHistory.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteVisitHistory.Location = new System.Drawing.Point(593, 287);
            this.btnDeleteVisitHistory.Name = "btnDeleteVisitHistory";
            this.btnDeleteVisitHistory.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteVisitHistory.TabIndex = 25;
            this.btnDeleteVisitHistory.Text = "Delete";
            this.btnDeleteVisitHistory.UseVisualStyleBackColor = true;
            // 
            // lblSpecialRequest2
            // 
            this.lblSpecialRequest2.AutoSize = true;
            this.lblSpecialRequest2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRequest2.Location = new System.Drawing.Point(7, 206);
            this.lblSpecialRequest2.Name = "lblSpecialRequest2";
            this.lblSpecialRequest2.Size = new System.Drawing.Size(55, 20);
            this.lblSpecialRequest2.TabIndex = 61;
            this.lblSpecialRequest2.Text = "Request";
            // 
            // btnCancelVisitHistory
            // 
            this.btnCancelVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelVisitHistory.Location = new System.Drawing.Point(501, 287);
            this.btnCancelVisitHistory.Name = "btnCancelVisitHistory";
            this.btnCancelVisitHistory.Size = new System.Drawing.Size(70, 30);
            this.btnCancelVisitHistory.TabIndex = 24;
            this.btnCancelVisitHistory.Text = "Cancel";
            this.btnCancelVisitHistory.UseVisualStyleBackColor = true;
            // 
            // rtxtSpecialRequest
            // 
            this.rtxtSpecialRequest.Location = new System.Drawing.Point(73, 185);
            this.rtxtSpecialRequest.Name = "rtxtSpecialRequest";
            this.rtxtSpecialRequest.Size = new System.Drawing.Size(590, 96);
            this.rtxtSpecialRequest.TabIndex = 23;
            this.rtxtSpecialRequest.Text = "";
            // 
            // btnSaveVisitHistory
            // 
            this.btnSaveVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVisitHistory.Location = new System.Drawing.Point(409, 287);
            this.btnSaveVisitHistory.Name = "btnSaveVisitHistory";
            this.btnSaveVisitHistory.Size = new System.Drawing.Size(70, 30);
            this.btnSaveVisitHistory.TabIndex = 23;
            this.btnSaveVisitHistory.Text = "Save";
            this.btnSaveVisitHistory.UseVisualStyleBackColor = true;
            // 
            // lblSpecialRequest1
            // 
            this.lblSpecialRequest1.AutoSize = true;
            this.lblSpecialRequest1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialRequest1.Location = new System.Drawing.Point(7, 186);
            this.lblSpecialRequest1.Name = "lblSpecialRequest1";
            this.lblSpecialRequest1.Size = new System.Drawing.Size(51, 20);
            this.lblSpecialRequest1.TabIndex = 22;
            this.lblSpecialRequest1.Text = "Special";
            // 
            // btnClearVisitHistory
            // 
            this.btnClearVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearVisitHistory.Location = new System.Drawing.Point(317, 287);
            this.btnClearVisitHistory.Name = "btnClearVisitHistory";
            this.btnClearVisitHistory.Size = new System.Drawing.Size(70, 30);
            this.btnClearVisitHistory.TabIndex = 22;
            this.btnClearVisitHistory.Text = "Clear";
            this.btnClearVisitHistory.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "hh:mm tt";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(396, 154);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.ShowUpDown = true;
            this.dtEnd.Size = new System.Drawing.Size(100, 25);
            this.dtEnd.TabIndex = 60;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "hh:mm tt";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(246, 154);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(100, 25);
            this.dtStart.TabIndex = 59;
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(73, 154);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(100, 25);
            this.dtDate.TabIndex = 40;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(509, 156);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 20);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(352, 156);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(31, 20);
            this.lblEnd.TabIndex = 36;
            this.lblEnd.Text = "End";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(563, 154);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 25);
            this.txtStatus.TabIndex = 39;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(190, 156);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 20);
            this.lblStart.TabIndex = 34;
            this.lblStart.Text = "Start";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 156);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 20);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Date";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(331, 63);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 20);
            this.lblWorker.TabIndex = 30;
            this.lblWorker.Text = "Worker";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 20);
            this.lblPrice.TabIndex = 28;
            this.lblPrice.Text = "Price";
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(388, 61);
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(80, 25);
            this.txtWorker.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(73, 92);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(53, 25);
            this.txtPrice.TabIndex = 29;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(6, 63);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(50, 20);
            this.lblService.TabIndex = 26;
            this.lblService.Text = "Service";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(73, 61);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(252, 25);
            this.txtService.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(179, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblHistoryId
            // 
            this.lblHistoryId.AutoSize = true;
            this.lblHistoryId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryId.Location = new System.Drawing.Point(6, 32);
            this.lblHistoryId.Name = "lblHistoryId";
            this.lblHistoryId.Size = new System.Drawing.Size(61, 20);
            this.lblHistoryId.TabIndex = 22;
            this.lblHistoryId.Text = "History ID";
            // 
            // txtVisitHistoryId
            // 
            this.txtVisitHistoryId.Location = new System.Drawing.Point(73, 30);
            this.txtVisitHistoryId.Name = "txtVisitHistoryId";
            this.txtVisitHistoryId.Size = new System.Drawing.Size(100, 25);
            this.txtVisitHistoryId.TabIndex = 23;
            // 
            // grpboxClientProfile
            // 
            this.grpboxClientProfile.Controls.Add(this.txtPhone);
            this.grpboxClientProfile.Controls.Add(this.lblClientId);
            this.grpboxClientProfile.Controls.Add(this.btnDeleteProfile);
            this.grpboxClientProfile.Controls.Add(this.txtClientId);
            this.grpboxClientProfile.Controls.Add(this.btnCancelProfile);
            this.grpboxClientProfile.Controls.Add(this.lblName);
            this.grpboxClientProfile.Controls.Add(this.btnSaveProfile);
            this.grpboxClientProfile.Controls.Add(this.txtName);
            this.grpboxClientProfile.Controls.Add(this.btnClearProfile);
            this.grpboxClientProfile.Controls.Add(this.lblPhone);
            this.grpboxClientProfile.Controls.Add(this.rtxtNotes);
            this.grpboxClientProfile.Controls.Add(this.lblNotes);
            this.grpboxClientProfile.Controls.Add(this.lblEmail);
            this.grpboxClientProfile.Controls.Add(this.txtEmail);
            this.grpboxClientProfile.Controls.Add(this.picProfilePicture);
            this.grpboxClientProfile.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxClientProfile.Location = new System.Drawing.Point(264, 51);
            this.grpboxClientProfile.Name = "grpboxClientProfile";
            this.grpboxClientProfile.Size = new System.Drawing.Size(428, 300);
            this.grpboxClientProfile.TabIndex = 23;
            this.grpboxClientProfile.TabStop = false;
            this.grpboxClientProfile.Text = "Client Profile";
            // 
            // grpboxNav
            // 
            this.grpboxNav.Controls.Add(this.lstboxNav);
            this.grpboxNav.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxNav.Location = new System.Drawing.Point(12, 51);
            this.grpboxNav.Name = "grpboxNav";
            this.grpboxNav.Size = new System.Drawing.Size(246, 300);
            this.grpboxNav.TabIndex = 24;
            this.grpboxNav.TabStop = false;
            this.grpboxNav.Text = "Client List";
            // 
            // grpboxViewVisitHistory
            // 
            this.grpboxViewVisitHistory.Controls.Add(this.rtxtViewVisitHistory);
            this.grpboxViewVisitHistory.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxViewVisitHistory.Location = new System.Drawing.Point(12, 357);
            this.grpboxViewVisitHistory.Name = "grpboxViewVisitHistory";
            this.grpboxViewVisitHistory.Size = new System.Drawing.Size(680, 219);
            this.grpboxViewVisitHistory.TabIndex = 62;
            this.grpboxViewVisitHistory.TabStop = false;
            this.grpboxViewVisitHistory.Text = "View Visit History";
            // 
            // rtxtViewVisitHistory
            // 
            this.rtxtViewVisitHistory.Location = new System.Drawing.Point(6, 24);
            this.rtxtViewVisitHistory.Name = "rtxtViewVisitHistory";
            this.rtxtViewVisitHistory.Size = new System.Drawing.Size(657, 182);
            this.rtxtViewVisitHistory.TabIndex = 62;
            this.rtxtViewVisitHistory.Text = "";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(256, 917);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 12);
            this.lblCopyright.TabIndex = 63;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "Copyright © Junseo Yang 2021 ";
            this.lblCopyright.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(479, 18);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 64;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(65, 87);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 25);
            this.txtPhone.TabIndex = 22;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // ClientDBManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 938);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.grpboxViewVisitHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpboxClientProfile);
            this.Controls.Add(this.grpboxNav);
            this.Controls.Add(this.grpboxEditVisitHistoryManually);
            this.Name = "ClientDBManagement";
            this.Text = "Rium Salon Coiffure - Client DB Management";
            this.Load += new System.EventHandler(this.ClientDBManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePicture)).EndInit();
            this.grpboxEditVisitHistoryManually.ResumeLayout(false);
            this.grpboxEditVisitHistoryManually.PerformLayout();
            this.grpboxClientProfile.ResumeLayout(false);
            this.grpboxClientProfile.PerformLayout();
            this.grpboxNav.ResumeLayout(false);
            this.grpboxViewVisitHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxNav;
        private System.Windows.Forms.Label lblTitle;
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
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnCancelProfile;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.GroupBox grpboxEditVisitHistoryManually;
        private System.Windows.Forms.GroupBox grpboxClientProfile;
        private System.Windows.Forms.GroupBox grpboxNav;
        private System.Windows.Forms.Label lblHistoryId;
        private System.Windows.Forms.TextBox txtVisitHistoryId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblSpecialRequest2;
        private System.Windows.Forms.RichTextBox rtxtSpecialRequest;
        private System.Windows.Forms.Label lblSpecialRequest1;
        private System.Windows.Forms.GroupBox grpboxViewVisitHistory;
        private System.Windows.Forms.RichTextBox rtxtViewVisitHistory;
        private System.Windows.Forms.Button btnDeleteVisitHistory;
        private System.Windows.Forms.Button btnCancelVisitHistory;
        private System.Windows.Forms.Button btnSaveVisitHistory;
        private System.Windows.Forms.Button btnClearVisitHistory;
        private System.Windows.Forms.LinkLabel lblCopyright;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.Label lblQST;
        private System.Windows.Forms.TextBox txtQST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.ComboBox cmbboxMethod;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}