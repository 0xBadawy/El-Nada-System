using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_General_Report
{
    public partial class Form_General_Report : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_General_report tb_general_report = new TB_General_report();

        public int id_report = 0;
        public Form_General_Report()
        {
            InitializeComponent();
        }

        private void Form_General_Report_Load(object sender, EventArgs e)
        {
            edit_date.DateTime = DateTime.Today;
            DateTime date = DateTime.Now;
            DayOfWeek dayOfWeek = date.DayOfWeek;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void edit_report_dession_EditValueChanged(object sender, EventArgs e)
        {

           

        }

        private void edit_date_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void edit_report_table_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void clear()
        {
            edit_report_num.Text = "";
            edit_report_table.Text = "";
            edit_report_dession.Text = "";
            edit_report_day.Text = "";
            edit_date.Text = "";


        }

        private void Add_Click(object sender, EventArgs e)
        {

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();

            try
            {
                if (id_report==0)
                {

               
                    if (edit_report_num.Text == "" || edit_report_table.Text == "" || edit_report_dession.Text == "" || edit_report_day.Text == "" || edit_date.Text == "")
                    {
                        ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                        ToastWaring.Show();
                    }
                    else
                    {
                        tb_general_report.General_report_create_date = DateTime.Today;
                        tb_general_report.General_report_date = edit_date.DateTime;
                        tb_general_report.General_report_day = edit_report_day.Text;
                        tb_general_report.General_report_dessition = edit_report_dession.Text;
                        tb_general_report.General_report_end = edit_report_end.Text;
                        tb_general_report.General_report_start = edit_report_start.Text;
                        tb_general_report.General_report_table = edit_report_table.Text;

                        tb_general_report.General_report_writer = Class_main.emp_login_id;

                        tb_general_report.General_report_Number = Convert.ToInt32(edit_report_num.Text);                    


                        DataBase.TB_General_report.Add(tb_general_report);
                        DataBase.SaveChanges();


                        ToastDone.Lable_Text.Text = "تمت الاضافة";
                        ToastDone.Show();
                        clear();
                        this.Close();
                    }


                }
                else
                {


                    if (edit_report_num.Text == "" || edit_report_table.Text == "" || edit_report_dession.Text == "" || edit_report_day.Text == "" || edit_date.Text == "")
                    {
                        ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                        ToastWaring.Show();
                    }
                    else
                    {
                        tb_general_report.General_report_ID = id_report;

                        tb_general_report.General_report_create_date = DateTime.Today;
                        tb_general_report.General_report_date = edit_date.DateTime;
                        tb_general_report.General_report_day = edit_report_day.Text;
                        tb_general_report.General_report_dessition = edit_report_dession.Text;
                        tb_general_report.General_report_end = edit_report_end.Text;
                        tb_general_report.General_report_start = edit_report_start.Text;
                        tb_general_report.General_report_table = edit_report_table.Text;
                        tb_general_report.General_report_writer = Class_main.emp_login_id;
                        tb_general_report.General_report_Number = Convert.ToInt32(edit_report_num.Text);


                   
                        DataBase.Entry(tb_general_report).State = System.Data.Entity.EntityState.Modified;
                        DataBase.SaveChanges();



                        ToastDone.Lable_Text.Text = "تمت التعديل";
                        ToastDone.Show();

                        clear();
                        this.Close();
                    }





















                }





            }
            catch
            {
                toast_Wrong.Lable_Text.Text = "حدث خطأ";
                toast_Wrong.Show();

            }
        }
    }
}
