using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Customers
{
    public partial class Form_Cus_img : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
    //    BL.Methods methodsf = new BL.Methods();
     //   BL.Methods methodsb = new BL.Methods();
        public Form_Cus_img()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            TB_CUS_Img tb_cus_img = new TB_CUS_Img();

            tb_cus_img.CUS_Img_fk = 5;

            DataBase.TB_CUS_Img.Add(tb_cus_img);
            DataBase.SaveChanges();
        }
    }
}
