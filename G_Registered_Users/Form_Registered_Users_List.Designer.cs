
namespace FWD.G_Registered_Users
{
    partial class Form_Registered_Users_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registered_Users_List));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHealth_Status_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRank_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Add_det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Fam_Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Helth_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Hus_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Hus_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Hus_Ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_incom_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_income_val = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSocial_State_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pn_frm_cat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.colRegistered_Users_BairthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Pn_frm_cat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Registered_Users_New);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1568, 751);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
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
            this.colHealth_Status_Name,
            this.colLOC_Name,
            this.colRank_Name,
            this.colRegistered_Users_Add_det,
            this.colRegistered_Users_Fam_Num,
            this.colRegistered_Users_Helth_info,
            this.colRegistered_Users_Hus_Name,
            this.colRegistered_Users_Hus_Phone,
            this.colRegistered_Users_ID,
            this.colRegistered_Users_Hus_Ssn,
            this.colRegistered_Users_incom_name,
            this.colRegistered_Users_income_val,
            this.colRegistered_Users_Name,
            this.colRegistered_Users_phone,
            this.colRegistered_Users_Ssn,
            this.colSocial_State_Name,
            this.colSUPP_Name,
            this.colRegistered_Users_BairthDay,
            this.colAge});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(292, 396, 264, 444);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colHealth_Status_Name
            // 
            this.colHealth_Status_Name.Caption = "  الحالة الصحية";
            this.colHealth_Status_Name.FieldName = "Health_Status_Name";
            this.colHealth_Status_Name.Name = "colHealth_Status_Name";
            this.colHealth_Status_Name.Visible = true;
            this.colHealth_Status_Name.VisibleIndex = 1;
            this.colHealth_Status_Name.Width = 132;
            // 
            // colLOC_Name
            // 
            this.colLOC_Name.Caption = "العنوان";
            this.colLOC_Name.FieldName = "LOC_Name";
            this.colLOC_Name.Name = "colLOC_Name";
            this.colLOC_Name.Visible = true;
            this.colLOC_Name.VisibleIndex = 2;
            this.colLOC_Name.Width = 132;
            // 
            // colRank_Name
            // 
            this.colRank_Name.Caption = "درجة الحالة";
            this.colRank_Name.FieldName = "Rank_Name";
            this.colRank_Name.Name = "colRank_Name";
            this.colRank_Name.Visible = true;
            this.colRank_Name.VisibleIndex = 0;
            this.colRank_Name.Width = 132;
            // 
            // colRegistered_Users_Add_det
            // 
            this.colRegistered_Users_Add_det.Caption = "العنوان بالتفصيل";
            this.colRegistered_Users_Add_det.FieldName = "Registered_Users_Add_det";
            this.colRegistered_Users_Add_det.Name = "colRegistered_Users_Add_det";
            // 
            // colRegistered_Users_Fam_Num
            // 
            this.colRegistered_Users_Fam_Num.Caption = "عدد الافراد";
            this.colRegistered_Users_Fam_Num.FieldName = "Registered_Users_Fam_Num";
            this.colRegistered_Users_Fam_Num.Name = "colRegistered_Users_Fam_Num";
            this.colRegistered_Users_Fam_Num.Visible = true;
            this.colRegistered_Users_Fam_Num.VisibleIndex = 3;
            this.colRegistered_Users_Fam_Num.Width = 92;
            // 
            // colRegistered_Users_Helth_info
            // 
            this.colRegistered_Users_Helth_info.Caption = "وصف الحالة الصحية";
            this.colRegistered_Users_Helth_info.FieldName = "Registered_Users_Helth_info";
            this.colRegistered_Users_Helth_info.Name = "colRegistered_Users_Helth_info";
            // 
            // colRegistered_Users_Hus_Name
            // 
            this.colRegistered_Users_Hus_Name.Caption = "اسم الزوج";
            this.colRegistered_Users_Hus_Name.FieldName = "Registered_Users_Hus_Name";
            this.colRegistered_Users_Hus_Name.Name = "colRegistered_Users_Hus_Name";
            this.colRegistered_Users_Hus_Name.Width = 183;
            // 
            // colRegistered_Users_Hus_Phone
            // 
            this.colRegistered_Users_Hus_Phone.Caption = "رقم الزوج";
            this.colRegistered_Users_Hus_Phone.FieldName = "Registered_Users_Hus_Phone";
            this.colRegistered_Users_Hus_Phone.Name = "colRegistered_Users_Hus_Phone";
            // 
            // colRegistered_Users_ID
            // 
            this.colRegistered_Users_ID.Caption = "الكود";
            this.colRegistered_Users_ID.FieldName = "Registered_Users_ID";
            this.colRegistered_Users_ID.Name = "colRegistered_Users_ID";
            this.colRegistered_Users_ID.Visible = true;
            this.colRegistered_Users_ID.VisibleIndex = 11;
            this.colRegistered_Users_ID.Width = 72;
            // 
            // colRegistered_Users_Hus_Ssn
            // 
            this.colRegistered_Users_Hus_Ssn.Caption = "الرقم القومى للزوج";
            this.colRegistered_Users_Hus_Ssn.FieldName = "Registered_Users_Hus_Ssn";
            this.colRegistered_Users_Hus_Ssn.Name = "colRegistered_Users_Hus_Ssn";
            // 
            // colRegistered_Users_incom_name
            // 
            this.colRegistered_Users_incom_name.Caption = "مصدر الدخل";
            this.colRegistered_Users_incom_name.FieldName = "Registered_Users_incom_name";
            this.colRegistered_Users_incom_name.Name = "colRegistered_Users_incom_name";
            this.colRegistered_Users_incom_name.Visible = true;
            this.colRegistered_Users_incom_name.VisibleIndex = 5;
            this.colRegistered_Users_incom_name.Width = 122;
            // 
            // colRegistered_Users_income_val
            // 
            this.colRegistered_Users_income_val.Caption = "قيمة الدخل";
            this.colRegistered_Users_income_val.FieldName = "Registered_Users_income_val";
            this.colRegistered_Users_income_val.Name = "colRegistered_Users_income_val";
            this.colRegistered_Users_income_val.Visible = true;
            this.colRegistered_Users_income_val.VisibleIndex = 4;
            this.colRegistered_Users_income_val.Width = 115;
            // 
            // colRegistered_Users_Name
            // 
            this.colRegistered_Users_Name.Caption = "الاسم";
            this.colRegistered_Users_Name.FieldName = "Registered_Users_Name";
            this.colRegistered_Users_Name.Name = "colRegistered_Users_Name";
            this.colRegistered_Users_Name.Visible = true;
            this.colRegistered_Users_Name.VisibleIndex = 10;
            this.colRegistered_Users_Name.Width = 235;
            // 
            // colRegistered_Users_phone
            // 
            this.colRegistered_Users_phone.Caption = "التلفون";
            this.colRegistered_Users_phone.FieldName = "Registered_Users_phone";
            this.colRegistered_Users_phone.Name = "colRegistered_Users_phone";
            this.colRegistered_Users_phone.Visible = true;
            this.colRegistered_Users_phone.VisibleIndex = 6;
            this.colRegistered_Users_phone.Width = 130;
            // 
            // colRegistered_Users_Ssn
            // 
            this.colRegistered_Users_Ssn.Caption = "الرقم القومى";
            this.colRegistered_Users_Ssn.FieldName = "Registered_Users_Ssn";
            this.colRegistered_Users_Ssn.Name = "colRegistered_Users_Ssn";
            this.colRegistered_Users_Ssn.Visible = true;
            this.colRegistered_Users_Ssn.VisibleIndex = 8;
            this.colRegistered_Users_Ssn.Width = 145;
            // 
            // colSocial_State_Name
            // 
            this.colSocial_State_Name.Caption = "الحالة الاجتماعية";
            this.colSocial_State_Name.FieldName = "Social_State_Name";
            this.colSocial_State_Name.Name = "colSocial_State_Name";
            this.colSocial_State_Name.Visible = true;
            this.colSocial_State_Name.VisibleIndex = 9;
            this.colSocial_State_Name.Width = 87;
            // 
            // colSUPP_Name
            // 
            this.colSUPP_Name.Caption = "اسم المندوب";
            this.colSUPP_Name.FieldName = "SUPP_Name";
            this.colSUPP_Name.Name = "colSUPP_Name";
            // 
            // Pn_frm_cat
            // 
            this.Pn_frm_cat.Controls.Add(this.gridControl1);
            this.Pn_frm_cat.Controls.Add(this.panel1);
            this.Pn_frm_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_cat.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_cat.Name = "Pn_frm_cat";
            this.Pn_frm_cat.Size = new System.Drawing.Size(1568, 810);
            this.Pn_frm_cat.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_edt);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 751);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(535, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.Location = new System.Drawing.Point(356, 6);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(144, 44);
            this.btn_edt.TabIndex = 0;
            this.btn_edt.Text = "تعديل";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
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
            // colRegistered_Users_BairthDay
            // 
            this.colRegistered_Users_BairthDay.Caption = "تاريخ الميلاد";
            this.colRegistered_Users_BairthDay.FieldName = "Registered_Users_BairthDay";
            this.colRegistered_Users_BairthDay.Name = "colRegistered_Users_BairthDay";
            this.colRegistered_Users_BairthDay.Width = 83;
            // 
            // colAge
            // 
            this.colAge.Caption = "السن";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 7;
            this.colAge.Width = 61;
            // 
            // Form_Registered_Users_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 810);
            this.Controls.Add(this.Pn_frm_cat);
            this.Name = "Form_Registered_Users_List";
            this.Text = "Form_Registered_Users_List";
            this.Load += new System.EventHandler(this.Form_Registered_Users_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Pn_frm_cat.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.Panel Pn_frm_cat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Columns.GridColumn colHealth_Status_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRank_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Add_det;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Fam_Num;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Helth_info;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Hus_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Hus_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Hus_Ssn;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_incom_name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_income_val;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Ssn;
        private DevExpress.XtraGrid.Columns.GridColumn colSocial_State_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Name;
        public DevExpress.XtraEditors.SimpleButton btn_edt;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_BairthDay;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
    }
}