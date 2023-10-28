
namespace FWD.G_Doctors
{
    partial class Form_Parmasist_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Parmasist_Add));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPharmasist_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPharmasist_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Edit_Add = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_doc_name = new DevExpress.XtraEditors.TextEdit();
            this.tBELOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2084 = new FWD.DB_FWDDataSet2084();
            this.tBELOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2083 = new FWD.DB_FWDDataSet2083();
            this.tBE_LOCTableAdapter = new FWD.DB_FWDDataSet2083TableAdapters.TBE_LOCTableAdapter();
            this.tBE_LOCTableAdapter1 = new FWD.DB_FWDDataSet2084TableAdapters.TBE_LOCTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2084)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2083)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.Edit_Add);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.edt_doc_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 619);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Pharmasist_Info);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 300);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1208, 319);
            this.gridControl1.TabIndex = 81;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colLOC_Name,
            this.colPharmasist_ID,
            this.colPharmasist_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colLOC_Name
            // 
            this.colLOC_Name.Caption = "عنوان الصيدلية";
            this.colLOC_Name.FieldName = "LOC_Name";
            this.colLOC_Name.Name = "colLOC_Name";
            this.colLOC_Name.Visible = true;
            this.colLOC_Name.VisibleIndex = 0;
            // 
            // colPharmasist_ID
            // 
            this.colPharmasist_ID.Caption = "كود الصيدلية";
            this.colPharmasist_ID.FieldName = "Pharmasist_ID";
            this.colPharmasist_ID.Name = "colPharmasist_ID";
            this.colPharmasist_ID.Visible = true;
            this.colPharmasist_ID.VisibleIndex = 2;
            // 
            // colPharmasist_Name
            // 
            this.colPharmasist_Name.Caption = "اسم الصيدلية";
            this.colPharmasist_Name.FieldName = "Pharmasist_Name";
            this.colPharmasist_Name.Name = "colPharmasist_Name";
            this.colPharmasist_Name.Visible = true;
            this.colPharmasist_Name.VisibleIndex = 1;
            // 
            // Edit_Add
            // 
            this.Edit_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Add.Location = new System.Drawing.Point(71, 128);
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
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(374, 223);
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
            this.label9.Location = new System.Drawing.Point(429, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "اضافة بيانات صيدلية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 43);
            this.label3.TabIndex = 72;
            this.label3.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1035, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 43);
            this.label2.TabIndex = 72;
            this.label2.Text = "اسم الصيدلية";
            // 
            // edt_doc_name
            // 
            this.edt_doc_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_doc_name.EditValue = "";
            this.edt_doc_name.Location = new System.Drawing.Point(639, 128);
            this.edt_doc_name.Name = "edt_doc_name";
            this.edt_doc_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_doc_name.Properties.Appearance.Options.UseFont = true;
            this.edt_doc_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_doc_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_doc_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_doc_name.Size = new System.Drawing.Size(390, 40);
            this.edt_doc_name.TabIndex = 1;
            // 
            // tBELOCBindingSource1
            // 
            this.tBELOCBindingSource1.DataMember = "TBE_LOC";
            this.tBELOCBindingSource1.DataSource = this.dB_FWDDataSet2084;
            // 
            // dB_FWDDataSet2084
            // 
            this.dB_FWDDataSet2084.DataSetName = "DB_FWDDataSet2084";
            this.dB_FWDDataSet2084.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tBE_LOCTableAdapter1
            // 
            this.tBE_LOCTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Parmasist_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 619);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Parmasist_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Parmasist_Add";
            this.Load += new System.EventHandler(this.Form_Parmasist_Add_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2084)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2083)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit Edit_Add;
        private System.Windows.Forms.BindingSource tBELOCBindingSource;
        private DB_FWDDataSet2083 dB_FWDDataSet2083;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_doc_name;
        private DB_FWDDataSet2083TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter;
        private DB_FWDDataSet2084 dB_FWDDataSet2084;
        private System.Windows.Forms.BindingSource tBELOCBindingSource1;
        private DB_FWDDataSet2084TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPharmasist_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPharmasist_Name;
        public System.Windows.Forms.Panel panel2;
    }
}