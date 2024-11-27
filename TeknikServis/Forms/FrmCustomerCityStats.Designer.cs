namespace TeknikServis.Forms
{
    partial class FrmCustomerCityStats
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.grcCustomerCityList = new DevExpress.XtraGrid.GridControl();
            this.gvwCustomerCities = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomerCityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomerCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grcCustomerCityList
            // 
            this.grcCustomerCityList.Location = new System.Drawing.Point(1, 2);
            this.grcCustomerCityList.MainView = this.gvwCustomerCities;
            this.grcCustomerCityList.Name = "grcCustomerCityList";
            this.grcCustomerCityList.Size = new System.Drawing.Size(384, 536);
            this.grcCustomerCityList.TabIndex = 9;
            this.grcCustomerCityList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwCustomerCities});
            // 
            // gvwCustomerCities
            // 
            this.gvwCustomerCities.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.gvwCustomerCities.Appearance.Row.BorderColor = System.Drawing.Color.Black;
            this.gvwCustomerCities.Appearance.Row.Options.UseBackColor = true;
            this.gvwCustomerCities.Appearance.Row.Options.UseBorderColor = true;
            this.gvwCustomerCities.GridControl = this.grcCustomerCityList;
            this.gvwCustomerCities.Name = "gvwCustomerCities";
            this.gvwCustomerCities.OptionsView.ShowGroupPanel = false;
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            simpleDiagram3D1.RotationMatrixSerializable = "0.720346198222537;-0.179924140264866;0.669872120972571;0;0.468910095418127;0.8379" +
    "66768585722;-0.279168438690642;0;-0.511101435256549;0.515207723637714;0.68799442" +
    "176717;0;0;0;0;1";
            this.chartControl1.Diagram = simpleDiagram3D1;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.Transparent;
            legend1.LegendID = 1;
            legend1.Name = "Legend 1";
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartControl1.Location = new System.Drawing.Point(391, 2);
            this.chartControl1.Name = "chartControl1";
            series1.LegendName = "Legend 1";
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = pie3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(973, 536);
            this.chartControl1.TabIndex = 10;
            // 
            // FrmCustomerCityStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.grcCustomerCityList);
            this.Name = "FrmCustomerCityStats";
            this.Text = "Customer City Stats";
            this.Load += new System.EventHandler(this.FrmCustomerCityStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomerCityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomerCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcCustomerCityList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwCustomerCities;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}