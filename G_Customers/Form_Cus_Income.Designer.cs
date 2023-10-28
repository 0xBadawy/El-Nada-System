
namespace FWD.G_Customers
{
    partial class Form_Cus_Income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Income));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheekJop = new DevExpress.XtraEditors.RadioGroup();
            this.G_none = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.no_det = new DevExpress.XtraEditors.TextEdit();
            this.no_reson = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.G_project = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Project_Name = new DevExpress.XtraEditors.TextEdit();
            this.Project_state = new DevExpress.XtraEditors.TextEdit();
            this.Project_val = new DevExpress.XtraEditors.TextEdit();
            this.G_Jop = new System.Windows.Forms.GroupBox();
            this.has_Jop_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.has_Jop_incomtype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.has_Jop_value = new DevExpress.XtraEditors.TextEdit();
            this.Button_add = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_incom_owner = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCUST_Income_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Income_Owner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Income_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Income_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCUST_Income_Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTB_CUST_Person = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_Form_Cus_Incom = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheekJop.Properties)).BeginInit();
            this.G_none.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_reson.Properties)).BeginInit();
            this.G_project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_val.Properties)).BeginInit();
            this.G_Jop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_incomtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_value.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_incom_owner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Form_Cus_Incom.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.CheekJop);
            this.groupBox1.Controls.Add(this.G_none);
            this.groupBox1.Controls.Add(this.G_project);
            this.groupBox1.Controls.Add(this.G_Jop);
            this.groupBox1.Controls.Add(this.Button_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_incom_owner);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(85, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1329, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // CheekJop
            // 
            this.CheekJop.Location = new System.Drawing.Point(160, 34);
            this.CheekJop.Name = "CheekJop";
            this.CheekJop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.CheekJop.Properties.Appearance.Options.UseFont = true;
            this.CheekJop.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("hasJop", "يعمل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("nojop", "لا يعمل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("project", "مشروع خاص")});
            this.CheekJop.Size = new System.Drawing.Size(550, 43);
            this.CheekJop.TabIndex = 56;
            this.CheekJop.SelectedIndexChanged += new System.EventHandler(this.CheekJop_SelectedIndexChanged);
            // 
            // G_none
            // 
            this.G_none.Controls.Add(this.label9);
            this.G_none.Controls.Add(this.no_det);
            this.G_none.Controls.Add(this.no_reson);
            this.G_none.Controls.Add(this.label7);
            this.G_none.Enabled = false;
            this.G_none.Location = new System.Drawing.Point(65, 263);
            this.G_none.Name = "G_none";
            this.G_none.Size = new System.Drawing.Size(1247, 77);
            this.G_none.TabIndex = 55;
            this.G_none.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 43);
            this.label9.TabIndex = 56;
            this.label9.Text = "التفاصيل";
            // 
            // no_det
            // 
            this.no_det.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.no_det.EditValue = "";
            this.no_det.Location = new System.Drawing.Point(22, 29);
            this.no_det.Name = "no_det";
            this.no_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.no_det.Properties.Appearance.Options.UseFont = true;
            this.no_det.Properties.Appearance.Options.UseTextOptions = true;
            this.no_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.no_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.no_det.Size = new System.Drawing.Size(528, 40);
            this.no_det.TabIndex = 55;
            // 
            // no_reson
            // 
            this.no_reson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.no_reson.Location = new System.Drawing.Point(685, 27);
            this.no_reson.Name = "no_reson";
            this.no_reson.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.no_reson.Properties.Appearance.Options.UseFont = true;
            this.no_reson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.no_reson.Properties.Items.AddRange(new object[] {
            "عدم القدرة ",
            "عدم الرغبة ",
            "المهارات",
            "فرص العمل "});
            this.no_reson.Size = new System.Drawing.Size(229, 40);
            this.no_reson.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(920, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 43);
            this.label7.TabIndex = 50;
            this.label7.Text = "سبب عدم العمل";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // G_project
            // 
            this.G_project.Controls.Add(this.label4);
            this.G_project.Controls.Add(this.label5);
            this.G_project.Controls.Add(this.label6);
            this.G_project.Controls.Add(this.Project_Name);
            this.G_project.Controls.Add(this.Project_state);
            this.G_project.Controls.Add(this.Project_val);
            this.G_project.Enabled = false;
            this.G_project.Location = new System.Drawing.Point(65, 180);
            this.G_project.Name = "G_project";
            this.G_project.Size = new System.Drawing.Size(1247, 77);
            this.G_project.TabIndex = 55;
            this.G_project.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1131, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 43);
            this.label4.TabIndex = 50;
            this.label4.Text = "المشروع";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 43);
            this.label5.TabIndex = 50;
            this.label5.Text = "قيمة الدخل";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 43);
            this.label6.TabIndex = 50;
            this.label6.Text = "قيمة المشروع";
            // 
            // Project_Name
            // 
            this.Project_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project_Name.EditValue = "";
            this.Project_Name.Location = new System.Drawing.Point(896, 27);
            this.Project_Name.Name = "Project_Name";
            this.Project_Name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Project_Name.Properties.Appearance.Options.UseFont = true;
            this.Project_Name.Properties.Appearance.Options.UseTextOptions = true;
            this.Project_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Project_Name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Project_Name.Size = new System.Drawing.Size(229, 40);
            this.Project_Name.TabIndex = 2;
            // 
            // Project_state
            // 
            this.Project_state.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project_state.EditValue = "";
            this.Project_state.Location = new System.Drawing.Point(372, 23);
            this.Project_state.Name = "Project_state";
            this.Project_state.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Project_state.Properties.Appearance.Options.UseFont = true;
            this.Project_state.Properties.Appearance.Options.UseTextOptions = true;
            this.Project_state.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Project_state.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Project_state.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.Project_state.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.Project_state.Properties.MaskSettings.Set("mask", "d");
            this.Project_state.Size = new System.Drawing.Size(229, 40);
            this.Project_state.TabIndex = 2;
            // 
            // Project_val
            // 
            this.Project_val.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Project_val.EditValue = "";
            this.Project_val.Location = new System.Drawing.Point(30, 23);
            this.Project_val.Name = "Project_val";
            this.Project_val.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Project_val.Properties.Appearance.Options.UseFont = true;
            this.Project_val.Properties.Appearance.Options.UseTextOptions = true;
            this.Project_val.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Project_val.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Project_val.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.Project_val.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.Project_val.Properties.MaskSettings.Set("mask", "d");
            this.Project_val.Size = new System.Drawing.Size(108, 40);
            this.Project_val.TabIndex = 2;
            // 
            // G_Jop
            // 
            this.G_Jop.Controls.Add(this.has_Jop_type);
            this.G_Jop.Controls.Add(this.label8);
            this.G_Jop.Controls.Add(this.label3);
            this.G_Jop.Controls.Add(this.label1);
            this.G_Jop.Controls.Add(this.has_Jop_incomtype);
            this.G_Jop.Controls.Add(this.has_Jop_value);
            this.G_Jop.Enabled = false;
            this.G_Jop.Location = new System.Drawing.Point(65, 87);
            this.G_Jop.Name = "G_Jop";
            this.G_Jop.Size = new System.Drawing.Size(1247, 77);
            this.G_Jop.TabIndex = 55;
            this.G_Jop.TabStop = false;
            this.G_Jop.Enter += new System.EventHandler(this.G_Jop_Enter);
            // 
            // has_Jop_type
            // 
            this.has_Jop_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.has_Jop_type.Location = new System.Drawing.Point(856, 25);
            this.has_Jop_type.Name = "has_Jop_type";
            this.has_Jop_type.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.has_Jop_type.Properties.Appearance.Options.UseFont = true;
            this.has_Jop_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.has_Jop_type.Properties.Items.AddRange(new object[] {
            "موظف حكومى",
            "قطاع خاص",
            "ارزقى/حرفي",
            "صنايعى"});
            this.has_Jop_type.Size = new System.Drawing.Size(279, 40);
            this.has_Jop_type.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1131, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 43);
            this.label8.TabIndex = 50;
            this.label8.Text = "نوع العمل";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 43);
            this.label3.TabIndex = 50;
            this.label3.Text = "قيمة الدخل";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "نوع الدخل من العمل ";
            // 
            // has_Jop_incomtype
            // 
            this.has_Jop_incomtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.has_Jop_incomtype.EditValue = "";
            this.has_Jop_incomtype.Location = new System.Drawing.Point(368, 23);
            this.has_Jop_incomtype.Name = "has_Jop_incomtype";
            this.has_Jop_incomtype.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.has_Jop_incomtype.Properties.Appearance.Options.UseFont = true;
            this.has_Jop_incomtype.Properties.Appearance.Options.UseTextOptions = true;
            this.has_Jop_incomtype.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.has_Jop_incomtype.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.has_Jop_incomtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.has_Jop_incomtype.Properties.Items.AddRange(new object[] {
            "يومى",
            "شهري",
            "موسمي"});
            this.has_Jop_incomtype.Size = new System.Drawing.Size(234, 40);
            this.has_Jop_incomtype.TabIndex = 8;
            this.has_Jop_incomtype.SelectedIndexChanged += new System.EventHandler(this.edt_incom_state_SelectedIndexChanged);
            // 
            // has_Jop_value
            // 
            this.has_Jop_value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.has_Jop_value.EditValue = "";
            this.has_Jop_value.Location = new System.Drawing.Point(30, 23);
            this.has_Jop_value.Name = "has_Jop_value";
            this.has_Jop_value.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.has_Jop_value.Properties.Appearance.Options.UseFont = true;
            this.has_Jop_value.Properties.Appearance.Options.UseTextOptions = true;
            this.has_Jop_value.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.has_Jop_value.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.has_Jop_value.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.has_Jop_value.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.has_Jop_value.Properties.MaskSettings.Set("mask", "d");
            this.has_Jop_value.Size = new System.Drawing.Size(108, 40);
            this.has_Jop_value.TabIndex = 2;
            // 
            // Button_add
            // 
            this.Button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button_add.Appearance.Options.UseFont = true;
            this.Button_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_add.ImageOptions.Image")));
            this.Button_add.Location = new System.Drawing.Point(532, 364);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(252, 50);
            this.Button_add.TabIndex = 53;
            this.Button_add.Text = "اضافة";
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1146, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 43);
            this.label2.TabIndex = 50;
            this.label2.Text = "اسم صاحب الدخل";
            // 
            // edt_incom_owner
            // 
            this.edt_incom_owner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_incom_owner.EditValue = "";
            this.edt_incom_owner.Location = new System.Drawing.Point(750, 35);
            this.edt_incom_owner.Name = "edt_incom_owner";
            this.edt_incom_owner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_incom_owner.Properties.Appearance.Options.UseFont = true;
            this.edt_incom_owner.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_incom_owner.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_incom_owner.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_incom_owner.Size = new System.Drawing.Size(390, 40);
            this.edt_incom_owner.TabIndex = 2;
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCUST_Income_Name,
            this.colCUST_Income_Owner,
            this.colCUST_Income_State,
            this.colCUST_Income_Type,
            this.colCUST_Income_Value,
            this.colTB_CUST_Person});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1488, 495, 264, 434);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCUST_Income_Name
            // 
            this.colCUST_Income_Name.Caption = "اسم مصدر الدخل";
            this.colCUST_Income_Name.FieldName = "CUST_Income_Name";
            this.colCUST_Income_Name.Name = "colCUST_Income_Name";
            this.colCUST_Income_Name.Visible = true;
            this.colCUST_Income_Name.VisibleIndex = 2;
            this.colCUST_Income_Name.Width = 249;
            // 
            // colCUST_Income_Owner
            // 
            this.colCUST_Income_Owner.Caption = "صاحب الدخل";
            this.colCUST_Income_Owner.FieldName = "CUST_Income_Owner";
            this.colCUST_Income_Owner.Name = "colCUST_Income_Owner";
            this.colCUST_Income_Owner.Visible = true;
            this.colCUST_Income_Owner.VisibleIndex = 4;
            this.colCUST_Income_Owner.Width = 313;
            // 
            // colCUST_Income_State
            // 
            this.colCUST_Income_State.Caption = "حالة الدخل";
            this.colCUST_Income_State.FieldName = "CUST_Income_State";
            this.colCUST_Income_State.Name = "colCUST_Income_State";
            this.colCUST_Income_State.Visible = true;
            this.colCUST_Income_State.VisibleIndex = 3;
            this.colCUST_Income_State.Width = 249;
            // 
            // colCUST_Income_Type
            // 
            this.colCUST_Income_Type.Caption = "النوع";
            this.colCUST_Income_Type.FieldName = "CUST_Income_Type";
            this.colCUST_Income_Type.Name = "colCUST_Income_Type";
            this.colCUST_Income_Type.Visible = true;
            this.colCUST_Income_Type.VisibleIndex = 0;
            this.colCUST_Income_Type.Width = 249;
            // 
            // colCUST_Income_Value
            // 
            this.colCUST_Income_Value.Caption = "القيمة";
            this.colCUST_Income_Value.FieldName = "CUST_Income_Value";
            this.colCUST_Income_Value.Name = "colCUST_Income_Value";
            this.colCUST_Income_Value.Visible = true;
            this.colCUST_Income_Value.VisibleIndex = 1;
            this.colCUST_Income_Value.Width = 249;
            // 
            // colTB_CUST_Person
            // 
            this.colTB_CUST_Person.Caption = "اسم 2";
            this.colTB_CUST_Person.FieldName = "TB_CUST_Person";
            this.colTB_CUST_Person.Name = "colTB_CUST_Person";
            this.colTB_CUST_Person.Width = 185;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.TB_CUST_Income);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 544);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1524, 228);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 772);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 62);
            this.panel1.TabIndex = 52;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(194, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 41);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تحديث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "حذف";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(565, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(326, 72);
            this.label12.TabIndex = 50;
            this.label12.Text = "تسجيل مصادر الدخل";
            // 
            // panel_Form_Cus_Incom
            // 
            this.panel_Form_Cus_Incom.AutoScroll = true;
            this.panel_Form_Cus_Incom.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Incom.Controls.Add(this.gridControl1);
            this.panel_Form_Cus_Incom.Controls.Add(this.panel1);
            this.panel_Form_Cus_Incom.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Incom.Controls.Add(this.label12);
            this.panel_Form_Cus_Incom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Incom.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Incom.Name = "panel_Form_Cus_Incom";
            this.panel_Form_Cus_Incom.Size = new System.Drawing.Size(1524, 834);
            this.panel_Form_Cus_Incom.TabIndex = 3;
            // 
            // Form_Cus_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1524, 834);
            this.Controls.Add(this.panel_Form_Cus_Incom);
            this.Name = "Form_Cus_Income";
            this.Text = "Form_Cus_Income";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheekJop.Properties)).EndInit();
            this.G_none.ResumeLayout(false);
            this.G_none.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_reson.Properties)).EndInit();
            this.G_project.ResumeLayout(false);
            this.G_project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Project_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Project_val.Properties)).EndInit();
            this.G_Jop.ResumeLayout(false);
            this.G_Jop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_incomtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.has_Jop_value.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_incom_owner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_Form_Cus_Incom.ResumeLayout(false);
            this.panel_Form_Cus_Incom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton Button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit has_Jop_incomtype;
        private DevExpress.XtraEditors.TextEdit has_Jop_value;
        private DevExpress.XtraEditors.TextEdit edt_incom_owner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel_Form_Cus_Incom;
        private DevExpress.XtraEditors.RadioGroup CheekJop;
        private System.Windows.Forms.GroupBox G_none;
        private DevExpress.XtraEditors.ComboBoxEdit no_reson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox G_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit Project_Name;
        private DevExpress.XtraEditors.TextEdit Project_state;
        private DevExpress.XtraEditors.TextEdit Project_val;
        private System.Windows.Forms.GroupBox G_Jop;
        private DevExpress.XtraEditors.ComboBoxEdit has_Jop_type;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit no_det;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Income_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Income_Owner;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Income_State;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Income_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colCUST_Income_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colTB_CUST_Person;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}