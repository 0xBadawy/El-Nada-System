
namespace FWD.G_Pocet
{
    partial class Form_Pocet_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pocet_Add));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_cat_val = new DevExpress.XtraEditors.TextEdit();
            this.edt_don_rece = new DevExpress.XtraEditors.TextEdit();
            this.edt_don_dir = new DevExpress.XtraEditors.TextEdit();
            this.edt_don_name = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOC_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOC_Own = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOC_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOC_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Pn_frm_poc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat_val.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_rece.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_dir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pn_frm_poc.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(650, 314);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 43);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "سحب";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(639, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 66);
            this.label9.TabIndex = 60;
            this.label9.Text = "المصاريف";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1193, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 43);
            this.label4.TabIndex = 59;
            this.label4.Text = "القيمة";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(582, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 43);
            this.label5.TabIndex = 56;
            this.label5.Text = "المستلم";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 43);
            this.label1.TabIndex = 56;
            this.label1.Text = "النوع";
            // 
            // edt_cat_val
            // 
            this.edt_cat_val.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_cat_val.Location = new System.Drawing.Point(793, 223);
            this.edt_cat_val.Name = "edt_cat_val";
            this.edt_cat_val.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_cat_val.Properties.Appearance.Options.UseFont = true;
            this.edt_cat_val.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_cat_val.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_cat_val.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_cat_val.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_cat_val.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_cat_val.Properties.MaskSettings.Set("mask", "\\d+");
            this.edt_cat_val.Size = new System.Drawing.Size(393, 40);
            this.edt_cat_val.TabIndex = 3;
            // 
            // edt_don_rece
            // 
            this.edt_don_rece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_don_rece.EditValue = "";
            this.edt_don_rece.Location = new System.Drawing.Point(183, 216);
            this.edt_don_rece.Name = "edt_don_rece";
            this.edt_don_rece.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_don_rece.Properties.Appearance.Options.UseFont = true;
            this.edt_don_rece.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_don_rece.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_don_rece.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_don_rece.Size = new System.Drawing.Size(393, 40);
            this.edt_don_rece.TabIndex = 4;
            // 
            // edt_don_dir
            // 
            this.edt_don_dir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_don_dir.EditValue = "";
            this.edt_don_dir.Location = new System.Drawing.Point(183, 147);
            this.edt_don_dir.Name = "edt_don_dir";
            this.edt_don_dir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_don_dir.Properties.Appearance.Options.UseFont = true;
            this.edt_don_dir.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_don_dir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_don_dir.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_don_dir.Size = new System.Drawing.Size(393, 40);
            this.edt_don_dir.TabIndex = 2;
            // 
            // edt_don_name
            // 
            this.edt_don_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_don_name.EditValue = "";
            this.edt_don_name.Location = new System.Drawing.Point(793, 149);
            this.edt_don_name.Name = "edt_don_name";
            this.edt_don_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_don_name.Properties.Appearance.Options.UseFont = true;
            this.edt_don_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_don_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_don_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_don_name.Size = new System.Drawing.Size(390, 40);
            this.edt_don_name.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.TB_POC);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 477);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1455, 288);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 14F);
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
            this.colID,
            this.colPOC_Date,
            this.colPOC_Name,
            this.colPOC_Own,
            this.colPOC_Type,
            this.colPOC_Value});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 5;
            this.colID.Width = 61;
            // 
            // colPOC_Date
            // 
            this.colPOC_Date.Caption = "التاريخ";
            this.colPOC_Date.FieldName = "POC_Date";
            this.colPOC_Date.Name = "colPOC_Date";
            this.colPOC_Date.Visible = true;
            this.colPOC_Date.VisibleIndex = 0;
            this.colPOC_Date.Width = 237;
            // 
            // colPOC_Name
            // 
            this.colPOC_Name.Caption = "اسم المصروف فية";
            this.colPOC_Name.FieldName = "POC_Name";
            this.colPOC_Name.Name = "colPOC_Name";
            this.colPOC_Name.Visible = true;
            this.colPOC_Name.VisibleIndex = 4;
            this.colPOC_Name.Width = 413;
            // 
            // colPOC_Own
            // 
            this.colPOC_Own.Caption = "المستلم";
            this.colPOC_Own.FieldName = "POC_Own";
            this.colPOC_Own.Name = "colPOC_Own";
            this.colPOC_Own.Visible = true;
            this.colPOC_Own.VisibleIndex = 1;
            this.colPOC_Own.Width = 237;
            // 
            // colPOC_Type
            // 
            this.colPOC_Type.Caption = "النوع";
            this.colPOC_Type.FieldName = "POC_Type";
            this.colPOC_Type.Name = "colPOC_Type";
            this.colPOC_Type.Visible = true;
            this.colPOC_Type.VisibleIndex = 2;
            this.colPOC_Type.Width = 237;
            // 
            // colPOC_Value
            // 
            this.colPOC_Value.Caption = "الفيمة";
            this.colPOC_Value.FieldName = "POC_Value";
            this.colPOC_Value.Name = "colPOC_Value";
            this.colPOC_Value.Visible = true;
            this.colPOC_Value.VisibleIndex = 3;
            this.colPOC_Value.Width = 240;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1455, 59);
            this.panel1.TabIndex = 0;
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
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.Enabled = false;
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.Location = new System.Drawing.Point(12, 7);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 44);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1189, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 43);
            this.label2.TabIndex = 58;
            this.label2.Text = "الاسم";
            // 
            // Pn_frm_poc
            // 
            this.Pn_frm_poc.BackColor = System.Drawing.Color.White;
            this.Pn_frm_poc.Controls.Add(this.simpleButton2);
            this.Pn_frm_poc.Controls.Add(this.label9);
            this.Pn_frm_poc.Controls.Add(this.label4);
            this.Pn_frm_poc.Controls.Add(this.label5);
            this.Pn_frm_poc.Controls.Add(this.label1);
            this.Pn_frm_poc.Controls.Add(this.edt_cat_val);
            this.Pn_frm_poc.Controls.Add(this.edt_don_rece);
            this.Pn_frm_poc.Controls.Add(this.edt_don_dir);
            this.Pn_frm_poc.Controls.Add(this.label2);
            this.Pn_frm_poc.Controls.Add(this.edt_don_name);
            this.Pn_frm_poc.Controls.Add(this.gridControl1);
            this.Pn_frm_poc.Controls.Add(this.panel1);
            this.Pn_frm_poc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_poc.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_poc.Name = "Pn_frm_poc";
            this.Pn_frm_poc.Size = new System.Drawing.Size(1455, 824);
            this.Pn_frm_poc.TabIndex = 2;
            // 
            // Form_Pocet_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 824);
            this.Controls.Add(this.Pn_frm_poc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pocet_Add";
            this.Text = "Form_Pocet_Add";
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat_val.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_rece.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_dir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Pn_frm_poc.ResumeLayout(false);
            this.Pn_frm_poc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit edt_cat_val;
        private DevExpress.XtraEditors.TextEdit edt_don_rece;
        private DevExpress.XtraEditors.TextEdit edt_don_dir;
        private DevExpress.XtraEditors.TextEdit edt_don_name;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel Pn_frm_poc;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPOC_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colPOC_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPOC_Own;
        private DevExpress.XtraGrid.Columns.GridColumn colPOC_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPOC_Value;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}