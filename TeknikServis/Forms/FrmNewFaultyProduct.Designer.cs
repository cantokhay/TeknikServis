﻿namespace TeknikServis.Forms
{
    partial class FrmNewFaultyProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewFaultyProduct));
            this.txtProductSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.lueEmployees = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCustomers = new DevExpress.XtraEditors.LookUpEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.btnNewActionQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewActionSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.btnGetCustomerInfo = new DevExpress.XtraEditors.SimpleButton();
            this.txtAcceptedDate = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductSerialNumber
            // 
            this.txtProductSerialNumber.EditValue = "Product Serial No";
            this.txtProductSerialNumber.Location = new System.Drawing.Point(50, 246);
            this.txtProductSerialNumber.Name = "txtProductSerialNumber";
            this.txtProductSerialNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtProductSerialNumber.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductSerialNumber.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtProductSerialNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtProductSerialNumber.Properties.Appearance.Options.UseFont = true;
            this.txtProductSerialNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtProductSerialNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtProductSerialNumber.Size = new System.Drawing.Size(130, 26);
            this.txtProductSerialNumber.TabIndex = 4;
            // 
            // lueEmployees
            // 
            this.lueEmployees.Location = new System.Drawing.Point(50, 150);
            this.lueEmployees.Name = "lueEmployees";
            this.lueEmployees.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lueEmployees.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lueEmployees.Properties.Appearance.Options.UseBackColor = true;
            this.lueEmployees.Properties.Appearance.Options.UseForeColor = true;
            this.lueEmployees.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployees.Properties.DisplayMember = "Employee";
            this.lueEmployees.Properties.ValueMember = "EmployeeId";
            this.lueEmployees.Size = new System.Drawing.Size(219, 20);
            this.lueEmployees.TabIndex = 2;
            // 
            // lueCustomers
            // 
            this.lueCustomers.Location = new System.Drawing.Point(50, 102);
            this.lueCustomers.Name = "lueCustomers";
            this.lueCustomers.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lueCustomers.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lueCustomers.Properties.Appearance.Options.UseBackColor = true;
            this.lueCustomers.Properties.Appearance.Options.UseForeColor = true;
            this.lueCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCustomers.Properties.DisplayMember = "Customer";
            this.lueCustomers.Properties.ValueMember = "CustomerId";
            this.lueCustomers.Size = new System.Drawing.Size(219, 20);
            this.lueCustomers.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(49, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 3);
            this.panel6.TabIndex = 86;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(12, 246);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit6.TabIndex = 84;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(49, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 3);
            this.panel3.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(49, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 50);
            this.label1.TabIndex = 82;
            this.label1.Text = "NEW FAULTY \r\n  PRODUCT";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(49, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 3);
            this.panel4.TabIndex = 81;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(37, 12);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit7.TabIndex = 76;
            // 
            // btnNewActionQuit
            // 
            this.btnNewActionQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewActionQuit.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewActionQuit.Appearance.Options.UseFont = true;
            this.btnNewActionQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSaleQuit.ImageOptions.Image")));
            this.btnNewActionQuit.Location = new System.Drawing.Point(155, 309);
            this.btnNewActionQuit.Name = "btnNewActionQuit";
            this.btnNewActionQuit.Size = new System.Drawing.Size(120, 33);
            this.btnNewActionQuit.TabIndex = 6;
            this.btnNewActionQuit.Text = "QUIT";
            this.btnNewActionQuit.Click += new System.EventHandler(this.btnNewActionQuit_Click);
            // 
            // btnNewActionSave
            // 
            this.btnNewActionSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewActionSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewActionSave.Appearance.Options.UseFont = true;
            this.btnNewActionSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSaleSave.ImageOptions.Image")));
            this.btnNewActionSave.Location = new System.Drawing.Point(12, 309);
            this.btnNewActionSave.Name = "btnNewActionSave";
            this.btnNewActionSave.Size = new System.Drawing.Size(120, 33);
            this.btnNewActionSave.TabIndex = 5;
            this.btnNewActionSave.Text = "SAVE";
            this.btnNewActionSave.Click += new System.EventHandler(this.btnNewActionSave_Click);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(12, 198);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit4.TabIndex = 73;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 150);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit3.TabIndex = 74;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 102);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit2.TabIndex = 71;
            // 
            // btnGetCustomerInfo
            // 
            this.btnGetCustomerInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
            this.btnGetCustomerInfo.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetCustomerInfo.Appearance.Options.UseBackColor = true;
            this.btnGetCustomerInfo.Appearance.Options.UseBorderColor = true;
            this.btnGetCustomerInfo.Appearance.Options.UseFont = true;
            this.btnGetCustomerInfo.Location = new System.Drawing.Point(187, 246);
            this.btnGetCustomerInfo.Name = "btnGetCustomerInfo";
            this.btnGetCustomerInfo.Size = new System.Drawing.Size(83, 32);
            this.btnGetCustomerInfo.TabIndex = 87;
            this.btnGetCustomerInfo.Text = "Get \r\nCustomer!";
            this.btnGetCustomerInfo.Click += new System.EventHandler(this.btnGetCustomerInfo_Click);
            // 
            // txtAcceptedDate
            // 
            this.txtAcceptedDate.EditValue = "Accepted Date";
            this.txtAcceptedDate.Location = new System.Drawing.Point(50, 198);
            this.txtAcceptedDate.Name = "txtAcceptedDate";
            this.txtAcceptedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtAcceptedDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAcceptedDate.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtAcceptedDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtAcceptedDate.Properties.Appearance.Options.UseFont = true;
            this.txtAcceptedDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtAcceptedDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAcceptedDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateOnlyMaskManager));
            this.txtAcceptedDate.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtAcceptedDate.Properties.MaskSettings.Set("mask", "d");
            this.txtAcceptedDate.Size = new System.Drawing.Size(219, 26);
            this.txtAcceptedDate.TabIndex = 3;
            // 
            // FrmNewFaultyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(287, 354);
            this.Controls.Add(this.txtAcceptedDate);
            this.Controls.Add(this.btnGetCustomerInfo);
            this.Controls.Add(this.txtProductSerialNumber);
            this.Controls.Add(this.lueEmployees);
            this.Controls.Add(this.lueCustomers);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.btnNewActionQuit);
            this.Controls.Add(this.btnNewActionSave);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewFaultyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewFaultyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.txtProductSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcceptedDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtProductSerialNumber;
        private DevExpress.XtraEditors.LookUpEdit lueEmployees;
        private DevExpress.XtraEditors.LookUpEdit lueCustomers;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.SimpleButton btnNewActionQuit;
        private DevExpress.XtraEditors.SimpleButton btnNewActionSave;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btnGetCustomerInfo;
        private DevExpress.XtraEditors.TextEdit txtAcceptedDate;
    }
}