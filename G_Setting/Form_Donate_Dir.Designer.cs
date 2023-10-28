
namespace FWD.G_Setting
{
    partial class Form_Donate_Dir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Donate_Dir));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDonation_Dir_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_Text_1 = new DevExpress.XtraEditors.TextEdit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Text_1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.Btn_Add);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Edit_Text_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 641);
            this.panel2.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.TB_Donation_Dirction);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gridControl1.Location = new System.Drawing.Point(0, 334);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(604, 307);
            this.gridControl1.TabIndex = 80;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDonation_Dir_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDonation_Dir_Name
            // 
            this.colDonation_Dir_Name.Caption = "اسم جهه التبرع";
            this.colDonation_Dir_Name.FieldName = "Donation_Dir_Name";
            this.colDonation_Dir_Name.Name = "colDonation_Dir_Name";
            this.colDonation_Dir_Name.Visible = true;
            this.colDonation_Dir_Name.VisibleIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.Appearance.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Add.Appearance.Options.UseFont = true;
            this.Btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.ImageOptions.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(161, 253);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(292, 43);
            this.Btn_Add.TabIndex = 9;
            this.Btn_Add.Text = "اضــافــة";
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Changa SemiBold", 23.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(182, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 66);
            this.label9.TabIndex = 79;
            this.label9.Text = "اضافة جهة تبرع ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Changa SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 43);
            this.label2.TabIndex = 72;
            this.label2.Text = "الاسم";
            // 
            // Edit_Text_1
            // 
            this.Edit_Text_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit_Text_1.EditValue = "";
            this.Edit_Text_1.Location = new System.Drawing.Point(85, 125);
            this.Edit_Text_1.Name = "Edit_Text_1";
            this.Edit_Text_1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Edit_Text_1.Properties.Appearance.Options.UseFont = true;
            this.Edit_Text_1.Properties.Appearance.Options.UseTextOptions = true;
            this.Edit_Text_1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Edit_Text_1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Edit_Text_1.Size = new System.Drawing.Size(390, 40);
            this.Edit_Text_1.TabIndex = 1;
            // 
            // Form_Donate_Dir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 641);
            this.Controls.Add(this.panel2);
            this.Name = "Form_Donate_Dir";
            this.Text = "اضافة جهة تبرع ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Text_1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Btn_Add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit Edit_Text_1;
        private DevExpress.XtraGrid.Columns.GridColumn colDonation_Dir_Name;
    }
}