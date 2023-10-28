
namespace FWD.G_Receives
{
    partial class Form_Receive_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Receive_Add));
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.tBCUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet1 = new FWD.DB_FWDDataSet1();
            this.tBPURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2 = new FWD.DB_FWDDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_res_name = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_num = new DevExpress.XtraEditors.SpinEdit();
            this.tB_CUSTableAdapter = new FWD.DB_FWDDataSet1TableAdapters.TB_CUSTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_ssn_serch = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_code = new DevExpress.XtraEditors.TextEdit();
            this.tB_PURTableAdapter = new FWD.DB_FWDDataSet2TableAdapters.TB_PURTableAdapter();
            this.tBPURBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2037 = new FWD.DB_FWDDataSet2037();
            this.tB_PURTableAdapter1 = new FWD.DB_FWDDataSet2037TableAdapters.TB_PURTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_C_Inf_name = new System.Windows.Forms.TextBox();
            this.label_C_Inf_ssn = new System.Windows.Forms.TextBox();
            this.label_C_Inf_id = new System.Windows.Forms.TextBox();
            this.label_C_Inf_add = new System.Windows.Forms.TextBox();
            this.label_C_Inf_add_2 = new System.Windows.Forms.TextBox();
            this.label_C_Inf_supp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_C_Inf_rank = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.Recever_charity = new DevExpress.XtraEditors.LookUpEdit();
            this.tBEmploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2093 = new FWD.DB_FWDDataSet2093();
            this.tB_EmploeeTableAdapter = new FWD.DB_FWDDataSet2093TableAdapters.TB_EmploeeTableAdapter();
            this.edt_cat = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tBCUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_num.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ssn_serch.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPURBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2037)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Recever_charity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEmploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2093)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(968, 580);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(392, 55);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "اضافة";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // tBCUSBindingSource
            // 
            this.tBCUSBindingSource.DataMember = "TB_CUS";
            this.tBCUSBindingSource.DataSource = this.dB_FWDDataSet1;
            // 
            // dB_FWDDataSet1
            // 
            this.dB_FWDDataSet1.DataSetName = "DB_FWDDataSet1";
            this.dB_FWDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBPURBindingSource
            // 
            this.tBPURBindingSource.DataMember = "TB_PUR";
            this.tBPURBindingSource.DataSource = this.dB_FWDDataSet2;
            // 
            // dB_FWDDataSet2
            // 
            this.dB_FWDDataSet2.DataSetName = "DB_FWDDataSet2";
            this.dB_FWDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1438, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 43);
            this.label4.TabIndex = 23;
            this.label4.Text = "العدد";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1429, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 43);
            this.label7.TabIndex = 25;
            this.label7.Text = "الصنف";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1351, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 43);
            this.label5.TabIndex = 26;
            this.label5.Text = "الكود";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // edt_res_name
            // 
            this.edt_res_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_res_name.Location = new System.Drawing.Point(967, 343);
            this.edt_res_name.Name = "edt_res_name";
            this.edt_res_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_name.Properties.Appearance.Options.UseFont = true;
            this.edt_res_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_res_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_res_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_res_name.Size = new System.Drawing.Size(392, 40);
            this.edt_res_name.TabIndex = 8;
            this.edt_res_name.EditValueChanged += new System.EventHandler(this.edt_res_name_EditValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(651, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 66);
            this.label9.TabIndex = 27;
            this.label9.Text = "قائمة التسليمات";
            // 
            // edt_num
            // 
            this.edt_num.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_num.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edt_num.Location = new System.Drawing.Point(967, 277);
            this.edt_num.Name = "edt_num";
            this.edt_num.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_num.Properties.Appearance.Options.UseFont = true;
            this.edt_num.Properties.AutoHeight = false;
            this.edt_num.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_num.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.edt_num.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edt_num.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edt_num.Size = new System.Drawing.Size(392, 40);
            this.edt_num.TabIndex = 7;
            // 
            // tB_CUSTableAdapter
            // 
            this.tB_CUSTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1365, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 43);
            this.label2.TabIndex = 28;
            this.label2.Text = "اسم المستلم";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(836, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 41);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // edt_ssn_serch
            // 
            this.edt_ssn_serch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_ssn_serch.Location = new System.Drawing.Point(85, 31);
            this.edt_ssn_serch.Name = "edt_ssn_serch";
            this.edt_ssn_serch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_ssn_serch.Properties.Appearance.Options.UseFont = true;
            this.edt_ssn_serch.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_ssn_serch.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_ssn_serch.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_ssn_serch.Size = new System.Drawing.Size(390, 40);
            this.edt_ssn_serch.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(492, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 43);
            this.label11.TabIndex = 28;
            this.label11.Text = "البحث بالرقم القومى";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.edt_code);
            this.groupBox1.Controls.Add(this.edt_ssn_serch);
            this.groupBox1.Location = new System.Drawing.Point(80, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1429, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الحالة";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.simpleButton4.Location = new System.Drawing.Point(791, 29);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(39, 41);
            this.simpleButton4.TabIndex = 87;
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(40, 29);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(39, 41);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // edt_code
            // 
            this.edt_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_code.Location = new System.Drawing.Point(888, 32);
            this.edt_code.Name = "edt_code";
            this.edt_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_code.Properties.Appearance.Options.UseFont = true;
            this.edt_code.Size = new System.Drawing.Size(390, 40);
            this.edt_code.TabIndex = 3;
            this.edt_code.EditValueChanged += new System.EventHandler(this.edt_code_EditValueChanged);
            // 
            // tB_PURTableAdapter
            // 
            this.tB_PURTableAdapter.ClearBeforeFill = true;
            // 
            // tBPURBindingSource1
            // 
            this.tBPURBindingSource1.DataMember = "TB_PUR";
            this.tBPURBindingSource1.DataSource = this.dB_FWDDataSet2037;
            // 
            // dB_FWDDataSet2037
            // 
            this.dB_FWDDataSet2037.DataSetName = "DB_FWDDataSet2037";
            this.dB_FWDDataSet2037.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_PURTableAdapter1
            // 
            this.tB_PURTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 43);
            this.label1.TabIndex = 28;
            this.label1.Text = ": الرقم القومى";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 43);
            this.label3.TabIndex = 28;
            this.label3.Text = ":              الكود";
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
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(80, 192);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 458);
            this.groupControl1.TabIndex = 35;
            this.groupControl1.Text = "تفاصيل بيانات الحالة";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1363, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 43);
            this.label13.TabIndex = 28;
            this.label13.Text = "اسم الموظف";
            this.label13.Visible = false;
            // 
            // Recever_charity
            // 
            this.Recever_charity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Recever_charity.Location = new System.Drawing.Point(967, 410);
            this.Recever_charity.Name = "Recever_charity";
            this.Recever_charity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Recever_charity.Properties.Appearance.Options.UseFont = true;
            this.Recever_charity.Properties.Appearance.Options.UseTextOptions = true;
            this.Recever_charity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Recever_charity.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Recever_charity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Recever_charity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Emploee_Name", "اسم الموظف", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.Recever_charity.Properties.DataSource = this.tBEmploeeBindingSource;
            this.Recever_charity.Properties.DisplayMember = "Emploee_Name";
            this.Recever_charity.Properties.NullText = " ";
            this.Recever_charity.Properties.ValueMember = "Emploee_ID";
            this.Recever_charity.Size = new System.Drawing.Size(392, 40);
            this.Recever_charity.TabIndex = 37;
            this.Recever_charity.Visible = false;
            // 
            // tBEmploeeBindingSource
            // 
            this.tBEmploeeBindingSource.DataMember = "TB_Emploee";
            this.tBEmploeeBindingSource.DataSource = this.dB_FWDDataSet2093;
            // 
            // dB_FWDDataSet2093
            // 
            this.dB_FWDDataSet2093.DataSetName = "DB_FWDDataSet2093";
            this.dB_FWDDataSet2093.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_EmploeeTableAdapter
            // 
            this.tB_EmploeeTableAdapter.ClearBeforeFill = true;
            // 
            // edt_cat
            // 
            this.edt_cat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_cat.Location = new System.Drawing.Point(968, 204);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_cat.Properties.Appearance.Options.UseFont = true;
            this.edt_cat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_cat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PUR_Name", "PUR_Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_cat.Properties.DataSource = typeof(FWD.TB_PUR);
            this.edt_cat.Properties.DisplayMember = "PUR_Name";
            this.edt_cat.Properties.NullText = " ";
            this.edt_cat.Properties.ValueMember = "ID";
            this.edt_cat.Size = new System.Drawing.Size(390, 40);
            this.edt_cat.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.edt_cat);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.Recever_charity);
            this.panel1.Controls.Add(this.edt_num);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.edt_res_name);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1609, 694);
            this.panel1.TabIndex = 39;
            // 
            // Form_Receive_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1609, 694);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Receive_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Receive_Add";
            this.Load += new System.EventHandler(this.Form_Receive_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBCUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_num.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ssn_serch.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBPURBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2037)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Recever_charity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEmploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2093)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit edt_res_name;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SpinEdit edt_num;
        private DB_FWDDataSet1 dB_FWDDataSet1;
        private System.Windows.Forms.BindingSource tBCUSBindingSource;
        private DB_FWDDataSet1TableAdapters.TB_CUSTableAdapter tB_CUSTableAdapter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit edt_ssn_serch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DB_FWDDataSet2 dB_FWDDataSet2;
        private System.Windows.Forms.BindingSource tBPURBindingSource;
        private DB_FWDDataSet2TableAdapters.TB_PURTableAdapter tB_PURTableAdapter;
        private DevExpress.XtraEditors.TextEdit edt_code;
        private DB_FWDDataSet2037 dB_FWDDataSet2037;
        private System.Windows.Forms.BindingSource tBPURBindingSource1;
        private DB_FWDDataSet2037TableAdapters.TB_PURTableAdapter tB_PURTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox label_C_Inf_name;
        private System.Windows.Forms.TextBox label_C_Inf_ssn;
        private System.Windows.Forms.TextBox label_C_Inf_id;
        private System.Windows.Forms.TextBox label_C_Inf_add;
        private System.Windows.Forms.TextBox label_C_Inf_add_2;
        private System.Windows.Forms.TextBox label_C_Inf_supp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox label_C_Inf_rank;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.LookUpEdit Recever_charity;
        private DB_FWDDataSet2093 dB_FWDDataSet2093;
        private System.Windows.Forms.BindingSource tBEmploeeBindingSource;
        private DB_FWDDataSet2093TableAdapters.TB_EmploeeTableAdapter tB_EmploeeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LookUpEdit edt_cat;
        public System.Windows.Forms.Panel panel1;
    }
}