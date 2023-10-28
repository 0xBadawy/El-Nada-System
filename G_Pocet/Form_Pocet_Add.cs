using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FWD.G_Pocet
{
    public partial class Form_Pocet_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_POC tb_poc = new TB_POC();
        TB_FIN tb_fin = new TB_FIN();
        public Form_Pocet_Add()
        {
            InitializeComponent();

            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.TB_POC.LoadAsync().ContinueWith(loadTask =>
            {
            gridControl1.DataSource = dbContext.TB_POC.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            var rs = MessageBox.Show("هل انت متاكد من عملية سحب هذا المبلغ", "عملية سحب ", MessageBoxButtons.YesNoCancel);

            if (rs == DialogResult.Yes)
            {


                Toise.Toast_Done ToastDone = new Toise.Toast_Done();
                Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
                Toast.Toast_Del ToastDel = new Toast.Toast_Del();

                if (edt_cat_val.Text == "" || edt_don_dir.Text == "" || edt_don_rece.Text == "" || edt_don_name.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اكمل باقى البيانات";
                    ToastWaring.Show();
                }
                else
                {

                    tb_poc.POC_Date = DateTime.Today;
                    tb_poc.POC_Name = edt_don_name.Text;
                    tb_poc.POC_Own = edt_don_rece.Text;
                    tb_poc.POC_Type = edt_don_dir.Text;
                    tb_poc.POC_Value = Convert.ToDouble(edt_cat_val.Text);


                    //التخزين فى المصاريف بس
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 2).FirstOrDefault();
                    double BAmount = tb_fin.FIN_Amount.Value;
                    double Amount = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount + Amount;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;


                    //التخزين فى الاجمالى 
                    tb_fin = DataBase.TB_FIN.Where(x => x.ID == 3).FirstOrDefault();
                    double BAmount1 = tb_fin.FIN_Amount.Value;
                    double Amount1 = Convert.ToDouble(edt_cat_val.Text);
                    tb_fin.FIN_Amount = BAmount1 - Amount1;
                    DataBase.Entry(tb_fin).State = System.Data.Entity.EntityState.Modified;



                    DataBase.TB_POC.Add(tb_poc);
                    DataBase.SaveChanges();

                    ToastDone.LbTitelAlterBox.Text = "تم سحب بالمبلغ";
                    ToastDone.Show();

                    edt_cat_val.Text = "";
                    edt_don_dir.Text = "";
                    edt_don_name.Text = "";
                    edt_don_rece.Text = "";

                }
            }

        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            UpDate_Data();
        }

        private void UpDate_Data()
        {
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.TB_POC.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    tb_poc = DataBase.TB_POC.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_poc).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();

                    ToastDel.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
