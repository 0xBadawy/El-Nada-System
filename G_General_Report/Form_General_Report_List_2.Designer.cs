
namespace FWD.G_General_Report
{
    partial class Form_General_Report_List_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_General_Report_List_2));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmploee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_create_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_attend = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_day = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_dessition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral_report_table = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(462, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.btn_ref);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 59);
            this.panel2.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(312, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(144, 44);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "تعديل";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(162, 6);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 722);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_General_report);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1430, 663);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmploee_Name,
            this.colGeneral_report_create_date,
            this.colGeneral_report_attend,
            this.colGeneral_report_date,
            this.colGeneral_report_day,
            this.colGeneral_report_dessition,
            this.colGeneral_report_end,
            this.colGeneral_report_ID,
            this.colGeneral_report_start,
            this.colGeneral_report_Number,
            this.colGeneral_report_table});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1221, 427, 264, 434);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colEmploee_Name
            // 
            this.colEmploee_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colEmploee_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmploee_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmploee_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmploee_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmploee_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEmploee_Name.Caption = "الموظف";
            this.colEmploee_Name.FieldName = "Emploee_Name";
            this.colEmploee_Name.Name = "colEmploee_Name";
            this.colEmploee_Name.Visible = true;
            this.colEmploee_Name.VisibleIndex = 0;
            this.colEmploee_Name.Width = 184;
            // 
            // colGeneral_report_create_date
            // 
            this.colGeneral_report_create_date.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_create_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_create_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_create_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_create_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_create_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_create_date.Caption = "تاريخ الكتابة";
            this.colGeneral_report_create_date.FieldName = "General_report_create_date";
            this.colGeneral_report_create_date.Name = "colGeneral_report_create_date";
            this.colGeneral_report_create_date.Visible = true;
            this.colGeneral_report_create_date.VisibleIndex = 1;
            this.colGeneral_report_create_date.Width = 134;
            // 
            // colGeneral_report_attend
            // 
            this.colGeneral_report_attend.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_attend.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_attend.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_attend.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_attend.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_attend.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_attend.Caption = "الحضور";
            this.colGeneral_report_attend.FieldName = "General_report_attend";
            this.colGeneral_report_attend.Name = "colGeneral_report_attend";
            this.colGeneral_report_attend.Width = 124;
            // 
            // colGeneral_report_date
            // 
            this.colGeneral_report_date.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_date.Caption = "التاريخ";
            this.colGeneral_report_date.FieldName = "General_report_date";
            this.colGeneral_report_date.Name = "colGeneral_report_date";
            this.colGeneral_report_date.Visible = true;
            this.colGeneral_report_date.VisibleIndex = 4;
            this.colGeneral_report_date.Width = 134;
            // 
            // colGeneral_report_day
            // 
            this.colGeneral_report_day.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_day.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_day.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_day.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_day.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_day.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_day.Caption = "اليوم";
            this.colGeneral_report_day.FieldName = "General_report_day";
            this.colGeneral_report_day.Name = "colGeneral_report_day";
            this.colGeneral_report_day.Visible = true;
            this.colGeneral_report_day.VisibleIndex = 5;
            this.colGeneral_report_day.Width = 134;
            // 
            // colGeneral_report_dessition
            // 
            this.colGeneral_report_dessition.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_dessition.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_dessition.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_dessition.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_dessition.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_dessition.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_dessition.Caption = "القرارات";
            this.colGeneral_report_dessition.FieldName = "General_report_dessition";
            this.colGeneral_report_dessition.Name = "colGeneral_report_dessition";
            this.colGeneral_report_dessition.Visible = true;
            this.colGeneral_report_dessition.VisibleIndex = 6;
            this.colGeneral_report_dessition.Width = 221;
            // 
            // colGeneral_report_end
            // 
            this.colGeneral_report_end.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_end.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_end.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_end.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_end.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_end.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_end.Caption = "النهاية";
            this.colGeneral_report_end.FieldName = "General_report_end";
            this.colGeneral_report_end.Name = "colGeneral_report_end";
            this.colGeneral_report_end.Visible = true;
            this.colGeneral_report_end.VisibleIndex = 2;
            this.colGeneral_report_end.Width = 134;
            // 
            // colGeneral_report_ID
            // 
            this.colGeneral_report_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_ID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_ID.Caption = "ID";
            this.colGeneral_report_ID.FieldName = "General_report_ID";
            this.colGeneral_report_ID.Name = "colGeneral_report_ID";
            this.colGeneral_report_ID.Visible = true;
            this.colGeneral_report_ID.VisibleIndex = 9;
            this.colGeneral_report_ID.Width = 45;
            // 
            // colGeneral_report_start
            // 
            this.colGeneral_report_start.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_start.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_start.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_start.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_start.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_start.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_start.Caption = "البداية";
            this.colGeneral_report_start.FieldName = "General_report_start";
            this.colGeneral_report_start.Name = "colGeneral_report_start";
            this.colGeneral_report_start.Visible = true;
            this.colGeneral_report_start.VisibleIndex = 3;
            this.colGeneral_report_start.Width = 134;
            // 
            // colGeneral_report_Number
            // 
            this.colGeneral_report_Number.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_Number.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_Number.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_Number.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_Number.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_Number.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_Number.Caption = "رقم المحضر";
            this.colGeneral_report_Number.FieldName = "General_report_Number";
            this.colGeneral_report_Number.Name = "colGeneral_report_Number";
            this.colGeneral_report_Number.Visible = true;
            this.colGeneral_report_Number.VisibleIndex = 8;
            this.colGeneral_report_Number.Width = 91;
            // 
            // colGeneral_report_table
            // 
            this.colGeneral_report_table.AppearanceCell.Options.UseTextOptions = true;
            this.colGeneral_report_table.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_table.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_table.AppearanceHeader.Options.UseTextOptions = true;
            this.colGeneral_report_table.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGeneral_report_table.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colGeneral_report_table.Caption = "جدول الاعمال";
            this.colGeneral_report_table.FieldName = "General_report_table";
            this.colGeneral_report_table.Name = "colGeneral_report_table";
            this.colGeneral_report_table.Visible = true;
            this.colGeneral_report_table.VisibleIndex = 7;
            this.colGeneral_report_table.Width = 189;
            // 
            // Form_General_Report_List_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 722);
            this.Controls.Add(this.panel1);
            this.Name = "Form_General_Report_List_2";
            this.Text = "Form_General_Report_List_2";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        public System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_create_date;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_attend;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_date;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_day;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_dessition;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_end;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_start;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral_report_table;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}