
namespace FWD.G_General_Report
{
    partial class Form_General_Report_List
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_General_Report_List));
            this.colGeneral_report_Number = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_date = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colEmploee_Name = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_attend = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_create_date = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_day = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_dessition = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_end = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_start = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_table = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGeneral_report_ID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colGeneral_report_Number
            // 
            this.colGeneral_report_Number.FieldName = "General_report_Number";
            this.colGeneral_report_Number.Name = "colGeneral_report_Number";
            this.colGeneral_report_Number.Visible = true;
            this.colGeneral_report_Number.VisibleIndex = 7;
            // 
            // colGeneral_report_date
            // 
            this.colGeneral_report_date.FieldName = "General_report_date";
            this.colGeneral_report_date.Name = "colGeneral_report_date";
            this.colGeneral_report_date.Visible = true;
            this.colGeneral_report_date.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 744);
            this.panel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_General_report);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1419, 685);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmploee_Name,
            this.colGeneral_report_attend,
            this.colGeneral_report_create_date,
            this.colGeneral_report_date,
            this.colGeneral_report_day,
            this.colGeneral_report_dessition,
            this.colGeneral_report_end,
            this.colGeneral_report_Number,
            this.colGeneral_report_start,
            this.colGeneral_report_table,
            this.colGeneral_report_ID});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.IndentBetweenGroups = 90;
            this.tileView1.OptionsTiles.IndentBetweenItems = 30;
            this.tileView1.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(10);
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(308, 310);
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(22);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 128D;
            tableColumnDefinition2.Length.Value = 182D;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 83D;
            tableRowDefinition2.Length.Value = 63D;
            tableRowDefinition3.Length.Value = 62D;
            tableRowDefinition4.Length.Value = 53D;
            tableRowDefinition5.Length.Value = 0D;
            tableRowDefinition6.Length.Value = 29D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition4);
            this.tileView1.TileRows.Add(tableRowDefinition5);
            this.tileView1.TileRows.Add(tableRowDefinition6);
            tableSpan1.ColumnSpan = 2;
            tableSpan2.ColumnSpan = 2;
            tableSpan2.RowIndex = 3;
            this.tileView1.TileSpans.Add(tableSpan1);
            this.tileView1.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Changa SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "محضر مجلس ادارة";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Changa SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "   رقم  ";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Changa SemiBold", 21.75F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.colGeneral_report_Number;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colGeneral_report_Number";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 18.25F, System.Drawing.FontStyle.Bold);
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Column = this.colGeneral_report_date;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 3;
            tileViewItemElement4.Text = "colGeneral_report_date";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            // 
            // colEmploee_Name
            // 
            this.colEmploee_Name.FieldName = "Emploee_Name";
            this.colEmploee_Name.Name = "colEmploee_Name";
            this.colEmploee_Name.Visible = true;
            this.colEmploee_Name.VisibleIndex = 0;
            // 
            // colGeneral_report_attend
            // 
            this.colGeneral_report_attend.FieldName = "General_report_attend";
            this.colGeneral_report_attend.Name = "colGeneral_report_attend";
            this.colGeneral_report_attend.Visible = true;
            this.colGeneral_report_attend.VisibleIndex = 1;
            // 
            // colGeneral_report_create_date
            // 
            this.colGeneral_report_create_date.FieldName = "General_report_create_date";
            this.colGeneral_report_create_date.Name = "colGeneral_report_create_date";
            this.colGeneral_report_create_date.Visible = true;
            this.colGeneral_report_create_date.VisibleIndex = 2;
            // 
            // colGeneral_report_day
            // 
            this.colGeneral_report_day.FieldName = "General_report_day";
            this.colGeneral_report_day.Name = "colGeneral_report_day";
            this.colGeneral_report_day.Visible = true;
            this.colGeneral_report_day.VisibleIndex = 4;
            // 
            // colGeneral_report_dessition
            // 
            this.colGeneral_report_dessition.FieldName = "General_report_dessition";
            this.colGeneral_report_dessition.Name = "colGeneral_report_dessition";
            this.colGeneral_report_dessition.Visible = true;
            this.colGeneral_report_dessition.VisibleIndex = 5;
            // 
            // colGeneral_report_end
            // 
            this.colGeneral_report_end.FieldName = "General_report_end";
            this.colGeneral_report_end.Name = "colGeneral_report_end";
            this.colGeneral_report_end.Visible = true;
            this.colGeneral_report_end.VisibleIndex = 6;
            // 
            // colGeneral_report_start
            // 
            this.colGeneral_report_start.FieldName = "General_report_start";
            this.colGeneral_report_start.Name = "colGeneral_report_start";
            this.colGeneral_report_start.Visible = true;
            this.colGeneral_report_start.VisibleIndex = 8;
            // 
            // colGeneral_report_table
            // 
            this.colGeneral_report_table.FieldName = "General_report_table";
            this.colGeneral_report_table.Name = "colGeneral_report_table";
            this.colGeneral_report_table.Visible = true;
            this.colGeneral_report_table.VisibleIndex = 9;
            // 
            // colGeneral_report_ID
            // 
            this.colGeneral_report_ID.FieldName = "General_report_ID";
            this.colGeneral_report_ID.Name = "colGeneral_report_ID";
            this.colGeneral_report_ID.Visible = true;
            this.colGeneral_report_ID.VisibleIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.btn_ref);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 59);
            this.panel2.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(347, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(144, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تعديل";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(507, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(187, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.Location = new System.Drawing.Point(12, 7);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 44);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form_General_Report_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 744);
            this.Controls.Add(this.panel1);
            this.Name = "Form_General_Report_List";
            this.Text = "Form_General_Report_List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEmploee_Name;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_attend;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_create_date;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_date;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_day;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_dessition;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_end;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_Number;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_start;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_table;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGeneral_report_ID;
        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}