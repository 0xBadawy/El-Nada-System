
namespace FWD.G_Medical_tools
{
    partial class Form_Midical_Return_Done
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Midical_Return_Done));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit_Lable = new System.Windows.Forms.TextBox();
            this.label_Pationt = new System.Windows.Forms.TextBox();
            this.label_Date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(144, 273);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(247, 43);
            this.simpleButton2.TabIndex = 124;
            this.simpleButton2.Text = "ارجاع الاداة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(343, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 43);
            this.label1.TabIndex = 122;
            this.label1.Text = ": اسم  مستلم الاداة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(130, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 66);
            this.label9.TabIndex = 123;
            this.label9.Text = "ارجاع اداة طبية";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(343, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 43);
            this.label2.TabIndex = 122;
            this.label2.Text = ": اسم  المريض ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(338, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 43);
            this.label4.TabIndex = 122;
            this.label4.Text = ": تاريخ تسليم الاداة";
            // 
            // Edit_Lable
            // 
            this.Edit_Lable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Edit_Lable.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Lable.Location = new System.Drawing.Point(12, 106);
            this.Edit_Lable.Name = "Edit_Lable";
            this.Edit_Lable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Edit_Lable.Size = new System.Drawing.Size(320, 39);
            this.Edit_Lable.TabIndex = 125;
            this.Edit_Lable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Pationt
            // 
            this.label_Pationt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Pationt.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_Pationt.Location = new System.Drawing.Point(12, 157);
            this.label_Pationt.Name = "label_Pationt";
            this.label_Pationt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Pationt.Size = new System.Drawing.Size(320, 39);
            this.label_Pationt.TabIndex = 126;
            // 
            // label_Date
            // 
            this.label_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_Date.Location = new System.Drawing.Point(12, 225);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(320, 26);
            this.label_Date.TabIndex = 127;
            this.label_Date.Text = "55555";
            this.label_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_Midical_Return_Done
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 327);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Pationt);
            this.Controls.Add(this.Edit_Lable);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "Form_Midical_Return_Done";
            this.Text = "Form_Midical_Return_Done";
            this.Load += new System.EventHandler(this.Form_Midical_Return_Done_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Edit_Lable;
        private System.Windows.Forms.TextBox label_Pationt;
        private System.Windows.Forms.TextBox label_Date;
    }
}