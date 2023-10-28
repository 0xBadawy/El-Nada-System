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

namespace FWD.G_Donations
{
    public partial class Form_Donation_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_DON tb_don = new TB_DON();
        TB_FIN tb_fin = new TB_FIN();
        View_Donation_List_New view_Donation_List_New = new View_Donation_List_New();
        public Form_Donation_Add()
        {
            InitializeComponent(); 
            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities(); 
            dbContext2.View_Donation_List_New.LoadAsync().ContinueWith(loadTask =>{
                 gridControl1.DataSource = dbContext2.View_Donation_List_New.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
          
            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
             dbContext1.TB_Donner_info.LoadAsync().ContinueWith(loadTask =>{
                 edt_don_name.Properties.DataSource = dbContext1.TB_Donner_info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
             
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
             dbContext.TB_Donation_Dirction.LoadAsync().ContinueWith(loadTask =>{
                edt_don_dir.Properties.DataSource = dbContext.TB_Donation_Dirction.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void Pn_frm_wat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متاكد من ايداع هذا المبلغ", "عملية تبرع ", MessageBoxButtons.YesNoCancel);

            if (rs == DialogResult.Yes){

                Toise.Toast_Done ToastDone = new Toise.Toast_Done();
                Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
                Toast.Toast_Del ToastDel = new Toast.Toast_Del();

                if (edt_cat_val.Text == "" || edt_don_dir.Text == "" || charity_Recever.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else
                {
                    tb_don.DON_Amount = Convert.ToDouble(edt_cat_val.Text);

                    tb_don.DON_Amo_txt = edt_don_val_w.Text;
                    tb_don.DON_Date = DateTime.Today;
                    tb_don.DON_Dir =Convert.ToInt32 (edt_don_dir.EditValue);
                    tb_don.DON_Name = Convert.ToInt32( edt_don_name.EditValue);
                    tb_don.DON_Resever = Convert.ToInt32( charity_Recever.EditValue);

                    //التخزين فى التبرعات بس
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 1).FirstOrDefault();
                    double BAmount = tb_fin.FIN_Amount.Value;
                    double Amount = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount + Amount;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;


                    //التخزين فى الاجمالى 
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 3).FirstOrDefault();
                    double BAmount1 = tb_fin.FIN_Amount.Value;
                    double Amount1 = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount1 + Amount1;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;


                    DataBase.TB_DON.Add(tb_don);
                    DataBase.SaveChanges();

                    ToastDone.LbTitelAlterBox.Text = "تم التبرع بالمبلغ";
                    ToastDone.Show();

                    edt_cat_val.Text = "";
                    edt_don_val_w.Text = "";
                    edt_don_dir.Text = "";
                    edt_don_name.Text = "";
                    charity_Recever.Text = "";

                }
            }
        }



        private string NumberToWords(int number)
        {
            Toise.Toast_Wrong ToastWrong = new Toise.Toast_Wrong();
            try{
                if (number == 0) return "صفر";
                string words = "";
                if ((number / 1000000) > 0){
                    words += NumberToWords(number / 1000000) + " مليون ";
                    number %= 1000000;
                }

                if ((number / 1000) > 0){
                    words += NumberToWords(number / 1000) + " ألف ";
                    number %= 1000;
                }

                if ((number / 100) > 0){
                    words += NumberToWords(number / 100) + " مائة ";
                    number %= 100;
                }

                if (number > 0){
                    if (words != "")words += "و ";
                    var unitsMap = new[] { "صفر", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة" };
                    var tensMap = new[] { "صفر", "عشرة", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };

                    if (number < 10) words += unitsMap[number];
                    else if (number < 20) words += unitsMap[number % 10] + " عشر";
                    else{
                        words += tensMap[number / 10];
                        if ((number % 10) > 0)words += " و " + unitsMap[number % 10];
                    }
                }
                
                return words;
            }
            catch{
                ToastWrong.Lable_Text.Text = "المبلغ غير صالح";
                ToastWrong.Show();
                return " ";
            }
        }

        private void edt_don_dir_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void edt_cat_val_EditValueChanged(object sender, EventArgs e)
        {
            try { 
                if (edt_cat_val.Text.Length > 0){
                    int x = Convert.ToInt32(edt_cat_val.Text);
                    string t= NumberToWords(x);
                    edt_don_val_w.Text = t+" جنية مصري لا غير ";
                }
            }
            catch{}
        }

        private void btn_ref_Click(object sender, EventArgs e){
            UpDate_Data();

            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            dbContext2.View_Donation_List_New.LoadAsync().ContinueWith(loadTask => {
                gridControl1.DataSource = dbContext2.View_Donation_List_New.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            dbContext1.TB_Donner_info.LoadAsync().ContinueWith(loadTask => {
                edt_don_name.Properties.DataSource = dbContext1.TB_Donner_info.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.TB_Donation_Dirction.LoadAsync().ContinueWith(loadTask => {
                edt_don_dir.Properties.DataSource = dbContext.TB_Donation_Dirction.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void UpDate_Data(){
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.View_Donation_List_New.ToList();
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
                    tb_don = DataBase.TB_DON.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_don).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();

                    ToastDel.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Print_Report();
        }


        private void Print_Report()
        {
            Reports.Report_Donation Report = new Reports.Report_Donation();
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            view_Donation_List_New = DataBase.View_Donation_List_New.Where(x => x.ID == id).FirstOrDefault();
            Report.DataSource = view_Donation_List_New;
            Report.ShowPreview();
        }
        private void Form_Donation_Add_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2096.TB_Emploee' table. You can move, or remove it, as needed.
        //    this.tB_EmploeeTableAdapter.Fill(this.dB_FWDDataSet2096.TB_Emploee);
            Getdata();

        }

        private void Pn_frm_don_MouseHover(object sender, EventArgs e)
        {
            Getdata();
        }

        private void edt_don_name_EditValueChanged(object sender, EventArgs e)
        {
            Getdata();
        }


        private void Getdata()
        {
            //  this.tB_Donation_DirctionTableAdapter.Fill(this.dB_FWDDataSet2053.TB_Donation_Dirction);
            //        this.tB_Donner_infoTableAdapter.Fill(this.dB_FWDDataSet2052.TB_Donner_info);
           

        }

        private void edt_don_name_Click(object sender, EventArgs e)
        {
            Getdata();///
        }

        private void edt_don_dir_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void edt_cat_val_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (edt_cat_val.Text.Length > 0)
                {
                    int x = Convert.ToInt32(edt_cat_val.Text);
                    string t = NumberToWords(x);
                    edt_don_val_w.Text = t + " جنية مصري لا غير ";
                }
            }
            catch { }

        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("هل انت متاكد من ايداع هذا المبلغ", "عملية تبرع ", MessageBoxButtons.YesNoCancel);

            if (rs == DialogResult.Yes)
            {

                Toise.Toast_Done ToastDone = new Toise.Toast_Done();
                Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
                Toast.Toast_Del ToastDel = new Toast.Toast_Del();

                if (edt_cat_val.Text == "" || edt_don_dir.Text == "" || charity_Recever.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else
                {
                    tb_don.DON_Amount = Convert.ToDouble(edt_cat_val.Text);

                    tb_don.DON_Amo_txt = edt_don_val_w.Text;
                    tb_don.DON_Date = DateTime.Today;
                    tb_don.DON_Dir = Convert.ToInt32(edt_don_dir.EditValue);
                    tb_don.DON_Name = Convert.ToInt32(edt_don_name.EditValue);
                    tb_don.DON_Resever = Class_main.emp_login_id;
                    // tb_don.DON_Resever = Convert.ToInt32(charity_Recever.EditValue);

                    //التخزين فى التبرعات بس
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 1).FirstOrDefault();
                    double BAmount = tb_fin.FIN_Amount.Value;
                    double Amount = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount + Amount;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;


                    //التخزين فى الاجمالى 
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 3).FirstOrDefault();
                    double BAmount1 = tb_fin.FIN_Amount.Value;
                    double Amount1 = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount1 + Amount1;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;


                    DataBase.TB_DON.Add(tb_don);
                    DataBase.SaveChanges();

                    UpDate_Data();
                    Print_Report();


                    ToastDone.LbTitelAlterBox.Text = "تم التبرع بالمبلغ";
                    ToastDone.Show();

                    edt_cat_val.Text = "";
                    edt_don_val_w.Text = "";
                    edt_don_dir.Text = "";
                    edt_don_name.Text = "";
                    charity_Recever.Text = "";

                }


            }


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Form_Donner_Add Donner = new Form_Donner_Add();
            Donner.Show();
        }

        private void charity_Recever_Click(object sender, EventArgs e)
        {
            this.tB_EmploeeTableAdapter.Fill(this.dB_FWDDataSet2096.TB_Emploee);

        }

        private void charity_Recever_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}
