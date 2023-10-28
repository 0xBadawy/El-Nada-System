
namespace FWD.G_Donations
{
    partial class Form_Donner_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Donner_Add));
            this.Pn_frm_don = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonner_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_Job_Add = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_proNoun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_SSN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_donner_add_jop = new DevExpress.XtraEditors.LookUpEdit();
            this.edit_donner_add = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.edt_donner_pro_noun = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_donner_phone = new DevExpress.XtraEditors.TextEdit();
            this.edt_donner_name = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_donner_ssn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.tBELOCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2056 = new FWD.DB_FWDDataSet2056();
            this.tBELOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2055 = new FWD.DB_FWDDataSet2055();
            this.tBE_LOCTableAdapter = new FWD.DB_FWDDataSet2055TableAdapters.TBE_LOCTableAdapter();
            this.tBE_LOCTableAdapter1 = new FWD.DB_FWDDataSet2056TableAdapters.TBE_LOCTableAdapter();
            this.Pn_frm_don.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_donner_add_jop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_donner_add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_pro_noun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_name.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2056)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2055)).BeginInit();
            this.SuspendLayout();
            // 
            // Pn_frm_don
            // 
            this.Pn_frm_don.BackColor = System.Drawing.Color.White;
            this.Pn_frm_don.Controls.Add(this.gridControl1);
            this.Pn_frm_don.Controls.Add(this.panel2);
            this.Pn_frm_don.Controls.Add(this.panel1);
            this.Pn_frm_don.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_don.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_don.Name = "Pn_frm_don";
            this.Pn_frm_don.Size = new System.Drawing.Size(1629, 843);
            this.Pn_frm_don.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Donor);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 555);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1629, 229);
            this.gridControl1.TabIndex = 66;
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
            this.colDonner_Add,
            this.colDonner_ID,
            this.colDonner_Job_Add,
            this.colDonner_Name,
            this.colDonner_Phone,
            this.colDonner_proNoun,
            this.colDonner_SSN});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDonner_Add
            // 
            this.colDonner_Add.Caption = "العنوان";
            this.colDonner_Add.FieldName = "Donner_Add";
            this.colDonner_Add.Name = "colDonner_Add";
            this.colDonner_Add.Visible = true;
            this.colDonner_Add.VisibleIndex = 0;
            this.colDonner_Add.Width = 227;
            // 
            // colDonner_ID
            // 
            this.colDonner_ID.Caption = "الكود";
            this.colDonner_ID.FieldName = "Donner_ID";
            this.colDonner_ID.Name = "colDonner_ID";
            this.colDonner_ID.Visible = true;
            this.colDonner_ID.VisibleIndex = 6;
            this.colDonner_ID.Width = 142;
            // 
            // colDonner_Job_Add
            // 
            this.colDonner_Job_Add.Caption = "عنوان العمل";
            this.colDonner_Job_Add.FieldName = "Donner_Job_Add";
            this.colDonner_Job_Add.Name = "colDonner_Job_Add";
            this.colDonner_Job_Add.Visible = true;
            this.colDonner_Job_Add.VisibleIndex = 1;
            this.colDonner_Job_Add.Width = 227;
            // 
            // colDonner_Name
            // 
            this.colDonner_Name.Caption = "اسم المتبرع";
            this.colDonner_Name.FieldName = "Donner_Name";
            this.colDonner_Name.Name = "colDonner_Name";
            this.colDonner_Name.Visible = true;
            this.colDonner_Name.VisibleIndex = 5;
            this.colDonner_Name.Width = 353;
            // 
            // colDonner_Phone
            // 
            this.colDonner_Phone.Caption = "التلفون";
            this.colDonner_Phone.FieldName = "Donner_Phone";
            this.colDonner_Phone.Name = "colDonner_Phone";
            this.colDonner_Phone.Visible = true;
            this.colDonner_Phone.VisibleIndex = 2;
            this.colDonner_Phone.Width = 227;
            // 
            // colDonner_proNoun
            // 
            this.colDonner_proNoun.Caption = "اللقب";
            this.colDonner_proNoun.FieldName = "Donner_proNoun";
            this.colDonner_proNoun.Name = "colDonner_proNoun";
            this.colDonner_proNoun.Visible = true;
            this.colDonner_proNoun.VisibleIndex = 4;
            this.colDonner_proNoun.Width = 137;
            // 
            // colDonner_SSN
            // 
            this.colDonner_SSN.Caption = "الرقم القومى";
            this.colDonner_SSN.FieldName = "Donner_SSN";
            this.colDonner_SSN.Name = "colDonner_SSN";
            this.colDonner_SSN.Visible = true;
            this.colDonner_SSN.VisibleIndex = 3;
            this.colDonner_SSN.Width = 278;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.edit_donner_add_jop);
            this.panel2.Controls.Add(this.edit_donner_add);
            this.panel2.Controls.Add(this.textEdit2);
            this.panel2.Controls.Add(this.edt_donner_pro_noun);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.edt_donner_phone);
            this.panel2.Controls.Add(this.edt_donner_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.edt_donner_ssn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1629, 784);
            this.panel2.TabIndex = 65;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // edit_donner_add_jop
            // 
            this.edit_donner_add_jop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_donner_add_jop.Location = new System.Drawing.Point(206, 238);
            this.edit_donner_add_jop.Name = "edit_donner_add_jop";
            this.edit_donner_add_jop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_donner_add_jop.Properties.Appearance.Options.UseFont = true;
            this.edit_donner_add_jop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_donner_add_jop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Name", "", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edit_donner_add_jop.Properties.DataSource = typeof(FWD.TBE_LOC);
            this.edit_donner_add_jop.Properties.DisplayMember = "LOC_Name";
            this.edit_donner_add_jop.Properties.NullText = " ";
            this.edit_donner_add_jop.Properties.ValueMember = "ID";
            this.edit_donner_add_jop.Size = new System.Drawing.Size(393, 40);
            this.edit_donner_add_jop.TabIndex = 6;
            this.edit_donner_add_jop.Click += new System.EventHandler(this.edit_donner_add_jop_Click);
            // 
            // edit_donner_add
            // 
            this.edit_donner_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edit_donner_add.Location = new System.Drawing.Point(923, 248);
            this.edit_donner_add.Name = "edit_donner_add";
            this.edit_donner_add.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edit_donner_add.Properties.Appearance.Options.UseFont = true;
            this.edit_donner_add.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edit_donner_add.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Name", "", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edit_donner_add.Properties.DataSource = typeof(FWD.TBE_LOC);
            this.edit_donner_add.Properties.DisplayMember = "LOC_Name";
            this.edit_donner_add.Properties.NullText = " ";
            this.edit_donner_add.Properties.ValueMember = "ID";
            this.edit_donner_add.Size = new System.Drawing.Size(393, 40);
            this.edit_donner_add.TabIndex = 5;
            this.edit_donner_add.Click += new System.EventHandler(this.edit_donner_add_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit2.EditValue = "";
            this.textEdit2.Location = new System.Drawing.Point(206, 178);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit2.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.textEdit2.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.textEdit2.Size = new System.Drawing.Size(393, 40);
            this.textEdit2.TabIndex = 4;
            // 
            // edt_donner_pro_noun
            // 
            this.edt_donner_pro_noun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_donner_pro_noun.EditValue = "";
            this.edt_donner_pro_noun.Location = new System.Drawing.Point(206, 116);
            this.edt_donner_pro_noun.Name = "edt_donner_pro_noun";
            this.edt_donner_pro_noun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_donner_pro_noun.Properties.Appearance.Options.UseFont = true;
            this.edt_donner_pro_noun.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_donner_pro_noun.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_donner_pro_noun.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_donner_pro_noun.Size = new System.Drawing.Size(393, 40);
            this.edt_donner_pro_noun.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(708, 321);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 43);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(655, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 66);
            this.label9.TabIndex = 72;
            this.label9.Text = "اضافة متبرع جديد";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1362, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 43);
            this.label7.TabIndex = 70;
            this.label7.Text = "العنوان";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1326, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 43);
            this.label6.TabIndex = 70;
            this.label6.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1323, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 70;
            this.label2.Text = "اسم المتبرع";
            // 
            // edt_donner_phone
            // 
            this.edt_donner_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_donner_phone.Location = new System.Drawing.Point(923, 178);
            this.edt_donner_phone.Name = "edt_donner_phone";
            this.edt_donner_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_donner_phone.Properties.Appearance.Options.UseFont = true;
            this.edt_donner_phone.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_donner_phone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_donner_phone.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_donner_phone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_donner_phone.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_donner_phone.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_donner_phone.Size = new System.Drawing.Size(393, 40);
            this.edt_donner_phone.TabIndex = 3;
            // 
            // edt_donner_name
            // 
            this.edt_donner_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_donner_name.Location = new System.Drawing.Point(923, 116);
            this.edt_donner_name.Name = "edt_donner_name";
            this.edt_donner_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_donner_name.Properties.Appearance.Options.UseFont = true;
            this.edt_donner_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_donner_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_donner_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_donner_name.Size = new System.Drawing.Size(393, 40);
            this.edt_donner_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 43);
            this.label3.TabIndex = 68;
            this.label3.Text = "عنوان العمل";
            // 
            // edt_donner_ssn
            // 
            this.edt_donner_ssn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_donner_ssn.AutoSize = true;
            this.edt_donner_ssn.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_donner_ssn.Location = new System.Drawing.Point(613, 173);
            this.edt_donner_ssn.Name = "edt_donner_ssn";
            this.edt_donner_ssn.Size = new System.Drawing.Size(144, 43);
            this.edt_donner_ssn.TabIndex = 68;
            this.edt_donner_ssn.Text = "الرقم القومى";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 43);
            this.label1.TabIndex = 68;
            this.label1.Text = "اللقب";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 784);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(173, 7);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(144, 44);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "تعديل";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(495, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(334, 7);
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
            // 
            // tBELOCBindingSource1
            // 
            this.tBELOCBindingSource1.DataMember = "TBE_LOC";
            this.tBELOCBindingSource1.DataSource = this.dB_FWDDataSet2056;
            // 
            // dB_FWDDataSet2056
            // 
            this.dB_FWDDataSet2056.DataSetName = "DB_FWDDataSet2056";
            this.dB_FWDDataSet2056.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBELOCBindingSource
            // 
            this.tBELOCBindingSource.DataMember = "TBE_LOC";
            this.tBELOCBindingSource.DataSource = this.dB_FWDDataSet2055;
            // 
            // dB_FWDDataSet2055
            // 
            this.dB_FWDDataSet2055.DataSetName = "DB_FWDDataSet2055";
            this.dB_FWDDataSet2055.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBE_LOCTableAdapter
            // 
            this.tBE_LOCTableAdapter.ClearBeforeFill = true;
            // 
            // tBE_LOCTableAdapter1
            // 
            this.tBE_LOCTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Donner_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 843);
            this.Controls.Add(this.Pn_frm_don);
            this.Name = "Form_Donner_Add";
            this.Text = "Form_Donner_Add";
            this.Load += new System.EventHandler(this.Form_Donner_Add_Load);
            this.Pn_frm_don.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edit_donner_add_jop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_donner_add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_pro_noun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_donner_name.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2056)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2055)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Pn_frm_don;
        private DevExpress.XtraEditors.TextEdit edt_donner_pro_noun;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_donner_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.LookUpEdit edit_donner_add_jop;
        private DevExpress.XtraEditors.LookUpEdit edit_donner_add;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit edt_donner_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label edt_donner_ssn;
        private DB_FWDDataSet2055 dB_FWDDataSet2055;
        private System.Windows.Forms.BindingSource tBELOCBindingSource;
        private DB_FWDDataSet2055TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter;
        private DB_FWDDataSet2056 dB_FWDDataSet2056;
        private System.Windows.Forms.BindingSource tBELOCBindingSource1;
        private DB_FWDDataSet2056TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_Job_Add;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_proNoun;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_SSN;
        public System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}