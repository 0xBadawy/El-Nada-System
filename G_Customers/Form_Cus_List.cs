using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraReports.UI;

namespace FWD.G_Customers
{
    public partial class Form_Cus_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();

        TB_CUST_Person tb_cust_person = new TB_CUST_Person();
        //  TB_CUS_Family_Member tb_family = new TB_CUS_Family_Member();
        public Form_Cus_List()
        {
            InitializeComponent();


            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext2.View_CUST_Main_data_01.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext2.View_CUST_Main_data_01.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;

        }

        private void gridControl1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "Rank_Name")
                {
                    string cellValue = e.CellValue.ToString();
                    if (cellValue == "غير مستحق")
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "حالة ( أ )")
                    {
                        e.Appearance.BackColor = Color.MediumSeaGreen;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "حالة ( جـ )")
                    {
                        e.Appearance.BackColor = Color.MediumAquamarine;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "حالة ( ب )")
                    {
                        e.Appearance.BackColor = Color.DarkSeaGreen;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "حالة ( د )")
                    {
                        e.Appearance.BackColor = Color.MediumTurquoise;
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
            catch
            {



            }
        }



        private void Form_Cus_List_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {/*
            var rs = MessageBox.Show("عملية تعديل", "هل انت متاكد من عملية التعديل", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes){
                Reports.XtraReport4 report = new Reports.XtraReport4();
                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Main_ID"));
                tb_cust_person = DataBase.TB_CUST_Person.Where(x => x.CUST_Main_ID == id).FirstOrDefault();
                report.DataSource = tb_cust_person;
                report.ShowDesigner();
            }*/
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        { /*
            Reports.Report_Customer report = new Reports.Report_Customer();

            
              int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Main_ID"));
            tb_cust_person = DataBase.TB_CUST_Person.Where(x => x.CUST_Main_ID == id).FirstOrDefault();
      //      tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK == id).FirstOrDefault();
            report.DataSource = tb_cust_person;

    //        report.DetailReport.DataSource = tb_family;

            //    report.ShowPreview();

            report.ShowPreviewDialog();
           // view_Doctor_Report = DataBase.View_Doctor_report.Where(x => x.ID == id).FirstOrDefault();*/
            gridControl1.ShowPrintPreview();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //  TB_CUS_Family_Member tb_family = new TB_CUS_Family_Member(); 
            Reports.XtraReport4 report = new Reports.XtraReport4();

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Main_ID"));
            tb_cust_person = DataBase.TB_CUST_Person.Where(x => x.CUST_Main_ID == id).FirstOrDefault();
            report.DataSource = tb_cust_person;

            //   tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK == id).ToList();
            //     tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK == id).ToList();
            // report.DetailReport.DataSource = TB_CUS_Family_Member;
            //       List<TB_CUS_Family_Member> tb_family = DataBase.TB_CUS_Family_Member.Where(x => x.CUST_Family_Member_PK >0).ToList();


            //    report.DetailReport.DataSource = tb_family; 
            report.ShowPreview();
            //   report.ShowDesigner();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private int rr = 0;
        private void panel3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
/*
 *  Reports.Doctor_Report_3 Report = new Reports.Doctor_Report_3();
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
           Report.DataSource = view_Doctor_Report;
           Report.ShowPreview();
         //   Report.ShowDesigner();*/