using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Courses
{
    public partial class Form_Courses_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Course_info tb_course_info = new TB_Course_info();
        public int ID_course = 0;

        public Form_Courses_Add()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

           // DateTimeOffset NullDate = new DateTimeOffset(new DateTime(0001, 01, 01));

            if (edt_course_name.Text == ""||edt_course_teacher.Text == ""||edt_course_start.DateTimeOffset == null || edt_course_end.DateTimeOffset == null || edt_course_owner.Text == ""||edt_course_manager.Text == "" ||edt_course_location.Text == ""  ||edt_course_phone.Text == "" ||edt_course_trenee_num.Text == "")
            {
                ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                ToastWaring.Show();
            }
            else { 
                if (ID_course == 0){
                   try{

                     

                        double D1 = Convert.ToInt32(edt_course_teacher_cost.Text);
                        double D2 = Convert.ToInt32(edt_course_price.Text);
                        double D3 = Convert.ToInt32(edt_course_student_tax.Text);

                        DateTime STARTDate = edt_course_start.DateTimeOffset.DateTime;
                        DateTime ENDDate = edt_course_end.DateTimeOffset.DateTime;

                        tb_course_info.Course_Name = edt_course_name.Text;
                        tb_course_info.Course_teraner= edt_course_teacher.Text;

                        tb_course_info.Course_start = STARTDate;
                        tb_course_info.Course_end = ENDDate;

                        tb_course_info.Course_owner= edt_course_owner.Text;
                        tb_course_info.Course_teatcher_cost = D1;
                        tb_course_info.Course_Price = D2;
                        tb_course_info.Course_studet_tax = D3;
                        tb_course_info.Course_treener_manager= edt_course_manager.Text;
                        tb_course_info.Course_location= edt_course_location.Text;
                        tb_course_info.Course_more_info= edt_course_info.Text;
                        tb_course_info.Course_teacher_phone= edt_course_phone.Text;
                        tb_course_info.Course_student_num=Convert.ToInt32( edt_course_trenee_num.Text);

                        DataBase.TB_Course_info.Add(tb_course_info);
                        DataBase.SaveChanges();

                        ToastDone.LbTitelAlterBox.Text = "تمت عملية التسجيل";
                        ToastDone.Show();
                        this.Close();

                    }
                    catch{
                       ToastWaring.Lable_Text.Text = "تاكد من البيانات";
                       ToastWaring.Show();
                    }


                }
                else{
                    try{
                        tb_course_info.Course_ID = ID_course;
                        tb_course_info.Course_Name = edt_course_name.Text;
                        tb_course_info.Course_teraner = edt_course_teacher.Text;
                        tb_course_info.Course_start = edt_course_start.DateTimeOffset.DateTime;
                        tb_course_info.Course_end = edt_course_end.DateTimeOffset.DateTime;
                        tb_course_info.Course_owner = edt_course_owner.Text;
                        tb_course_info.Course_teatcher_cost = Convert.ToDouble(edt_course_teacher_cost.Text);
                        tb_course_info.Course_Price = Convert.ToDouble(edt_course_price.Text);
                        tb_course_info.Course_studet_tax = Convert.ToDouble(edt_course_student_tax.Text);
                        tb_course_info.Course_treener_manager = edt_course_manager.Text;
                        tb_course_info.Course_location = edt_course_location.Text;
                        tb_course_info.Course_more_info = edt_course_info.Text;
                        tb_course_info.Course_teacher_phone = edt_course_phone.Text;
                        tb_course_info.Course_student_num = Convert.ToInt32(edt_course_trenee_num.Text);
                        DataBase.Entry(tb_course_info).State = System.Data.Entity.EntityState.Modified;

                        DataBase.SaveChanges();
                        ToastDone.Lable_Text.Text = "تمت التعديل ";
                        ToastDone.Show();
                        this.Close();

                    }
                    catch{
                        ToastWaring.Lable_Text.Text = "تاكد من صحة البيانات";
                        ToastWaring.Show();
                    }
                }

            }

        }

        private void Form_Courses_Add_Load(object sender, EventArgs e)
        {


        }
    }
}
