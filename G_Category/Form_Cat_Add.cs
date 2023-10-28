using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Category
{
    public partial class Form_Cat_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_PUR tb_pur = new TB_PUR();

        public int tb_pur_id = 0;
        public Form_Cat_Add()
        {
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            if (tb_pur_id == 0)
            {

                if (edt_cat_det.Text == "" || edt_supp_Date.Text == "" || edt_cat_name.Text == "" || edt_cat_num.Text == "" || edt_cat_supplyer.Text == "" || edt_cat_val.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();

                }
                else
                {
                    tb_pur.PUR_Date = edt_supp_Date.DateTimeOffset.DateTime;
                    tb_pur.PUR_Det = edt_cat_det.Text;
                    tb_pur.PUR_Name = edt_cat_name.Text;
                    tb_pur.PUR_Qt = Convert.ToDouble(edt_cat_num.Text);
                    tb_pur.PUR_supp = edt_cat_supplyer.Text;
                    tb_pur.PUR_Val = Convert.ToDouble(edt_cat_val.Text);

                    DataBase.TB_PUR.Add(tb_pur);
                    DataBase.SaveChanges();

                    ToastDone.Lable_Text.Text = "تمت اضافة صنف";
                    ToastDone.Show();
                   // this.Close();
                }

            }
            else
            {

                if (edt_cat_det.Text == "" || edt_supp_Date.Text == "" || edt_cat_name.Text == "" || edt_cat_num.Text == "" || edt_cat_supplyer.Text == "" || edt_cat_val.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();

                }
                else
                {
                    tb_pur.ID = tb_pur_id;
                    tb_pur.PUR_Date = edt_supp_Date.DateTimeOffset.DateTime;
                    tb_pur.PUR_Det = edt_cat_det.Text;
                    tb_pur.PUR_Name = edt_cat_name.Text;
                    tb_pur.PUR_Qt = Convert.ToDouble(edt_cat_num.Text);
                    tb_pur.PUR_supp = edt_cat_supplyer.Text;
                    tb_pur.PUR_Val = Convert.ToDouble(edt_cat_val.Text);

                    DataBase.Entry(tb_pur).State = System.Data.Entity.EntityState.Modified;   
                    DataBase.SaveChanges();


                    ToastDone.Lable_Text.Text = "تمت تعديل الصنف";
                    ToastDone.Show();
                    this.Close();
                }



            }
        }

        private void Form_Cat_Add_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
