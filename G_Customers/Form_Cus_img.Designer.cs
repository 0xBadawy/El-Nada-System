
namespace FWD.G_Customers
{
    partial class Form_Cus_img
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_img));
            this.panel_Form_Cus_file = new System.Windows.Forms.Panel();
            this.Button_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Form_Cus_file.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Form_Cus_file
            // 
            this.panel_Form_Cus_file.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_file.Controls.Add(this.Button_Add);
            this.panel_Form_Cus_file.Controls.Add(this.label1);
            this.panel_Form_Cus_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_file.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_file.Name = "panel_Form_Cus_file";
            this.panel_Form_Cus_file.Size = new System.Drawing.Size(1468, 831);
            this.panel_Form_Cus_file.TabIndex = 5;
            // 
            // Button_Add
            // 
            this.Button_Add.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Button_Add.Appearance.Options.UseFont = true;
            this.Button_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Button_Add.ImageOptions.Image")));
            this.Button_Add.Location = new System.Drawing.Point(635, 651);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(252, 50);
            this.Button_Add.TabIndex = 53;
            this.Button_Add.Text = "اضافة";
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(532, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 72);
            this.label1.TabIndex = 50;
            this.label1.Text = "اضافة ملفات الاسرة";
            // 
            // Form_Cus_img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 831);
            this.Controls.Add(this.panel_Form_Cus_file);
            this.Name = "Form_Cus_img";
            this.Text = "Form_Cus_img";
            this.panel_Form_Cus_file.ResumeLayout(false);
            this.panel_Form_Cus_file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Form_Cus_file;
        private DevExpress.XtraEditors.SimpleButton Button_Add;
        private System.Windows.Forms.Label label1;
    }
}