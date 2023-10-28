
namespace FWD.G_Users
{
    partial class Form_User_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User_List));
            this.User_list_panel = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmploee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_permitions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_Roll_E_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_Roll_login_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_Roll_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.User_list_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // User_list_panel
            // 
            this.User_list_panel.Controls.Add(this.gridControl1);
            this.User_list_panel.Controls.Add(this.panel2);
            this.User_list_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_list_panel.Location = new System.Drawing.Point(0, 0);
            this.User_list_panel.Name = "User_list_panel";
            this.User_list_panel.Size = new System.Drawing.Size(1316, 776);
            this.User_list_panel.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_emploee_list);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1316, 717);
            this.gridControl1.TabIndex = 2;
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
            this.colEmploee_ID,
            this.colEmploee_Name,
            this.colEmploee_permitions,
            this.colEmploee_phone,
            this.colEmploee_Roll_E_Name,
            this.colEmploee_Roll_login_State,
            this.colEmploee_Roll_Name,
            this.colEmploee_UserName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmploee_Roll_login_State, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colEmploee_ID
            // 
            this.colEmploee_ID.Caption = "ID";
            this.colEmploee_ID.FieldName = "Emploee_ID";
            this.colEmploee_ID.Name = "colEmploee_ID";
            this.colEmploee_ID.Visible = true;
            this.colEmploee_ID.VisibleIndex = 7;
            this.colEmploee_ID.Width = 58;
            // 
            // colEmploee_Name
            // 
            this.colEmploee_Name.Caption = "اسم المستخدم";
            this.colEmploee_Name.FieldName = "Emploee_Name";
            this.colEmploee_Name.Name = "colEmploee_Name";
            this.colEmploee_Name.Visible = true;
            this.colEmploee_Name.VisibleIndex = 6;
            this.colEmploee_Name.Width = 268;
            // 
            // colEmploee_permitions
            // 
            this.colEmploee_permitions.Caption = "الصلاحيات";
            this.colEmploee_permitions.FieldName = "Emploee_permitions";
            this.colEmploee_permitions.Name = "colEmploee_permitions";
            this.colEmploee_permitions.Visible = true;
            this.colEmploee_permitions.VisibleIndex = 2;
            this.colEmploee_permitions.Width = 160;
            // 
            // colEmploee_phone
            // 
            this.colEmploee_phone.Caption = "رقم الهاتف";
            this.colEmploee_phone.FieldName = "Emploee_phone";
            this.colEmploee_phone.Name = "colEmploee_phone";
            this.colEmploee_phone.Visible = true;
            this.colEmploee_phone.VisibleIndex = 5;
            this.colEmploee_phone.Width = 160;
            // 
            // colEmploee_Roll_E_Name
            // 
            this.colEmploee_Roll_E_Name.Caption = "دور المستخدم";
            this.colEmploee_Roll_E_Name.FieldName = "Emploee_Roll_E_Name";
            this.colEmploee_Roll_E_Name.Name = "colEmploee_Roll_E_Name";
            this.colEmploee_Roll_E_Name.Visible = true;
            this.colEmploee_Roll_E_Name.VisibleIndex = 4;
            this.colEmploee_Roll_E_Name.Width = 160;
            // 
            // colEmploee_Roll_login_State
            // 
            this.colEmploee_Roll_login_State.Caption = "حالة الدخول";
            this.colEmploee_Roll_login_State.FieldName = "Emploee_Roll_login_State";
            this.colEmploee_Roll_login_State.Name = "colEmploee_Roll_login_State";
            this.colEmploee_Roll_login_State.Visible = true;
            this.colEmploee_Roll_login_State.VisibleIndex = 0;
            this.colEmploee_Roll_login_State.Width = 160;
            // 
            // colEmploee_Roll_Name
            // 
            this.colEmploee_Roll_Name.Caption = "دور المستخدم";
            this.colEmploee_Roll_Name.FieldName = "Emploee_Roll_Name";
            this.colEmploee_Roll_Name.Name = "colEmploee_Roll_Name";
            this.colEmploee_Roll_Name.Visible = true;
            this.colEmploee_Roll_Name.VisibleIndex = 1;
            this.colEmploee_Roll_Name.Width = 160;
            // 
            // colEmploee_UserName
            // 
            this.colEmploee_UserName.Caption = "User Name";
            this.colEmploee_UserName.FieldName = "Emploee_UserName";
            this.colEmploee_UserName.Name = "colEmploee_UserName";
            this.colEmploee_UserName.Visible = true;
            this.colEmploee_UserName.VisibleIndex = 3;
            this.colEmploee_UserName.Width = 160;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.btn_ref);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 59);
            this.panel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(144, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تعديل";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(471, 7);
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
            this.btn_ref.Location = new System.Drawing.Point(318, 7);
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
            // Form_User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 776);
            this.Controls.Add(this.User_list_panel);
            this.Name = "Form_User_List";
            this.Text = "Form_User_List";
            this.Load += new System.EventHandler(this.Form_User_List_Load);
            this.User_list_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public System.Windows.Forms.Panel User_list_panel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_permitions;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Roll_E_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Roll_login_State;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Roll_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_UserName;
    }
}