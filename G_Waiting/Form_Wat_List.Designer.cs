
namespace FWD.G_Waiting
{
    partial class Form_Wat_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Wat_List));
            this.Pn_frm_wat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Date_Order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Date_Bairth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Done_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Done_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Phone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Phone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Supp_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWAT_Supp_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Key = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.Pn_frm_wat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pn_frm_wat
            // 
            this.Pn_frm_wat.Controls.Add(this.gridControl1);
            this.Pn_frm_wat.Controls.Add(this.panel1);
            this.Pn_frm_wat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_wat.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_wat.Name = "Pn_frm_wat";
            this.Pn_frm_wat.Size = new System.Drawing.Size(1555, 809);
            this.Pn_frm_wat.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Wating_List_List);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1555, 750);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAge,
            this.colID,
            this.colWAT_Cat,
            this.colWAT_Add,
            this.colWAT_Date_Order,
            this.colWAT_Date_Bairth,
            this.colWAT_Done_Date,
            this.colWAT_Det,
            this.colWAT_Done_state,
            this.colWAT_Name,
            this.colWAT_Phone1,
            this.colWAT_Phone2,
            this.colWAT_SSN,
            this.colWAT_Supp_name,
            this.colWAT_Supp_Phone,
            this.colLOC_Key});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1338, 446, 264, 444);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colWAT_Date_Order, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colAge
            // 
            this.colAge.Caption = "السن";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.OptionsColumn.AllowEdit = false;
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 6;
            this.colAge.Width = 57;
            // 
            // colID
            // 
            this.colID.Caption = "الكود";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 10;
            this.colID.Width = 77;
            // 
            // colWAT_Cat
            // 
            this.colWAT_Cat.Caption = "الفئة";
            this.colWAT_Cat.FieldName = "WL_Category";
            this.colWAT_Cat.Name = "colWAT_Cat";
            this.colWAT_Cat.OptionsColumn.AllowEdit = false;
            this.colWAT_Cat.Visible = true;
            this.colWAT_Cat.VisibleIndex = 8;
            this.colWAT_Cat.Width = 122;
            // 
            // colWAT_Add
            // 
            this.colWAT_Add.Caption = "العنوان";
            this.colWAT_Add.FieldName = "LOC_Name";
            this.colWAT_Add.Name = "colWAT_Add";
            this.colWAT_Add.OptionsColumn.AllowEdit = false;
            this.colWAT_Add.Visible = true;
            this.colWAT_Add.VisibleIndex = 3;
            this.colWAT_Add.Width = 131;
            // 
            // colWAT_Date_Order
            // 
            this.colWAT_Date_Order.Caption = "تاريخ الطلب";
            this.colWAT_Date_Order.FieldName = "WAT_Date_Order";
            this.colWAT_Date_Order.Name = "colWAT_Date_Order";
            this.colWAT_Date_Order.OptionsColumn.AllowEdit = false;
            this.colWAT_Date_Order.Visible = true;
            this.colWAT_Date_Order.VisibleIndex = 4;
            this.colWAT_Date_Order.Width = 128;
            // 
            // colWAT_Date_Bairth
            // 
            this.colWAT_Date_Bairth.Caption = "تاريخ الميلاد";
            this.colWAT_Date_Bairth.FieldName = "WAT_Date_Bairth";
            this.colWAT_Date_Bairth.Name = "colWAT_Date_Bairth";
            this.colWAT_Date_Bairth.OptionsColumn.AllowEdit = false;
            this.colWAT_Date_Bairth.Width = 113;
            // 
            // colWAT_Done_Date
            // 
            this.colWAT_Done_Date.Caption = "تاريخ التنفيذ";
            this.colWAT_Done_Date.FieldName = "WAT_Done_Date";
            this.colWAT_Done_Date.Name = "colWAT_Done_Date";
            this.colWAT_Done_Date.OptionsColumn.AllowEdit = false;
            this.colWAT_Done_Date.Visible = true;
            this.colWAT_Done_Date.VisibleIndex = 0;
            this.colWAT_Done_Date.Width = 133;
            // 
            // colWAT_Det
            // 
            this.colWAT_Det.Caption = "التفاصيل";
            this.colWAT_Det.FieldName = "WAT_Det";
            this.colWAT_Det.Name = "colWAT_Det";
            this.colWAT_Det.OptionsColumn.AllowEdit = false;
            this.colWAT_Det.Visible = true;
            this.colWAT_Det.VisibleIndex = 2;
            this.colWAT_Det.Width = 209;
            // 
            // colWAT_Done_state
            // 
            this.colWAT_Done_state.Caption = "الحالة";
            this.colWAT_Done_state.FieldName = "WAT_Done_state";
            this.colWAT_Done_state.Name = "colWAT_Done_state";
            this.colWAT_Done_state.OptionsColumn.AllowEdit = false;
            this.colWAT_Done_state.Visible = true;
            this.colWAT_Done_state.VisibleIndex = 1;
            this.colWAT_Done_state.Width = 118;
            // 
            // colWAT_Name
            // 
            this.colWAT_Name.Caption = "الاسم";
            this.colWAT_Name.FieldName = "WAT_Name";
            this.colWAT_Name.Name = "colWAT_Name";
            this.colWAT_Name.OptionsColumn.AllowEdit = false;
            this.colWAT_Name.Visible = true;
            this.colWAT_Name.VisibleIndex = 9;
            this.colWAT_Name.Width = 274;
            // 
            // colWAT_Phone1
            // 
            this.colWAT_Phone1.Caption = "رقم تلفون 1";
            this.colWAT_Phone1.FieldName = "WAT_Phone1";
            this.colWAT_Phone1.Name = "colWAT_Phone1";
            this.colWAT_Phone1.OptionsColumn.AllowEdit = false;
            this.colWAT_Phone1.Visible = true;
            this.colWAT_Phone1.VisibleIndex = 5;
            this.colWAT_Phone1.Width = 133;
            // 
            // colWAT_Phone2
            // 
            this.colWAT_Phone2.Caption = "رقم تلفون 2";
            this.colWAT_Phone2.FieldName = "WAT_Phone2";
            this.colWAT_Phone2.Name = "colWAT_Phone2";
            this.colWAT_Phone2.OptionsColumn.AllowEdit = false;
            this.colWAT_Phone2.Width = 113;
            // 
            // colWAT_SSN
            // 
            this.colWAT_SSN.Caption = "الرقم القومى";
            this.colWAT_SSN.FieldName = "WAT_SSN";
            this.colWAT_SSN.Name = "colWAT_SSN";
            this.colWAT_SSN.OptionsColumn.AllowEdit = false;
            this.colWAT_SSN.Visible = true;
            this.colWAT_SSN.VisibleIndex = 7;
            this.colWAT_SSN.Width = 143;
            // 
            // colWAT_Supp_name
            // 
            this.colWAT_Supp_name.Caption = "اسم المندوب";
            this.colWAT_Supp_name.FieldName = "SUPP_Name";
            this.colWAT_Supp_name.Name = "colWAT_Supp_name";
            this.colWAT_Supp_name.OptionsColumn.AllowEdit = false;
            this.colWAT_Supp_name.Width = 45;
            // 
            // colWAT_Supp_Phone
            // 
            this.colWAT_Supp_Phone.Caption = "تلفون المندوب";
            this.colWAT_Supp_Phone.FieldName = "SUPP_Phone1";
            this.colWAT_Supp_Phone.Name = "colWAT_Supp_Phone";
            this.colWAT_Supp_Phone.OptionsColumn.AllowEdit = false;
            this.colWAT_Supp_Phone.Width = 166;
            // 
            // colLOC_Key
            // 
            this.colLOC_Key.Caption = "كود المنطقة";
            this.colLOC_Key.FieldName = "LOC_Key";
            this.colLOC_Key.Name = "colLOC_Key";
            this.colLOC_Key.OptionsColumn.AllowEdit = false;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1555, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 809);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1555, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 809);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1555, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 809);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "اااااااااااااااا";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 750);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1555, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(605, 11);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(211, 36);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تغير حالة الانتظار";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(368, 7);
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
            // Form_Wat_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 809);
            this.Controls.Add(this.Pn_frm_wat);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Wat_List";
            this.Text = "Form_Wat_List";
            this.Pn_frm_wat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel Pn_frm_wat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Date_Order;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Date_Bairth;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Done_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Done_state;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Phone1;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Phone2;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_SSN;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Supp_name;
        private DevExpress.XtraGrid.Columns.GridColumn colWAT_Supp_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Key;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}