
namespace FWD.G_Report_Forms
{
    partial class Form_Pharmasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pharmasy));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_doc_det = new DevExpress.XtraEditors.TextEdit();
            this.edt_doc_Date = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.Pn_frm_phar = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPharmasist_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHR_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistered_Users_Ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label_C_Inf_rank = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_C_Inf_supp = new System.Windows.Forms.TextBox();
            this.label_C_Inf_add_2 = new System.Windows.Forms.TextBox();
            this.label_C_Inf_add = new System.Windows.Forms.TextBox();
            this.label_C_Inf_id = new System.Windows.Forms.TextBox();
            this.label_C_Inf_ssn = new System.Windows.Forms.TextBox();
            this.label_C_Inf_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edt_code = new DevExpress.XtraEditors.TextEdit();
            this.Edit_Phar = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tBPharmasistInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2090 = new FWD.DB_FWDDataSet2090();
            this.tB_Pharmasist_InfoTableAdapter = new FWD.DB_FWDDataSet2090TableAdapters.TB_Pharmasist_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_Date.Properties.CalendarTimeProperties)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pn_frm_phar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Phar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPharmasistInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2090)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(561, 351);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 43);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(580, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "طلب دواء من صيدلية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1305, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 43);
            this.label3.TabIndex = 73;
            this.label3.Text = "تفاصيل";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1311, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 43);
            this.label4.TabIndex = 77;
            this.label4.Text = "التاريخ";
            // 
            // edt_doc_det
            // 
            this.edt_doc_det.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_doc_det.Location = new System.Drawing.Point(878, 286);
            this.edt_doc_det.Name = "edt_doc_det";
            this.edt_doc_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_doc_det.Properties.Appearance.Options.UseFont = true;
            this.edt_doc_det.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_doc_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_doc_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_doc_det.Size = new System.Drawing.Size(393, 40);
            this.edt_doc_det.TabIndex = 4;
            // 
            // edt_doc_Date
            // 
            this.edt_doc_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_doc_Date.EditValue = null;
            this.edt_doc_Date.Location = new System.Drawing.Point(878, 359);
            this.edt_doc_Date.Name = "edt_doc_Date";
            this.edt_doc_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_doc_Date.Properties.Appearance.Options.UseFont = true;
            this.edt_doc_Date.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_doc_Date.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_doc_Date.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_doc_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_doc_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_doc_Date.Properties.DisplayFormat.FormatString = "";
            this.edt_doc_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edt_doc_Date.Properties.EditFormat.FormatString = "";
            this.edt_doc_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.edt_doc_Date.Properties.MaskSettings.Set("mask", "yyyy / MM / dd ");
            this.edt_doc_Date.Size = new System.Drawing.Size(393, 40);
            this.edt_doc_Date.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(368, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(188, 44);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "طباعة الطلب";
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
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 821);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1513, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(580, 7);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(244, 44);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "طباعة الكشف كامل";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(187, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 11;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // Pn_frm_phar
            // 
            this.Pn_frm_phar.BackColor = System.Drawing.Color.White;
            this.Pn_frm_phar.Controls.Add(this.gridControl1);
            this.Pn_frm_phar.Controls.Add(this.panel2);
            this.Pn_frm_phar.Controls.Add(this.panel1);
            this.Pn_frm_phar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_phar.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_phar.Name = "Pn_frm_phar";
            this.Pn_frm_phar.Size = new System.Drawing.Size(1513, 880);
            this.Pn_frm_phar.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.view_Pharmasist_List);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 671);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1513, 150);
            this.gridControl1.TabIndex = 3;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPharmasist_Name,
            this.colPHR_Date,
            this.kk,
            this.colRegistered_Users_Name,
            this.colRegistered_Users_phone,
            this.colRegistered_Users_Ssn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "الكود";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 6;
            this.colID.Width = 115;
            // 
            // colPharmasist_Name
            // 
            this.colPharmasist_Name.Caption = "اسم الصيدلية";
            this.colPharmasist_Name.FieldName = "Pharmasist_Name";
            this.colPharmasist_Name.Name = "colPharmasist_Name";
            this.colPharmasist_Name.Visible = true;
            this.colPharmasist_Name.VisibleIndex = 2;
            this.colPharmasist_Name.Width = 210;
            // 
            // colPHR_Date
            // 
            this.colPHR_Date.Caption = "التاريخ";
            this.colPHR_Date.FieldName = "PHR_Date";
            this.colPHR_Date.Name = "colPHR_Date";
            this.colPHR_Date.Visible = true;
            this.colPHR_Date.VisibleIndex = 0;
            this.colPHR_Date.Width = 153;
            // 
            // kk
            // 
            this.kk.Caption = "الدواء";
            this.kk.FieldName = "PHR_Drug";
            this.kk.Name = "kk";
            this.kk.Visible = true;
            this.kk.VisibleIndex = 1;
            this.kk.Width = 267;
            // 
            // colRegistered_Users_Name
            // 
            this.colRegistered_Users_Name.Caption = "اسم المريض";
            this.colRegistered_Users_Name.FieldName = "Registered_Users_Name";
            this.colRegistered_Users_Name.Name = "colRegistered_Users_Name";
            this.colRegistered_Users_Name.Visible = true;
            this.colRegistered_Users_Name.VisibleIndex = 5;
            this.colRegistered_Users_Name.Width = 335;
            // 
            // colRegistered_Users_phone
            // 
            this.colRegistered_Users_phone.Caption = "التلفون";
            this.colRegistered_Users_phone.FieldName = "Registered_Users_phone";
            this.colRegistered_Users_phone.Name = "colRegistered_Users_phone";
            this.colRegistered_Users_phone.Visible = true;
            this.colRegistered_Users_phone.VisibleIndex = 3;
            this.colRegistered_Users_phone.Width = 210;
            // 
            // colRegistered_Users_Ssn
            // 
            this.colRegistered_Users_Ssn.Caption = "الرقم القومى";
            this.colRegistered_Users_Ssn.FieldName = "Registered_Users_Ssn";
            this.colRegistered_Users_Ssn.Name = "colRegistered_Users_Ssn";
            this.colRegistered_Users_Ssn.Visible = true;
            this.colRegistered_Users_Ssn.VisibleIndex = 4;
            this.colRegistered_Users_Ssn.Width = 193;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.simpleButton4);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Controls.Add(this.edt_code);
            this.panel2.Controls.Add(this.Edit_Phar);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.edt_doc_det);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.edt_doc_Date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1513, 821);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(791, 210);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(39, 41);
            this.simpleButton4.TabIndex = 89;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(836, 210);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(39, 41);
            this.simpleButton3.TabIndex = 86;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1285, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 43);
            this.label2.TabIndex = 88;
            this.label2.Text = "كود المريض";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupControl1.Controls.Add(this.label_C_Inf_rank);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label_C_Inf_supp);
            this.groupControl1.Controls.Add(this.label_C_Inf_add_2);
            this.groupControl1.Controls.Add(this.label_C_Inf_add);
            this.groupControl1.Controls.Add(this.label_C_Inf_id);
            this.groupControl1.Controls.Add(this.label_C_Inf_ssn);
            this.groupControl1.Controls.Add(this.label_C_Inf_name);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Location = new System.Drawing.Point(50, 102);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 458);
            this.groupControl1.TabIndex = 83;
            this.groupControl1.Text = "تفاصيل بيانات الحالة";
            // 
            // label_C_Inf_rank
            // 
            this.label_C_Inf_rank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_rank.Enabled = false;
            this.label_C_Inf_rank.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_rank.Location = new System.Drawing.Point(3, 391);
            this.label_C_Inf_rank.Name = "label_C_Inf_rank";
            this.label_C_Inf_rank.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_rank.TabIndex = 31;
            this.label_C_Inf_rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 43);
            this.label6.TabIndex = 30;
            this.label6.Text = ":    درجة الحالة";
            // 
            // label_C_Inf_supp
            // 
            this.label_C_Inf_supp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_supp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_supp.Enabled = false;
            this.label_C_Inf_supp.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_supp.Location = new System.Drawing.Point(3, 330);
            this.label_C_Inf_supp.Name = "label_C_Inf_supp";
            this.label_C_Inf_supp.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_supp.TabIndex = 29;
            this.label_C_Inf_supp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_add_2
            // 
            this.label_C_Inf_add_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_add_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_add_2.Enabled = false;
            this.label_C_Inf_add_2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_add_2.Location = new System.Drawing.Point(1, 261);
            this.label_C_Inf_add_2.Name = "label_C_Inf_add_2";
            this.label_C_Inf_add_2.Size = new System.Drawing.Size(127, 39);
            this.label_C_Inf_add_2.TabIndex = 29;
            this.label_C_Inf_add_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_add
            // 
            this.label_C_Inf_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_add.Enabled = false;
            this.label_C_Inf_add.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_add.Location = new System.Drawing.Point(184, 260);
            this.label_C_Inf_add.Name = "label_C_Inf_add";
            this.label_C_Inf_add.Size = new System.Drawing.Size(127, 39);
            this.label_C_Inf_add.TabIndex = 29;
            this.label_C_Inf_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_id
            // 
            this.label_C_Inf_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_id.Enabled = false;
            this.label_C_Inf_id.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_id.Location = new System.Drawing.Point(3, 190);
            this.label_C_Inf_id.Name = "label_C_Inf_id";
            this.label_C_Inf_id.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_id.TabIndex = 29;
            this.label_C_Inf_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_ssn
            // 
            this.label_C_Inf_ssn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_ssn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_ssn.Enabled = false;
            this.label_C_Inf_ssn.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_ssn.Location = new System.Drawing.Point(2, 120);
            this.label_C_Inf_ssn.Name = "label_C_Inf_ssn";
            this.label_C_Inf_ssn.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_ssn.TabIndex = 29;
            this.label_C_Inf_ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_name
            // 
            this.label_C_Inf_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_name.Enabled = false;
            this.label_C_Inf_name.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_name.Location = new System.Drawing.Point(5, 50);
            this.label_C_Inf_name.Name = "label_C_Inf_name";
            this.label_C_Inf_name.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_name.TabIndex = 29;
            this.label_C_Inf_name.Text = "  ";
            this.label_C_Inf_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(316, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 43);
            this.label10.TabIndex = 28;
            this.label10.Text = ":          المندوب";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(316, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 43);
            this.label8.TabIndex = 28;
            this.label8.Text = ":           العنوان";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 43);
            this.label7.TabIndex = 28;
            this.label7.Text = ":              الكود";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(319, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 43);
            this.label12.TabIndex = 28;
            this.label12.Text = ":              الاسم";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(316, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 43);
            this.label11.TabIndex = 28;
            this.label11.Text = ": الرقم القومى";
            // 
            // edt_code
            // 
            this.edt_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_code.Location = new System.Drawing.Point(881, 212);
            this.edt_code.Name = "edt_code";
            this.edt_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_code.Properties.Appearance.Options.UseFont = true;
            this.edt_code.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.edt_code.Properties.MaskSettings.Set("mask", "d");
            this.edt_code.Size = new System.Drawing.Size(390, 40);
            this.edt_code.TabIndex = 87;
            // 
            // Edit_Phar
            // 
            this.Edit_Phar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Phar.Location = new System.Drawing.Point(881, 139);
            this.Edit_Phar.Name = "Edit_Phar";
            this.Edit_Phar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Phar.Properties.Appearance.Options.UseFont = true;
            this.Edit_Phar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Phar.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pharmasist_Name", "Pharmasist_Name", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Edit_Phar.Properties.DataSource = typeof(FWD.TB_Pharmasist_Info);
            this.Edit_Phar.Properties.DisplayMember = "Pharmasist_Name";
            this.Edit_Phar.Properties.NullText = " ";
            this.Edit_Phar.Properties.ValueMember = "Pharmasist_ID";
            this.Edit_Phar.Size = new System.Drawing.Size(390, 40);
            this.Edit_Phar.TabIndex = 80;
            this.Edit_Phar.Click += new System.EventHandler(this.Edit_Phar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1279, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 43);
            this.label5.TabIndex = 72;
            this.label5.Text = "اسم الصيدلية";
            // 
            // tBPharmasistInfoBindingSource
            // 
            this.tBPharmasistInfoBindingSource.DataMember = "TB_Pharmasist_Info";
            this.tBPharmasistInfoBindingSource.DataSource = this.dB_FWDDataSet2090;
            // 
            // dB_FWDDataSet2090
            // 
            this.dB_FWDDataSet2090.DataSetName = "DB_FWDDataSet2090";
            this.dB_FWDDataSet2090.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_Pharmasist_InfoTableAdapter
            // 
            this.tB_Pharmasist_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Pharmasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 880);
            this.Controls.Add(this.Pn_frm_phar);
            this.Name = "Form_Pharmasy";
            this.Text = "Form_Pharmasy";
            this.Load += new System.EventHandler(this.Form_Pharmasy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_doc_Date.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Pn_frm_phar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Phar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPharmasistInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2090)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit edt_doc_det;
        private DevExpress.XtraEditors.DateEdit edt_doc_Date;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        public System.Windows.Forms.Panel Pn_frm_phar;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LookUpEdit Edit_Phar;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox label_C_Inf_rank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox label_C_Inf_supp;
        private System.Windows.Forms.TextBox label_C_Inf_add_2;
        private System.Windows.Forms.TextBox label_C_Inf_add;
        private System.Windows.Forms.TextBox label_C_Inf_id;
        private System.Windows.Forms.TextBox label_C_Inf_ssn;
        private System.Windows.Forms.TextBox label_C_Inf_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_code;
        private DB_FWDDataSet2090 dB_FWDDataSet2090;
        private System.Windows.Forms.BindingSource tBPharmasistInfoBindingSource;
        private DB_FWDDataSet2090TableAdapters.TB_Pharmasist_InfoTableAdapter tB_Pharmasist_InfoTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colPharmasist_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPHR_Date;
        private DevExpress.XtraGrid.Columns.GridColumn kk;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistered_Users_Ssn;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}