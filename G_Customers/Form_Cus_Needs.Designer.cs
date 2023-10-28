
namespace FWD.G_Customers
{
    partial class Form_Cus_Needs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Needs));
            this.label12 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUST_Need_type_det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFamily_Needs_Type_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Need_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Button_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_need_type = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_need_det = new DevExpress.XtraEditors.TextEdit();
            this.tBFamilyNeedsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2097 = new FWD.DB_FWDDataSet2097();
            this.panel_Form_Cus_Needs = new System.Windows.Forms.Panel();
            this.tB_Family_Needs_TypeTableAdapter = new FWD.DB_FWDDataSet2097TableAdapters.TB_Family_Needs_TypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_need_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_need_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFamilyNeedsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2097)).BeginInit();
            this.panel_Form_Cus_Needs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(650, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 72);
            this.label12.TabIndex = 50;
            this.label12.Text = "احتيجات الاسرة";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_CUST_Need);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 381);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1616, 426);
            this.gridControl1.TabIndex = 51;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCUST_Need_type_det,
            this.colFamily_Needs_Type_Name,
            this.colCUST_Need_ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCUST_Need_type_det
            // 
            this.colCUST_Need_type_det.Caption = "التفاصيل";
            this.colCUST_Need_type_det.FieldName = "CUST_Need_type_det";
            this.colCUST_Need_type_det.Name = "colCUST_Need_type_det";
            this.colCUST_Need_type_det.Visible = true;
            this.colCUST_Need_type_det.VisibleIndex = 0;
            this.colCUST_Need_type_det.Width = 784;
            // 
            // colFamily_Needs_Type_Name
            // 
            this.colFamily_Needs_Type_Name.Caption = "النوع";
            this.colFamily_Needs_Type_Name.FieldName = "Family_Needs_Type_Name";
            this.colFamily_Needs_Type_Name.Name = "colFamily_Needs_Type_Name";
            this.colFamily_Needs_Type_Name.Visible = true;
            this.colFamily_Needs_Type_Name.VisibleIndex = 1;
            this.colFamily_Needs_Type_Name.Width = 716;
            // 
            // colCUST_Need_ID
            // 
            this.colCUST_Need_ID.Caption = "ID";
            this.colCUST_Need_ID.FieldName = "CUST_Need_ID";
            this.colCUST_Need_ID.Name = "colCUST_Need_ID";
            this.colCUST_Need_ID.Visible = true;
            this.colCUST_Need_ID.VisibleIndex = 2;
            this.colCUST_Need_ID.Width = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 807);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 62);
            this.panel1.TabIndex = 52;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(194, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 41);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تحديث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "حذف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Button_add
            // 
            this.Button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button_add.Appearance.Options.UseFont = true;
            this.Button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.ImageOptions.Image")));
            this.Button_add.Location = new System.Drawing.Point(550, 116);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(252, 50);
            this.Button_add.TabIndex = 53;
            this.Button_add.Text = "اضافة";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edit_need_type);
            this.groupBox1.Controls.Add(this.Button_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edit_need_det);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(55, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1526, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edit_need_type
            // 
            this.edit_need_type.Location = new System.Drawing.Point(955, 42);
            this.edit_need_type.Name = "edit_need_type";
            this.edit_need_type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_need_type.Properties.Appearance.Options.UseFont = true;
            this.edit_need_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_need_type.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Family_Needs_Type_Name", "Family_Needs_Type_Name", 145, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edit_need_type.Properties.DataSource = typeof(FWD.TB_Family_Needs_Type);
            this.edit_need_type.Properties.DisplayMember = "Family_Needs_Type_Name";
            this.edit_need_type.Properties.NullText = " ";
            this.edit_need_type.Properties.ValueMember = "Family_Needs_Type_ID";
            this.edit_need_type.Size = new System.Drawing.Size(296, 40);
            this.edit_need_type.TabIndex = 55;
            this.edit_need_type.Click += new System.EventHandler(this.lookUpEdit1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "التفاصيل";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1257, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 43);
            this.label2.TabIndex = 50;
            this.label2.Text = "النوع";
            // 
            // edit_need_det
            // 
            this.edit_need_det.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_need_det.EditValue = "";
            this.edit_need_det.Location = new System.Drawing.Point(120, 42);
            this.edit_need_det.Name = "edit_need_det";
            this.edit_need_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_need_det.Properties.Appearance.Options.UseFont = true;
            this.edit_need_det.Properties.Appearance.Options.UseTextOptions = true;
            this.edit_need_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edit_need_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edit_need_det.Size = new System.Drawing.Size(682, 40);
            this.edit_need_det.TabIndex = 2;
            // 
            // tBFamilyNeedsTypeBindingSource
            // 
            this.tBFamilyNeedsTypeBindingSource.DataMember = "TB_Family_Needs_Type";
            this.tBFamilyNeedsTypeBindingSource.DataSource = this.dB_FWDDataSet2097;
            // 
            // dB_FWDDataSet2097
            // 
            this.dB_FWDDataSet2097.DataSetName = "DB_FWDDataSet2097";
            this.dB_FWDDataSet2097.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_Form_Cus_Needs
            // 
            this.panel_Form_Cus_Needs.AutoScroll = true;
            this.panel_Form_Cus_Needs.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Needs.Controls.Add(this.gridControl1);
            this.panel_Form_Cus_Needs.Controls.Add(this.panel1);
            this.panel_Form_Cus_Needs.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Needs.Controls.Add(this.label12);
            this.panel_Form_Cus_Needs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Needs.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Needs.Name = "panel_Form_Cus_Needs";
            this.panel_Form_Cus_Needs.Size = new System.Drawing.Size(1616, 869);
            this.panel_Form_Cus_Needs.TabIndex = 4;
            this.panel_Form_Cus_Needs.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Cus_Incom_Paint);
            // 
            // tB_Family_Needs_TypeTableAdapter
            // 
            this.tB_Family_Needs_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Cus_Needs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1616, 869);
            this.Controls.Add(this.panel_Form_Cus_Needs);
            this.Name = "Form_Cus_Needs";
            this.Text = "Form_Cus_Needs";
            this.Load += new System.EventHandler(this.Form_Cus_Needs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_need_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_need_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFamilyNeedsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2097)).EndInit();
            this.panel_Form_Cus_Needs.ResumeLayout(false);
            this.panel_Form_Cus_Needs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton Button_add;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel panel_Form_Cus_Needs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edit_need_det;
        private DevExpress.XtraEditors.LookUpEdit edit_need_type;
        private DB_FWDDataSet2097 dB_FWDDataSet2097;
        private System.Windows.Forms.BindingSource tBFamilyNeedsTypeBindingSource;
        private DB_FWDDataSet2097TableAdapters.TB_Family_Needs_TypeTableAdapter tB_Family_Needs_TypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Need_type_det;
        private DevExpress.XtraGrid.Columns.GridColumn colFamily_Needs_Type_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Need_ID;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}