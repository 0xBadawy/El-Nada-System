
namespace FWD.G_Volanteer
{
    partial class Form_Volanteer_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Volanteer_List));
            this.Pn_frm_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSocial_State_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Bairth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Department_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Department_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Jop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_more_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Start_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Tax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_type_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_type_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Work_add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.Pn_frm_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pn_frm_cat
            // 
            this.Pn_frm_cat.Controls.Add(this.gridControl1);
            this.Pn_frm_cat.Controls.Add(this.panel1);
            this.Pn_frm_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_cat.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_cat.Name = "Pn_frm_cat";
            this.Pn_frm_cat.Size = new System.Drawing.Size(1709, 813);
            this.Pn_frm_cat.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.view_volanteer);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1709, 754);
            this.gridControl1.TabIndex = 1;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSocial_State_Name,
            this.colvolunteer_Add,
            this.colvolunteer_Bairth,
            this.colvolunteer_Department_1,
            this.colvolunteer_Department_2,
            this.colvolunteer_ID,
            this.colvolunteer_Jop,
            this.colvolunteer_more_info,
            this.colvolunteer_Name,
            this.colvolunteer_Phone,
            this.colvolunteer_SSN,
            this.colvolunteer_Start_Date,
            this.colvolunteer_Tax,
            this.colvolunteer_type_Name,
            this.colvolunteer_type_num,
            this.colvolunteer_Work_add});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(717, 396, 264, 444);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSocial_State_Name
            // 
            this.colSocial_State_Name.Caption = "الحالة الاجتماعية";
            this.colSocial_State_Name.FieldName = "Social_State_Name";
            this.colSocial_State_Name.Name = "colSocial_State_Name";
            // 
            // colvolunteer_Add
            // 
            this.colvolunteer_Add.Caption = "العنوان";
            this.colvolunteer_Add.FieldName = "volunteer_Add";
            this.colvolunteer_Add.Name = "colvolunteer_Add";
            this.colvolunteer_Add.Visible = true;
            this.colvolunteer_Add.VisibleIndex = 0;
            this.colvolunteer_Add.Width = 141;
            // 
            // colvolunteer_Bairth
            // 
            this.colvolunteer_Bairth.Caption = "تاريخ الميلاد";
            this.colvolunteer_Bairth.FieldName = "volunteer_Bairth";
            this.colvolunteer_Bairth.Name = "colvolunteer_Bairth";
            // 
            // colvolunteer_Department_1
            // 
            this.colvolunteer_Department_1.Caption = "اللجنة الاساسية";
            this.colvolunteer_Department_1.FieldName = "volunteer_Department_1";
            this.colvolunteer_Department_1.Name = "colvolunteer_Department_1";
            this.colvolunteer_Department_1.Visible = true;
            this.colvolunteer_Department_1.VisibleIndex = 2;
            this.colvolunteer_Department_1.Width = 173;
            // 
            // colvolunteer_Department_2
            // 
            this.colvolunteer_Department_2.Caption = "اللجنة الفرعية";
            this.colvolunteer_Department_2.FieldName = "volunteer_Department_2";
            this.colvolunteer_Department_2.Name = "colvolunteer_Department_2";
            this.colvolunteer_Department_2.Visible = true;
            this.colvolunteer_Department_2.VisibleIndex = 1;
            this.colvolunteer_Department_2.Width = 188;
            // 
            // colvolunteer_ID
            // 
            this.colvolunteer_ID.Caption = "كود المتطوع";
            this.colvolunteer_ID.FieldName = "volunteer_ID";
            this.colvolunteer_ID.Name = "colvolunteer_ID";
            this.colvolunteer_ID.Visible = true;
            this.colvolunteer_ID.VisibleIndex = 8;
            this.colvolunteer_ID.Width = 59;
            // 
            // colvolunteer_Jop
            // 
            this.colvolunteer_Jop.Caption = "الوظيفة";
            this.colvolunteer_Jop.FieldName = "volunteer_Jop";
            this.colvolunteer_Jop.Name = "colvolunteer_Jop";
            this.colvolunteer_Jop.Width = 183;
            // 
            // colvolunteer_more_info
            // 
            this.colvolunteer_more_info.Caption = "معلومات اضافية";
            this.colvolunteer_more_info.FieldName = "volunteer_more_info";
            this.colvolunteer_more_info.Name = "colvolunteer_more_info";
            this.colvolunteer_more_info.Width = 152;
            // 
            // colvolunteer_Name
            // 
            this.colvolunteer_Name.Caption = "اسم المتطوع";
            this.colvolunteer_Name.FieldName = "volunteer_Name";
            this.colvolunteer_Name.Name = "colvolunteer_Name";
            this.colvolunteer_Name.Visible = true;
            this.colvolunteer_Name.VisibleIndex = 7;
            this.colvolunteer_Name.Width = 384;
            // 
            // colvolunteer_Phone
            // 
            this.colvolunteer_Phone.Caption = "رقم الهاتف";
            this.colvolunteer_Phone.FieldName = "volunteer_Phone";
            this.colvolunteer_Phone.Name = "colvolunteer_Phone";
            this.colvolunteer_Phone.Visible = true;
            this.colvolunteer_Phone.VisibleIndex = 5;
            this.colvolunteer_Phone.Width = 205;
            // 
            // colvolunteer_SSN
            // 
            this.colvolunteer_SSN.Caption = "الرقم القومى";
            this.colvolunteer_SSN.FieldName = "volunteer_SSN";
            this.colvolunteer_SSN.Name = "colvolunteer_SSN";
            this.colvolunteer_SSN.Visible = true;
            this.colvolunteer_SSN.VisibleIndex = 6;
            this.colvolunteer_SSN.Width = 215;
            // 
            // colvolunteer_Start_Date
            // 
            this.colvolunteer_Start_Date.Caption = "تاريخ البداية";
            this.colvolunteer_Start_Date.FieldName = "volunteer_Start_Date";
            this.colvolunteer_Start_Date.Name = "colvolunteer_Start_Date";
            this.colvolunteer_Start_Date.Visible = true;
            this.colvolunteer_Start_Date.VisibleIndex = 4;
            this.colvolunteer_Start_Date.Width = 133;
            // 
            // colvolunteer_Tax
            // 
            this.colvolunteer_Tax.Caption = "قيمة الاشترك";
            this.colvolunteer_Tax.FieldName = "volunteer_Tax";
            this.colvolunteer_Tax.Name = "colvolunteer_Tax";
            // 
            // colvolunteer_type_Name
            // 
            this.colvolunteer_type_Name.Caption = "نوع المتطوع";
            this.colvolunteer_type_Name.FieldName = "volunteer_type_Name";
            this.colvolunteer_type_Name.Name = "colvolunteer_type_Name";
            this.colvolunteer_type_Name.Visible = true;
            this.colvolunteer_type_Name.VisibleIndex = 3;
            this.colvolunteer_type_Name.Width = 181;
            // 
            // colvolunteer_type_num
            // 
            this.colvolunteer_type_num.Caption = "العدد";
            this.colvolunteer_type_num.FieldName = "volunteer_type_num";
            this.colvolunteer_type_num.Name = "colvolunteer_type_num";
            // 
            // colvolunteer_Work_add
            // 
            this.colvolunteer_Work_add.Caption = "عنوان العمل";
            this.colvolunteer_Work_add.FieldName = "volunteer_Work_add";
            this.colvolunteer_Work_add.Name = "colvolunteer_Work_add";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_edt);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 754);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1709, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(534, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_edt
            // 
            this.btn_edt.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.Location = new System.Drawing.Point(186, 7);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(144, 44);
            this.btn_edt.TabIndex = 0;
            this.btn_edt.Text = "تعديل";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(360, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
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
            // Form_Volanteer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 813);
            this.Controls.Add(this.Pn_frm_cat);
            this.Name = "Form_Volanteer_List";
            this.Text = "Form_Volanteer_List";
            this.Pn_frm_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel Pn_frm_cat;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSocial_State_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Bairth;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Department_1;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Department_2;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Jop;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_more_info;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_SSN;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Start_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Tax;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_type_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_type_num;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Work_add;
        public DevExpress.XtraEditors.SimpleButton btn_edt;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}