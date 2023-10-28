
namespace FWD.G_Courses
{
    partial class Form_Take_Course_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Take_Course_List));
            this.Pn_frm_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCourse_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCourse_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTake_Course_Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTake_Course_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTake_Course_Student = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.Pn_frm_cat.Size = new System.Drawing.Size(1457, 846);
            this.Pn_frm_cat.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Take_Course);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1457, 787);
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
            this.colCourse_end,
            this.colCourse_Name,
            this.colCourse_Price,
            this.colCourse_start,
            this.colRegistered_Users_Name,
            this.colRegistered_Users_phone,
            this.colRegistered_Users_ssn,
            this.colTake_Course_Course,
            this.colTake_Course_ID,
            this.colTake_Course_Student});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1248, 541, 264, 444);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCourse_end
            // 
            this.colCourse_end.Caption = "نهاية التدريب";
            this.colCourse_end.FieldName = "Course_end";
            this.colCourse_end.Name = "colCourse_end";
            this.colCourse_end.Visible = true;
            this.colCourse_end.VisibleIndex = 0;
            this.colCourse_end.Width = 176;
            // 
            // colCourse_Name
            // 
            this.colCourse_Name.Caption = "اسم التدريب";
            this.colCourse_Name.FieldName = "Course_Name";
            this.colCourse_Name.Name = "colCourse_Name";
            this.colCourse_Name.Visible = true;
            this.colCourse_Name.VisibleIndex = 3;
            this.colCourse_Name.Width = 186;
            // 
            // colCourse_Price
            // 
            this.colCourse_Price.Caption = "السعر";
            this.colCourse_Price.FieldName = "Course_Price";
            this.colCourse_Price.Name = "colCourse_Price";
            this.colCourse_Price.Visible = true;
            this.colCourse_Price.VisibleIndex = 2;
            this.colCourse_Price.Width = 104;
            // 
            // colCourse_start
            // 
            this.colCourse_start.Caption = "بداية التدريب";
            this.colCourse_start.FieldName = "Course_start";
            this.colCourse_start.Name = "colCourse_start";
            this.colCourse_start.Visible = true;
            this.colCourse_start.VisibleIndex = 1;
            this.colCourse_start.Width = 177;
            // 
            // colRegistered_Users_Name
            // 
            this.colRegistered_Users_Name.Caption = "اسم المتدرب";
            this.colRegistered_Users_Name.FieldName = "Registered_Users_Name";
            this.colRegistered_Users_Name.Name = "colRegistered_Users_Name";
            this.colRegistered_Users_Name.Visible = true;
            this.colRegistered_Users_Name.VisibleIndex = 6;
            this.colRegistered_Users_Name.Width = 327;
            // 
            // colRegistered_Users_phone
            // 
            this.colRegistered_Users_phone.Caption = "رقم المتدرب";
            this.colRegistered_Users_phone.FieldName = "Registered_Users_phone";
            this.colRegistered_Users_phone.Name = "colRegistered_Users_phone";
            this.colRegistered_Users_phone.Visible = true;
            this.colRegistered_Users_phone.VisibleIndex = 4;
            this.colRegistered_Users_phone.Width = 188;
            // 
            // colRegistered_Users_ssn
            // 
            this.colRegistered_Users_ssn.Caption = "الرقم القومى";
            this.colRegistered_Users_ssn.FieldName = "Registered_Users_ssn";
            this.colRegistered_Users_ssn.Name = "colRegistered_Users_ssn";
            this.colRegistered_Users_ssn.Visible = true;
            this.colRegistered_Users_ssn.VisibleIndex = 5;
            this.colRegistered_Users_ssn.Width = 188;
            // 
            // colTake_Course_Course
            // 
            this.colTake_Course_Course.Caption = "اسم التدريب";
            this.colTake_Course_Course.FieldName = "Take_Course_Course";
            this.colTake_Course_Course.Name = "colTake_Course_Course";
            this.colTake_Course_Course.Width = 143;
            // 
            // colTake_Course_ID
            // 
            this.colTake_Course_ID.Caption = "ID";
            this.colTake_Course_ID.FieldName = "Take_Course_ID";
            this.colTake_Course_ID.Name = "colTake_Course_ID";
            this.colTake_Course_ID.Visible = true;
            this.colTake_Course_ID.VisibleIndex = 7;
            this.colTake_Course_ID.Width = 81;
            // 
            // colTake_Course_Student
            // 
            this.colTake_Course_Student.Caption = "الطالب";
            this.colTake_Course_Student.FieldName = "Take_Course_Student";
            this.colTake_Course_Student.Name = "colTake_Course_Student";
            this.colTake_Course_Student.Width = 156;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 787);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 59);
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
            // Form_Take_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 846);
            this.Controls.Add(this.Pn_frm_cat);
            this.Name = "Form_Take_Course_List";
            this.Text = "Form_Take_Course_List";
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
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_end;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colCourse_start;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_ssn;
        private DevExpress.XtraGrid.Columns.GridColumn colTake_Course_Course;
        private DevExpress.XtraGrid.Columns.GridColumn colTake_Course_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTake_Course_Student;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}