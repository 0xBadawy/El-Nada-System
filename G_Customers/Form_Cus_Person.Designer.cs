
namespace FWD.G_Customers
{
    partial class Form_Cus_Person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Person));
            this.panel_Form_Cus_Person = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_per_helth_type = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_per_edu = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_per_social_state = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_per_bairth = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_per_label_age = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_per_helth_det = new DevExpress.XtraEditors.TextEdit();
            this.edt_per_phone2 = new DevExpress.XtraEditors.TextEdit();
            this.edt_per_phone = new DevExpress.XtraEditors.TextEdit();
            this.edt_per_ssn = new DevExpress.XtraEditors.TextEdit();
            this.edt_per_name = new DevExpress.XtraEditors.TextEdit();
            this.edt_per_gend = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tBHealthStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2026 = new FWD.DB_FWDDataSet2026();
            this.tBEducationalStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2027 = new FWD.DB_FWDDataSet2027();
            this.tBSocialStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2025 = new FWD.DB_FWDDataSet2025();
            this.tB_Social_StateTableAdapter = new FWD.DB_FWDDataSet2025TableAdapters.TB_Social_StateTableAdapter();
            this.tB_Health_StatusTableAdapter = new FWD.DB_FWDDataSet2026TableAdapters.TB_Health_StatusTableAdapter();
            this.tB_Educational_StatusTableAdapter = new FWD.DB_FWDDataSet2027TableAdapters.TB_Educational_StatusTableAdapter();
            this.panel_Form_Cus_Person.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_helth_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_edu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_social_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_bairth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_helth_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_phone2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_ssn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_gend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHealthStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2026)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEducationalStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2027)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSocialStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2025)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Form_Cus_Person
            // 
            this.panel_Form_Cus_Person.AutoScroll = true;
            this.panel_Form_Cus_Person.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Person.Controls.Add(this.simpleButton1);
            this.panel_Form_Cus_Person.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Person.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Person.Name = "panel_Form_Cus_Person";
            this.panel_Form_Cus_Person.Size = new System.Drawing.Size(1392, 671);
            this.panel_Form_Cus_Person.TabIndex = 0;
            this.panel_Form_Cus_Person.MouseHover += new System.EventHandler(this.panel_Form_Cus_Person_MouseHover);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(509, 571);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(301, 52);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "تسجيل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edt_per_helth_type);
            this.groupBox1.Controls.Add(this.edt_per_edu);
            this.groupBox1.Controls.Add(this.edt_per_social_state);
            this.groupBox1.Controls.Add(this.edt_per_bairth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edt_per_label_age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_per_helth_det);
            this.groupBox1.Controls.Add(this.edt_per_phone2);
            this.groupBox1.Controls.Add(this.edt_per_phone);
            this.groupBox1.Controls.Add(this.edt_per_ssn);
            this.groupBox1.Controls.Add(this.edt_per_name);
            this.groupBox1.Controls.Add(this.edt_per_gend);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1329, 452);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الحالة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // edt_per_helth_type
            // 
            this.edt_per_helth_type.Location = new System.Drawing.Point(693, 309);
            this.edt_per_helth_type.Name = "edt_per_helth_type";
            this.edt_per_helth_type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_helth_type.Properties.Appearance.Options.UseFont = true;
            this.edt_per_helth_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_per_helth_type.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Health_Status_Name", "Health_Status_Name", 119, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_per_helth_type.Properties.DataSource = typeof(FWD.TB_Health_Status);
            this.edt_per_helth_type.Properties.DisplayMember = "Health_Status_Name";
            this.edt_per_helth_type.Properties.NullText = " ";
            this.edt_per_helth_type.Properties.ValueMember = "Health_Status_ID";
            this.edt_per_helth_type.Size = new System.Drawing.Size(391, 40);
            this.edt_per_helth_type.TabIndex = 7;
            this.edt_per_helth_type.Click += new System.EventHandler(this.edt_per_helth_type_Click);
            // 
            // edt_per_edu
            // 
            this.edt_per_edu.Location = new System.Drawing.Point(697, 377);
            this.edt_per_edu.Name = "edt_per_edu";
            this.edt_per_edu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_edu.Properties.Appearance.Options.UseFont = true;
            this.edt_per_edu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_per_edu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Educational_Status_Name", "Educational_Status_Name", 143, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_per_edu.Properties.DataSource = typeof(FWD.TB_Educational_Status);
            this.edt_per_edu.Properties.DisplayMember = "Educational_Status_Name";
            this.edt_per_edu.Properties.NullText = " ";
            this.edt_per_edu.Properties.ValueMember = "Educational_Status_ID";
            this.edt_per_edu.Size = new System.Drawing.Size(390, 40);
            this.edt_per_edu.TabIndex = 9;
            // 
            // edt_per_social_state
            // 
            this.edt_per_social_state.Location = new System.Drawing.Point(100, 309);
            this.edt_per_social_state.Name = "edt_per_social_state";
            this.edt_per_social_state.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_social_state.Properties.Appearance.Options.UseFont = true;
            this.edt_per_social_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_per_social_state.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Social_State_Name", "Social_State_Name", 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_per_social_state.Properties.DataSource = typeof(FWD.TB_Social_State);
            this.edt_per_social_state.Properties.DisplayMember = "Social_State_Name";
            this.edt_per_social_state.Properties.NullText = " ";
            this.edt_per_social_state.Properties.ValueMember = "Social_State_ID";
            this.edt_per_social_state.Size = new System.Drawing.Size(390, 40);
            this.edt_per_social_state.TabIndex = 8;
            this.edt_per_social_state.Click += new System.EventHandler(this.edt_per_social_state_Click);
            // 
            // edt_per_bairth
            // 
            this.edt_per_bairth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_bairth.EditValue = null;
            this.edt_per_bairth.Location = new System.Drawing.Point(798, 173);
            this.edt_per_bairth.Name = "edt_per_bairth";
            this.edt_per_bairth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_bairth.Properties.Appearance.Options.UseFont = true;
            this.edt_per_bairth.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_bairth.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_bairth.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_bairth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_per_bairth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.edt_per_bairth.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.edt_per_bairth.Properties.MaskSettings.Set("mask", "d");
            this.edt_per_bairth.Size = new System.Drawing.Size(289, 40);
            this.edt_per_bairth.TabIndex = 3;
            this.edt_per_bairth.EditValueChanged += new System.EventHandler(this.edt_per_bairth_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1093, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "الحالة التعليمية";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1112, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 43);
            this.label11.TabIndex = 50;
            this.label11.Text = "الحالة الصحية";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 43);
            this.label9.TabIndex = 50;
            this.label9.Text = "الحالة الاجتماعية";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 43);
            this.label5.TabIndex = 50;
            this.label5.Text = "النوع";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 43);
            this.label3.TabIndex = 50;
            this.label3.Text = "الرقم القومى";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(693, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 43);
            this.label7.TabIndex = 50;
            this.label7.Text = "سنة";
            // 
            // edt_per_label_age
            // 
            this.edt_per_label_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_label_age.AutoSize = true;
            this.edt_per_label_age.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_per_label_age.Location = new System.Drawing.Point(745, 168);
            this.edt_per_label_age.Name = "edt_per_label_age";
            this.edt_per_label_age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_per_label_age.Size = new System.Drawing.Size(47, 43);
            this.edt_per_label_age.TabIndex = 50;
            this.edt_per_label_age.Text = "00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1128, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 43);
            this.label4.TabIndex = 50;
            this.label4.Text = "تاريخ الميلاد";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(527, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 43);
            this.label10.TabIndex = 50;
            this.label10.Text = "وصف المرض";
            this.label10.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 43);
            this.label6.TabIndex = 50;
            this.label6.Text = "رقم الهاتف";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1129, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 43);
            this.label8.TabIndex = 50;
            this.label8.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1177, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 43);
            this.label2.TabIndex = 50;
            this.label2.Text = "الاسم";
            // 
            // edt_per_helth_det
            // 
            this.edt_per_helth_det.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_helth_det.EditValue = "";
            this.edt_per_helth_det.Location = new System.Drawing.Point(100, 377);
            this.edt_per_helth_det.Name = "edt_per_helth_det";
            this.edt_per_helth_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_helth_det.Properties.Appearance.Options.UseFont = true;
            this.edt_per_helth_det.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_helth_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_helth_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_helth_det.Size = new System.Drawing.Size(390, 40);
            this.edt_per_helth_det.TabIndex = 9;
            this.edt_per_helth_det.Visible = false;
            // 
            // edt_per_phone2
            // 
            this.edt_per_phone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_phone2.EditValue = "";
            this.edt_per_phone2.Location = new System.Drawing.Point(100, 241);
            this.edt_per_phone2.Name = "edt_per_phone2";
            this.edt_per_phone2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_phone2.Properties.Appearance.Options.UseFont = true;
            this.edt_per_phone2.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_phone2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_phone2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_phone2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_per_phone2.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_per_phone2.Size = new System.Drawing.Size(390, 40);
            this.edt_per_phone2.TabIndex = 6;
            // 
            // edt_per_phone
            // 
            this.edt_per_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_phone.EditValue = "";
            this.edt_per_phone.Location = new System.Drawing.Point(697, 241);
            this.edt_per_phone.Name = "edt_per_phone";
            this.edt_per_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_phone.Properties.Appearance.Options.UseFont = true;
            this.edt_per_phone.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_phone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_phone.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_phone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_per_phone.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_per_phone.Size = new System.Drawing.Size(390, 40);
            this.edt_per_phone.TabIndex = 5;
            // 
            // edt_per_ssn
            // 
            this.edt_per_ssn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_ssn.EditValue = "";
            this.edt_per_ssn.Location = new System.Drawing.Point(102, 105);
            this.edt_per_ssn.Name = "edt_per_ssn";
            this.edt_per_ssn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_ssn.Properties.Appearance.Options.UseFont = true;
            this.edt_per_ssn.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_ssn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_ssn.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_ssn.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_per_ssn.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_per_ssn.Size = new System.Drawing.Size(390, 40);
            this.edt_per_ssn.TabIndex = 2;
            // 
            // edt_per_name
            // 
            this.edt_per_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_name.EditValue = "";
            this.edt_per_name.Location = new System.Drawing.Point(694, 105);
            this.edt_per_name.Name = "edt_per_name";
            this.edt_per_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_name.Properties.Appearance.Options.UseFont = true;
            this.edt_per_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_name.Size = new System.Drawing.Size(390, 40);
            this.edt_per_name.TabIndex = 1;
            // 
            // edt_per_gend
            // 
            this.edt_per_gend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_gend.EditValue = "";
            this.edt_per_gend.Location = new System.Drawing.Point(102, 173);
            this.edt_per_gend.Name = "edt_per_gend";
            this.edt_per_gend.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_gend.Properties.Appearance.Options.UseFont = true;
            this.edt_per_gend.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_gend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_gend.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_gend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_per_gend.Properties.Items.AddRange(new object[] {
            "ذكر",
            "انثي"});
            this.edt_per_gend.Size = new System.Drawing.Size(390, 40);
            this.edt_per_gend.TabIndex = 4;
            this.edt_per_gend.Click += new System.EventHandler(this.edt_per_gend_Click);
            // 
            // tBHealthStatusBindingSource
            // 
            this.tBHealthStatusBindingSource.DataMember = "TB_Health_Status";
            this.tBHealthStatusBindingSource.DataSource = this.dB_FWDDataSet2026;
            // 
            // dB_FWDDataSet2026
            // 
            this.dB_FWDDataSet2026.DataSetName = "DB_FWDDataSet2026";
            this.dB_FWDDataSet2026.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBEducationalStatusBindingSource
            // 
            this.tBEducationalStatusBindingSource.DataMember = "TB_Educational_Status";
            this.tBEducationalStatusBindingSource.DataSource = this.dB_FWDDataSet2027;
            // 
            // dB_FWDDataSet2027
            // 
            this.dB_FWDDataSet2027.DataSetName = "DB_FWDDataSet2027";
            this.dB_FWDDataSet2027.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBSocialStateBindingSource
            // 
            this.tBSocialStateBindingSource.DataMember = "TB_Social_State";
            this.tBSocialStateBindingSource.DataSource = this.dB_FWDDataSet2025;
            // 
            // dB_FWDDataSet2025
            // 
            this.dB_FWDDataSet2025.DataSetName = "DB_FWDDataSet2025";
            this.dB_FWDDataSet2025.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_Social_StateTableAdapter
            // 
            this.tB_Social_StateTableAdapter.ClearBeforeFill = true;
            // 
            // tB_Health_StatusTableAdapter
            // 
            this.tB_Health_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // tB_Educational_StatusTableAdapter
            // 
            this.tB_Educational_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Cus_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1392, 671);
            this.Controls.Add(this.panel_Form_Cus_Person);
            this.Name = "Form_Cus_Person";
            this.Text = "Form_Cus_Person";
            this.Load += new System.EventHandler(this.Form_Cus_Person_Load);
            this.Click += new System.EventHandler(this.Form_Cus_Person_Click);
            this.panel_Form_Cus_Person.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_helth_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_edu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_social_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_bairth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_helth_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_phone2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_ssn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_gend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBHealthStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2026)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEducationalStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2027)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSocialStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2025)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Form_Cus_Person;
        public System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.DateTimeOffsetEdit edt_per_bairth;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label edt_per_label_age;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit edt_per_helth_det;
        public DevExpress.XtraEditors.TextEdit edt_per_phone;
        public DevExpress.XtraEditors.TextEdit edt_per_ssn;
        public DevExpress.XtraEditors.TextEdit edt_per_name;
        public DevExpress.XtraEditors.ComboBoxEdit edt_per_gend;
        public System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.TextEdit edt_per_phone2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit edt_per_social_state;
        private DB_FWDDataSet2025 dB_FWDDataSet2025;
        private System.Windows.Forms.BindingSource tBSocialStateBindingSource;
        private DB_FWDDataSet2025TableAdapters.TB_Social_StateTableAdapter tB_Social_StateTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit edt_per_helth_type;
        private DevExpress.XtraEditors.LookUpEdit edt_per_edu;
        private DB_FWDDataSet2026 dB_FWDDataSet2026;
        private System.Windows.Forms.BindingSource tBHealthStatusBindingSource;
        private DB_FWDDataSet2026TableAdapters.TB_Health_StatusTableAdapter tB_Health_StatusTableAdapter;
        private DB_FWDDataSet2027 dB_FWDDataSet2027;
        private System.Windows.Forms.BindingSource tBEducationalStatusBindingSource;
        private DB_FWDDataSet2027TableAdapters.TB_Educational_StatusTableAdapter tB_Educational_StatusTableAdapter;
    }
}