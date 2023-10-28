﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FWD.G_Customers
{
    public partial class Form_Cus_Income : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        public Form_Cus_Income()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_CUST_Income.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TB_CUST_Income.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
        }

        private void Button_add_Click(object sender, EventArgs e){

            TB_CUST_Income tb_cus_income = new TB_CUST_Income();

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                tb_cus_income.CUST_Income_Owner = edt_incom_owner.Text;
                
                
                tb_cus_income.CUST_Income_State = CheekJop.Text;

                if (CheekJop.Text == "hasJop")
                {
                    tb_cus_income.CUST_Income_State = "يعمل";
                    tb_cus_income.CUST_Income_Type = has_Jop_type.Text;
                    tb_cus_income.CUST_Income_Name = has_Jop_type.Text;
                    tb_cus_income.CUST_Income_Value = Convert.ToDouble(has_Jop_value.Text);

                }
                if (CheekJop.Text == "nojop")
                {

                    tb_cus_income.CUST_Income_State = "لا يعمل";

                    tb_cus_income.CUST_Income_Type = no_det.Text;
                    tb_cus_income.CUST_Income_Name = no_reson.Text;
                }
                if (CheekJop.Text == "project")
                {
                    tb_cus_income.CUST_Income_State = "مشروع خاص";

                    tb_cus_income.CUST_Income_Type = Project_Name.Text;
                    tb_cus_income.CUST_Income_Name = Project_state.Text;
                    tb_cus_income.CUST_Income_Value = Convert.ToDouble(Project_val.Text);
                }

                tb_cus_income.CUST_Income_PK = Class_main.myGlobalVariable;

                DataBase.TB_CUST_Income.Add(tb_cus_income);
                DataBase.SaveChanges();
           //     Button_add.Enabled = false;


                ToastDone.Lable_Text.Text = "تم تسجيل مصدر دخل";
                ToastDone.Show();
                UpDate_Data();

            }
            catch
            {
                ToastWaring.Lable_Text.Text = "حدث خطا فى الحفظ";
                ToastWaring.Show();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CheekJop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CheekJop.Text== "hasJop"){
                G_Jop.Enabled = true;
                G_project.Enabled = false;
                G_none.Enabled = false;
            }
            if (CheekJop.Text == "nojop"){
                G_Jop.Enabled = false;
                G_project.Enabled = false;
                G_none.Enabled = true;
            }
            if (CheekJop.Text == "project"){
                G_Jop.Enabled = false;
                G_project.Enabled = true;
                G_none.Enabled = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TB_CUST_Income tb_cus_income = new TB_CUST_Income();

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("CUST_Income_ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    tb_cus_income = DataBase.TB_CUST_Income.Where(x => x.CUST_Income_ID == id).FirstOrDefault();
                    DataBase.Entry(tb_cus_income).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();
                    ToastDone.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void UpDate_Data()
        {
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.TB_CUST_Income.Where(x=>x.CUST_Income_PK==Class_main.myGlobalVariable).ToList();
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell; gridView1.CustomDrawCell += gridControl1_CustomDrawCell; gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
        }

        private void G_Jop_Enter(object sender, EventArgs e)
        {

        }

        private void edt_incom_state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {

                if (e.Column.FieldName == "CUST_Income_State")
                {
                    string cellValue = e.CellValue.ToString();
                    if (cellValue == "لا يعمل")
                    {
                        e.Appearance.BackColor = Color.OrangeRed;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "مشروع خاص")
                    {
                        e.Appearance.BackColor = Color.DodgerBlue;
                        e.Appearance.ForeColor = Color.White;
                    }
                    else if (cellValue == "يعمل")
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.ForeColor = Color.White;
                    }
                }

            }
            catch
            {

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpDate_Data();
        }
    }

}