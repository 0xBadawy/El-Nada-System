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
using FWD.BL;
namespace FWD.G_Customers
{
    public partial class Form_Cus_Person : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_CUST_Person tb_cus_person = new TB_CUST_Person();
        Form_Cust_Add form_add = new Form_Cust_Add();
        BL.Methods methodsf = new BL.Methods();
        BL.Methods methodsb = new BL.Methods();
        public Form_Cus_Person()
        {
            InitializeComponent();

            FWD.DB_FWDEntities dbContext1 = new FWD.DB_FWDEntities();
            dbContext1.TB_Health_Status.LoadAsync().ContinueWith(loadTask =>
            {
                edt_per_helth_type.Properties.DataSource = dbContext1.TB_Health_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());



            FWD.DB_FWDEntities dbContext2 = new FWD.DB_FWDEntities();
            dbContext2.TB_Social_State.LoadAsync().ContinueWith(loadTask =>
            {
                edt_per_social_state.Properties.DataSource = dbContext2.TB_Social_State.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());


            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.TB_Educational_Status.LoadAsync().ContinueWith(loadTask =>
            {
                edt_per_edu.Properties.DataSource = dbContext.TB_Educational_Status.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        G_Customers.Form_Cust_Add Form_Cust_Add = new Form_Cust_Add();

        private void Form_Cus_Person_Load(object sender, EventArgs e)
        {



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //  Form_Cust_Add.FFF();


        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                tb_cus_person.CUST_Person_Bairth = edt_per_bairth.DateTimeOffset.DateTime;
                tb_cus_person.CUST_Person_Eud = Convert.ToInt32(edt_per_edu.EditValue);
                tb_cus_person.CUST_Person_Gen = edt_per_gend.Text;
                tb_cus_person.CUST_Person_Helth = Convert.ToInt32(edt_per_helth_type.EditValue);
                tb_cus_person.CUST_Person_Helth_Det = edt_per_helth_det.Text;
                tb_cus_person.CUST_Person_Name = edt_per_name.Text;
                tb_cus_person.CUST_Person_Phone_1 = edt_per_phone.Text;
                tb_cus_person.CUST_Person_Phone_2 = edt_per_phone2.Text;
                tb_cus_person.CUST_Person_SO_ST = Convert.ToInt32(edt_per_social_state.EditValue);
                tb_cus_person.CUST_Person_SSN = edt_per_ssn.Text;
              //  IMg();
                DataBase.TB_CUST_Person.Add(tb_cus_person);
                DataBase.SaveChanges();

                tb_cus_person = DataBase.TB_CUST_Person
                    .Where(x => x.CUST_Person_SSN == edt_per_ssn.Text && x.CUST_Person_Name == edt_per_name.Text)
                    .FirstOrDefault();

                Class_main.myGlobalVariable = tb_cus_person.CUST_Main_ID;

                simpleButton1.Enabled = false;

                //  form_add.btn_Main_cus.Enabled = true;

                Toise.Toast_Done toast_Done = new Toise.Toast_Done();
                toast_Done.Lable_Text.Text = "تم اضافة بيانات الحالة";
                toast_Done.Show();

            }
            catch
            {
                Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();
                toast_Wrong.Lable_Text.Text = "خطأ فى البيانات";
                toast_Wrong.Show();
            }

        }


        private void IMg()
        {/*
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            try{
             //   pictureEdit_Front.Image.Save(methodsf.ma, System.Drawing.Imaging.ImageFormat.Png);
          //      pictureEdit_Back.Image.Save(methodsb.ma, System.Drawing.Imaging.ImageFormat.Png);
                tb_cus_person.CUST_Person_img_f = methodsf.convert_byte();
                tb_cus_person.CUST_Person_img_b = methodsb.convert_byte();
            }
            catch (Exception ex)
            {
                ToastWaring.Lable_Text.Text = "An error occurred: " + ex.Message;
                ToastWaring.Show();
            }*/

        }
        private void panel_Form_Cus_Person_MouseHover(object sender, EventArgs e)
        {



        }

        private void Form_Cus_Person_Click(object sender, EventArgs e)
        {

        }

        private void edt_per_gend_Click(object sender, EventArgs e)
        {



        }

        private void edt_per_helth_type_Click(object sender, EventArgs e)
        {

        }

        private void edt_per_social_state_Click(object sender, EventArgs e)
        {

        }

        private void edt_per_bairth_EditValueChanged(object sender, EventArgs e)
        {
            edt_per_label_age.Text = Convert.ToString(CalculateAge(edt_per_bairth.DateTimeOffset));
        }

        private int CalculateAge(DateTimeOffset birthDate)
        {
            DateTimeOffset currentDate = DateTimeOffset.Now;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age)) age--;
            return age;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
