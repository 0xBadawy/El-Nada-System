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

namespace FWD.G_Receives
{
    public partial class Form_Receive_Add : Form
    {
         DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_WAT tb_wat = new TB_WAT();
        TB_SELL tb_sell = new TB_SELL();
         Registered_Users_View registered_rsers_view = new Registered_Users_View();

 
        int cus_id = 1;
        string cus_ssn = "00000000000000";
        private void Form_Receive_Add_Load(object sender, EventArgs e){

            /*
            // TODO: This line of code loads data into the 'dB_FWDDataSet2093.TB_Emploee' table. You can move, or remove it, as needed.
            this.tB_EmploeeTableAdapter.Fill(this.dB_FWDDataSet2093.TB_Emploee);
            // TODO: This line of code loads data into the 'dB_FWDDataSet2037.TB_PUR' table. You can move, or remove it, as needed.
            this.tB_PURTableAdapter1.Fill(this.dB_FWDDataSet2037.TB_PUR);
            // TODO: This line of code loads data into the 'dB_FWDDataSet2034.TB_Health_Status' table. You can move, or remove it, as needed.
            //  this.tB_Health_StatusTableAdapter.Fill(this.dB_FWDDataSet2034.TB_Health_Status);
            // TODO: This line of code loads data into the 'dB_FWDDataSet2.TB_PUR' table. You can move, or remove it, as needed.
            this.tB_PURTableAdapter.Fill(this.dB_FWDDataSet2.TB_PUR);
     //       this.tB_CUSTableAdapter.Fill(this.dB_FWDDataSet1.TB_CUS);

            */
        }

        public Form_Receive_Add()
        {
            InitializeComponent();           
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
             dbContext.TB_PUR.LoadAsync().ContinueWith(loadTask =>{
                edt_cat.Properties.DataSource = dbContext.TB_PUR.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void edt_name_EditValueChanged(object sender, EventArgs e){
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)  //Code search
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();

            try
            {
                int RRt = Convert.ToInt32(edt_code.Text);
                registered_rsers_view = DataBase.Registered_Users_View.Where(x => x.Registered_Users_ID == RRt ).FirstOrDefault();
                edt_ssn_serch.Text = registered_rsers_view.Registered_Users_Ssn;
                Fill_labels_Data();

                ToastDone.Lable_Text.Text = "هذا الاسم موجود ";
                ToastDone.Show();

            }
            catch{
                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();
                cus_id = 1;
                Clear_Form();

            }

        }

        private void simpleButton2_Click(object sender, EventArgs e) // SSN sarech
        {
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();

          //  registered_rsers_view = DataBase.Registered_Users_View.Where(x => x.Registered_Users_Ssn ==edt_ssn_serch.Text ).FirstOrDefault();

            string ssnToSearch = edt_ssn_serch.Text;
            registered_rsers_view = DataBase.Registered_Users_View.FirstOrDefault(x => x.Registered_Users_Ssn == ssnToSearch);

            if (registered_rsers_view != null)
            {
                Fill_labels_Data();
                int yy = registered_rsers_view.Registered_Users_ID;
                edt_code.Text = registered_rsers_view.Registered_Users_ID.ToString();
                ToastDone.Lable_Text.Text = "هذا الاسم موجود ";
                ToastDone.Show();
            }
            else
            {

                ToastWaring.Lable_Text.Text = "هذا الاسم غير مسجل";
                ToastWaring.Show();

                var rs = MessageBox.Show("هل تريد تسجيل حالة جديدة", "هذا الاسم غير موجود ", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    G_Registered_Users.Form_Registered_Users_Add form_registered_users_add = new G_Registered_Users.Form_Registered_Users_Add();
                    form_registered_users_add.Show();

                }
            }



        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            try
            {

          
                tb_sell.SELL_Person_Code = Convert.ToInt32 (edt_code.Text);
                tb_sell.SELL_Date = DateTime.Today;
                tb_sell.SELL_Resv_Name = edt_res_name.Text;
                tb_sell.SELL_Cat = Convert.ToInt32(edt_cat.EditValue);
                tb_sell.SELL_Num = Convert.ToInt32(edt_num.Text);

             //   tb_sell.SELL_Charity_Rcever = Convert.ToInt32(Recever_charity.EditValue);
                tb_sell.SELL_Charity_Rcever = Class_main.emp_login_id;


                DataBase.TB_SELL.Add(tb_sell);            
                DataBase.SaveChanges();

                ToastDone.Lable_Text.Text = "تمت عملية التسليم";
                ToastDone.Show();
                Clear_Form();

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "تاكد من البيانات";
                ToastWaring.Show();
            }
            



    }

        private void edt_name_Enter(object sender, EventArgs e)
        {
           
        }

     
        private void Fill_labels_Data(){

            try { 
                label_C_Inf_name.Text = registered_rsers_view.Registered_Users_Name;
                label_C_Inf_ssn.Text = registered_rsers_view.Registered_Users_Ssn;
                label_C_Inf_id.Text = registered_rsers_view.Registered_Users_ID.ToString();
                label_C_Inf_add.Text = registered_rsers_view.LOC_Name;
                label_C_Inf_add_2.Text = registered_rsers_view.LOC_Key;
                label_C_Inf_supp.Text = registered_rsers_view.SUPP_Name;
                label_C_Inf_rank.Text = registered_rsers_view.Rank_Name;

                edt_res_name.Text= registered_rsers_view.Registered_Users_Name;
            }
            catch
            {

            }


            // */
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
            edt_res_name.Text = "";
            edt_code.Text = "";
            edt_ssn_serch.Text = "";
            edt_cat.Text = "";

            Recever_charity.Text = "";
        }

        private void edt_code_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void edt_res_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            G_Registered_Users.Form_Search_Person form_Search_Person = new G_Registered_Users.Form_Search_Person();
            form_Search_Person.Show();
        }
    }
}
