namespace TeknikServis.Forms
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            this.grcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvwProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bntProductListRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueProductCategories = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductBrand = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductId = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grcProductList
            // 
            this.grcProductList.Location = new System.Drawing.Point(1, 2);
            this.grcProductList.MainView = this.gvwProducts;
            this.grcProductList.Name = "grcProductList";
            this.grcProductList.Size = new System.Drawing.Size(1018, 536);
            this.grcProductList.TabIndex = 0;
            this.grcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwProducts});
            // 
            // gvwProducts
            // 
            this.gvwProducts.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.gvwProducts.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvwProducts.Appearance.Row.Options.UseBackColor = true;
            this.gvwProducts.Appearance.Row.Options.UseBorderColor = true;
            this.gvwProducts.GridControl = this.grcProductList;
            this.gvwProducts.Name = "gvwProducts";
            this.gvwProducts.OptionsView.ShowGroupPanel = false;
            this.gvwProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvwProducts_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.bntProductListRefresh);
            this.groupControl1.Controls.Add(this.btnProductUpdate);
            this.groupControl1.Controls.Add(this.btnProductDelete);
            this.groupControl1.Controls.Add(this.btnProductSave);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lueProductCategories);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtStock);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtSalePrice);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPurchasePrice);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtProductBrand);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtProductId);
            this.groupControl1.Controls.Add(this.txtProductName);
            this.groupControl1.Location = new System.Drawing.Point(1025, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(340, 536);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "PRODUCT OPERATIONS";
            // 
            // bntProductListRefresh
            // 
            this.bntProductListRefresh.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.bntProductListRefresh.Appearance.Options.UseFont = true;
            this.bntProductListRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntProductListRefresh.ImageOptions.Image")));
            this.bntProductListRefresh.Location = new System.Drawing.Point(34, 489);
            this.bntProductListRefresh.Name = "bntProductListRefresh";
            this.bntProductListRefresh.Size = new System.Drawing.Size(293, 39);
            this.bntProductListRefresh.TabIndex = 9;
            this.bntProductListRefresh.Text = "REFRESH LIST";
            this.bntProductListRefresh.Click += new System.EventHandler(this.bntProductListRefresh_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductUpdate.Appearance.Options.UseFont = true;
            this.btnProductUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductUpdate.ImageOptions.Image")));
            this.btnProductUpdate.Location = new System.Drawing.Point(34, 444);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(293, 39);
            this.btnProductUpdate.TabIndex = 9;
            this.btnProductUpdate.Text = "UPDATE";
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductDelete.Appearance.Options.UseFont = true;
            this.btnProductDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductDelete.ImageOptions.Image")));
            this.btnProductDelete.Location = new System.Drawing.Point(34, 399);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(292, 39);
            this.btnProductDelete.TabIndex = 8;
            this.btnProductDelete.Text = "DELETE";
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.Appearance.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductSave.Appearance.Options.UseFont = true;
            this.btnProductSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductSave.ImageOptions.Image")));
            this.btnProductSave.Location = new System.Drawing.Point(34, 354);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(293, 39);
            this.btnProductSave.TabIndex = 7;
            this.btnProductSave.Text = "SAVE";
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(60, 261);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "CATEGORY : ";
            // 
            // lueProductCategories
            // 
            this.lueProductCategories.Location = new System.Drawing.Point(127, 258);
            this.lueProductCategories.Name = "lueProductCategories";
            this.lueProductCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductCategories.Properties.DisplayMember = "CategoryName";
            this.lueProductCategories.Properties.ValueMember = "CategoryId";
            this.lueProductCategories.Size = new System.Drawing.Size(194, 20);
            this.lueProductCategories.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(81, 231);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "STOCK : ";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(127, 228);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(194, 20);
            this.txtStock.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 201);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "SALE PRICE : ";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(127, 198);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(194, 20);
            this.txtSalePrice.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "PURCHASE PRICE : ";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(127, 168);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(194, 20);
            this.txtPurchasePrice.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "PRODUCT BRAND : ";
            // 
            // txtProductBrand
            // 
            this.txtProductBrand.Location = new System.Drawing.Point(127, 138);
            this.txtProductBrand.Name = "txtProductBrand";
            this.txtProductBrand.Size = new System.Drawing.Size(194, 20);
            this.txtProductBrand.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Enabled = false;
            this.labelControl7.Location = new System.Drawing.Point(52, 85);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "PRODUCT ID : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "PRODUCT NAME : ";
            // 
            // txtProductId
            // 
            this.txtProductId.Enabled = false;
            this.txtProductId.Location = new System.Drawing.Point(127, 82);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(194, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(127, 108);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(194, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grcProductList);
            this.Name = "FrmProductList";
            this.Text = "Product List";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwProducts;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtProductBrand;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPurchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueProductCategories;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.SimpleButton btnProductSave;
        private DevExpress.XtraEditors.SimpleButton btnProductUpdate;
        private DevExpress.XtraEditors.SimpleButton btnProductDelete;
        private DevExpress.XtraEditors.SimpleButton bntProductListRefresh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtProductId;
    }
}