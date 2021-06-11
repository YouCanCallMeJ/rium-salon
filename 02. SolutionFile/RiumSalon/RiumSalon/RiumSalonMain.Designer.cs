
namespace RiumSalon
{
    partial class RiumSalonMain
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
            this.btnClientDBManagement = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProductMangement = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnClientDBManagement
            // 
            this.btnClientDBManagement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDBManagement.Location = new System.Drawing.Point(89, 82);
            this.btnClientDBManagement.Name = "btnClientDBManagement";
            this.btnClientDBManagement.Size = new System.Drawing.Size(168, 35);
            this.btnClientDBManagement.TabIndex = 0;
            this.btnClientDBManagement.Text = "Client DB Management";
            this.btnClientDBManagement.UseVisualStyleBackColor = true;
            this.btnClientDBManagement.Click += new System.EventHandler(this.btnClientDBManagement_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Rium Salon Coiffure";
            // 
            // btnProductMangement
            // 
            this.btnProductMangement.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductMangement.Location = new System.Drawing.Point(89, 131);
            this.btnProductMangement.Name = "btnProductMangement";
            this.btnProductMangement.Size = new System.Drawing.Size(168, 35);
            this.btnProductMangement.TabIndex = 2;
            this.btnProductMangement.Text = "Product Management";
            this.btnProductMangement.UseVisualStyleBackColor = true;
            this.btnProductMangement.Click += new System.EventHandler(this.btnProductMangement_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(89, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(82, 267);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 12);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = "Copyright © Junseo Yang 2021 ";
            this.lblCopyright.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // RiumSalonMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 288);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProductMangement);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClientDBManagement);
            this.Name = "RiumSalonMain";
            this.Text = "Rium Salon Coiffure - Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientDBManagement;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProductMangement;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lblCopyright;
    }
}

