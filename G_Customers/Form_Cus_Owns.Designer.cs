
namespace FWD.G_Customers
{
    partial class Form_Cus_Owns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Owns));
            this.panel_Form_Cus_Owns = new System.Windows.Forms.Panel();
            this.Button_Add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUST_Property_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Property_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Property_value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFamily_Owns_Type_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_owns_Type = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_owns_val = new DevExpress.XtraEditors.TextEdit();
            this.edit_owns_det = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.tBFamilyOwnsTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2098 = new FWD.DB_FWDDataSet2098();
            this.tB_Family_Owns_TypeTableAdapter = new FWD.DB_FWDDataSet2098TableAdapters.TB_Family_Owns_TypeTableAdapter();
            this.panel_Form_Cus_Owns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_Type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_val.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFamilyOwnsTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2098)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Form_Cus_Owns
            // 
            this.panel_Form_Cus_Owns.AutoScroll = true;
            this.panel_Form_Cus_Owns.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Owns.Controls.Add(this.Button_Add);
            this.panel_Form_Cus_Owns.Controls.Add(this.gridControl1);
            this.panel_Form_Cus_Owns.Controls.Add(this.panel1);
            this.panel_Form_Cus_Owns.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Owns.Controls.Add(this.label12);
            this.panel_Form_Cus_Owns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Owns.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Owns.Name = "panel_Form_Cus_Owns";
            this.panel_Form_Cus_Owns.Size = new System.Drawing.Size(1450, 782);
            this.panel_Form_Cus_Owns.TabIndex = 3;
            this.panel_Form_Cus_Owns.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Cus_Owns_Paint);
            // 
            // Button_Add
            // 
            this.Button_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button_Add.Appearance.Options.UseFont = true;
            this.Button_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Add.ImageOptions.Image")));
            this.Button_Add.Location = new System.Drawing.Point(596, 257);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(252, 50);
            this.Button_Add.TabIndex = 53;
            this.Button_Add.Text = "اضافة";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_CUST_Propert);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 409);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1450, 311);
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
            this.colCUST_Property_Det,
            this.colCUST_Property_ID,
            this.colCUST_Property_value,
            this.colFamily_Owns_Type_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCUST_Property_Det
            // 
            this.colCUST_Property_Det.Caption = "التفاصيل";
            this.colCUST_Property_Det.FieldName = "CUST_Property_Det";
            this.colCUST_Property_Det.Name = "colCUST_Property_Det";
            this.colCUST_Property_Det.Visible = true;
            this.colCUST_Property_Det.VisibleIndex = 0;
            this.colCUST_Property_Det.Width = 527;
            // 
            // colCUST_Property_ID
            // 
            this.colCUST_Property_ID.Caption = "ID";
            this.colCUST_Property_ID.FieldName = "CUST_Property_ID";
            this.colCUST_Property_ID.Name = "colCUST_Property_ID";
            this.colCUST_Property_ID.Visible = true;
            this.colCUST_Property_ID.VisibleIndex = 3;
            this.colCUST_Property_ID.Width = 146;
            // 
            // colCUST_Property_value
            // 
            this.colCUST_Property_value.Caption = "القيمة";
            this.colCUST_Property_value.FieldName = "CUST_Property_value";
            this.colCUST_Property_value.Name = "colCUST_Property_value";
            this.colCUST_Property_value.Visible = true;
            this.colCUST_Property_value.VisibleIndex = 1;
            this.colCUST_Property_value.Width = 208;
            // 
            // colFamily_Owns_Type_Name
            // 
            this.colFamily_Owns_Type_Name.Caption = "الاسم";
            this.colFamily_Owns_Type_Name.FieldName = "Family_Owns_Type_Name";
            this.colFamily_Owns_Type_Name.Name = "colFamily_Owns_Type_Name";
            this.colFamily_Owns_Type_Name.Visible = true;
            this.colFamily_Owns_Type_Name.VisibleIndex = 2;
            this.colFamily_Owns_Type_Name.Width = 539;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 62);
            this.panel1.TabIndex = 52;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
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
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "حذف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edit_owns_Type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edit_owns_val);
            this.groupBox1.Controls.Add(this.edit_owns_det);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(55, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1329, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edit_owns_Type
            // 
            this.edit_owns_Type.Location = new System.Drawing.Point(988, 43);
            this.edit_owns_Type.Name = "edit_owns_Type";
            this.edit_owns_Type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_owns_Type.Properties.Appearance.Options.UseFont = true;
            this.edit_owns_Type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_owns_Type.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Family_Owns_Type_Name", "Family_Owns_Type_Name", 144, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edit_owns_Type.Properties.DataSource = typeof(FWD.TB_Family_Owns_Type);
            this.edit_owns_Type.Properties.DisplayMember = "Family_Owns_Type_Name";
            this.edit_owns_Type.Properties.NullText = " ";
            this.edit_owns_Type.Properties.ValueMember = "Family_Owns_Type_ID";
            this.edit_owns_Type.Size = new System.Drawing.Size(265, 40);
            this.edit_owns_Type.TabIndex = 58;
            this.edit_owns_Type.EditValueChanged += new System.EventHandler(this.edit_owns_Type_EditValueChanged);
            this.edit_owns_Type.Click += new System.EventHandler(this.lookUpEdit1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 43);
            this.label3.TabIndex = 56;
            this.label3.Text = "القيمة";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 43);
            this.label1.TabIndex = 56;
            this.label1.Text = "التفاصيل";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1259, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 43);
            this.label2.TabIndex = 57;
            this.label2.Text = "النوع";
            // 
            // edit_owns_val
            // 
            this.edit_owns_val.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_owns_val.EditValue = "";
            this.edit_owns_val.Location = new System.Drawing.Point(24, 41);
            this.edit_owns_val.Name = "edit_owns_val";
            this.edit_owns_val.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_owns_val.Properties.Appearance.Options.UseFont = true;
            this.edit_owns_val.Properties.Appearance.Options.UseTextOptions = true;
            this.edit_owns_val.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edit_owns_val.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edit_owns_val.Size = new System.Drawing.Size(177, 40);
            this.edit_owns_val.TabIndex = 55;
            // 
            // edit_owns_det
            // 
            this.edit_owns_det.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_owns_det.EditValue = "";
            this.edit_owns_det.Location = new System.Drawing.Point(386, 41);
            this.edit_owns_det.Name = "edit_owns_det";
            this.edit_owns_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_owns_det.Properties.Appearance.Options.UseFont = true;
            this.edit_owns_det.Properties.Appearance.Options.UseTextOptions = true;
            this.edit_owns_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edit_owns_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edit_owns_det.Size = new System.Drawing.Size(432, 40);
            this.edit_owns_det.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(503, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 72);
            this.label12.TabIndex = 50;
            this.label12.Text = "تسجيل بيانات الممتلكات";
            // 
            // tBFamilyOwnsTypeBindingSource
            // 
            this.tBFamilyOwnsTypeBindingSource.DataMember = "TB_Family_Owns_Type";
            this.tBFamilyOwnsTypeBindingSource.DataSource = this.dB_FWDDataSet2098;
            // 
            // dB_FWDDataSet2098
            // 
            this.dB_FWDDataSet2098.DataSetName = "DB_FWDDataSet2098";
            this.dB_FWDDataSet2098.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_Family_Owns_TypeTableAdapter
            // 
            this.tB_Family_Owns_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Cus_Owns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1450, 782);
            this.Controls.Add(this.panel_Form_Cus_Owns);
            this.Name = "Form_Cus_Owns";
            this.Text = "Form_Cus_Owns";
            this.Load += new System.EventHandler(this.Form_Cus_Owns_Load);
            this.panel_Form_Cus_Owns.ResumeLayout(false);
            this.panel_Form_Cus_Owns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_Type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_val.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_owns_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBFamilyOwnsTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2098)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Form_Cus_Owns;
        private DevExpress.XtraEditors.SimpleButton Button_Add;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edit_owns_det;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit edit_owns_val;
        private DevExpress.XtraEditors.LookUpEdit edit_owns_Type;
        private DB_FWDDataSet2098 dB_FWDDataSet2098;
        private System.Windows.Forms.BindingSource tBFamilyOwnsTypeBindingSource;
        private DB_FWDDataSet2098TableAdapters.TB_Family_Owns_TypeTableAdapter tB_Family_Owns_TypeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Property_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Property_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Property_value;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colFamily_Owns_Type_Name;
    }
}