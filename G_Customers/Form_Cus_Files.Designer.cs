
namespace FWD.G_Customers
{
    partial class Form_Cus_Files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cus_Files));
            this.panel_Form_Cus_file = new System.Windows.Forms.Panel();
            this.Button_Add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureEdit_Front = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureEdit_Back = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_Form_Cus_file.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Front.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Back.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Form_Cus_file
            // 
            this.panel_Form_Cus_file.AutoScroll = true;
            this.panel_Form_Cus_file.BackColor = System.Drawing.Color.White;
            this.panel_Form_Cus_file.Controls.Add(this.Button_Add);
            this.panel_Form_Cus_file.Controls.Add(this.groupBox1);
            this.panel_Form_Cus_file.Controls.Add(this.label1);
            this.panel_Form_Cus_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form_Cus_file.Location = new System.Drawing.Point(0, 0);
            this.panel_Form_Cus_file.Name = "panel_Form_Cus_file";
            this.panel_Form_Cus_file.Size = new System.Drawing.Size(1651, 822);
            this.panel_Form_Cus_file.TabIndex = 4;
            this.panel_Form_Cus_file.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Cus_file_Paint);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(195, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1186, 374);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureEdit_Front);
            this.groupBox3.Location = new System.Drawing.Point(605, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 315);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الوجة";
            // 
            // pictureEdit_Front
            // 
            this.pictureEdit_Front.EditValue = ((object)(resources.GetObject("pictureEdit_Front.EditValue")));
            this.pictureEdit_Front.Location = new System.Drawing.Point(6, 27);
            this.pictureEdit_Front.Name = "pictureEdit_Front";
            this.pictureEdit_Front.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Front.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit_Front.Size = new System.Drawing.Size(511, 281);
            this.pictureEdit_Front.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureEdit_Back);
            this.groupBox2.Location = new System.Drawing.Point(16, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 315);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الظهر";
            // 
            // pictureEdit_Back
            // 
            this.pictureEdit_Back.EditValue = ((object)(resources.GetObject("pictureEdit_Back.EditValue")));
            this.pictureEdit_Back.Location = new System.Drawing.Point(7, 28);
            this.pictureEdit_Back.Name = "pictureEdit_Back";
            this.pictureEdit_Back.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Back.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit_Back.Size = new System.Drawing.Size(511, 281);
            this.pictureEdit_Back.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Changa SemiBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(623, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 72);
            this.label1.TabIndex = 50;
            this.label1.Text = "اضافة ملفات الاسرة";
            this.label1.Click += new System.EventHandler(this.label12_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Cus_Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 822);
            this.Controls.Add(this.panel_Form_Cus_file);
            this.Name = "Form_Cus_Files";
            this.Text = "Form_Cus_Files";
            this.panel_Form_Cus_file.ResumeLayout(false);
            this.panel_Form_Cus_file.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Front.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Back.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_Form_Cus_file;
        private DevExpress.XtraEditors.SimpleButton Button_Add;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Front;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}