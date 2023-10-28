
namespace FWD.G_Receives
{
    partial class Form_Recive_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Recive_List));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmploee_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPUR_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELL_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELL_Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSELL_Resv_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.h = new DevExpress.XtraGrid.GridControl();
            this.Pn_frm_receive = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            this.Pn_frm_receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(314, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 789);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 59);
            this.panel1.TabIndex = 0;
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(163, 7);
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
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colEmploee_Name,
            this.colID,
            this.colPUR_Name,
            this.colRegistered_Users_Name,
            this.colRegistered_Users_phone,
            this.colRegistered_Users_Ssn,
            this.colSELL_Date,
            this.colSELL_Num,
            this.gridColumn1,
            this.colSELL_Resv_Name});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1284, 512, 264, 444);
            this.gridView1.GridControl = this.h;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmploee_Name
            // 
            this.colEmploee_Name.Caption = "اسم الموظف";
            this.colEmploee_Name.FieldName = "Emploee_Name";
            this.colEmploee_Name.Name = "colEmploee_Name";
            this.colEmploee_Name.Visible = true;
            this.colEmploee_Name.VisibleIndex = 0;
            this.colEmploee_Name.Width = 202;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 8;
            this.colID.Width = 54;
            // 
            // colPUR_Name
            // 
            this.colPUR_Name.Caption = "اسم الصنف";
            this.colPUR_Name.FieldName = "PUR_Name";
            this.colPUR_Name.Name = "colPUR_Name";
            this.colPUR_Name.Visible = true;
            this.colPUR_Name.VisibleIndex = 3;
            this.colPUR_Name.Width = 172;
            // 
            // colRegistered_Users_Name
            // 
            this.colRegistered_Users_Name.Caption = "اسم الحالة";
            this.colRegistered_Users_Name.FieldName = "Registered_Users_Name";
            this.colRegistered_Users_Name.Name = "colRegistered_Users_Name";
            this.colRegistered_Users_Name.Visible = true;
            this.colRegistered_Users_Name.VisibleIndex = 7;
            this.colRegistered_Users_Name.Width = 235;
            // 
            // colRegistered_Users_phone
            // 
            this.colRegistered_Users_phone.Caption = "رقم الهاتف";
            this.colRegistered_Users_phone.FieldName = "Registered_Users_phone";
            this.colRegistered_Users_phone.Name = "colRegistered_Users_phone";
            this.colRegistered_Users_phone.Visible = true;
            this.colRegistered_Users_phone.VisibleIndex = 4;
            this.colRegistered_Users_phone.Width = 172;
            // 
            // colRegistered_Users_Ssn
            // 
            this.colRegistered_Users_Ssn.Caption = "الرقم القومى";
            this.colRegistered_Users_Ssn.FieldName = "Registered_Users_Ssn";
            this.colRegistered_Users_Ssn.Name = "colRegistered_Users_Ssn";
            this.colRegistered_Users_Ssn.Visible = true;
            this.colRegistered_Users_Ssn.VisibleIndex = 5;
            this.colRegistered_Users_Ssn.Width = 207;
            // 
            // colSELL_Date
            // 
            this.colSELL_Date.Caption = "تاريخ الاستلام";
            this.colSELL_Date.FieldName = "SELL_Date";
            this.colSELL_Date.Name = "colSELL_Date";
            this.colSELL_Date.Visible = true;
            this.colSELL_Date.VisibleIndex = 1;
            this.colSELL_Date.Width = 163;
            // 
            // colSELL_Num
            // 
            this.colSELL_Num.Caption = "العدد";
            this.colSELL_Num.FieldName = "SELL_Num";
            this.colSELL_Num.Name = "colSELL_Num";
            this.colSELL_Num.Visible = true;
            this.colSELL_Num.VisibleIndex = 2;
            this.colSELL_Num.Width = 72;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الامضاء";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 147;
            // 
            // colSELL_Resv_Name
            // 
            this.colSELL_Resv_Name.Caption = "اسم المستلم";
            this.colSELL_Resv_Name.FieldName = "SELL_Resv_Name";
            this.colSELL_Resv_Name.Name = "colSELL_Resv_Name";
            this.colSELL_Resv_Name.Visible = true;
            this.colSELL_Resv_Name.VisibleIndex = 6;
            this.colSELL_Resv_Name.Width = 194;
            // 
            // h
            // 
            this.h.DataSource = typeof(FWD.View_Sell_to_Customers);
            this.h.Dock = System.Windows.Forms.DockStyle.Fill;
            this.h.Location = new System.Drawing.Point(0, 0);
            this.h.MainView = this.gridView1;
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(1501, 789);
            this.h.TabIndex = 1;
            this.h.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Pn_frm_receive
            // 
            this.Pn_frm_receive.Controls.Add(this.h);
            this.Pn_frm_receive.Controls.Add(this.panel1);
            this.Pn_frm_receive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_receive.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_receive.Name = "Pn_frm_receive";
            this.Pn_frm_receive.Size = new System.Drawing.Size(1501, 848);
            this.Pn_frm_receive.TabIndex = 1;
            // 
            // Form_Recive_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 848);
            this.Controls.Add(this.Pn_frm_receive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Recive_List";
            this.Text = "Form_Recive_List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            this.Pn_frm_receive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl h;
        public System.Windows.Forms.Panel Pn_frm_receive;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPUR_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Ssn;
        private DevExpress.XtraGrid.Columns.GridColumn colSELL_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colSELL_Num;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colSELL_Resv_Name;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}