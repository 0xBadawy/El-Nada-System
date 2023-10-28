
namespace FWD.G_Waiting
{
    partial class Form_WAT_Done
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WAT_Done));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_Lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(120, 218);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(247, 43);
            this.simpleButton2.TabIndex = 118;
            this.simpleButton2.Text = "تغير حالة الانتظار";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(81, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 66);
            this.label9.TabIndex = 117;
            this.label9.Text = "تغير حالة قائمة الانتظار";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 43);
            this.label7.TabIndex = 116;
            this.label7.Text = "الحالة";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(31, 156);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("LBC", 16.25F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit1.Properties.Items.AddRange(new object[] {
            "في قائمة الانتظار",
            "تم التفيذ",
            "جارٍ التنفيذ"});
            this.textEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.textEdit1.Size = new System.Drawing.Size(413, 42);
            this.textEdit1.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(281, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 117;
            this.label1.Text = ": اسم صاحب الطلب";
            // 
            // Edit_Lable
            // 
            this.Edit_Lable.AutoSize = true;
            this.Edit_Lable.Font = new System.Drawing.Font("Changa SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Lable.Location = new System.Drawing.Point(69, 100);
            this.Edit_Lable.Name = "Edit_Lable";
            this.Edit_Lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Edit_Lable.Size = new System.Drawing.Size(211, 35);
            this.Edit_Lable.TabIndex = 117;
            this.Edit_Lable.Text = "محمد بدوى سيد عبدالرحيم";
            this.Edit_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_WAT_Done
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 273);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.Edit_Lable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEdit1);
            this.Name = "Form_WAT_Done";
            this.Text = "Form_WAT_Done";
            this.Load += new System.EventHandler(this.Form_WAT_Done_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Edit_Lable;
    }
}