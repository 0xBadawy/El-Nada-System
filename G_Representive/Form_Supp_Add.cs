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

namespace FWD.G_Representive
{
    public partial class Form_Supp_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_SUPP tb_supp = new TB_SUPP();

        public int Supp_ID = 0;
        public Form_Supp_Add()
        {
            InitializeComponent();
            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
             dbContext1.TBE_LOC.LoadAsync().ContinueWith(loadTask => {
                 edt_supp_add.Properties.DataSource = dbContext1.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


             FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
             dbContext.TBE_LOC.LoadAsync().ContinueWith(loadTask =>
            {
            edt_supp_retion.Properties.DataSource = dbContext.TBE_LOC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Form_Supp_Add_Load(object sender, EventArgs e){       
            /*this.tBE_LOCTableAdapter2.Fill(this.dB_FWDDataSet2094.TBE_LOC);
            this.tBE_LOCTableAdapter1.Fill(this.location.TBE_LOC);
            this.tBE_LOCTableAdapter.Fill(this.dB_FWDDataSet3.TBE_LOC);*/
        }



        public DateTime SSN(string x)
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            try { 
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
            catch{
                ToastWaring.Lable_Text.Text = "الرقم القومى غير صحيح";
                ToastWaring.Show();
                return DateTime.Now;
            }
        }

        private void edt_supp_ssn_EditValueChanged(object sender, EventArgs e){
            string x = edt_supp_ssn.Text;
            if (x.Length == 14)
            {
                edt_supp_Date_bairth.DateTimeOffset = SSN(x);
                edt_supp_date_start.DateTimeOffset = DateTimeOffset.Now;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            if (Supp_ID == 0) {
                if (edt_supp_date_start.Text == "" || edt_supp_Date_bairth.Text == "" || edt_supp_name.Text == "" || edt_supp_phone1.Text == "" || edt_supp_retion.Text == "" || edt_supp_ssn.Text == "" || edt_supp_add.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else{
                    tb_supp.SUPP_Adress = Convert.ToInt32(edt_supp_add.EditValue);
                    tb_supp.SUPP_Bairth = edt_supp_Date_bairth.DateTimeOffset.DateTime;
                    tb_supp.SUPP_Date_Regest = edt_supp_date_start.DateTimeOffset.DateTime;
                    tb_supp.SUPP_Name = edt_supp_name.Text;
                    tb_supp.SUPP_Phone1 = edt_supp_phone1.Text;
                    tb_supp.SUPP_phone2 = edt_supp_phone2.Text;
                    tb_supp.SUPP_Retion = Convert.ToInt32(edt_supp_retion.EditValue);
                    tb_supp.SUPP_SSN = edt_supp_ssn.Text;
                    DataBase.TB_SUPP.Add(tb_supp);
                    DataBase.SaveChanges();
                    ToastDone.Text = "تمت اضافة مندوب";
                    ToastDone.Show();
                    clrear();
                }
            }
            else
            {

                if (edt_supp_date_start.Text == "" || edt_supp_Date_bairth.Text == "" || edt_supp_name.Text == "" || edt_supp_phone1.Text == "" || edt_supp_retion.Text == "" || edt_supp_ssn.Text == "" || edt_supp_add.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else
                {
                    tb_supp.ID = Supp_ID;
                    tb_supp.SUPP_Adress = Convert.ToInt32(edt_supp_add.EditValue);
                    tb_supp.SUPP_Bairth = edt_supp_Date_bairth.DateTimeOffset.DateTime;
                    tb_supp.SUPP_Date_Regest = edt_supp_date_start.DateTimeOffset.DateTime;
                    tb_supp.SUPP_Name = edt_supp_name.Text;
                    tb_supp.SUPP_Phone1 = edt_supp_phone1.Text;
                    tb_supp.SUPP_phone2 = edt_supp_phone2.Text;
                    tb_supp.SUPP_Retion = Convert.ToInt32(edt_supp_retion.EditValue);
                    tb_supp.SUPP_SSN = edt_supp_ssn.Text;

                    DataBase.Entry(tb_supp).State = System.Data.Entity.EntityState.Modified;
                    DataBase.SaveChanges();




                    ToastDone.Text = "تمت تعديل مندوب";
                    ToastDone.Show();
                    clrear();
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clrear()
        {
            edt_supp_add.Text = "";
            edt_supp_Date_bairth.Text = "";
            edt_supp_date_start.Text = "";
            edt_supp_name.Text = "";
            edt_supp_phone1.Text = "";
            edt_supp_phone2.Text = "";
            edt_supp_retion.Text = "";
            edt_supp_ssn.Text = "";

        }


    }
}
