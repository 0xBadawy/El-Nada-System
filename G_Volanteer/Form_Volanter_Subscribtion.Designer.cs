
namespace FWD.G_Volanteer
{
    partial class Form_Volanter_Subscribtion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Volanter_Subscribtion));
            this.Edit_Volanter_Name = new DevExpress.XtraEditors.LookUpEdit();
            this.tBvolunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2088 = new FWD.DB_FWDDataSet2088();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_Volanter_Date = new DevExpress.XtraEditors.DateEdit();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.Pn_frm_doc = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMoth_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Department_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolunteer_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolunteer_Subscription_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolunteer_Subscription_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolunteer_Subscription_recet_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Recite = new DevExpress.XtraEditors.TextEdit();
            this.Edit_Volanter_Month = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Edit_Volanter_value = new DevExpress.XtraEditors.TextEdit();
            this.tBSupscriptionMothBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2089 = new FWD.DB_FWDDataSet2089();
            this.tB_volunteerTableAdapter = new FWD.DB_FWDDataSet2088TableAdapters.TB_volunteerTableAdapter();
            this.tB_Supscription_MothTableAdapter = new FWD.DB_FWDDataSet2089TableAdapters.TB_Supscription_MothTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBvolunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2088)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Date.Properties.CalendarTimeProperties)).BeginInit();
            this.panel1.SuspendLayout();
            this.Pn_frm_doc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Recite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Month.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_value.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupscriptionMothBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2089)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_Volanter_Name
            // 
            this.Edit_Volanter_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Volanter_Name.Location = new System.Drawing.Point(744, 93);
            this.Edit_Volanter_Name.Name = "Edit_Volanter_Name";
            this.Edit_Volanter_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Volanter_Name.Properties.Appearance.Options.UseFont = true;
            this.Edit_Volanter_Name.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Volanter_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Volanter_Name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Volanter_Name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Volanter_Name.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("volunteer_Name", "volunteer_Name", 97, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Edit_Volanter_Name.Properties.DataSource = typeof(FWD.TB_volunteer);
            this.Edit_Volanter_Name.Properties.DisplayMember = "volunteer_Name";
            this.Edit_Volanter_Name.Properties.NullText = " ";
            this.Edit_Volanter_Name.Properties.ValueMember = "volunteer_ID";
            this.Edit_Volanter_Name.Size = new System.Drawing.Size(393, 40);
            this.Edit_Volanter_Name.TabIndex = 80;
            this.Edit_Volanter_Name.EditValueChanged += new System.EventHandler(this.Edit_Volanter_Name_EditValueChanged);
            this.Edit_Volanter_Name.Click += new System.EventHandler(this.Edit_Volanter_Name_Click);
            // 
            // tBvolunteerBindingSource
            // 
            this.tBvolunteerBindingSource.DataMember = "TB_volunteer";
            this.tBvolunteerBindingSource.DataSource = this.dB_FWDDataSet2088;
            // 
            // dB_FWDDataSet2088
            // 
            this.dB_FWDDataSet2088.DataSetName = "DB_FWDDataSet2088";
            this.dB_FWDDataSet2088.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(124, 188);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(390, 43);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(512, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "دفع اشتراكات المتطوعين";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1184, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 43);
            this.label4.TabIndex = 77;
            this.label4.Text = "التاريخ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1155, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 43);
            this.label2.TabIndex = 72;
            this.label2.Text = "اسم المتطوع";
            // 
            // Edit_Volanter_Date
            // 
            this.Edit_Volanter_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Volanter_Date.EditValue = null;
            this.Edit_Volanter_Date.Location = new System.Drawing.Point(744, 149);
            this.Edit_Volanter_Date.Name = "Edit_Volanter_Date";
            this.Edit_Volanter_Date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Volanter_Date.Properties.Appearance.Options.UseFont = true;
            this.Edit_Volanter_Date.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Volanter_Date.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Volanter_Date.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Volanter_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Volanter_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Volanter_Date.Properties.DisplayFormat.FormatString = "";
            this.Edit_Volanter_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Edit_Volanter_Date.Properties.EditFormat.FormatString = "";
            this.Edit_Volanter_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Edit_Volanter_Date.Properties.MaskSettings.Set("mask", "yyyy / MM / dd ");
            this.Edit_Volanter_Date.Size = new System.Drawing.Size(393, 40);
            this.Edit_Volanter_Date.TabIndex = 3;
            this.Edit_Volanter_Date.EditValueChanged += new System.EventHandler(this.Edit_Volanter_Date_EditValueChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 734);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(368, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 10;
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
            this.btn_del.TabIndex = 12;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Pn_frm_doc
            // 
            this.Pn_frm_doc.BackColor = System.Drawing.Color.White;
            this.Pn_frm_doc.Controls.Add(this.gridControl1);
            this.Pn_frm_doc.Controls.Add(this.panel2);
            this.Pn_frm_doc.Controls.Add(this.panel1);
            this.Pn_frm_doc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_doc.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_doc.Name = "Pn_frm_doc";
            this.Pn_frm_doc.Size = new System.Drawing.Size(1440, 793);
            this.Pn_frm_doc.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Volunteer_Subscription);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 465);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1440, 269);
            this.gridControl1.TabIndex = 3;
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
            this.colMoth_Name,
            this.colvolunteer_Department_1,
            this.colvolunteer_Name,
            this.colvolunteer_Phone,
            this.colvolunteer_SSN,
            this.colVolunteer_Subscription_Date,
            this.colVolunteer_Subscription_Value,
            this.colVolunteer_Subscription_recet_num});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMoth_Name
            // 
            this.colMoth_Name.Caption = "الشهر";
            this.colMoth_Name.FieldName = "Moth_Name";
            this.colMoth_Name.Name = "colMoth_Name";
            this.colMoth_Name.Visible = true;
            this.colMoth_Name.VisibleIndex = 1;
            this.colMoth_Name.Width = 137;
            // 
            // colvolunteer_Department_1
            // 
            this.colvolunteer_Department_1.Caption = "اللجنة الاساسية";
            this.colvolunteer_Department_1.FieldName = "volunteer_Department_1";
            this.colvolunteer_Department_1.Name = "colvolunteer_Department_1";
            this.colvolunteer_Department_1.Visible = true;
            this.colvolunteer_Department_1.VisibleIndex = 4;
            this.colvolunteer_Department_1.Width = 160;
            // 
            // colvolunteer_Name
            // 
            this.colvolunteer_Name.Caption = "اسم المتطوع";
            this.colvolunteer_Name.FieldName = "volunteer_Name";
            this.colvolunteer_Name.Name = "colvolunteer_Name";
            this.colvolunteer_Name.Visible = true;
            this.colvolunteer_Name.VisibleIndex = 7;
            this.colvolunteer_Name.Width = 311;
            // 
            // colvolunteer_Phone
            // 
            this.colvolunteer_Phone.Caption = "رقم الهاتف";
            this.colvolunteer_Phone.FieldName = "volunteer_Phone";
            this.colvolunteer_Phone.Name = "colvolunteer_Phone";
            this.colvolunteer_Phone.Visible = true;
            this.colvolunteer_Phone.VisibleIndex = 5;
            this.colvolunteer_Phone.Width = 124;
            // 
            // colvolunteer_SSN
            // 
            this.colvolunteer_SSN.Caption = "الرقم القومى";
            this.colvolunteer_SSN.FieldName = "volunteer_SSN";
            this.colvolunteer_SSN.Name = "colvolunteer_SSN";
            this.colvolunteer_SSN.Visible = true;
            this.colvolunteer_SSN.VisibleIndex = 6;
            this.colvolunteer_SSN.Width = 185;
            // 
            // colVolunteer_Subscription_Date
            // 
            this.colVolunteer_Subscription_Date.Caption = "التاريخ";
            this.colVolunteer_Subscription_Date.FieldName = "Volunteer_Subscription_Date";
            this.colVolunteer_Subscription_Date.Name = "colVolunteer_Subscription_Date";
            this.colVolunteer_Subscription_Date.Visible = true;
            this.colVolunteer_Subscription_Date.VisibleIndex = 0;
            this.colVolunteer_Subscription_Date.Width = 136;
            // 
            // colVolunteer_Subscription_Value
            // 
            this.colVolunteer_Subscription_Value.Caption = "قيمة الاشتراك";
            this.colVolunteer_Subscription_Value.FieldName = "Volunteer_Subscription_Value";
            this.colVolunteer_Subscription_Value.Name = "colVolunteer_Subscription_Value";
            this.colVolunteer_Subscription_Value.Visible = true;
            this.colVolunteer_Subscription_Value.VisibleIndex = 3;
            this.colVolunteer_Subscription_Value.Width = 146;
            // 
            // colVolunteer_Subscription_recet_num
            // 
            this.colVolunteer_Subscription_recet_num.Caption = "رقم ايصال الدفع";
            this.colVolunteer_Subscription_recet_num.FieldName = "Volunteer_Subscription_recet_num";
            this.colVolunteer_Subscription_recet_num.Name = "colVolunteer_Subscription_recet_num";
            this.colVolunteer_Subscription_recet_num.Visible = true;
            this.colVolunteer_Subscription_recet_num.VisibleIndex = 2;
            this.colVolunteer_Subscription_recet_num.Width = 211;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Recite);
            this.panel2.Controls.Add(this.Edit_Volanter_Month);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Edit_Volanter_value);
            this.panel2.Controls.Add(this.Edit_Volanter_Name);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Edit_Volanter_Date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1440, 734);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1155, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 43);
            this.label3.TabIndex = 90;
            this.label3.Text = "رقم ايصال الدفع";
            // 
            // Recite
            // 
            this.Recite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Recite.Location = new System.Drawing.Point(744, 195);
            this.Recite.Name = "Recite";
            this.Recite.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Recite.Properties.Appearance.Options.UseFont = true;
            this.Recite.Properties.Appearance.Options.UseTextOptions = true;
            this.Recite.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Recite.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Recite.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.Recite.Properties.MaskSettings.Set("mask", "d");
            this.Recite.Size = new System.Drawing.Size(390, 40);
            this.Recite.TabIndex = 89;
            this.Recite.EditValueChanged += new System.EventHandler(this.Recite_EditValueChanged);
            // 
            // Edit_Volanter_Month
            // 
            this.Edit_Volanter_Month.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Volanter_Month.Location = new System.Drawing.Point(124, 141);
            this.Edit_Volanter_Month.Name = "Edit_Volanter_Month";
            this.Edit_Volanter_Month.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Volanter_Month.Properties.Appearance.Options.UseFont = true;
            this.Edit_Volanter_Month.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Volanter_Month.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Volanter_Month.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Volanter_Month.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Edit_Volanter_Month.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moth_Name", "Moth_Name", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Edit_Volanter_Month.Properties.DataSource = typeof(FWD.TB_Supscription_Moth);
            this.Edit_Volanter_Month.Properties.DisplayMember = "Moth_Name";
            this.Edit_Volanter_Month.Properties.NullText = " ";
            this.Edit_Volanter_Month.Properties.ValueMember = "Moth_ID";
            this.Edit_Volanter_Month.Size = new System.Drawing.Size(390, 40);
            this.Edit_Volanter_Month.TabIndex = 88;
            this.Edit_Volanter_Month.EditValueChanged += new System.EventHandler(this.Edit_Volanter_Month_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 43);
            this.label1.TabIndex = 87;
            this.label1.Text = "الشهر";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 43);
            this.label5.TabIndex = 87;
            this.label5.Text = "مبلغ الاشتراك";
            // 
            // Edit_Volanter_value
            // 
            this.Edit_Volanter_value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Volanter_value.Location = new System.Drawing.Point(124, 95);
            this.Edit_Volanter_value.Name = "Edit_Volanter_value";
            this.Edit_Volanter_value.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Volanter_value.Properties.Appearance.Options.UseFont = true;
            this.Edit_Volanter_value.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Volanter_value.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Volanter_value.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Volanter_value.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.Edit_Volanter_value.Properties.MaskSettings.Set("mask", "f");
            this.Edit_Volanter_value.Size = new System.Drawing.Size(390, 40);
            this.Edit_Volanter_value.TabIndex = 86;
            this.Edit_Volanter_value.EditValueChanged += new System.EventHandler(this.Edit_Volanter_value_EditValueChanged);
            // 
            // tBSupscriptionMothBindingSource
            // 
            this.tBSupscriptionMothBindingSource.DataMember = "TB_Supscription_Moth";
            this.tBSupscriptionMothBindingSource.DataSource = this.dB_FWDDataSet2089;
            // 
            // dB_FWDDataSet2089
            // 
            this.dB_FWDDataSet2089.DataSetName = "DB_FWDDataSet2089";
            this.dB_FWDDataSet2089.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_volunteerTableAdapter
            // 
            this.tB_volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // tB_Supscription_MothTableAdapter
            // 
            this.tB_Supscription_MothTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Volanter_Subscribtion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 793);
            this.Controls.Add(this.Pn_frm_doc);
            this.Name = "Form_Volanter_Subscribtion";
            this.Text = "Form_Volanter_Subscribtion";
            this.Load += new System.EventHandler(this.Form_Volanter_Subscribtion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBvolunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2088)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Date.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Pn_frm_doc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Recite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_Month.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Volanter_value.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSupscriptionMothBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2089)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit Edit_Volanter_Name;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit Edit_Volanter_Date;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        public System.Windows.Forms.Panel Pn_frm_doc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit Edit_Volanter_value;
        private DevExpress.XtraEditors.LookUpEdit Edit_Volanter_Month;
        private System.Windows.Forms.Label label1;
        private DB_FWDDataSet2088 dB_FWDDataSet2088;
        private System.Windows.Forms.BindingSource tBvolunteerBindingSource;
        private DB_FWDDataSet2088TableAdapters.TB_volunteerTableAdapter tB_volunteerTableAdapter;
        private DB_FWDDataSet2089 dB_FWDDataSet2089;
        private System.Windows.Forms.BindingSource tBSupscriptionMothBindingSource;
        private DB_FWDDataSet2089TableAdapters.TB_Supscription_MothTableAdapter tB_Supscription_MothTableAdapter;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit Recite;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMoth_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Department_1;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colvolunteer_SSN;
        private DevExpress.XtraGrid.Columns.GridColumn colVolunteer_Subscription_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colVolunteer_Subscription_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colVolunteer_Subscription_recet_num;
    }
}