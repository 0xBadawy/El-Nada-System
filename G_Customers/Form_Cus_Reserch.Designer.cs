
namespace FWD.G_Customers
{
    partial class Form_Cus_Reserch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Reserch));
            this.edt_res_state = new DevExpress.XtraEditors.RadioGroup();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_Form_Cus_Res = new System.Windows.Forms.Panel();
            this.Button_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_res_deg = new DevExpress.XtraEditors.TextEdit();
            this.edt_res_dir = new DevExpress.XtraEditors.TextEdit();
            this.edt_res_resercher = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_res_supp = new DevExpress.XtraEditors.LookUpEdit();
            this.edt_res_date = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.edt_res_opin = new DevExpress.XtraEditors.MemoEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.tBRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resercher = new FWD.Resercher();
            this.tBSUPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet7 = new FWD.DB_FWDDataSet7();
            this.tB_RESTableAdapter = new FWD.ResercherTableAdapters.TB_RESTableAdapter();
            this.tB_SUPPTableAdapter = new FWD.DB_FWDDataSet7TableAdapters.TB_SUPPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_state.Properties)).BeginInit();
            this.panel_Form_Cus_Res.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_deg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_dir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_resercher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_supp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_opin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSUPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_res_state
            // 
            this.edt_res_state.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_res_state.Location = new System.Drawing.Point(54, 236);
            this.edt_res_state.Name = "edt_res_state";
            this.edt_res_state.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_res_state.Properties.Appearance.Options.UseFont = true;
            this.edt_res_state.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "فـئـة (أ)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "فـئـة (ب)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "فـئـة (جـ)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "غير مستحق")});
            this.edt_res_state.Size = new System.Drawing.Size(1093, 51);
            this.edt_res_state.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1175, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 43);
            this.label9.TabIndex = 50;
            this.label9.Text = "رأى الباحث";
            // 
            // panel_Form_Cus_Res
            // 
            this.panel_Form_Cus_Res.AutoScroll = true;
            this.panel_Form_Cus_Res.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Res.Controls.Add(this.Button_Add);
            this.panel_Form_Cus_Res.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Res.Controls.Add(this.label12);
            this.panel_Form_Cus_Res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Res.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Res.Name = "panel_Form_Cus_Res";
            this.panel_Form_Cus_Res.Size = new System.Drawing.Size(1509, 760);
            this.panel_Form_Cus_Res.TabIndex = 2;
            // 
            // Button_Add
            // 
            this.Button_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Button_Add.Appearance.Options.UseFont = true;
            this.Button_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Add.ImageOptions.Image")));
            this.Button_Add.Location = new System.Drawing.Point(607, 669);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(237, 57);
            this.Button_Add.TabIndex = 51;
            this.Button_Add.Text = "أضافة";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edt_res_deg);
            this.groupBox1.Controls.Add(this.edt_res_dir);
            this.groupBox1.Controls.Add(this.edt_res_resercher);
            this.groupBox1.Controls.Add(this.edt_res_state);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edt_res_supp);
            this.groupBox1.Controls.Add(this.edt_res_date);
            this.groupBox1.Controls.Add(this.edt_res_opin);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(67, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1293, 551);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // edt_res_deg
            // 
            this.edt_res_deg.Location = new System.Drawing.Point(756, 171);
            this.edt_res_deg.Name = "edt_res_deg";
            this.edt_res_deg.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_deg.Properties.Appearance.Options.UseFont = true;
            this.edt_res_deg.Size = new System.Drawing.Size(394, 40);
            this.edt_res_deg.TabIndex = 55;
            this.edt_res_deg.EditValueChanged += new System.EventHandler(this.edt_res_deg_EditValueChanged);
            // 
            // edt_res_dir
            // 
            this.edt_res_dir.Location = new System.Drawing.Point(98, 89);
            this.edt_res_dir.Name = "edt_res_dir";
            this.edt_res_dir.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_dir.Properties.Appearance.Options.UseFont = true;
            this.edt_res_dir.Size = new System.Drawing.Size(394, 40);
            this.edt_res_dir.TabIndex = 55;
            // 
            // edt_res_resercher
            // 
            this.edt_res_resercher.Location = new System.Drawing.Point(757, 28);
            this.edt_res_resercher.Name = "edt_res_resercher";
            this.edt_res_resercher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_resercher.Properties.Appearance.Options.UseFont = true;
            this.edt_res_resercher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_res_resercher.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RES_Name", "RES_Name", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_res_resercher.Properties.DataSource = typeof(FWD.TB_RES);
            this.edt_res_resercher.Properties.DisplayMember = "RES_Name";
            this.edt_res_resercher.Properties.NullText = " ";
            this.edt_res_resercher.Properties.ValueMember = "ID";
            this.edt_res_resercher.Size = new System.Drawing.Size(386, 40);
            this.edt_res_resercher.TabIndex = 54;
            this.edt_res_resercher.EditValueChanged += new System.EventHandler(this.edt_res_resercher_EditValueChanged);
            this.edt_res_resercher.Click += new System.EventHandler(this.edt_res_resercher_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 43);
            this.label3.TabIndex = 50;
            this.label3.Text = "اسم مندوب المنطقة";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1153, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 43);
            this.label6.TabIndex = 50;
            this.label6.Text = "درجة الحالة";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 43);
            this.label5.TabIndex = 50;
            this.label5.Text = "الجهة القائمة بالبحث";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1157, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 43);
            this.label4.TabIndex = 50;
            this.label4.Text = "تاريخ البحث";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1153, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 43);
            this.label2.TabIndex = 50;
            this.label2.Text = "اسم الباحث";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1155, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 43);
            this.label7.TabIndex = 50;
            this.label7.Text = "التصنيف";
            // 
            // edt_res_supp
            // 
            this.edt_res_supp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_res_supp.Location = new System.Drawing.Point(98, 27);
            this.edt_res_supp.Name = "edt_res_supp";
            this.edt_res_supp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_supp.Properties.Appearance.Options.UseFont = true;
            this.edt_res_supp.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_res_supp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_res_supp.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_res_supp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_res_supp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPP_Name", "SUPP_Name", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_res_supp.Properties.DataSource = typeof(FWD.TB_SUPP);
            this.edt_res_supp.Properties.DisplayMember = "SUPP_Name";
            this.edt_res_supp.Properties.NullText = "";
            this.edt_res_supp.Properties.ValueMember = "ID";
            this.edt_res_supp.Size = new System.Drawing.Size(390, 40);
            this.edt_res_supp.TabIndex = 53;
            // 
            // edt_res_date
            // 
            this.edt_res_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_res_date.EditValue = "";
            this.edt_res_date.Location = new System.Drawing.Point(757, 90);
            this.edt_res_date.Name = "edt_res_date";
            this.edt_res_date.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_date.Properties.Appearance.Options.UseFont = true;
            this.edt_res_date.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_res_date.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_res_date.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_res_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_res_date.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.edt_res_date.Properties.MaskSettings.Set("mask", "d");
            this.edt_res_date.Size = new System.Drawing.Size(390, 40);
            this.edt_res_date.TabIndex = 53;
            // 
            // edt_res_opin
            // 
            this.edt_res_opin.Location = new System.Drawing.Point(54, 333);
            this.edt_res_opin.Name = "edt_res_opin";
            this.edt_res_opin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_res_opin.Properties.Appearance.Options.UseFont = true;
            this.edt_res_opin.Size = new System.Drawing.Size(1093, 212);
            this.edt_res_opin.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(586, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 72);
            this.label12.TabIndex = 50;
            this.label12.Text = "رأى الباحث";
            // 
            // tBRESBindingSource
            // 
            this.tBRESBindingSource.DataMember = "TB_RES";
            this.tBRESBindingSource.DataSource = this.resercher;
            // 
            // resercher
            // 
            this.resercher.DataSetName = "Resercher";
            this.resercher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBSUPPBindingSource
            // 
            this.tBSUPPBindingSource.DataMember = "TB_SUPP";
            this.tBSUPPBindingSource.DataSource = this.dB_FWDDataSet7;
            // 
            // dB_FWDDataSet7
            // 
            this.dB_FWDDataSet7.DataSetName = "DB_FWDDataSet7";
            this.dB_FWDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_RESTableAdapter
            // 
            this.tB_RESTableAdapter.ClearBeforeFill = true;
            // 
            // tB_SUPPTableAdapter
            // 
            this.tB_SUPPTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Cus_Reserch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1509, 760);
            this.Controls.Add(this.panel_Form_Cus_Res);
            this.Name = "Form_Cus_Reserch";
            this.Text = "Form_Cus_Reserch";
            this.Load += new System.EventHandler(this.Form_Cus_Reserch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_state.Properties)).EndInit();
            this.panel_Form_Cus_Res.ResumeLayout(false);
            this.panel_Form_Cus_Res.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_deg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_dir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_resercher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_supp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_res_opin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBSUPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.RadioGroup edt_res_state;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel_Form_Cus_Res;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.LookUpEdit edt_res_resercher;
        private System.Windows.Forms.Label label2;
        private Resercher resercher;
        private System.Windows.Forms.BindingSource tBRESBindingSource;
        private ResercherTableAdapters.TB_RESTableAdapter tB_RESTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit edt_res_supp;
        private DB_FWDDataSet7 dB_FWDDataSet7;
        private System.Windows.Forms.BindingSource tBSUPPBindingSource;
        private DB_FWDDataSet7TableAdapters.TB_SUPPTableAdapter tB_SUPPTableAdapter;
        private DevExpress.XtraEditors.TextEdit edt_res_deg;
        private DevExpress.XtraEditors.TextEdit edt_res_dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateTimeOffsetEdit edt_res_date;
        private DevExpress.XtraEditors.MemoEdit edt_res_opin;
        private DevExpress.XtraEditors.SimpleButton Button_Add;
    }
}