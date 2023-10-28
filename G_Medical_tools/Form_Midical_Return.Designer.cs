
namespace FWD.G_Medical_tools
{
    partial class Form_Midical_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Midical_Return));
            this.edt_tool_give_tool_name = new DevExpress.XtraEditors.LookUpEdit();
            this.tBMedicalgiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDDataSet2060 = new FWD.DB_FWDDataSet2060();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label_C_Inf_add = new System.Windows.Forms.TextBox();
            this.label_C_Inf_id = new System.Windows.Forms.TextBox();
            this.label_C_Inf_ssn = new System.Windows.Forms.TextBox();
            this.label_C_Inf_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_tool_give_emploee = new DevExpress.XtraEditors.LookUpEdit();
            this.tB_Medical_giveTableAdapter = new FWD.DB_FWDDataSet2060TableAdapters.TB_Medical_giveTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_tool_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMedicalgiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2060)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_emploee.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // edt_tool_give_tool_name
            // 
            this.edt_tool_give_tool_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_tool_name.Location = new System.Drawing.Point(632, 227);
            this.edt_tool_give_tool_name.Name = "edt_tool_give_tool_name";
            this.edt_tool_give_tool_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_tool_name.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_tool_name.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_tool_give_tool_name.Properties.DataSource = typeof(FWD.TB_Medical_give);
            this.edt_tool_give_tool_name.Properties.DisplayMember = "Medical_give_ID";
            this.edt_tool_give_tool_name.Properties.NullText = " ";
            this.edt_tool_give_tool_name.Properties.ValueMember = "Medical_give_ID";
            this.edt_tool_give_tool_name.Size = new System.Drawing.Size(401, 40);
            this.edt_tool_give_tool_name.TabIndex = 111;
            this.edt_tool_give_tool_name.EditValueChanged += new System.EventHandler(this.edt_tool_give_tool_name_EditValueChanged);
            // 
            // tBMedicalgiveBindingSource
            // 
            this.tBMedicalgiveBindingSource.DataMember = "TB_Medical_give";
            this.tBMedicalgiveBindingSource.DataSource = this.dB_FWDDataSet2060;
            // 
            // dB_FWDDataSet2060
            // 
            this.dB_FWDDataSet2060.DataSetName = "DB_FWDDataSet2060";
            this.dB_FWDDataSet2060.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(783, 425);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 43);
            this.simpleButton2.TabIndex = 110;
            this.simpleButton2.Text = "اضــافــة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(560, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 66);
            this.label9.TabIndex = 109;
            this.label9.Text = "ارجاع اداة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1034, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 43);
            this.label4.TabIndex = 103;
            this.label4.Text = "اسم الاداة";
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
            this.groupControl1.Controls.Add(this.label_C_Inf_add);
            this.groupControl1.Controls.Add(this.label_C_Inf_id);
            this.groupControl1.Controls.Add(this.label_C_Inf_ssn);
            this.groupControl1.Controls.Add(this.label_C_Inf_name);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label12);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.label14);
            this.groupControl1.Location = new System.Drawing.Point(123, 224);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(489, 308);
            this.groupControl1.TabIndex = 114;
            this.groupControl1.Text = "تفاصيل بيانات الحالة";
            // 
            // label_C_Inf_add
            // 
            this.label_C_Inf_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_add.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_add.Enabled = false;
            this.label_C_Inf_add.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_add.Location = new System.Drawing.Point(29, 251);
            this.label_C_Inf_add.Name = "label_C_Inf_add";
            this.label_C_Inf_add.Size = new System.Drawing.Size(289, 39);
            this.label_C_Inf_add.TabIndex = 29;
            this.label_C_Inf_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_id
            // 
            this.label_C_Inf_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_id.Enabled = false;
            this.label_C_Inf_id.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_id.Location = new System.Drawing.Point(5, 184);
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
            this.label_C_Inf_ssn.Location = new System.Drawing.Point(8, 113);
            this.label_C_Inf_ssn.Name = "label_C_Inf_ssn";
            this.label_C_Inf_ssn.Size = new System.Drawing.Size(305, 39);
            this.label_C_Inf_ssn.TabIndex = 29;
            this.label_C_Inf_ssn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_C_Inf_name
            // 
            this.label_C_Inf_name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_C_Inf_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_C_Inf_name.Enabled = false;
            this.label_C_Inf_name.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_C_Inf_name.Location = new System.Drawing.Point(10, 44);
            this.label_C_Inf_name.Name = "label_C_Inf_name";
            this.label_C_Inf_name.Size = new System.Drawing.Size(308, 39);
            this.label_C_Inf_name.TabIndex = 29;
            this.label_C_Inf_name.Text = "  ";
            this.label_C_Inf_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 43);
            this.label11.TabIndex = 28;
            this.label11.Text = ":                  التاريخ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 43);
            this.label12.TabIndex = 28;
            this.label12.Text = ":    اسم المستحق   ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(315, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 43);
            this.label13.TabIndex = 28;
            this.label13.Text = ":         اسم الاداة";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(309, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 43);
            this.label14.TabIndex = 28;
            this.label14.Text = ":    اسم المستلم  ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1047, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 43);
            this.label7.TabIndex = 104;
            this.label7.Text = "الموظف ";
            // 
            // edt_tool_give_emploee
            // 
            this.edt_tool_give_emploee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.edt_tool_give_emploee.Location = new System.Drawing.Point(640, 329);
            this.edt_tool_give_emploee.Name = "edt_tool_give_emploee";
            this.edt_tool_give_emploee.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.edt_tool_give_emploee.Properties.Appearance.Options.UseFont = true;
            this.edt_tool_give_emploee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edt_tool_give_emploee.Properties.NullText = " ";
            this.edt_tool_give_emploee.Size = new System.Drawing.Size(393, 40);
            this.edt_tool_give_emploee.TabIndex = 113;
            // 
            // tB_Medical_giveTableAdapter
            // 
            this.tB_Medical_giveTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.edt_tool_give_emploee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.edt_tool_give_tool_name);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 855);
            this.panel1.TabIndex = 115;
            // 
            // Form_Midical_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 855);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Midical_Return";
            this.Text = "Form_Midical_Return";
            this.Load += new System.EventHandler(this.Form_Midical_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_tool_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBMedicalgiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDDataSet2060)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_tool_give_emploee.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LookUpEdit edt_tool_give_tool_name;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox label_C_Inf_add;
        private System.Windows.Forms.TextBox label_C_Inf_id;
        private System.Windows.Forms.TextBox label_C_Inf_ssn;
        private System.Windows.Forms.TextBox label_C_Inf_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.LookUpEdit edt_tool_give_emploee;
        private DB_FWDDataSet2060 dB_FWDDataSet2060;
        private System.Windows.Forms.BindingSource tBMedicalgiveBindingSource;
        private DB_FWDDataSet2060TableAdapters.TB_Medical_giveTableAdapter tB_Medical_giveTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}