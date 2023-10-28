
namespace FWD.G_Courses
{
    partial class Form_Take_Courses_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Take_Courses_Add));
            this.edt_cat = new DevExpress.XtraEditors.LookUpEdit();
            this.tBCourseinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2050 = new FWD.DB_FWDDataSet2050();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edt_code = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_ssn_serch = new DevExpress.XtraEditors.TextEdit();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_Course_infoTableAdapter = new FWD.DB_FWDDataSet2050TableAdapters.TB_Course_infoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCourseinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2050)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ssn_serch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edt_cat
            // 
            this.edt_cat.Location = new System.Drawing.Point(106, 176);
            this.edt_cat.Name = "edt_cat";
            this.edt_cat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_cat.Properties.Appearance.Options.UseFont = true;
            this.edt_cat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_cat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Course_Name", "Course_Name", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_cat.Properties.DataSource = typeof(FWD.TB_Course_info);
            this.edt_cat.Properties.DisplayMember = "Course_Name";
            this.edt_cat.Properties.NullText = " ";
            this.edt_cat.Properties.ValueMember = "Course_ID";
            this.edt_cat.Size = new System.Drawing.Size(390, 40);
            this.edt_cat.TabIndex = 46;
            // 
            // tBCourseinfoBindingSource
            // 
            this.tBCourseinfoBindingSource.DataMember = "TB_Course_info";
            this.tBCourseinfoBindingSource.DataSource = this.dB_FWDDataSet2050;
            // 
            // dB_FWDDataSet2050
            // 
            this.dB_FWDDataSet2050.DataSetName = "DB_FWDDataSet2050";
            this.dB_FWDDataSet2050.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edt_cat);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.edt_code);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edt_ssn_serch);
            this.groupBox1.Location = new System.Drawing.Point(520, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(722, 384);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(48, 33);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(39, 41);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(48, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 41);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 43);
            this.label5.TabIndex = 26;
            this.label5.Text = "الكود";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 43);
            this.label11.TabIndex = 28;
            this.label11.Text = "البحث بالرقم القومى";
            // 
            // edt_code
            // 
            this.edt_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_code.Location = new System.Drawing.Point(106, 105);
            this.edt_code.Name = "edt_code";
            this.edt_code.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_code.Properties.Appearance.Options.UseFont = true;
            this.edt_code.Size = new System.Drawing.Size(390, 40);
            this.edt_code.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(587, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 43);
            this.label7.TabIndex = 42;
            this.label7.Text = "اسم التدريب";
            // 
            // edt_ssn_serch
            // 
            this.edt_ssn_serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edt_ssn_serch.Location = new System.Drawing.Point(106, 34);
            this.edt_ssn_serch.Name = "edt_ssn_serch";
            this.edt_ssn_serch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_ssn_serch.Properties.Appearance.Options.UseFont = true;
            this.edt_ssn_serch.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_ssn_serch.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_ssn_serch.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_ssn_serch.Size = new System.Drawing.Size(390, 40);
            this.edt_ssn_serch.TabIndex = 3;
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
            this.groupControl1.Location = new System.Drawing.Point(16, 181);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(475, 458);
            this.groupControl1.TabIndex = 45;
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
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(626, 595);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(390, 44);
            this.Btn_Add.TabIndex = 40;
            this.Btn_Add.Text = "اضافة";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(383, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(474, 66);
            this.label9.TabIndex = 43;
            this.label9.Text = "قائمة تسجيل حضور دورة تدريبية ";
            // 
            // tB_Course_infoTableAdapter
            // 
            this.tB_Course_infoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Btn_Add);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 684);
            this.panel1.TabIndex = 46;
            // 
            // Form_Take_Courses_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1301, 684);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Take_Courses_Add";
            this.Text = "Form_Take_Courses_Add";
            this.Load += new System.EventHandler(this.Form_Take_Courses_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCourseinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2050)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_ssn_serch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit edt_cat;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit edt_code;
        private DevExpress.XtraEditors.TextEdit edt_ssn_serch;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private DB_FWDDataSet2050 dB_FWDDataSet2050;
        private System.Windows.Forms.BindingSource tBCourseinfoBindingSource;
        private DB_FWDDataSet2050TableAdapters.TB_Course_infoTableAdapter tB_Course_infoTableAdapter;
        public System.Windows.Forms.Panel panel1;
    }
}