﻿namespace TeknikServis.Forms
{
    partial class FrmNewDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDepartment));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager2 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnNewDepartmentQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDepartmentSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txtDepartmentDescription = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "NEW DEPARTMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(49, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 34;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.EditValue = "Department Name ";
            this.txtDepartmentName.Location = new System.Drawing.Point(48, 102);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDepartmentName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtDepartmentName.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartmentName.Properties.Appearance.Options.UseFont = true;
            this.txtDepartmentName.Properties.Appearance.Options.UseForeColor = true;
            this.txtDepartmentName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDepartmentName.Size = new System.Drawing.Size(143, 26);
            this.txtDepartmentName.TabIndex = 33;
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
            this.pictureEdit7.TabIndex = 32;
            // 
            // btnNewDepartmentQuit
            // 
            this.btnNewDepartmentQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewDepartmentQuit.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewDepartmentQuit.Appearance.Options.UseFont = true;
            this.btnNewDepartmentQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProductQuit.ImageOptions.Image")));
            this.btnNewDepartmentQuit.Location = new System.Drawing.Point(155, 213);
            this.btnNewDepartmentQuit.Name = "btnNewDepartmentQuit";
            this.btnNewDepartmentQuit.Size = new System.Drawing.Size(120, 33);
            this.btnNewDepartmentQuit.TabIndex = 37;
            this.btnNewDepartmentQuit.Text = "QUIT";
            this.btnNewDepartmentQuit.Click += new System.EventHandler(this.btnNewDepartmentQuit_Click);
            // 
            // btnNewDepartmentSave
            // 
            this.btnNewDepartmentSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewDepartmentSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewDepartmentSave.Appearance.Options.UseFont = true;
            this.btnNewDepartmentSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewProductSave.ImageOptions.Image")));
            this.btnNewDepartmentSave.Location = new System.Drawing.Point(12, 213);
            this.btnNewDepartmentSave.Name = "btnNewDepartmentSave";
            this.btnNewDepartmentSave.Size = new System.Drawing.Size(120, 33);
            this.btnNewDepartmentSave.TabIndex = 36;
            this.btnNewDepartmentSave.Text = "SAVE";
            this.btnNewDepartmentSave.Click += new System.EventHandler(this.btnNewDepartmentSave_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 102);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 31;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 150);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit2.TabIndex = 31;
            // 
            // txtDepartmentDescription
            // 
            this.txtDepartmentDescription.EditValue = "Description";
            this.txtDepartmentDescription.Location = new System.Drawing.Point(48, 150);
            this.txtDepartmentDescription.Name = "txtDepartmentDescription";
            this.txtDepartmentDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDepartmentDescription.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepartmentDescription.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtDepartmentDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDepartmentDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDepartmentDescription.Properties.Appearance.Options.UseForeColor = true;
            this.txtDepartmentDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDepartmentDescription.Size = new System.Drawing.Size(124, 26);
            this.txtDepartmentDescription.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(49, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 3);
            this.panel2.TabIndex = 34;
            // 
            // FrmNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(287, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDepartmentDescription);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.btnNewDepartmentQuit);
            this.Controls.Add(this.btnNewDepartmentSave);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtDepartmentName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager2;
        private DevExpress.XtraEditors.SimpleButton btnNewDepartmentQuit;
        private DevExpress.XtraEditors.SimpleButton btnNewDepartmentSave;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit txtDepartmentDescription;
        private System.Windows.Forms.Panel panel2;
    }
}