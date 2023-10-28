
namespace FWD.G_Donations
{
    partial class Form_Donation_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Donation_Add));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDON_Resever = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_Dir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_Amo_txt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDON_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonner_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Pn_frm_don = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.charity_Recever = new DevExpress.XtraEditors.LookUpEdit();
            this.tBEmploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2096 = new FWD.DB_FWDDataSet2096();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_don_dir = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_don_name = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.edt_don_val_w = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_cat_val = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBDonationDirctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2053 = new FWD.DB_FWDDataSet2053();
            this.tBDonnerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2052 = new FWD.DB_FWDDataSet2052();
            this.tB_Donner_infoTableAdapter = new FWD.DB_FWDDataSet2052TableAdapters.TB_Donner_infoTableAdapter();
            this.tB_Donation_DirctionTableAdapter = new FWD.DB_FWDDataSet2053TableAdapters.TB_Donation_DirctionTableAdapter();
            this.tB_EmploeeTableAdapter = new FWD.DB_FWDDataSet2096TableAdapters.TB_EmploeeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.Pn_frm_don.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charity_Recever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEmploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2096)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_dir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat_val.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDonationDirctionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2053)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDonnerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2052)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(348, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(218, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة ايصال التبرع";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_ref);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 755);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1591, 59);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(590, 7);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(275, 44);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "طباعة كشف كامل";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(180, 7);
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
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDON_Resever,
            this.colDON_Dir,
            this.colDON_Date,
            this.colDON_Amo_txt,
            this.colDON_Amount,
            this.colDON_Name,
            this.colDonner_Phone,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDON_Date, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colDON_Resever
            // 
            this.colDON_Resever.Caption = "المستلم";
            this.colDON_Resever.FieldName = "Emploee_Name";
            this.colDON_Resever.Name = "colDON_Resever";
            this.colDON_Resever.Visible = true;
            this.colDON_Resever.VisibleIndex = 6;
            this.colDON_Resever.Width = 382;
            // 
            // colDON_Dir
            // 
            this.colDON_Dir.Caption = "جهة التبرع";
            this.colDON_Dir.FieldName = "Donation_Dir_Name";
            this.colDON_Dir.Name = "colDON_Dir";
            this.colDON_Dir.Visible = true;
            this.colDON_Dir.VisibleIndex = 0;
            this.colDON_Dir.Width = 218;
            // 
            // colDON_Date
            // 
            this.colDON_Date.Caption = "تاريخ التبرع";
            this.colDON_Date.FieldName = "DON_Date";
            this.colDON_Date.Name = "colDON_Date";
            this.colDON_Date.Visible = true;
            this.colDON_Date.VisibleIndex = 1;
            this.colDON_Date.Width = 122;
            // 
            // colDON_Amo_txt
            // 
            this.colDON_Amo_txt.Caption = "المبلغ مكتوب";
            this.colDON_Amo_txt.FieldName = "DON_Amo_txt";
            this.colDON_Amo_txt.Name = "colDON_Amo_txt";
            this.colDON_Amo_txt.Visible = true;
            this.colDON_Amo_txt.VisibleIndex = 2;
            this.colDON_Amo_txt.Width = 287;
            // 
            // colDON_Amount
            // 
            this.colDON_Amount.Caption = "المبلغ";
            this.colDON_Amount.FieldName = "DON_Amount";
            this.colDON_Amount.Name = "colDON_Amount";
            this.colDON_Amount.Visible = true;
            this.colDON_Amount.VisibleIndex = 3;
            this.colDON_Amount.Width = 114;
            // 
            // colDON_Name
            // 
            this.colDON_Name.Caption = "اسم المتبرع";
            this.colDON_Name.FieldName = "Donner_Name";
            this.colDON_Name.Name = "colDON_Name";
            this.colDON_Name.Visible = true;
            this.colDON_Name.VisibleIndex = 5;
            this.colDON_Name.Width = 238;
            // 
            // colDonner_Phone
            // 
            this.colDonner_Phone.Caption = "رقم المتبرع";
            this.colDonner_Phone.FieldName = "Donner_Phone";
            this.colDonner_Phone.Name = "colDonner_Phone";
            this.colDonner_Phone.Visible = true;
            this.colDonner_Phone.VisibleIndex = 4;
            this.colDonner_Phone.Width = 129;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 7;
            this.colID.Width = 71;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Donation_List_New);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 385);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1591, 370);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // Pn_frm_don
            // 
            this.Pn_frm_don.BackColor = System.Drawing.Color.White;
            this.Pn_frm_don.Controls.Add(this.panel2);
            this.Pn_frm_don.Controls.Add(this.gridControl1);
            this.Pn_frm_don.Controls.Add(this.panel1);
            this.Pn_frm_don.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_don.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_don.Name = "Pn_frm_don";
            this.Pn_frm_don.Size = new System.Drawing.Size(1591, 814);
            this.Pn_frm_don.TabIndex = 1;
            this.Pn_frm_don.Paint += new System.Windows.Forms.PaintEventHandler(this.Pn_frm_wat_Paint);
            this.Pn_frm_don.MouseHover += new System.EventHandler(this.Pn_frm_don_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.charity_Recever);
            this.panel2.Controls.Add(this.simpleButton3);
            this.panel2.Controls.Add(this.edt_don_dir);
            this.panel2.Controls.Add(this.edt_don_name);
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.edt_don_val_w);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.edt_cat_val);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1591, 385);
            this.panel2.TabIndex = 65;
            // 
            // charity_Recever
            // 
            this.charity_Recever.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.charity_Recever.Location = new System.Drawing.Point(839, 264);
            this.charity_Recever.Name = "charity_Recever";
            this.charity_Recever.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.charity_Recever.Properties.Appearance.Options.UseFont = true;
            this.charity_Recever.Properties.Appearance.Options.UseTextOptions = true;
            this.charity_Recever.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.charity_Recever.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.charity_Recever.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.charity_Recever.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Emploee_Name", "", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.charity_Recever.Properties.DataSource = this.tBEmploeeBindingSource;
            this.charity_Recever.Properties.DisplayMember = "Emploee_Name";
            this.charity_Recever.Properties.NullText = " ";
            this.charity_Recever.Properties.ValueMember = "Emploee_ID";
            this.charity_Recever.Size = new System.Drawing.Size(393, 40);
            this.charity_Recever.TabIndex = 78;
            this.charity_Recever.Visible = false;
            this.charity_Recever.EditValueChanged += new System.EventHandler(this.charity_Recever_EditValueChanged);
            this.charity_Recever.Click += new System.EventHandler(this.charity_Recever_Click);
            // 
            // tBEmploeeBindingSource
            // 
            this.tBEmploeeBindingSource.DataMember = "TB_Emploee";
            this.tBEmploeeBindingSource.DataSource = this.dB_FWDDataSet2096;
            // 
            // dB_FWDDataSet2096
            // 
            this.dB_FWDDataSet2096.DataSetName = "DB_FWDDataSet2096";
            this.dB_FWDDataSet2096.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(787, 117);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(46, 41);
            this.simpleButton3.TabIndex = 77;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // edt_don_dir
            // 
            this.edt_don_dir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_don_dir.Location = new System.Drawing.Point(229, 118);
            this.edt_don_dir.Name = "edt_don_dir";
            this.edt_don_dir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_don_dir.Properties.Appearance.Options.UseFont = true;
            this.edt_don_dir.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_don_dir.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_don_dir.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_don_dir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_don_dir.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Donation_Dir_Name", " ", 113, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_don_dir.Properties.DataSource = typeof(FWD.TB_Donation_Dirction);
            this.edt_don_dir.Properties.DisplayMember = "Donation_Dir_Name";
            this.edt_don_dir.Properties.NullText = " ";
            this.edt_don_dir.Properties.ValueMember = "Donation_Dir_ID";
            this.edt_don_dir.Size = new System.Drawing.Size(393, 40);
            this.edt_don_dir.TabIndex = 76;
            this.edt_don_dir.Click += new System.EventHandler(this.edt_don_dir_Click);
            // 
            // edt_don_name
            // 
            this.edt_don_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_don_name.Location = new System.Drawing.Point(839, 118);
            this.edt_don_name.Name = "edt_don_name";
            this.edt_don_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_don_name.Properties.Appearance.Options.UseFont = true;
            this.edt_don_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_don_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_don_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_don_name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_don_name.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Donner_Name", "", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_don_name.Properties.DataSource = typeof(FWD.TB_Donner_info);
            this.edt_don_name.Properties.DisplayMember = "Donner_Name";
            this.edt_don_name.Properties.NullText = " ";
            this.edt_don_name.Properties.ValueMember = "Donner_ID";
            this.edt_don_name.Size = new System.Drawing.Size(393, 40);
            this.edt_don_name.TabIndex = 75;
            this.edt_don_name.EditValueChanged += new System.EventHandler(this.edt_don_name_EditValueChanged);
            this.edt_don_name.Click += new System.EventHandler(this.edt_don_name_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(229, 257);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(393, 43);
            this.simpleButton2.TabIndex = 74;
            this.simpleButton2.Text = "تـــبــرع";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // edt_don_val_w
            // 
            this.edt_don_val_w.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_don_val_w.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edt_don_val_w.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_don_val_w.Location = new System.Drawing.Point(229, 201);
            this.edt_don_val_w.Name = "edt_don_val_w";
            this.edt_don_val_w.Size = new System.Drawing.Size(390, 26);
            this.edt_don_val_w.TabIndex = 73;
            this.edt_don_val_w.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(665, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 66);
            this.label9.TabIndex = 72;
            this.label9.Text = "تبرع مالى";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1239, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 43);
            this.label4.TabIndex = 71;
            this.label4.Text = "القيمة";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1238, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 43);
            this.label5.TabIndex = 67;
            this.label5.Text = "المستلم";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 43);
            this.label1.TabIndex = 68;
            this.label1.Text = "جهة التبرع";
            // 
            // edt_cat_val
            // 
            this.edt_cat_val.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_cat_val.Location = new System.Drawing.Point(839, 194);
            this.edt_cat_val.Name = "edt_cat_val";
            this.edt_cat_val.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_cat_val.Properties.Appearance.Options.UseFont = true;
            this.edt_cat_val.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_cat_val.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_cat_val.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_cat_val.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_cat_val.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_cat_val.Properties.MaskSettings.Set("mask", "\\d+");
            this.edt_cat_val.Size = new System.Drawing.Size(393, 40);
            this.edt_cat_val.TabIndex = 65;
            this.edt_cat_val.EditValueChanged += new System.EventHandler(this.edt_cat_val_EditValueChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 43);
            this.label3.TabIndex = 69;
            this.label3.Text = "المبلغ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1235, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 43);
            this.label2.TabIndex = 70;
            this.label2.Text = "اسم المتبرع";
            // 
            // tBDonationDirctionBindingSource
            // 
            this.tBDonationDirctionBindingSource.DataMember = "TB_Donation_Dirction";
            this.tBDonationDirctionBindingSource.DataSource = this.dB_FWDDataSet2053;
            // 
            // dB_FWDDataSet2053
            // 
            this.dB_FWDDataSet2053.DataSetName = "DB_FWDDataSet2053";
            this.dB_FWDDataSet2053.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBDonnerinfoBindingSource
            // 
            this.tBDonnerinfoBindingSource.DataMember = "TB_Donner_info";
            this.tBDonnerinfoBindingSource.DataSource = this.dB_FWDDataSet2052;
            // 
            // dB_FWDDataSet2052
            // 
            this.dB_FWDDataSet2052.DataSetName = "DB_FWDDataSet2052";
            this.dB_FWDDataSet2052.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_Donner_infoTableAdapter
            // 
            this.tB_Donner_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tB_Donation_DirctionTableAdapter
            // 
            this.tB_Donation_DirctionTableAdapter.ClearBeforeFill = true;
            // 
            // tB_EmploeeTableAdapter
            // 
            this.tB_EmploeeTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Donation_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 814);
            this.Controls.Add(this.Pn_frm_don);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Donation_Add";
            this.Text = "Form_Donation_Add";
            this.Load += new System.EventHandler(this.Form_Donation_Add_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.Pn_frm_don.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charity_Recever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEmploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2096)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_dir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_don_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cat_val.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDonationDirctionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2053)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBDonnerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2052)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public System.Windows.Forms.Panel Pn_frm_don;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Resever;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Dir;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Amo_txt;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colDON_Name;
        private DB_FWDDataSet2052 dB_FWDDataSet2052;
        private System.Windows.Forms.BindingSource tBDonnerinfoBindingSource;
        private DB_FWDDataSet2052TableAdapters.TB_Donner_infoTableAdapter tB_Donner_infoTableAdapter;
        private DB_FWDDataSet2053 dB_FWDDataSet2053;
        private System.Windows.Forms.BindingSource tBDonationDirctionBindingSource;
        private DB_FWDDataSet2053TableAdapters.TB_Donation_DirctionTableAdapter tB_Donation_DirctionTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LookUpEdit edt_don_dir;
        private DevExpress.XtraEditors.LookUpEdit edt_don_name;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox edt_don_val_w;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit edt_cat_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LookUpEdit charity_Recever;
        private DevExpress.XtraGrid.Columns.GridColumn colDonner_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DB_FWDDataSet2096 dB_FWDDataSet2096;
        private System.Windows.Forms.BindingSource tBEmploeeBindingSource;
        private DB_FWDDataSet2096TableAdapters.TB_EmploeeTableAdapter tB_EmploeeTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        public DevExpress.XtraEditors.SimpleButton btn_del;
    }
}