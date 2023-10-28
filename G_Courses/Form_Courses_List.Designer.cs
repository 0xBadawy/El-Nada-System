
namespace FWD.G_Courses
{
    partial class Form_Courses_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Courses_List));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCourse_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTB_Take_Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_treener_manager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_teraner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_teatcher_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_teacher_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_studet_tax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_student_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_owner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_more_info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pn_frm_cat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Pn_frm_cat.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.TB_Course_info);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1500, 747);
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCourse_end,
            this.colCourse_ID,
            this.colCourse_location,
            this.colTB_Take_Course,
            this.colCourse_treener_manager,
            this.colCourse_teraner,
            this.colCourse_teatcher_cost,
            this.colCourse_teacher_phone,
            this.colCourse_studet_tax,
            this.colCourse_student_num,
            this.colCourse_start,
            this.colCourse_Price,
            this.colCourse_owner,
            this.colCourse_Name,
            this.colCourse_more_info});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1291, 501, 264, 444);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCourse_end
            // 
            this.colCourse_end.Caption = "نهاية التدريب";
            this.colCourse_end.FieldName = "Course_end";
            this.colCourse_end.Name = "colCourse_end";
            this.colCourse_end.Visible = true;
            this.colCourse_end.VisibleIndex = 0;
            this.colCourse_end.Width = 116;
            // 
            // colCourse_ID
            // 
            this.colCourse_ID.Caption = "ID";
            this.colCourse_ID.FieldName = "Course_ID";
            this.colCourse_ID.Name = "colCourse_ID";
            this.colCourse_ID.Visible = true;
            this.colCourse_ID.VisibleIndex = 10;
            this.colCourse_ID.Width = 71;
            // 
            // colCourse_location
            // 
            this.colCourse_location.Caption = "المقر";
            this.colCourse_location.FieldName = "Course_location";
            this.colCourse_location.Name = "colCourse_location";
            this.colCourse_location.Visible = true;
            this.colCourse_location.VisibleIndex = 2;
            this.colCourse_location.Width = 106;
            // 
            // colTB_Take_Course
            // 
            this.colTB_Take_Course.FieldName = "TB_Take_Course";
            this.colTB_Take_Course.Name = "colTB_Take_Course";
            this.colTB_Take_Course.Width = 98;
            // 
            // colCourse_treener_manager
            // 
            this.colCourse_treener_manager.Caption = "المشرف على التدريب";
            this.colCourse_treener_manager.FieldName = "Course_treener_manager";
            this.colCourse_treener_manager.Name = "colCourse_treener_manager";
            this.colCourse_treener_manager.Width = 98;
            // 
            // colCourse_teraner
            // 
            this.colCourse_teraner.Caption = "المدرب";
            this.colCourse_teraner.FieldName = "Course_teraner";
            this.colCourse_teraner.Name = "colCourse_teraner";
            this.colCourse_teraner.Visible = true;
            this.colCourse_teraner.VisibleIndex = 5;
            this.colCourse_teraner.Width = 196;
            // 
            // colCourse_teatcher_cost
            // 
            this.colCourse_teatcher_cost.Caption = "تكلفة المدرب";
            this.colCourse_teatcher_cost.FieldName = "Course_teatcher_cost";
            this.colCourse_teatcher_cost.Name = "colCourse_teatcher_cost";
            this.colCourse_teatcher_cost.Visible = true;
            this.colCourse_teatcher_cost.VisibleIndex = 3;
            this.colCourse_teatcher_cost.Width = 122;
            // 
            // colCourse_teacher_phone
            // 
            this.colCourse_teacher_phone.Caption = "هاتف المدرب";
            this.colCourse_teacher_phone.FieldName = "Course_teacher_phone";
            this.colCourse_teacher_phone.Name = "colCourse_teacher_phone";
            this.colCourse_teacher_phone.Visible = true;
            this.colCourse_teacher_phone.VisibleIndex = 4;
            this.colCourse_teacher_phone.Width = 154;
            // 
            // colCourse_studet_tax
            // 
            this.colCourse_studet_tax.Caption = "تكاليف الدورة";
            this.colCourse_studet_tax.FieldName = "Course_studet_tax";
            this.colCourse_studet_tax.Name = "colCourse_studet_tax";
            this.colCourse_studet_tax.Visible = true;
            this.colCourse_studet_tax.VisibleIndex = 6;
            this.colCourse_studet_tax.Width = 123;
            // 
            // colCourse_student_num
            // 
            this.colCourse_student_num.Caption = "عدد الطلاب";
            this.colCourse_student_num.FieldName = "Course_student_num";
            this.colCourse_student_num.Name = "colCourse_student_num";
            this.colCourse_student_num.Visible = true;
            this.colCourse_student_num.VisibleIndex = 7;
            this.colCourse_student_num.Width = 118;
            // 
            // colCourse_start
            // 
            this.colCourse_start.Caption = "بداية التدريب";
            this.colCourse_start.FieldName = "Course_start";
            this.colCourse_start.Name = "colCourse_start";
            this.colCourse_start.Visible = true;
            this.colCourse_start.VisibleIndex = 1;
            this.colCourse_start.Width = 110;
            // 
            // colCourse_Price
            // 
            this.colCourse_Price.Caption = "السعر";
            this.colCourse_Price.FieldName = "Course_Price";
            this.colCourse_Price.Name = "colCourse_Price";
            this.colCourse_Price.Visible = true;
            this.colCourse_Price.VisibleIndex = 8;
            this.colCourse_Price.Width = 104;
            // 
            // colCourse_owner
            // 
            this.colCourse_owner.Caption = "اسم المؤسسة";
            this.colCourse_owner.FieldName = "Course_owner";
            this.colCourse_owner.Name = "colCourse_owner";
            this.colCourse_owner.Width = 98;
            // 
            // colCourse_Name
            // 
            this.colCourse_Name.Caption = "اسم التدريب";
            this.colCourse_Name.FieldName = "Course_Name";
            this.colCourse_Name.Name = "colCourse_Name";
            this.colCourse_Name.Visible = true;
            this.colCourse_Name.VisibleIndex = 9;
            this.colCourse_Name.Width = 250;
            // 
            // colCourse_more_info
            // 
            this.colCourse_more_info.Caption = "معلومات اضافية";
            this.colCourse_more_info.FieldName = "Course_more_info";
            this.colCourse_more_info.Name = "colCourse_more_info";
            this.colCourse_more_info.Width = 158;
            // 
            // Pn_frm_cat
            // 
            this.Pn_frm_cat.Controls.Add(this.gridControl1);
            this.Pn_frm_cat.Controls.Add(this.panel1);
            this.Pn_frm_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_cat.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_cat.Name = "Pn_frm_cat";
            this.Pn_frm_cat.Size = new System.Drawing.Size(1500, 806);
            this.Pn_frm_cat.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_edt);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 747);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(462, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            // 
            // btn_edt
            // 
            this.btn_edt.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.Location = new System.Drawing.Point(162, 7);
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
            this.btn_ref.Location = new System.Drawing.Point(312, 7);
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
            // Form_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 806);
            this.Controls.Add(this.Pn_frm_cat);
            this.Name = "Form_Courses_List";
            this.Text = "Form_Courses_List";
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
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_end;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_location;
        private DevExpress.XtraGrid.Columns.GridColumn colTB_Take_Course;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_treener_manager;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_teraner;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_teatcher_cost;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_teacher_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_studet_tax;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_student_num;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_start;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_owner;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_more_info;
        public DevExpress.XtraEditors.SimpleButton btn_ref;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton btn_edt;
    }
}