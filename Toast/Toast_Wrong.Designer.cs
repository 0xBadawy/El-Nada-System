
namespace FWD.Toise
{
    partial class Toast_Wrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toast_Wrong));
            this.PicAlterBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linePanel = new System.Windows.Forms.Panel();
            this.LbTitelAlterBox = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Lable_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicAlterBox
            // 
            this.PicAlterBox.Image = ((System.Drawing.Image)(resources.GetObject("PicAlterBox.Image")));
            this.PicAlterBox.Location = new System.Drawing.Point(416, 10);
            this.PicAlterBox.Name = "PicAlterBox";
            this.PicAlterBox.Size = new System.Drawing.Size(72, 66);
            this.PicAlterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAlterBox.TabIndex = 15;
            this.PicAlterBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // linePanel
            // 
            this.linePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linePanel.Location = new System.Drawing.Point(0, 78);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(5, 10);
            this.linePanel.TabIndex = 16;
            // 
            // LbTitelAlterBox
            // 
            this.LbTitelAlterBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbTitelAlterBox.AutoSize = true;
            this.LbTitelAlterBox.Font = new System.Drawing.Font("Changa SemiBold", 13.75F, System.Drawing.FontStyle.Bold);
            this.LbTitelAlterBox.Location = new System.Drawing.Point(266, 9);
            this.LbTitelAlterBox.Name = "LbTitelAlterBox";
            this.LbTitelAlterBox.Size = new System.Drawing.Size(132, 39);
            this.LbTitelAlterBox.TabIndex = 18;
            this.LbTitelAlterBox.Text = "حــــدث خــطــأ";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Lable_Text
            // 
            this.Lable_Text.BackColor = System.Drawing.Color.LightPink;
            this.Lable_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lable_Text.Font = new System.Drawing.Font("Changa", 14.25F);
            this.Lable_Text.Location = new System.Drawing.Point(11, 40);
            this.Lable_Text.Name = "Lable_Text";
            this.Lable_Text.ReadOnly = true;
            this.Lable_Text.Size = new System.Drawing.Size(399, 35);
            this.Lable_Text.TabIndex = 20;
            this.Lable_Text.Text = "حدث خطا اثناء حفظ البيانات";
            this.Lable_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Toast_Wrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(500, 87);
            this.Controls.Add(this.Lable_Text);
            this.Controls.Add(this.LbTitelAlterBox);
            this.Controls.Add(this.PicAlterBox);
            this.Controls.Add(this.linePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast_Wrong";
            this.Text = "Toast_Wrong";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Toast_Wrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicAlterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicAlterBox;
        private System.Windows.Forms.Panel linePanel;
        public System.Windows.Forms.Label LbTitelAlterBox;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.TextBox Lable_Text;
    }
}