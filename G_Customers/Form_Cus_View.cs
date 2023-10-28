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
    public partial class Form_Cus_View : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();

        public int main_cus_view_ID = 33;
        View_CUST_Main_data_01 view_CUST_Main_Data_01 = new View_CUST_Main_data_01();
        public Form_Cus_View()
        {
            InitializeComponent();
        }

        private void Form_Cus_View_Load(object sender, EventArgs e)
        {

            
            //*** Main data for person
            view_CUST_Main_Data_01 = DataBase.View_CUST_Main_data_01.Where(x => x.CUST_Main_ID == main_cus_view_ID).FirstOrDefault();
            edit_person_name.Text = view_CUST_Main_Data_01.CUST_Person_Name;
            edit_person_age.Text = view_CUST_Main_Data_01.Age_person.ToString();
            edit_person_birth.Text = view_CUST_Main_Data_01.CUST_Person_Bairth.ToString();
            edit_person_edu.Text = view_CUST_Main_Data_01.person_Educational_Status_Name;
            edit_person_phone1.Text = view_CUST_Main_Data_01.CUST_Person_Phone_1;
            edit_person_phone2.Text = view_CUST_Main_Data_01.CUST_Person_Phone_2;
          //   edit_person_sost.Text = view_CUST_Main_Data_01.CUST_Person_SO_ST;
            edit_person_ssn.Text= view_CUST_Main_Data_01.CUST_Person_SSN;



            //****  father 


            


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
