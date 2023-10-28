
namespace FWD.G_Representive
{
    partial class Form_Supp_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Supp_List));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUPP_Date_Regest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Bairth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_phone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Phone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupp_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Retion_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Pn_frm_supp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.Pn_frm_supp.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(471, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            // 
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.Location = new System.Drawing.Point(12, 7);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 44);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1414, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(144, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تعديل";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(318, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUPP_Date_Regest,
            this.colSUPP_Bairth,
            this.colSUPP_SSN,
            this.colSUPP_phone2,
            this.colSUPP_Phone1,
            this.colSUPP_Name,
            this.colID,
            this.colsupp_Add,
            this.colSUPP_Retion_Add,
            this.colAge});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSUPP_Date_Regest
            // 
            this.colSUPP_Date_Regest.Caption = "بداية العمل";
            this.colSUPP_Date_Regest.FieldName = "SUPP_Date_Regest";
            this.colSUPP_Date_Regest.Name = "colSUPP_Date_Regest";
            this.colSUPP_Date_Regest.Visible = true;
            this.colSUPP_Date_Regest.VisibleIndex = 0;
            this.colSUPP_Date_Regest.Width = 103;
            // 
            // colSUPP_Bairth
            // 
            this.colSUPP_Bairth.Caption = "تاريخ الميلاد";
            this.colSUPP_Bairth.FieldName = "SUPP_Bairth";
            this.colSUPP_Bairth.Name = "colSUPP_Bairth";
            this.colSUPP_Bairth.Visible = true;
            this.colSUPP_Bairth.VisibleIndex = 2;
            this.colSUPP_Bairth.Width = 105;
            // 
            // colSUPP_SSN
            // 
            this.colSUPP_SSN.Caption = "الرقم القومى";
            this.colSUPP_SSN.FieldName = "SUPP_SSN";
            this.colSUPP_SSN.Name = "colSUPP_SSN";
            this.colSUPP_SSN.Visible = true;
            this.colSUPP_SSN.VisibleIndex = 3;
            this.colSUPP_SSN.Width = 203;
            // 
            // colSUPP_phone2
            // 
            this.colSUPP_phone2.Caption = "تلفون 2";
            this.colSUPP_phone2.FieldName = "SUPP_phone2";
            this.colSUPP_phone2.Name = "colSUPP_phone2";
            this.colSUPP_phone2.Visible = true;
            this.colSUPP_phone2.VisibleIndex = 4;
            this.colSUPP_phone2.Width = 158;
            // 
            // colSUPP_Phone1
            // 
            this.colSUPP_Phone1.Caption = "تلفون 2";
            this.colSUPP_Phone1.FieldName = "SUPP_Phone1";
            this.colSUPP_Phone1.Name = "colSUPP_Phone1";
            this.colSUPP_Phone1.Visible = true;
            this.colSUPP_Phone1.VisibleIndex = 5;
            this.colSUPP_Phone1.Width = 120;
            // 
            // colSUPP_Name
            // 
            this.colSUPP_Name.Caption = "الاسم";
            this.colSUPP_Name.FieldName = "SUPP_Name";
            this.colSUPP_Name.Name = "colSUPP_Name";
            this.colSUPP_Name.Visible = true;
            this.colSUPP_Name.VisibleIndex = 8;
            this.colSUPP_Name.Width = 302;
            // 
            // colID
            // 
            this.colID.Caption = "الكود";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 9;
            this.colID.Width = 59;
            // 
            // colsupp_Add
            // 
            this.colsupp_Add.Caption = "العنوان";
            this.colsupp_Add.FieldName = "supp_Add";
            this.colsupp_Add.Name = "colsupp_Add";
            this.colsupp_Add.Visible = true;
            this.colsupp_Add.VisibleIndex = 7;
            this.colsupp_Add.Width = 128;
            // 
            // colSUPP_Retion_Add
            // 
            this.colSUPP_Retion_Add.Caption = "منطقة البحث";
            this.colSUPP_Retion_Add.FieldName = "SUPP_Retion_Add";
            this.colSUPP_Retion_Add.Name = "colSUPP_Retion_Add";
            this.colSUPP_Retion_Add.Visible = true;
            this.colSUPP_Retion_Add.VisibleIndex = 6;
            this.colSUPP_Retion_Add.Width = 137;
            // 
            // colAge
            // 
            this.colAge.Caption = "السن";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 1;
            this.colAge.Width = 69;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_supp_list);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1414, 724);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Pn_frm_supp
            // 
            this.Pn_frm_supp.Controls.Add(this.gridControl1);
            this.Pn_frm_supp.Controls.Add(this.panel1);
            this.Pn_frm_supp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_supp.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_supp.Name = "Pn_frm_supp";
            this.Pn_frm_supp.Size = new System.Drawing.Size(1414, 783);
            this.Pn_frm_supp.TabIndex = 1;
            // 
            // Form_Supp_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 783);
            this.Controls.Add(this.Pn_frm_supp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Supp_List";
            this.Text = "Form_Supp_List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.Pn_frm_supp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.Panel Pn_frm_supp;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Date_Regest;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Bairth;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_SSN;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_phone2;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Phone1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colsupp_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Retion_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}