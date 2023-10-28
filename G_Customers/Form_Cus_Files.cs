using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FWD.G_Customers
{
    public partial class Form_Cus_Files : Form
    {

        DB_FWDEntities DataBase = new DB_FWDEntities();
        BL.Methods methodsf = new BL.Methods();
      //  BL.Methods methodsb = new BL.Methods();
        BL.ClassMethod classmethod = new BL.ClassMethod();
        TB_CUS_Img tb_cus_files = new TB_CUS_Img();
        public Form_Cus_Files()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void File_Add_Click(object sender, EventArgs e)
        {



        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();




            try
            {
                pictureEdit_Back.Image.Save(classmethod.ma, System.Drawing.Imaging.ImageFormat.Png);
                pictureEdit_Front.Image.Save(methodsf.ma, System.Drawing.Imaging.ImageFormat.Png);

                tb_cus_files.CUS_Img_front = methodsf.convert_byte();
                tb_cus_files.CUS_Img_back = classmethod.convert_byte();

                tb_cus_files.CUS_Img_fk = Class_main.myGlobalVariable;
                DataBase.TB_CUS_Img.Add(tb_cus_files);
                DataBase.SaveChanges();

                ToastDone.LbTitelAlterBox.Text = "تمت عملية التسجيل";
                ToastDone.Show();


                Button_Add.Enabled = false;

            }
            catch (Exception ex)
            {
                ToastWaring.Lable_Text.Text = "An error occurred: " + ex.Message;
                ToastWaring.Show();
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel_Form_Cus_file_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}