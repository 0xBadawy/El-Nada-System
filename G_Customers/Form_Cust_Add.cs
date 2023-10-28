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
    public partial class Form_Cust_Add : Form
    {
        public int main_dd=1;
        /*
        G_Customers.Form_Cus_Person form_Cus_Person = new G_Customers.Form_Cus_Person();
        G_Customers.Form_Cus_Income form_Cus_Income = new G_Customers.Form_Cus_Income();
        G_Customers.Form_Cus_Home form_Cus_Home = new G_Customers.Form_Cus_Home();
        G_Customers.Form_Cus_Family form_Cus_Family = new G_Customers.Form_Cus_Family();
        G_Customers.Form_Cus_Father form_Cus_Father = new G_Customers.Form_Cus_Father();
        G_Customers.Form_Cus_Owns form_Cus_Owns = new G_Customers.Form_Cus_Owns();
        G_Customers.Form_Cus_Reserch form_Cus_Reserch = new G_Customers.Form_Cus_Reserch();*/
       // TB_CUST_Person tb_cus_person = new TB_CUST_Person();

        int i = 0;
        public Form_Cust_Add()
        {
            InitializeComponent();
           
            

        }
        private void Form_Cust_Add_Load(object sender, EventArgs e)
        {

            G_Customers.Form_Cus_Person form_Cus_Person = new Form_Cus_Person();


            panel1.Controls.Clear();
            panel1.Controls.Add(form_Cus_Person.panel_Form_Cus_Person);
            i++;
            stepProgressBar1.SelectNext();
            main_dd = 3;

        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //label1.Text = Convert.ToString(i);
            G_Customers.Form_Cus_Income form_Cus_Income = new Form_Cus_Income();
            G_Customers.Form_Cus_Home form_Cus_Home = new Form_Cus_Home();
            G_Customers.Form_Cus_Family form_Cus_Family = new Form_Cus_Family();
            // G_Customers.Form_Cus_Father form_Cus_Father = new Form_Cus_Father();
            G_Customers.Form_Cus_Husban form_Cus_Husban = new Form_Cus_Husban();
            G_Customers.Form_Cus_Owns form_Cus_Owns = new Form_Cus_Owns();
            G_Customers.Form_Cus_Reserch form_Cus_Reserch = new Form_Cus_Reserch();
            G_Customers.Form_Cus_Person form_Cus_Person = new Form_Cus_Person();
            G_Customers.Form_Cus_Needs form_Cus_needs = new Form_Cus_Needs();
            G_Customers.Form_Cus_Files form_Cus_file = new Form_Cus_Files();

            var rs = MessageBox.Show( "هل انت متأكد من حفظ هذه البيانات والتقدم الى الخطوة التالية ", "حفظ البيانات", MessageBoxButtons.YesNo);

            if(rs==DialogResult.Yes)
            {


                //  btn_Main_cus.Enabled = false;
                main_dd = 3;

                if (i == 0)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Person.panel_Form_Cus_Person);                
                    i++;
                    stepProgressBar1.SelectNext();
                    main_dd = 3;
                }
                else if (i == 1)
                {
                   // AddPerson();

                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Husban.panel_Form_Cus_Father);
                    i++;
                    stepProgressBar1.SelectNext();
                    main_dd = 3;

                }
                else if (i == 2)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Family.panel_Form_Cus_Family);
                    i++;
                    stepProgressBar1.SelectNext();
                    main_dd = 3;
                }
                else if (i == 3)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Home.panel_Form_Cus_Home);
                    i++;
                    stepProgressBar1.SelectNext();
                }
                else if (i == 4)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Income.panel_Form_Cus_Incom);
                    i++;
                    stepProgressBar1.SelectNext();
                }
                else if (i == 5)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Owns.panel_Form_Cus_Owns);
                    i++;
                    stepProgressBar1.SelectNext();
                }
                else if (i == 6)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_needs.panel_Form_Cus_Needs);
                    i++;
                    stepProgressBar1.SelectNext();
                }
                else if (i == 7)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_file.panel_Form_Cus_file);
                    i++;
                    stepProgressBar1.SelectNext();
                }
                else if (i == 8)
                {
                    panel1.Controls.Clear();
                    panel1.Controls.Add(form_Cus_Reserch.panel_Form_Cus_Res);
                    i++;
                    stepProgressBar1.SelectNext();
                }

            //    btn_Main_cus.Enabled = false;

            }
        }
    }
}
