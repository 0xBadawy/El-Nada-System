
namespace FWD.G_Customers
{
    partial class Form_cus_print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cus_print));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUST_Main_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRank_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Person_Phone_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Person_Gen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge_person = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Person_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Father_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1497, 852);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(1497, 790);
            this.panel4.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_CUST_Main_data_01);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.Size = new System.Drawing.Size(1497, 790);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCUST_Main_ID,
            this.colRank_Name,
            this.colLOC_Name,
            this.colCUST_Person_Phone_1,
            this.colCUST_Person_Gen,
            this.colAge_person,
            this.colCUST_Person_Name,
            this.colCUST_Father_Name});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(487, 368, 264, 434);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCUST_Main_ID
            // 
            this.colCUST_Main_ID.Caption = "الكود";
            this.colCUST_Main_ID.FieldName = "CUST_Main_ID";
            this.colCUST_Main_ID.Name = "colCUST_Main_ID";
            this.colCUST_Main_ID.Visible = true;
            this.colCUST_Main_ID.VisibleIndex = 7;
            this.colCUST_Main_ID.Width = 77;
            // 
            // colRank_Name
            // 
            this.colRank_Name.Caption = "درجة الحالة";
            this.colRank_Name.FieldName = "Rank_Name";
            this.colRank_Name.Name = "colRank_Name";
            this.colRank_Name.Visible = true;
            this.colRank_Name.VisibleIndex = 0;
            this.colRank_Name.Width = 157;
            // 
            // colLOC_Name
            // 
            this.colLOC_Name.Caption = "العنوان";
            this.colLOC_Name.FieldName = "LOC_Name";
            this.colLOC_Name.Name = "colLOC_Name";
            this.colLOC_Name.Visible = true;
            this.colLOC_Name.VisibleIndex = 1;
            this.colLOC_Name.Width = 107;
            // 
            // colCUST_Person_Phone_1
            // 
            this.colCUST_Person_Phone_1.Caption = "تلفون 1";
            this.colCUST_Person_Phone_1.FieldName = "CUST_Person_Phone_1";
            this.colCUST_Person_Phone_1.Name = "colCUST_Person_Phone_1";
            this.colCUST_Person_Phone_1.Visible = true;
            this.colCUST_Person_Phone_1.VisibleIndex = 2;
            this.colCUST_Person_Phone_1.Width = 188;
            // 
            // colCUST_Person_Gen
            // 
            this.colCUST_Person_Gen.Caption = "النوع";
            this.colCUST_Person_Gen.FieldName = "CUST_Person_Gen";
            this.colCUST_Person_Gen.Name = "colCUST_Person_Gen";
            this.colCUST_Person_Gen.Visible = true;
            this.colCUST_Person_Gen.VisibleIndex = 3;
            this.colCUST_Person_Gen.Width = 72;
            // 
            // colAge_person
            // 
            this.colAge_person.Caption = "السن";
            this.colAge_person.FieldName = "Age_person";
            this.colAge_person.Name = "colAge_person";
            this.colAge_person.Visible = true;
            this.colAge_person.VisibleIndex = 4;
            this.colAge_person.Width = 125;
            // 
            // colCUST_Person_Name
            // 
            this.colCUST_Person_Name.Caption = "اسم الحالة";
            this.colCUST_Person_Name.FieldName = "CUST_Person_Name";
            this.colCUST_Person_Name.Name = "colCUST_Person_Name";
            this.colCUST_Person_Name.Visible = true;
            this.colCUST_Person_Name.VisibleIndex = 6;
            this.colCUST_Person_Name.Width = 455;
            // 
            // colCUST_Father_Name
            // 
            this.colCUST_Father_Name.Caption = "اسم الزوج";
            this.colCUST_Father_Name.FieldName = "CUST_Father_Name";
            this.colCUST_Father_Name.Name = "colCUST_Father_Name";
            this.colCUST_Father_Name.Visible = true;
            this.colCUST_Father_Name.VisibleIndex = 5;
            this.colCUST_Father_Name.Width = 286;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.simpleButton4);
            this.panel3.Controls.Add(this.simpleButton3);
            this.panel3.Controls.Add(this.simpleButton2);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 790);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1497, 62);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseTextOptions = true;
            this.simpleButton4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(901, 6);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(201, 49);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "طباعة البحث";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(680, 6);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(201, 49);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "طباعة القائمة";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(445, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(219, 48);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تعديل قبل الطباعة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(4921, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(158, 34);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "التفاصيل";
            // 
            // Form_cus_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 852);
            this.Controls.Add(this.panel1);
            this.Name = "Form_cus_print";
            this.Text = "Form_cus_print";
            this.Load += new System.EventHandler(this.Form_cus_print_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Main_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRank_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Person_Phone_1;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Person_Gen;
        private DevExpress.XtraGrid.Columns.GridColumn colAge_person;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Person_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Father_Name;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}