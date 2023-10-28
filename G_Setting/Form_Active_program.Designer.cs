
namespace FWD.G_Setting
{
    partial class Form_Active_program
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Active_program));
            this.txtMacAddress = new DevExpress.XtraEditors.TextEdit();
            this.Edit_Key = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.barCode = new DevExpress.XtraEditors.BarCodeControl();
            this.MacHexa = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Acctive = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMacAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Key.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.Location = new System.Drawing.Point(563, 143);
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMacAddress.Properties.Appearance.Options.UseFont = true;
            this.txtMacAddress.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMacAddress.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMacAddress.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtMacAddress.Size = new System.Drawing.Size(433, 40);
            this.txtMacAddress.TabIndex = 0;
            this.txtMacAddress.EditValueChanged += new System.EventHandler(this.txtMacAddress_EditValueChanged);
            // 
            // Edit_Key
            // 
            this.Edit_Key.Location = new System.Drawing.Point(563, 289);
            this.Edit_Key.Name = "Edit_Key";
            this.Edit_Key.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Key.Properties.Appearance.Options.UseFont = true;
            this.Edit_Key.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Key.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Key.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Key.Size = new System.Drawing.Size(433, 40);
            this.Edit_Key.TabIndex = 0;
            this.Edit_Key.EditValueChanged += new System.EventHandler(this.txtMacAddress_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "تفعيل البرنامج";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.barCode);
            this.groupControl1.Controls.Add(this.MacHexa);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.DateText);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(20, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(473, 381);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Changa", 15.75F);
            this.label6.Location = new System.Drawing.Point(332, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 43);
            this.label6.TabIndex = 4;
            this.label6.Text = ": كود البرنامج";
            // 
            // barCode
            // 
            this.barCode.AutoModule = true;
            this.barCode.Location = new System.Drawing.Point(16, 270);
            this.barCode.Name = "barCode";
            this.barCode.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCode.ShowText = false;
            this.barCode.Size = new System.Drawing.Size(433, 98);
            this.barCode.Symbology = code128Generator1;
            this.barCode.TabIndex = 2;
            // 
            // MacHexa
            // 
            this.MacHexa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MacHexa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MacHexa.Enabled = false;
            this.MacHexa.Font = new System.Drawing.Font("Microsoft YaHei", 17.25F);
            this.MacHexa.Location = new System.Drawing.Point(30, 135);
            this.MacHexa.Name = "MacHexa";
            this.MacHexa.Size = new System.Drawing.Size(291, 31);
            this.MacHexa.TabIndex = 1;
            this.MacHexa.Text = "5145474787";
            this.MacHexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 17.25F);
            this.textBox1.Location = new System.Drawing.Point(30, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "5145474787";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DateText
            // 
            this.DateText.AutoSize = true;
            this.DateText.BackColor = System.Drawing.Color.Transparent;
            this.DateText.Font = new System.Drawing.Font("Microsoft YaHei", 17.25F);
            this.DateText.Location = new System.Drawing.Point(95, 206);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(165, 30);
            this.DateText.TabIndex = 1;
            this.DateText.Text = "15 / 10 / 2002";
            this.DateText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Changa", 15.75F);
            this.label5.Location = new System.Drawing.Point(332, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 43);
            this.label5.TabIndex = 1;
            this.label5.Text = ": تاريخ التثبيت";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Changa", 15.75F);
            this.label2.Location = new System.Drawing.Point(332, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = ": كود النسخة";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Acctive
            // 
            this.Acctive.Appearance.Font = new System.Drawing.Font("Changa", 14.75F);
            this.Acctive.Appearance.Options.UseFont = true;
            this.Acctive.Location = new System.Drawing.Point(666, 375);
            this.Acctive.Name = "Acctive";
            this.Acctive.Size = new System.Drawing.Size(232, 44);
            this.Acctive.TabIndex = 4;
            this.Acctive.Text = "تفعيل البرنامج";
            this.Acctive.Click += new System.EventHandler(this.Acctive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Changa", 14.75F);
            this.label3.Location = new System.Drawing.Point(882, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "رقم النسخة";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa", 14.75F);
            this.label4.Location = new System.Drawing.Point(879, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "رقم التفعيل";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Acctive);
            this.panel1.Controls.Add(this.txtMacAddress);
            this.panel1.Controls.Add(this.Edit_Key);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 450);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa", 24.75F);
            this.label7.Location = new System.Drawing.Point(569, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 67);
            this.label7.TabIndex = 1;
            this.label7.Text = "تم تفعيل البرنامج بنجاح";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Changa", 14.75F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(8, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(34, 36);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form_Active_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Active_program";
            this.Text = "تفعيل البرنامج";
            this.Load += new System.EventHandler(this.Form_Active_program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMacAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Key.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMacAddress;
        private DevExpress.XtraEditors.TextEdit Edit_Key;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Acctive;
        private DevExpress.XtraEditors.BarCodeControl barCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MacHexa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}