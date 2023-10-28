
namespace FWD.G_Doctors
{
    partial class Form_Doctor_info_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Doctor_info_Add));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDoctor_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoctor_spicailize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.Edit_Add = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_doc_spatilize = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_doc_name = new DevExpress.XtraEditors.TextEdit();
            this.tBELOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2083 = new FWD.DB_FWDDataSet2083();
            this.tBE_LOCTableAdapter = new FWD.DB_FWDDataSet2083TableAdapters.TBE_LOCTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_spatilize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2083)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Edit_Add);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.edt_doc_spatilize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.edt_doc_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 774);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Doctor_Info);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 367);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1388, 348);
            this.gridControl1.TabIndex = 81;
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
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDoctor_ID,
            this.colDoctor_Name,
            this.colDoctor_spicailize,
            this.colLOC_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDoctor_ID
            // 
            this.colDoctor_ID.Caption = "كود الدكتور";
            this.colDoctor_ID.FieldName = "Doctor_ID";
            this.colDoctor_ID.Name = "colDoctor_ID";
            this.colDoctor_ID.Visible = true;
            this.colDoctor_ID.VisibleIndex = 3;
            this.colDoctor_ID.Width = 182;
            // 
            // colDoctor_Name
            // 
            this.colDoctor_Name.Caption = "اسم الدكتور";
            this.colDoctor_Name.FieldName = "Doctor_Name";
            this.colDoctor_Name.Name = "colDoctor_Name";
            this.colDoctor_Name.Visible = true;
            this.colDoctor_Name.VisibleIndex = 2;
            this.colDoctor_Name.Width = 567;
            // 
            // colDoctor_spicailize
            // 
            this.colDoctor_spicailize.Caption = "تحصص الدكتور";
            this.colDoctor_spicailize.FieldName = "Doctor_spicailize";
            this.colDoctor_spicailize.Name = "colDoctor_spicailize";
            this.colDoctor_spicailize.Visible = true;
            this.colDoctor_spicailize.VisibleIndex = 1;
            this.colDoctor_spicailize.Width = 372;
            // 
            // colLOC_Name
            // 
            this.colLOC_Name.Caption = "العنوان";
            this.colLOC_Name.FieldName = "LOC_Name";
            this.colLOC_Name.Name = "colLOC_Name";
            this.colLOC_Name.Visible = true;
            this.colLOC_Name.VisibleIndex = 0;
            this.colLOC_Name.Width = 237;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 715);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 59);
            this.panel1.TabIndex = 82;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(322, 7);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(144, 44);
            this.simpleButton3.TabIndex = 0;
            this.simpleButton3.Text = "طباعة";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(162, 7);
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
            // Edit_Add
            // 
            this.Edit_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Add.Location = new System.Drawing.Point(729, 215);
            this.Edit_Add.Name = "Edit_Add";
            this.Edit_Add.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Add.Properties.Appearance.Options.UseFont = true;
            this.Edit_Add.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Add.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Name", "LOC_Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Key", "LOC_Key", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Edit_Add.Properties.DataSource = typeof(FWD.TBE_LOC);
            this.Edit_Add.Properties.DisplayMember = "LOC_Name";
            this.Edit_Add.Properties.NullText = " ";
            this.Edit_Add.Properties.ValueMember = "ID";
            this.Edit_Add.Size = new System.Drawing.Size(390, 40);
            this.Edit_Add.TabIndex = 80;
            this.Edit_Add.EditValueChanged += new System.EventHandler(this.Edit_Add_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(114, 216);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(393, 43);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(503, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "اضافة بيانات دكتور";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 43);
            this.label1.TabIndex = 71;
            this.label1.Text = "اسم تخصص الدكتور";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // edt_doc_spatilize
            // 
            this.edt_doc_spatilize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_doc_spatilize.EditValue = "";
            this.edt_doc_spatilize.Location = new System.Drawing.Point(114, 130);
            this.edt_doc_spatilize.Name = "edt_doc_spatilize";
            this.edt_doc_spatilize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_doc_spatilize.Properties.Appearance.Options.UseFont = true;
            this.edt_doc_spatilize.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_doc_spatilize.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_doc_spatilize.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_doc_spatilize.Size = new System.Drawing.Size(393, 40);
            this.edt_doc_spatilize.TabIndex = 2;
            this.edt_doc_spatilize.EditValueChanged += new System.EventHandler(this.edt_doc_spatilize_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1170, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 43);
            this.label3.TabIndex = 72;
            this.label3.Text = "العنوان";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1125, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 43);
            this.label2.TabIndex = 72;
            this.label2.Text = "اسم الدكتور";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_doc_name
            // 
            this.edt_doc_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_doc_name.EditValue = "";
            this.edt_doc_name.Location = new System.Drawing.Point(729, 128);
            this.edt_doc_name.Name = "edt_doc_name";
            this.edt_doc_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_doc_name.Properties.Appearance.Options.UseFont = true;
            this.edt_doc_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_doc_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_doc_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_doc_name.Size = new System.Drawing.Size(390, 40);
            this.edt_doc_name.TabIndex = 1;
            this.edt_doc_name.EditValueChanged += new System.EventHandler(this.edt_doc_name_EditValueChanged);
            // 
            // tBELOCBindingSource
            // 
            this.tBELOCBindingSource.DataMember = "TBE_LOC";
            this.tBELOCBindingSource.DataSource = this.dB_FWDDataSet2083;
            // 
            // dB_FWDDataSet2083
            // 
            this.dB_FWDDataSet2083.DataSetName = "DB_FWDDataSet2083";
            this.dB_FWDDataSet2083.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBE_LOCTableAdapter
            // 
            this.tBE_LOCTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Doctor_info_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 774);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Doctor_info_Add";
            this.Text = "Form_Doctor_info_Add";
            this.Load += new System.EventHandler(this.Form_Doctor_info_Add_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_spatilize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2083)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit edt_doc_spatilize;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_doc_name;
        private DevExpress.XtraEditors.LookUpEdit Edit_Add;
        private System.Windows.Forms.Label label3;
        private DB_FWDDataSet2083 dB_FWDDataSet2083;
        private System.Windows.Forms.BindingSource tBELOCBindingSource;
        private DB_FWDDataSet2083TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctor_spicailize;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Name;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}