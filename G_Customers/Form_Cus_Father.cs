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
    public partial class Form_Cus_Father : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_CUST_Father tb_cust_father = new TB_CUST_Father();

        public Form_Cus_Father()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tb_cust_father.CUST_Father_Bairth = edt_father_bairth.DateTimeOffset.DateTime;
            tb_cust_father.CUST_Father_Edu = Convert.ToInt32( edt_father_edu.EditValue);
        //    tb_cust_father.CUST_Father_helth = Convert.ToInt32(edt_per_father_type.EditValue);
            tb_cust_father.CUST_Father_Helth_det = edt_per_father_det.Text;
            tb_cust_father.CUST_Father_Name = edt_father_name.Text;
            tb_cust_father.CUST_Father_Phone = edt_father_phone.Text;
            tb_cust_father.CUST_Father_SSN = edt_father_ssn.Text;

            int ty = Class_main.myGlobalVariable;
            tb_cust_father.CUST_Father_FK = ty;

            DataBase.TB_CUST_Father.Add(tb_cust_father);
            DataBase.SaveChanges();

            simpleButton1.Enabled = false;

        }

        private void Form_Cus_Father_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2034.TB_Health_Status' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dB_FWDDataSet2033.TB_Educational_Status' table. You can move, or remove it, as needed.
            this.tB_Educational_StatusTableAdapter.Fill(this.dB_FWDDataSet2033.TB_Educational_Status);

        }

        private void edt_father_name_EditValueChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_FWDDataSet2034.TB_Health_Status' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dB_FWDDataSet2033.TB_Educational_Status' table. You can move, or remove it, as needed.
            this.tB_Educational_StatusTableAdapter.Fill(this.dB_FWDDataSet2033.TB_Educational_Status);
        }
    }
}
