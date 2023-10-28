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

namespace FWD.G_Waiting
{
    public partial class Form_Wat_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_WAT tb_wat = new TB_WAT();
        TB_SUPP tb_supp = new TB_SUPP();
        DateTime Birth;
        public Form_Wat_Add()
        {
            InitializeComponent();
            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
             dbContext1.TB_WL_CAT.LoadAsync().ContinueWith(loadTask =>{
                 edt_cat.Properties.DataSource = dbContext1.TB_WL_CAT.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
           
            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            dbContext2.TBE_LOC.LoadAsync().ContinueWith(loadTask =>{
                 edt_add.Properties.DataSource = dbContext2.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
             dbContext.TB_SUPP.LoadAsync().ContinueWith(loadTask =>{
                edt_supp.Properties.DataSource = dbContext.TB_SUPP.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Form_Wat_Add_Load(object sender, EventArgs e)
        {
            try{
                 this.tB_SUPPTableAdapter1.Fill(this.dB_FWDDataSet2024.TB_SUPP);
                 this.tBE_LOCTableAdapter1.Fill(this.dB_FWDDataSet2023.TBE_LOC);
                 this.tB_WL_CATTableAdapter.Fill(this.dB_FWDDataSet2022.TB_WL_CAT);
                 this.tB_SUPPTableAdapter.Fill(this.supp.TB_SUPP);
                 this.tBE_LOCTableAdapter.Fill(this.location.TBE_LOC);
            }
            catch
            {

            }          
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            if (edt_ssn.Text != "" && edt_name.Text != "" && edt_cat.Text!=""){
                try{
                    tb_wat.WAT_Add = Convert.ToInt32(edt_add.EditValue);
                    tb_wat.WAT_Cat = Convert.ToInt32(edt_cat.EditValue);
                    tb_wat.WAT_Date_Order = DateTime.Today;
                    tb_wat.WAT_Det = edt_det.Text;
                    tb_wat.WAT_Name = edt_name.Text;
                    tb_wat.WAT_Phone1 = edt_phone1.Text;
                    tb_wat.WAT_Phone2 = edt_phone2.Text;
                    tb_wat.WAT_SSN = edt_ssn.Text;
                    tb_wat.WAT_Supp_name = Convert.ToInt32(edt_supp.EditValue);
                    tb_wat.WAT_Done_state = "في قائمة الانتظار";
                    tb_wat.WAT_Date_Bairth = Birth;


                    DataBase.TB_WAT.Add(tb_wat);
                    DataBase.SaveChanges();

                    ToastDone.LbTitelAlterBox.Text = "تمت الاضافة الى القائمة ";
                    ToastDone.Show();
                    clear();
                }
                catch
                {
                    ToastWaring.Lable_Text.Text = "حدث خطا اثناء الحفظ , تاكد من كل البيانات";
                    ToastWaring.Show();
                }

            }
            else
            {
                ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                ToastWaring.Show();
            }



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void edt_supp_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void edt_name_EditValueChanged(object sender, EventArgs e)
        {

        }


        public DateTime SSN(string x)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            try
            {
                int birthYear = int.Parse(x.Substring(1, 2));
                int birthMonth = int.Parse(x.Substring(3, 2));
                int birthDay = int.Parse(x.Substring(5, 2));

                int century = int.Parse(x[0].ToString());
                if (century == 2)
                {
                    birthYear += 1900;
                }
                else if (century == 3)
                {
                    birthYear += 2000;
                }

                DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
                return birthDate;

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "الرقم القومى غير صحيح";
                ToastWaring.Show();
                return DateTime.Now;
            }
        }

        private void edt_ssn_EditValueChanged(object sender, EventArgs e)
        {

            string x = edt_ssn.Text;
            if (x.Length == 14) Birth = SSN(x);
        }

        private void Paner_wat_add_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear()
        {
             edt_add.Text = ""; ;
             edt_cat.Text = "";
            edt_det.Text="";
             edt_name.Text = "";
              edt_phone1.Text = "";
             edt_phone2.Text = "";
              edt_ssn.Text = "";
            edt_supp.Text = "";

        }


    }
}
