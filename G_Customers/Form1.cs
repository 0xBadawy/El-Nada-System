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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        G_Customers.Form_Cus_Person form_Cus_Person = new G_Customers.Form_Cus_Person();
        G_Customers.Form_Cus_Income form_Cus_Income = new G_Customers.Form_Cus_Income();
        G_Customers.Form_Cus_Home form_Cus_Home = new G_Customers.Form_Cus_Home();
        G_Customers.Form_Cus_Family form_Cus_Family = new G_Customers.Form_Cus_Family();
        G_Customers.Form_Cus_Father form_Cus_Father = new G_Customers.Form_Cus_Father();
        G_Customers.Form_Cus_Owns form_Cus_Owns = new G_Customers.Form_Cus_Owns();
        G_Customers.Form_Cus_Reserch form_Cus_Reserch = new G_Customers.Form_Cus_Reserch();
        DB_FWDEntities DataBase = new DB_FWDEntities();

        private void AddPerson()
        {
            // G_Customers.Form_Cus_Person form_Cus_Person = new Form_Cus_Person();
            TB_CUST_Person tb_cus_person = new TB_CUST_Person();

            tb_cus_person.CUST_Person_Age = Convert.ToInt32(form_Cus_Person.edt_per_label_age.Text);
            tb_cus_person.CUST_Person_Bairth = form_Cus_Person.edt_per_bairth.DateTimeOffset.DateTime;
            tb_cus_person.CUST_Person_Name = form_Cus_Person.edt_per_name.Text;
            tb_cus_person.CUST_Person_Phone_1 = "dsssdsdsds";
            // tb_cus_person.CUST_Person_Eud= form_Cus_Person.ed
            DataBase.TB_CUST_Person.Add(tb_cus_person);
            DataBase.SaveChanges();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(form_Cus_Person.panel_Form_Cus_Person);

                i++;
                stepProgressBar1.SelectNext();

            }
            else if (i == 1)
            {
                AddPerson();

                panel1.Controls.Clear();
                panel1.Controls.Add(form_Cus_Father.panel_Form_Cus_Father);
                i++;
                stepProgressBar1.SelectNext();
            }
            else if (i == 2)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(form_Cus_Family.panel_Form_Cus_Family);
                i++;
                stepProgressBar1.SelectNext();
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
                panel1.Controls.Add(form_Cus_Reserch.panel_Form_Cus_Res);
                i++;
                stepProgressBar1.SelectNext();
            }


        }
    }
}
