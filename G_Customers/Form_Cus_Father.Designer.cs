
namespace FWD.G_Customers
{
    partial class Form_Cus_Father
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Father));
            this.edt_father_bairth = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_father_label_age = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_per_father_det = new DevExpress.XtraEditors.TextEdit();
            this.edt_father_phone = new DevExpress.XtraEditors.TextEdit();
            this.edt_father_ssn = new DevExpress.XtraEditors.TextEdit();
            this.edt_father_name = new DevExpress.XtraEditors.TextEdit();
            this.panel_Form_Cus_Father = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBHealthStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2034 = new FWD.DB_FWDDataSet2034();
            this.edt_father_edu = new DevExpress.XtraEditors.LookUpEdit();
            this.tBEducationalStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2033 = new FWD.DB_FWDDataSet2033();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_Educational_StatusTableAdapter = new FWD.DB_FWDDataSet2033TableAdapters.TB_Educational_StatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_bairth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_father_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_ssn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_name.Properties)).BeginInit();
            this.panel_Form_Cus_Father.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBHealthStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2034)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_edu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEducationalStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2033)).BeginInit();
            this.SuspendLayout();
            // 
            // edt_father_bairth
            // 
            this.edt_father_bairth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_father_bairth.EditValue = null;
            this.edt_father_bairth.Location = new System.Drawing.Point(794, 118);
            this.edt_father_bairth.Name = "edt_father_bairth";
            this.edt_father_bairth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_father_bairth.Properties.Appearance.Options.UseFont = true;
            this.edt_father_bairth.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_father_bairth.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_father_bairth.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_father_bairth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_father_bairth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.edt_father_bairth.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.edt_father_bairth.Properties.MaskSettings.Set("mask", "d");
            this.edt_father_bairth.Size = new System.Drawing.Size(289, 40);
            this.edt_father_bairth.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 117);
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
            this.label11.Location = new System.Drawing.Point(1103, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 43);
            this.label11.TabIndex = 50;
            this.label11.Text = "الحالة الصحية";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 51);
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
            this.label7.Location = new System.Drawing.Point(689, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 43);
            this.label7.TabIndex = 50;
            this.label7.Text = "سنة";
            // 
            // edt_father_label_age
            // 
            this.edt_father_label_age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_father_label_age.AutoSize = true;
            this.edt_father_label_age.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_father_label_age.Location = new System.Drawing.Point(741, 117);
            this.edt_father_label_age.Name = "edt_father_label_age";
            this.edt_father_label_age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_father_label_age.Size = new System.Drawing.Size(47, 43);
            this.edt_father_label_age.TabIndex = 50;
            this.edt_father_label_age.Text = "00";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1119, 117);
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
            this.label10.Location = new System.Drawing.Point(525, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 43);
            this.label10.TabIndex = 50;
            this.label10.Text = "وصف المرض";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1120, 177);
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
            this.label2.Location = new System.Drawing.Point(1168, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 43);
            this.label2.TabIndex = 50;
            this.label2.Text = "الاسم";
            // 
            // edt_per_father_det
            // 
            this.edt_per_father_det.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_per_father_det.EditValue = "";
            this.edt_per_father_det.Location = new System.Drawing.Point(96, 253);
            this.edt_per_father_det.Name = "edt_per_father_det";
            this.edt_per_father_det.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_per_father_det.Properties.Appearance.Options.UseFont = true;
            this.edt_per_father_det.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_per_father_det.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_per_father_det.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_per_father_det.Size = new System.Drawing.Size(390, 40);
            this.edt_per_father_det.TabIndex = 9;
            // 
            // edt_father_phone
            // 
            this.edt_father_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_father_phone.EditValue = "";
            this.edt_father_phone.Location = new System.Drawing.Point(693, 178);
            this.edt_father_phone.Name = "edt_father_phone";
            this.edt_father_phone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_father_phone.Properties.Appearance.Options.UseFont = true;
            this.edt_father_phone.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_father_phone.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_father_phone.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_father_phone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_father_phone.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_father_phone.Size = new System.Drawing.Size(390, 40);
            this.edt_father_phone.TabIndex = 6;
            // 
            // edt_father_ssn
            // 
            this.edt_father_ssn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_father_ssn.EditValue = "";
            this.edt_father_ssn.Location = new System.Drawing.Point(98, 54);
            this.edt_father_ssn.Name = "edt_father_ssn";
            this.edt_father_ssn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_father_ssn.Properties.Appearance.Options.UseFont = true;
            this.edt_father_ssn.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_father_ssn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_father_ssn.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_father_ssn.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.edt_father_ssn.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.edt_father_ssn.Size = new System.Drawing.Size(390, 40);
            this.edt_father_ssn.TabIndex = 3;
            // 
            // edt_father_name
            // 
            this.edt_father_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edt_father_name.EditValue = "";
            this.edt_father_name.Location = new System.Drawing.Point(690, 54);
            this.edt_father_name.Name = "edt_father_name";
            this.edt_father_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_father_name.Properties.Appearance.Options.UseFont = true;
            this.edt_father_name.Properties.Appearance.Options.UseTextOptions = true;
            this.edt_father_name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.edt_father_name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.edt_father_name.Size = new System.Drawing.Size(390, 40);
            this.edt_father_name.TabIndex = 2;
            this.edt_father_name.EditValueChanged += new System.EventHandler(this.edt_father_name_EditValueChanged);
            // 
            // panel_Form_Cus_Father
            // 
            this.panel_Form_Cus_Father.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_Father.Controls.Add(this.simpleButton1);
            this.panel_Form_Cus_Father.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_Father.Controls.Add(this.label12);
            this.panel_Form_Cus_Father.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_Father.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_Father.Name = "panel_Form_Cus_Father";
            this.panel_Form_Cus_Father.Size = new System.Drawing.Size(1419, 721);
            this.panel_Form_Cus_Father.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(606, 588);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(216, 52);
            this.simpleButton1.TabIndex = 51;
            this.simpleButton1.Text = "تسجيل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.edt_father_edu);
            this.groupBox1.Controls.Add(this.edt_father_bairth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edt_father_label_age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_per_father_det);
            this.groupBox1.Controls.Add(this.edt_father_phone);
            this.groupBox1.Controls.Add(this.edt_father_ssn);
            this.groupBox1.Controls.Add(this.edt_father_name);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(28, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1329, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tBHealthStatusBindingSource
            // 
            this.tBHealthStatusBindingSource.DataMember = "TB_Health_Status";
            this.tBHealthStatusBindingSource.DataSource = this.dB_FWDDataSet2034;
            // 
            // dB_FWDDataSet2034
            // 
            this.dB_FWDDataSet2034.DataSetName = "DB_FWDDataSet2034";
            this.dB_FWDDataSet2034.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edt_father_edu
            // 
            this.edt_father_edu.Location = new System.Drawing.Point(102, 118);
            this.edt_father_edu.Name = "edt_father_edu";
            this.edt_father_edu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_father_edu.Properties.Appearance.Options.UseFont = true;
            this.edt_father_edu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_father_edu.Properties.DataSource = this.tBEducationalStatusBindingSource;
            this.edt_father_edu.Properties.DisplayMember = "Educational_Status_Name";
            this.edt_father_edu.Properties.NullText = " ";
            this.edt_father_edu.Properties.ValueMember = "Educational_Status_ID";
            this.edt_father_edu.Size = new System.Drawing.Size(386, 40);
            this.edt_father_edu.TabIndex = 52;
            // 
            // tBEducationalStatusBindingSource
            // 
            this.tBEducationalStatusBindingSource.DataMember = "TB_Educational_Status";
            this.tBEducationalStatusBindingSource.DataSource = this.dB_FWDDataSet2033;
            // 
            // dB_FWDDataSet2033
            // 
            this.dB_FWDDataSet2033.DataSetName = "DB_FWDDataSet2033";
            this.dB_FWDDataSet2033.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(511, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 72);
            this.label12.TabIndex = 50;
            this.label12.Text = "تسجيل بيانات الزوج";
            // 
            // tB_Educational_StatusTableAdapter
            // 
            this.tB_Educational_StatusTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Cus_Father
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 721);
            this.Controls.Add(this.panel_Form_Cus_Father);
            this.Name = "Form_Cus_Father";
            this.Text = "Form_Cus_Father";
            this.Load += new System.EventHandler(this.Form_Cus_Father_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_bairth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_per_father_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_ssn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_name.Properties)).EndInit();
            this.panel_Form_Cus_Father.ResumeLayout(false);
            this.panel_Form_Cus_Father.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBHealthStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2034)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_father_edu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBEducationalStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2033)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateTimeOffsetEdit edt_father_bairth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label edt_father_label_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit edt_per_father_det;
        private DevExpress.XtraEditors.TextEdit edt_father_phone;
        private DevExpress.XtraEditors.TextEdit edt_father_ssn;
        private DevExpress.XtraEditors.TextEdit edt_father_name;
        public System.Windows.Forms.Panel panel_Form_Cus_Father;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit edt_father_edu;
        private DB_FWDDataSet2033 dB_FWDDataSet2033;
        private System.Windows.Forms.BindingSource tBEducationalStatusBindingSource;
        private DB_FWDDataSet2033TableAdapters.TB_Educational_StatusTableAdapter tB_Educational_StatusTableAdapter;
        private DB_FWDDataSet2034 dB_FWDDataSet2034;
        private System.Windows.Forms.BindingSource tBHealthStatusBindingSource;
        //private DB_FWDDataSet2034TableAdapters.TB_Health_StatusTableAdapter tB_Health_StatusTableAdapter;
    }
}