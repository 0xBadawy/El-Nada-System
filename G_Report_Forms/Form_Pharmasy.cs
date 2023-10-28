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

namespace FWD.G_Report_Forms
{
    public partial class Form_Pharmasy : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
         Registered_Users_View registered_rsers_view = new Registered_Users_View();
         TB_PHAR tb_phar = new TB_PHAR();
        View_Pharmasist_Info view_Pharmasist_Info = new View_Pharmasist_Info();
        view_Pharmasist_List view_Pharmasist_list = new view_Pharmasist_List();
        public Form_Pharmasy()
        {
            InitializeComponent();
            edt_doc_Date.DateTime = DateTime.Today;

            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext1.view_Pharmasist_List.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext1.view_Pharmasist_List.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Pharmasist_Info.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    Edit_Phar.Properties.DataSource = dbContext.TB_Pharmasist_Info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            if (Edit_Phar.Text == "" || edt_code.Text == "" || edt_doc_det.Text == ""|| edt_doc_Date.Text == "")
            {
                ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                ToastWaring.Show();
            }
            else
            {

                tb_phar.PHR_Patint =Convert.ToInt32( edt_code.Text);
                tb_phar.PHR_Drug = edt_doc_det.Text;
                tb_phar.PHR_Doctor = Convert.ToInt32(Edit_Phar.EditValue);
                tb_phar.PHR_Date = edt_doc_Date.DateTime;

                DataBase.TB_PHAR.Add(tb_phar);
                DataBase.SaveChanges();

                edt_doc_det.Text = "";
                edt_code.Text = "";
                Edit_Phar.Text = "";


                ToastDone.LbTitelAlterBox.Text = "تمت الاضافة";
                ToastDone.Show();
            }
            UpDate_Data();
        }

       

        private void Form_Pharmasy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2090.TB_Pharmasist_Info' table. You can move, or remove it, as needed.
         //   this.tB_Pharmasist_InfoTableAdapter.Fill(this.dB_FWDDataSet2090.TB_Pharmasist_Info);
            edt_doc_Date.DateTime = DateTime.Today;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();

            try
            {
                int RRt = Convert.ToInt32(edt_code.Text);
                registered_rsers_view = DataBase.Registered_Users_View.Where(x => x.Registered_Users_ID == RRt).FirstOrDefault();


                if (registered_rsers_view == null)
                {
                    ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                    ToastWaring.Show();
                    //  cus_id = 1;
                 }
                else
                {



                    Fill_labels_Data();


                    ToastDone.LbTitelAlterBox.Text = "هذا الاسم موجود ";
                    ToastDone.Show();
                }


            }
            catch
            {
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
                //  cus_id = 1;
                Clear_Form();

            }
        }

        private void Fill_labels_Data()
        {

            try
            {
                label_C_Inf_name.Text = registered_rsers_view.Registered_Users_Name;
                label_C_Inf_ssn.Text = registered_rsers_view.Registered_Users_Ssn;
                label_C_Inf_id.Text = registered_rsers_view.Registered_Users_ID.ToString();
                label_C_Inf_add.Text = registered_rsers_view.LOC_Name;
                label_C_Inf_add_2.Text = registered_rsers_view.LOC_Key;
                label_C_Inf_supp.Text = registered_rsers_view.SUPP_Name;
                label_C_Inf_rank.Text = registered_rsers_view.Rank_Name;

            }
            catch
            {

            }


            
        }


        private void Clear_Form()
        {
            label_C_Inf_name.Text = "";
            label_C_Inf_ssn.Text = "";
            label_C_Inf_id.Text = "";
            label_C_Inf_add.Text = "";
            label_C_Inf_add_2.Text = "";
            label_C_Inf_supp.Text = "";
            label_C_Inf_rank.Text = "";
            edt_code.Text = "";

        }

        private void Edit_Phar_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dB_FWDDataSet2090.TB_Pharmasist_Info' table. You can move, or remove it, as needed.
      //      this.tB_Pharmasist_InfoTableAdapter.Fill(this.dB_FWDDataSet2090.TB_Pharmasist_Info);
            edt_doc_Date.DateTime = DateTime.Today;
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            UpDate_Data();
        }

        private void UpDate_Data()
        {
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.view_Pharmasist_List.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    tb_phar = DataBase.TB_PHAR.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_phar).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();
                    ToastDone.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            G_Registered_Users.Form_Search_Person form_Search_Person = new G_Registered_Users.Form_Search_Person();
            form_Search_Person.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Reports.Pharmasy_Report Report = new Reports.Pharmasy_Report();
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            view_Pharmasist_list = DataBase.view_Pharmasist_List.Where(x => x.ID == id).FirstOrDefault();
             Report.DataSource = view_Pharmasist_list;
            Report.ShowPreview();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
