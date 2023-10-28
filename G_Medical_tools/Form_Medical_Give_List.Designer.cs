
namespace FWD.G_Medical_tools
{
    partial class Form_Medical_Give_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Medical_Give_List));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pn_frm_cat = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedical_give_return_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_return_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_charity_recever = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOC_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kdsf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_recever_ssn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_recever_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_recever = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_give_patient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedical_tool_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ref = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.Pn_frm_cat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pn_frm_cat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 849);
            this.panel1.TabIndex = 0;
            // 
            // Pn_frm_cat
            // 
            this.Pn_frm_cat.Controls.Add(this.gridControl1);
            this.Pn_frm_cat.Controls.Add(this.panel2);
            this.Pn_frm_cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pn_frm_cat.Location = new System.Drawing.Point(0, 0);
            this.Pn_frm_cat.Name = "Pn_frm_cat";
            this.Pn_frm_cat.Size = new System.Drawing.Size(1566, 849);
            this.Pn_frm_cat.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(FWD.View_Medical_Give_List);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1566, 790);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Changa", 14.25F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.AppearancePrint.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridView1.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.AppearancePrint.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.AppearancePrint.Preview.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView1.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedical_give_return_Date,
            this.colMedical_give_return_status,
            this.colMedical_give_charity_recever,
            this.colMedical_give_date,
            this.colLOC_Name,
            this.kdsf,
            this.colMedical_give_recever_ssn,
            this.colMedical_give_recever_phone,
            this.colMedical_give_recever,
            this.colMedical_give_patient,
            this.colMedical_tool_Name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMedical_give_return_Date
            // 
            this.colMedical_give_return_Date.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_return_Date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_return_Date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_return_Date.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_return_Date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_return_Date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_return_Date.Caption = "تاريخ الارجاع";
            this.colMedical_give_return_Date.FieldName = "Medical_give_return_Date";
            this.colMedical_give_return_Date.Name = "colMedical_give_return_Date";
            this.colMedical_give_return_Date.Visible = true;
            this.colMedical_give_return_Date.VisibleIndex = 0;
            this.colMedical_give_return_Date.Width = 122;
            // 
            // colMedical_give_return_status
            // 
            this.colMedical_give_return_status.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_return_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_return_status.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_return_status.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_return_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_return_status.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_return_status.Caption = "الحالة";
            this.colMedical_give_return_status.FieldName = "Medical_give_return_status";
            this.colMedical_give_return_status.Name = "colMedical_give_return_status";
            this.colMedical_give_return_status.Visible = true;
            this.colMedical_give_return_status.VisibleIndex = 1;
            this.colMedical_give_return_status.Width = 118;
            // 
            // colMedical_give_charity_recever
            // 
            this.colMedical_give_charity_recever.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_charity_recever.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_charity_recever.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_charity_recever.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_charity_recever.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_charity_recever.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_charity_recever.Caption = "الموظف";
            this.colMedical_give_charity_recever.FieldName = "Medical_give_charity_recever";
            this.colMedical_give_charity_recever.Name = "colMedical_give_charity_recever";
            this.colMedical_give_charity_recever.Visible = true;
            this.colMedical_give_charity_recever.VisibleIndex = 6;
            this.colMedical_give_charity_recever.Width = 108;
            // 
            // colMedical_give_date
            // 
            this.colMedical_give_date.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_date.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_date.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_date.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_date.Caption = "تاريخ التسليم";
            this.colMedical_give_date.FieldName = "Medical_give_date";
            this.colMedical_give_date.Name = "colMedical_give_date";
            this.colMedical_give_date.Visible = true;
            this.colMedical_give_date.VisibleIndex = 3;
            this.colMedical_give_date.Width = 121;
            // 
            // colLOC_Name
            // 
            this.colLOC_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colLOC_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOC_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLOC_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colLOC_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLOC_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colLOC_Name.Caption = "العنوان";
            this.colLOC_Name.FieldName = "LOC_Name";
            this.colLOC_Name.Name = "colLOC_Name";
            this.colLOC_Name.Visible = true;
            this.colLOC_Name.VisibleIndex = 2;
            this.colLOC_Name.Width = 123;
            // 
            // kdsf
            // 
            this.kdsf.AppearanceCell.Options.UseTextOptions = true;
            this.kdsf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.kdsf.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.kdsf.AppearanceHeader.Options.UseTextOptions = true;
            this.kdsf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.kdsf.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.kdsf.Caption = "ID";
            this.kdsf.FieldName = "Medical_give_ID";
            this.kdsf.Name = "kdsf";
            this.kdsf.Visible = true;
            this.kdsf.VisibleIndex = 10;
            this.kdsf.Width = 56;
            // 
            // colMedical_give_recever_ssn
            // 
            this.colMedical_give_recever_ssn.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_recever_ssn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_recever_ssn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever_ssn.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_recever_ssn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_recever_ssn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever_ssn.Caption = "الرقم القومى";
            this.colMedical_give_recever_ssn.FieldName = "Medical_give_recever_ssn";
            this.colMedical_give_recever_ssn.Name = "colMedical_give_recever_ssn";
            this.colMedical_give_recever_ssn.Visible = true;
            this.colMedical_give_recever_ssn.VisibleIndex = 5;
            this.colMedical_give_recever_ssn.Width = 201;
            // 
            // colMedical_give_recever_phone
            // 
            this.colMedical_give_recever_phone.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_recever_phone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_recever_phone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever_phone.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_recever_phone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_recever_phone.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever_phone.Caption = "رقم الهاتف";
            this.colMedical_give_recever_phone.FieldName = "Medical_give_recever_phone";
            this.colMedical_give_recever_phone.Name = "colMedical_give_recever_phone";
            this.colMedical_give_recever_phone.Visible = true;
            this.colMedical_give_recever_phone.VisibleIndex = 4;
            this.colMedical_give_recever_phone.Width = 151;
            // 
            // colMedical_give_recever
            // 
            this.colMedical_give_recever.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_recever.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMedical_give_recever.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_recever.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_recever.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_recever.Caption = "اسم المستلم";
            this.colMedical_give_recever.FieldName = "Medical_give_recever";
            this.colMedical_give_recever.Name = "colMedical_give_recever";
            this.colMedical_give_recever.Visible = true;
            this.colMedical_give_recever.VisibleIndex = 7;
            this.colMedical_give_recever.Width = 149;
            // 
            // colMedical_give_patient
            // 
            this.colMedical_give_patient.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_give_patient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMedical_give_patient.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_patient.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_give_patient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_give_patient.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_give_patient.Caption = "اسم المريض";
            this.colMedical_give_patient.FieldName = "Medical_give_patient";
            this.colMedical_give_patient.Name = "colMedical_give_patient";
            this.colMedical_give_patient.Visible = true;
            this.colMedical_give_patient.VisibleIndex = 8;
            this.colMedical_give_patient.Width = 170;
            // 
            // colMedical_tool_Name
            // 
            this.colMedical_tool_Name.AppearanceCell.Options.UseTextOptions = true;
            this.colMedical_tool_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMedical_tool_Name.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_tool_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colMedical_tool_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMedical_tool_Name.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMedical_tool_Name.Caption = "اسم الاداة";
            this.colMedical_tool_Name.FieldName = "Medical_tool_Name";
            this.colMedical_tool_Name.Name = "colMedical_tool_Name";
            this.colMedical_tool_Name.Visible = true;
            this.colMedical_tool_Name.VisibleIndex = 9;
            this.colMedical_tool_Name.Width = 217;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Controls.Add(this.btn_edt);
            this.panel2.Controls.Add(this.btn_ref);
            this.panel2.Controls.Add(this.btn_del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 790);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1566, 59);
            this.panel2.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(884, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(376, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "ارجاع الاداة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(535, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(144, 44);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btn_edt
            // 
            this.btn_edt.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edt.Appearance.Options.UseFont = true;
            this.btn_edt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edt.ImageOptions.Image")));
            this.btn_edt.Location = new System.Drawing.Point(356, 6);
            this.btn_edt.Name = "btn_edt";
            this.btn_edt.Size = new System.Drawing.Size(144, 44);
            this.btn_edt.TabIndex = 0;
            this.btn_edt.Text = "تعديل";
            this.btn_edt.Click += new System.EventHandler(this.btn_edt_Click);
            // 
            // btn_ref
            // 
            this.btn_ref.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ref.Appearance.Options.UseFont = true;
            this.btn_ref.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ref.ImageOptions.Image")));
            this.btn_ref.Location = new System.Drawing.Point(187, 7);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(144, 44);
            this.btn_ref.TabIndex = 0;
            this.btn_ref.Text = "تحديث";
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_del
            // 
            this.btn_del.Appearance.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.ImageOptions.Image")));
            this.btn_del.Location = new System.Drawing.Point(12, 7);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 44);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "حذف";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Form_Medical_Give_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 849);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Medical_Give_List";
            this.Text = "Form_Medical_Give_List";
            this.Load += new System.EventHandler(this.Form_Medical_Give_List_Load);
            this.panel1.ResumeLayout(false);
            this.Pn_frm_cat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel Pn_frm_cat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ref;
        private DevExpress.XtraGrid.Columns.GridColumn kdsf;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_tool_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_patient;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_recever;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_recever_phone;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_recever_ssn;
        private DevExpress.XtraGrid.Columns.GridColumn colLOC_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_date;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_charity_recever;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_return_status;
        private DevExpress.XtraGrid.Columns.GridColumn colMedical_give_return_Date;
        public DevExpress.XtraEditors.SimpleButton btn_edt;
        public DevExpress.XtraEditors.SimpleButton btn_del;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}