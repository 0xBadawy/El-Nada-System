
namespace FWD.G_Setting
{
    partial class Form_resercher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_resercher));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Pn_frm_supp = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSUPP_Date_Regest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Bairth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_phone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Phone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsupp_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPP_Retion_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.edt_supp_add = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_supp_name = new DevExpress.XtraEditors.TextEdit();
            this.edt_supp_phone1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_supp_ssn = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Pn_frm_supp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_phone1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_ssn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Pn_frm_supp);
            this.panel2.Controls.Add(this.edt_supp_add);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.edt_supp_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.edt_supp_phone1);
            this.panel2.Controls.Add(this.edt_supp_ssn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 650);
            this.panel2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(441, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "اضافة مندوب جديد";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Pn_frm_supp
            // 
            this.Pn_frm_supp.Controls.Add(this.gridControl1);
            this.Pn_frm_supp.Controls.Add(this.panel1);
            this.Pn_frm_supp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pn_frm_supp.Location = new System.Drawing.Point(0, 332);
            this.Pn_frm_supp.Name = "Pn_frm_supp";
            this.Pn_frm_supp.Size = new System.Drawing.Size(1282, 318);
            this.Pn_frm_supp.TabIndex = 80;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_supp_list);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1282, 259);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSUPP_Date_Regest,
            this.colSUPP_Bairth,
            this.colSUPP_SSN,
            this.colSUPP_phone2,
            this.colSUPP_Phone1,
            this.colSUPP_Name,
            this.colID,
            this.colsupp_Add,
            this.colSUPP_Retion_Add,
            this.colAge});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSUPP_Date_Regest
            // 
            this.colSUPP_Date_Regest.Caption = "بداية العمل";
            this.colSUPP_Date_Regest.FieldName = "SUPP_Date_Regest";
            this.colSUPP_Date_Regest.Name = "colSUPP_Date_Regest";
            this.colSUPP_Date_Regest.Visible = true;
            this.colSUPP_Date_Regest.VisibleIndex = 0;
            this.colSUPP_Date_Regest.Width = 103;
            // 
            // colSUPP_Bairth
            // 
            this.colSUPP_Bairth.Caption = "تاريخ الميلاد";
            this.colSUPP_Bairth.FieldName = "SUPP_Bairth";
            this.colSUPP_Bairth.Name = "colSUPP_Bairth";
            this.colSUPP_Bairth.Visible = true;
            this.colSUPP_Bairth.VisibleIndex = 2;
            this.colSUPP_Bairth.Width = 105;
            // 
            // colSUPP_SSN
            // 
            this.colSUPP_SSN.Caption = "الرقم القومى";
            this.colSUPP_SSN.FieldName = "SUPP_SSN";
            this.colSUPP_SSN.Name = "colSUPP_SSN";
            this.colSUPP_SSN.Visible = true;
            this.colSUPP_SSN.VisibleIndex = 3;
            this.colSUPP_SSN.Width = 203;
            // 
            // colSUPP_phone2
            // 
            this.colSUPP_phone2.Caption = "تلفون 2";
            this.colSUPP_phone2.FieldName = "SUPP_phone2";
            this.colSUPP_phone2.Name = "colSUPP_phone2";
            this.colSUPP_phone2.Visible = true;
            this.colSUPP_phone2.VisibleIndex = 4;
            this.colSUPP_phone2.Width = 158;
            // 
            // colSUPP_Phone1
            // 
            this.colSUPP_Phone1.Caption = "تلفون 2";
            this.colSUPP_Phone1.FieldName = "SUPP_Phone1";
            this.colSUPP_Phone1.Name = "colSUPP_Phone1";
            this.colSUPP_Phone1.Visible = true;
            this.colSUPP_Phone1.VisibleIndex = 5;
            this.colSUPP_Phone1.Width = 120;
            // 
            // colSUPP_Name
            // 
            this.colSUPP_Name.Caption = "الاسم";
            this.colSUPP_Name.FieldName = "SUPP_Name";
            this.colSUPP_Name.Name = "colSUPP_Name";
            this.colSUPP_Name.Visible = true;
            this.colSUPP_Name.VisibleIndex = 8;
            this.colSUPP_Name.Width = 302;
            // 
            // colID
            // 
            this.colID.Caption = "الكود";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 9;
            this.colID.Width = 59;
            // 
            // colsupp_Add
            // 
            this.colsupp_Add.Caption = "العنوان";
            this.colsupp_Add.FieldName = "supp_Add";
            this.colsupp_Add.Name = "colsupp_Add";
            this.colsupp_Add.Visible = true;
            this.colsupp_Add.VisibleIndex = 7;
            this.colsupp_Add.Width = 128;
            // 
            // colSUPP_Retion_Add
            // 
            this.colSUPP_Retion_Add.Caption = "منطقة البحث";
            this.colSUPP_Retion_Add.FieldName = "SUPP_Retion_Add";
            this.colSUPP_Retion_Add.Name = "colSUPP_Retion_Add";
            this.colSUPP_Retion_Add.Visible = true;
            this.colSUPP_Retion_Add.VisibleIndex = 6;
            this.colSUPP_Retion_Add.Width = 137;
            // 
            // colAge
            // 
            this.colAge.Caption = "السن";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 1;
            this.colAge.Width = 69;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(165, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(144, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "تعديل";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_ref.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(318, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
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
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(430, 254);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(292, 43);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "اضــافــة";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // edt_supp_add
            // 
            this.edt_supp_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_supp_add.Location = new System.Drawing.Point(75, 155);
            this.edt_supp_add.Name = "edt_supp_add";
            this.edt_supp_add.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_supp_add.Properties.Appearance.Options.UseFont = true;
            this.edt_supp_add.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_supp_add.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_supp_add.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_supp_add.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_supp_add.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Name", "LOC_Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Key", "LOC_Key", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_supp_add.Properties.DataSource = typeof(FWD.TBE_LOC);
            this.edt_supp_add.Properties.NullText = "";
            this.edt_supp_add.Size = new System.Drawing.Size(390, 40);
            this.edt_supp_add.TabIndex = 37;
            // 
            // edt_supp_name
            // 
            this.edt_supp_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_supp_name.EditValue = "";
            this.edt_supp_name.Location = new System.Drawing.Point(680, 99);
            this.edt_supp_name.Name = "edt_supp_name";
            this.edt_supp_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_supp_name.Properties.Appearance.Options.UseFont = true;
            this.edt_supp_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_supp_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_supp_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_supp_name.Size = new System.Drawing.Size(390, 40);
            this.edt_supp_name.TabIndex = 33;
            // 
            // edt_supp_phone1
            // 
            this.edt_supp_phone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_supp_phone1.Location = new System.Drawing.Point(680, 154);
            this.edt_supp_phone1.Name = "edt_supp_phone1";
            this.edt_supp_phone1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_supp_phone1.Properties.Appearance.Options.UseFont = true;
            this.edt_supp_phone1.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_supp_phone1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_supp_phone1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_supp_phone1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_supp_phone1.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_supp_phone1.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_supp_phone1.Size = new System.Drawing.Size(390, 40);
            this.edt_supp_phone1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 43);
            this.label1.TabIndex = 41;
            this.label1.Text = "الرقم القومى";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1088, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 43);
            this.label2.TabIndex = 42;
            this.label2.Text = "الاسم";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1078, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 43);
            this.label3.TabIndex = 43;
            this.label3.Text = "تلفون";
            // 
            // edt_supp_ssn
            // 
            this.edt_supp_ssn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_supp_ssn.EditValue = "";
            this.edt_supp_ssn.Location = new System.Drawing.Point(75, 97);
            this.edt_supp_ssn.Name = "edt_supp_ssn";
            this.edt_supp_ssn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_supp_ssn.Properties.Appearance.Options.UseFont = true;
            this.edt_supp_ssn.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_supp_ssn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_supp_ssn.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_supp_ssn.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_supp_ssn.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_supp_ssn.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_supp_ssn.Size = new System.Drawing.Size(390, 40);
            this.edt_supp_ssn.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 43);
            this.label5.TabIndex = 44;
            this.label5.Text = "العنوان";
            // 
            // Form_resercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 650);
            this.Controls.Add(this.panel2);
            this.Name = "Form_resercher";
            this.Text = "اضافة مندوب جديد";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pn_frm_supp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_phone1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_supp_ssn.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel Pn_frm_supp;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Date_Regest;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Bairth;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_SSN;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_phone2;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Phone1;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colsupp_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPP_Retion_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        public DevExpress.XtraEditors.LookUpEdit edt_supp_add;
        public DevExpress.XtraEditors.TextEdit edt_supp_name;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit edt_supp_phone1;
        public DevExpress.XtraEditors.TextEdit edt_supp_ssn;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}