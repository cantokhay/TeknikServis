namespace TeknikServis.Forms
{
    partial class FrmNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoteList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoteTitle = new DevExpress.XtraEditors.TextEdit();
            this.bntRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoteId = new DevExpress.XtraEditors.TextEdit();
            this.grcUnreadNotesList = new DevExpress.XtraGrid.GridControl();
            this.gvwUnreadNotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcReadNotesList = new DevExpress.XtraGrid.GridControl();
            this.gvwReadNotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.txtNoteDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkNoteStatus = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUnreadNotesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUnreadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcReadNotesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoteStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.chkNoteStatus);
            this.groupControl1.Controls.Add(this.txtNoteDescription);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.txtNoteTitle);
            this.groupControl1.Controls.Add(this.bntRefresh);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtNoteId);
            this.groupControl1.Location = new System.Drawing.Point(1025, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 536);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "NOTE OPERATIONS";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "DESCRIPTION : ";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(84, 153);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(37, 13);
            this.labelControl16.TabIndex = 18;
            this.labelControl16.Text = "TITLE : ";
            // 
            // txtNoteTitle
            // 
            this.txtNoteTitle.Location = new System.Drawing.Point(123, 150);
            this.txtNoteTitle.Name = "txtNoteTitle";
            this.txtNoteTitle.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtNoteTitle.Properties.MaskSettings.Set("mask", "(000) 000-0000");
            this.txtNoteTitle.Size = new System.Drawing.Size(190, 20);
            this.txtNoteTitle.TabIndex = 2;
            // 
            // bntRefresh
            // 
            this.bntRefresh.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.bntRefresh.Appearance.Options.UseFont = true;
            this.bntRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntRefresh.ImageOptions.Image")));
            this.bntRefresh.Location = new System.Drawing.Point(34, 490);
            this.bntRefresh.Name = "bntRefresh";
            this.bntRefresh.Size = new System.Drawing.Size(293, 39);
            this.bntRefresh.TabIndex = 8;
            this.bntRefresh.Text = "REFRESH LIST";
            this.bntRefresh.Click += new System.EventHandler(this.bntRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(34, 445);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(293, 39);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(34, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(293, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(34, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(293, 39);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(70, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "NOTE ID : ";
            // 
            // txtNoteId
            // 
            this.txtNoteId.Enabled = false;
            this.txtNoteId.Location = new System.Drawing.Point(123, 120);
            this.txtNoteId.Name = "txtNoteId";
            this.txtNoteId.Size = new System.Drawing.Size(190, 20);
            this.txtNoteId.TabIndex = 1;
            // 
            // grcUnreadNotesList
            // 
            this.grcUnreadNotesList.Location = new System.Drawing.Point(3, 20);
            this.grcUnreadNotesList.MainView = this.gvwUnreadNotes;
            this.grcUnreadNotesList.Name = "grcUnreadNotesList";
            this.grcUnreadNotesList.Size = new System.Drawing.Size(1018, 250);
            this.grcUnreadNotesList.TabIndex = 24;
            this.grcUnreadNotesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwUnreadNotes});
            // 
            // gvwUnreadNotes
            // 
            this.gvwUnreadNotes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.gvwUnreadNotes.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvwUnreadNotes.Appearance.Row.Options.UseBackColor = true;
            this.gvwUnreadNotes.Appearance.Row.Options.UseBorderColor = true;
            this.gvwUnreadNotes.GridControl = this.grcUnreadNotesList;
            this.gvwUnreadNotes.Name = "gvwUnreadNotes";
            this.gvwUnreadNotes.OptionsView.ShowGroupPanel = false;
            this.gvwUnreadNotes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvwUnreadNotes_FocusedRowChanged);
            // 
            // grcReadNotesList
            // 
            this.grcReadNotesList.Location = new System.Drawing.Point(3, 290);
            this.grcReadNotesList.MainView = this.gvwReadNotes;
            this.grcReadNotesList.Name = "grcReadNotesList";
            this.grcReadNotesList.Size = new System.Drawing.Size(1018, 250);
            this.grcReadNotesList.TabIndex = 24;
            this.grcReadNotesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwReadNotes});
            // 
            // gvwReadNotes
            // 
            this.gvwReadNotes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gvwReadNotes.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvwReadNotes.Appearance.Row.Options.UseBackColor = true;
            this.gvwReadNotes.Appearance.Row.Options.UseBorderColor = true;
            this.gvwReadNotes.GridControl = this.grcReadNotesList;
            this.gvwReadNotes.Name = "gvwReadNotes";
            this.gvwReadNotes.OptionsView.ShowGroupPanel = false;
            this.gvwReadNotes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvwReadNotes_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(454, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Unread Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(463, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Read Notes";
            // 
            // txtNoteDescription
            // 
            this.txtNoteDescription.Location = new System.Drawing.Point(123, 210);
            this.txtNoteDescription.Name = "txtNoteDescription";
            this.txtNoteDescription.Size = new System.Drawing.Size(190, 96);
            this.txtNoteDescription.TabIndex = 4;
            this.txtNoteDescription.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 184);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "READ STATUS : ";
            // 
            // chkNoteStatus
            // 
            this.chkNoteStatus.Location = new System.Drawing.Point(123, 180);
            this.chkNoteStatus.Name = "chkNoteStatus";
            this.chkNoteStatus.Properties.Caption = "Mark as Read";
            this.chkNoteStatus.Size = new System.Drawing.Size(190, 20);
            this.chkNoteStatus.TabIndex = 3;
            // 
            // FrmNoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grcReadNotesList);
            this.Controls.Add(this.grcUnreadNotesList);
            this.Name = "FrmNoteList";
            this.Text = "Note List";
            this.Load += new System.EventHandler(this.FrmNoteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcUnreadNotesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUnreadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcReadNotesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoteStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtNoteTitle;
        private DevExpress.XtraEditors.SimpleButton bntRefresh;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNoteId;
        private DevExpress.XtraGrid.GridControl grcUnreadNotesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwUnreadNotes;
        private DevExpress.XtraGrid.GridControl grcReadNotesList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwReadNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNoteDescription;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkNoteStatus;
    }
}