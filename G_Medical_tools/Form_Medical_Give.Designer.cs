
namespace FWD.G_Medical_tools
{
    partial class Form_Medical_Give
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Medical_Give));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_tool_give_recever = new DevExpress.XtraEditors.TextEdit();
            this.edt_tool_give_pationt = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_tool_give_tool_name = new DevExpress.XtraEditors.LookUpEdit();
            this.tBMedicaltoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2057 = new FWD.DB_FWDDataSet2057();
            this.edt_tool_give_phone = new DevExpress.XtraEditors.TextEdit();
            this.edt_tool_give_ssn = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_tool_give_add = new DevExpress.XtraEditors.LookUpEdit();
            this.tBELOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2058 = new FWD.DB_FWDDataSet2058();
            this.edt_tool_give_emploee = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Medical_toolTableAdapter = new FWD.DB_FWDDataSet2057TableAdapters.TB_Medical_toolTableAdapter();
            this.tBE_LOCTableAdapter = new FWD.DB_FWDDataSet2058TableAdapters.TBE_LOCTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_recever.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_pationt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_tool_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMedicaltoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2057)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_ssn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_add.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2058)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_emploee.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(378, 324);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(400, 43);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(469, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 66);
            this.label9.TabIndex = 92;
            this.label9.Text = "تسليم اداة طبية";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1074, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 43);
            this.label6.TabIndex = 90;
            this.label6.Text = "اسم المستلم";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1063, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 43);
            this.label2.TabIndex = 91;
            this.label2.Text = "اسم المستحق";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_tool_give_recever
            // 
            this.edt_tool_give_recever.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_recever.Location = new System.Drawing.Point(658, 200);
            this.edt_tool_give_recever.Name = "edt_tool_give_recever";
            this.edt_tool_give_recever.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_recever.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_recever.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_tool_give_recever.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_tool_give_recever.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_tool_give_recever.Size = new System.Drawing.Size(393, 40);
            this.edt_tool_give_recever.TabIndex = 3;
            // 
            // edt_tool_give_pationt
            // 
            this.edt_tool_give_pationt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_pationt.Location = new System.Drawing.Point(658, 140);
            this.edt_tool_give_pationt.Name = "edt_tool_give_pationt";
            this.edt_tool_give_pationt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_pationt.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_pationt.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_tool_give_pationt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_tool_give_pationt.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_tool_give_pationt.Size = new System.Drawing.Size(393, 40);
            this.edt_tool_give_pationt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1093, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 43);
            this.label3.TabIndex = 91;
            this.label3.Text = "رقم الهاتف";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 43);
            this.label4.TabIndex = 91;
            this.label4.Text = "اسم الاداة";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_tool_give_tool_name
            // 
            this.edt_tool_give_tool_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_tool_name.Location = new System.Drawing.Point(39, 133);
            this.edt_tool_give_tool_name.Name = "edt_tool_give_tool_name";
            this.edt_tool_give_tool_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_tool_name.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_tool_name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_tool_give_tool_name.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Medical_tool_Name", "Medical_tool_Name", 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_tool_give_tool_name.Properties.DataSource = typeof(FWD.TB_Medical_tool);
            this.edt_tool_give_tool_name.Properties.DisplayMember = "Medical_tool_Name";
            this.edt_tool_give_tool_name.Properties.NullText = " ";
            this.edt_tool_give_tool_name.Properties.ValueMember = "Medical_tool_ID";
            this.edt_tool_give_tool_name.Size = new System.Drawing.Size(401, 40);
            this.edt_tool_give_tool_name.TabIndex = 2;
            this.edt_tool_give_tool_name.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // tBMedicaltoolBindingSource
            // 
            this.tBMedicaltoolBindingSource.DataMember = "TB_Medical_tool";
            this.tBMedicaltoolBindingSource.DataSource = this.dB_FWDDataSet2057;
            // 
            // dB_FWDDataSet2057
            // 
            this.dB_FWDDataSet2057.DataSetName = "DB_FWDDataSet2057";
            this.dB_FWDDataSet2057.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edt_tool_give_phone
            // 
            this.edt_tool_give_phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_phone.Location = new System.Drawing.Point(658, 261);
            this.edt_tool_give_phone.Name = "edt_tool_give_phone";
            this.edt_tool_give_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_phone.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_phone.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_tool_give_phone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_tool_give_phone.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_tool_give_phone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_tool_give_phone.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_tool_give_phone.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_tool_give_phone.Size = new System.Drawing.Size(393, 40);
            this.edt_tool_give_phone.TabIndex = 5;
            // 
            // edt_tool_give_ssn
            // 
            this.edt_tool_give_ssn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_ssn.Location = new System.Drawing.Point(39, 189);
            this.edt_tool_give_ssn.Name = "edt_tool_give_ssn";
            this.edt_tool_give_ssn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_ssn.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_ssn.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_tool_give_ssn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_tool_give_ssn.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_tool_give_ssn.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_tool_give_ssn.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.edt_tool_give_ssn.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_tool_give_ssn.Size = new System.Drawing.Size(401, 40);
            this.edt_tool_give_ssn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(472, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 43);
            this.label5.TabIndex = 91;
            this.label5.Text = "رقم قومى";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 43);
            this.label7.TabIndex = 91;
            this.label7.Text = "الموظف ";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_tool_give_add
            // 
            this.edt_tool_give_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_add.Location = new System.Drawing.Point(39, 259);
            this.edt_tool_give_add.Name = "edt_tool_give_add";
            this.edt_tool_give_add.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_add.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_add.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_tool_give_add.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Name", "LOC_Name", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LOC_Key", "LOC_Key", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.edt_tool_give_add.Properties.DataSource = typeof(FWD.TBE_LOC);
            this.edt_tool_give_add.Properties.DisplayMember = "LOC_Name";
            this.edt_tool_give_add.Properties.NullText = " ";
            this.edt_tool_give_add.Properties.ValueMember = "ID";
            this.edt_tool_give_add.Size = new System.Drawing.Size(400, 40);
            this.edt_tool_give_add.TabIndex = 6;
            // 
            // tBELOCBindingSource
            // 
            this.tBELOCBindingSource.DataMember = "TBE_LOC";
            this.tBELOCBindingSource.DataSource = this.dB_FWDDataSet2058;
            // 
            // dB_FWDDataSet2058
            // 
            this.dB_FWDDataSet2058.DataSetName = "DB_FWDDataSet2058";
            this.dB_FWDDataSet2058.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edt_tool_give_emploee
            // 
            this.edt_tool_give_emploee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_emploee.Location = new System.Drawing.Point(12, 466);
            this.edt_tool_give_emploee.Name = "edt_tool_give_emploee";
            this.edt_tool_give_emploee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_emploee.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_emploee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_tool_give_emploee.Properties.NullText = " ";
            this.edt_tool_give_emploee.Size = new System.Drawing.Size(393, 40);
            this.edt_tool_give_emploee.TabIndex = 7;
            this.edt_tool_give_emploee.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 43);
            this.label1.TabIndex = 91;
            this.label1.Text = "العنوان";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // tB_Medical_toolTableAdapter
            // 
            this.tB_Medical_toolTableAdapter.ClearBeforeFill = true;
            // 
            // tBE_LOCTableAdapter
            // 
            this.tBE_LOCTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.edt_tool_give_pationt);
            this.panel1.Controls.Add(this.edt_tool_give_emploee);
            this.panel1.Controls.Add(this.edt_tool_give_recever);
            this.panel1.Controls.Add(this.edt_tool_give_add);
            this.panel1.Controls.Add(this.edt_tool_give_phone);
            this.panel1.Controls.Add(this.edt_tool_give_tool_name);
            this.panel1.Controls.Add(this.edt_tool_give_ssn);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 654);
            this.panel1.TabIndex = 93;
            // 
            // Form_Medical_Give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 654);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Medical_Give";
            this.Text = "Form_Medical_Give";
            this.Load += new System.EventHandler(this.Form_Medical_Give_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_recever.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_pationt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_tool_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMedicaltoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2057)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_ssn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_add.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBELOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2058)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_emploee.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_tool_give_recever;
        private DevExpress.XtraEditors.TextEdit edt_tool_give_pationt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit edt_tool_give_tool_name;
        private DevExpress.XtraEditors.TextEdit edt_tool_give_phone;
        private DevExpress.XtraEditors.TextEdit edt_tool_give_ssn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit edt_tool_give_add;
        private DevExpress.XtraEditors.LookUpEdit edt_tool_give_emploee;
        private System.Windows.Forms.Label label1;
        private DB_FWDDataSet2057 dB_FWDDataSet2057;
        private System.Windows.Forms.BindingSource tBMedicaltoolBindingSource;
        private DB_FWDDataSet2057TableAdapters.TB_Medical_toolTableAdapter tB_Medical_toolTableAdapter;
        private DB_FWDDataSet2058 dB_FWDDataSet2058;
        private System.Windows.Forms.BindingSource tBELOCBindingSource;
        private DB_FWDDataSet2058TableAdapters.TBE_LOCTableAdapter tBE_LOCTableAdapter;
        public System.Windows.Forms.Panel panel1;
    }
}