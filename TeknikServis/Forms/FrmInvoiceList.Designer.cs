namespace TeknikServis.Forms
{
    partial class FrmInvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceList));
            this.bntRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceSequanceNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtInvoiceSerialChar = new DevExpress.XtraEditors.TextEdit();
            this.txtInvoiceId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grcInvoiceList = new DevExpress.XtraGrid.GridControl();
            this.gvwInvoices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtInvoiceDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl999 = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceHour = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxOffice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lueEmployee = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSequanceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSerialChar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployee.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bntRefresh
            // 
            this.bntRefresh.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.bntRefresh.Appearance.Options.UseFont = true;
            this.bntRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntRefresh.ImageOptions.Image")));
            this.bntRefresh.Location = new System.Drawing.Point(34, 489);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(293, 39);
            this.bntRefresh.TabIndex = 12;
            this.bntRefresh.Text = "REFRESH LIST";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(34, 444);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(293, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "UPDATE";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(34, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(292, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(34, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(293, 39);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(28, 135);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(104, 13);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "SEQUENCE NUMBER :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(59, 105);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 13);
            this.labelControl11.TabIndex = 8;
            this.labelControl11.Text = "SERIAL CHAR :";
            // 
            // txtInvoiceSequanceNumber
            // 
            this.txtInvoiceSequanceNumber.Location = new System.Drawing.Point(135, 132);
            this.txtInvoiceSequanceNumber.Name = "txtInvoiceSequanceNumber";
            this.txtInvoiceSequanceNumber.Size = new System.Drawing.Size(190, 20);
            this.txtInvoiceSequanceNumber.TabIndex = 3;
            // 
            // txtInvoiceSerialChar
            // 
            this.txtInvoiceSerialChar.Location = new System.Drawing.Point(135, 102);
            this.txtInvoiceSerialChar.Name = "txtInvoiceSerialChar";
            this.txtInvoiceSerialChar.Size = new System.Drawing.Size(190, 20);
            this.txtInvoiceSerialChar.TabIndex = 2;
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Enabled = false;
            this.txtInvoiceId.Location = new System.Drawing.Point(135, 72);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(190, 20);
            this.txtInvoiceId.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(66, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "INVOICE ID : ";
            // 
            // grcInvoiceList
            // 
            this.grcInvoiceList.Location = new System.Drawing.Point(1, 2);
            this.grcInvoiceList.MainView = this.gvwInvoices;
            this.grcInvoiceList.Name = "grcInvoiceList";
            this.grcInvoiceList.Size = new System.Drawing.Size(1018, 536);
            this.grcInvoiceList.TabIndex = 18;
            this.grcInvoiceList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwInvoices});
            // 
            // gvwInvoices
            // 
            this.gvwInvoices.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.gvwInvoices.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvwInvoices.Appearance.Row.Options.UseBackColor = true;
            this.gvwInvoices.Appearance.Row.Options.UseBorderColor = true;
            this.gvwInvoices.GridControl = this.grcInvoiceList;
            this.gvwInvoices.Name = "gvwInvoices";
            this.gvwInvoices.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lueEmployee);
            this.groupControl1.Controls.Add(this.lueCustomer);
            this.groupControl1.Controls.Add(this.bntRefresh);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTaxOffice);
            this.groupControl1.Controls.Add(this.labelControl999);
            this.groupControl1.Controls.Add(this.txtInvoiceHour);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtInvoiceDate);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtInvoiceSequanceNumber);
            this.groupControl1.Controls.Add(this.txtInvoiceSerialChar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtInvoiceId);
            this.groupControl1.Location = new System.Drawing.Point(1025, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 536);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "INVOICE OPERATIONS";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(135, 162);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(190, 20);
            this.txtInvoiceDate.TabIndex = 4;
            // 
            // labelControl999
            // 
            this.labelControl999.Location = new System.Drawing.Point(51, 165);
            this.labelControl999.Name = "labelControl999";
            this.labelControl999.Size = new System.Drawing.Size(81, 13);
            this.labelControl999.TabIndex = 8;
            this.labelControl999.Text = "INVOICE DATE : ";
            // 
            // txtInvoiceHour
            // 
            this.txtInvoiceHour.Location = new System.Drawing.Point(135, 192);
            this.txtInvoiceHour.Name = "txtInvoiceHour";
            this.txtInvoiceHour.Size = new System.Drawing.Size(190, 20);
            this.txtInvoiceHour.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 195);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "INVOICE HOUR :";
            // 
            // txtTaxOffice
            // 
            this.txtTaxOffice.Location = new System.Drawing.Point(135, 222);
            this.txtTaxOffice.Name = "txtTaxOffice";
            this.txtTaxOffice.Size = new System.Drawing.Size(190, 20);
            this.txtTaxOffice.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(66, 225);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "TAX OFFICE :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(70, 255);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "CUSTOMER :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(71, 285);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "EMPLOYEE : ";
            // 
            // lueCustomer
            // 
            this.lueCustomer.Location = new System.Drawing.Point(135, 252);
            this.lueCustomer.Name = "lueCustomer";
            this.lueCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCustomer.Size = new System.Drawing.Size(190, 20);
            this.lueCustomer.TabIndex = 7;
            // 
            // lueEmployee
            // 
            this.lueEmployee.Location = new System.Drawing.Point(135, 282);
            this.lueEmployee.Name = "lueEmployee";
            this.lueEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployee.Size = new System.Drawing.Size(186, 20);
            this.lueEmployee.TabIndex = 8;
            // 
            // FrmInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.grcInvoiceList);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmInvoiceList";
            this.Text = "Invoice List";
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSequanceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSerialChar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployee.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntRefresh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtInvoiceSequanceNumber;
        private DevExpress.XtraEditors.TextEdit txtInvoiceSerialChar;
        private DevExpress.XtraEditors.TextEdit txtInvoiceId;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl grcInvoiceList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwInvoices;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTaxOffice;
        private DevExpress.XtraEditors.LabelControl labelControl999;
        private DevExpress.XtraEditors.TextEdit txtInvoiceHour;
        private DevExpress.XtraEditors.TextEdit txtInvoiceDate;
        private DevExpress.XtraEditors.LookUpEdit lueEmployee;
        private DevExpress.XtraEditors.LookUpEdit lueCustomer;
    }
}