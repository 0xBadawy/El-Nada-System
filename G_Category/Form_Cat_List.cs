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

namespace FWD.G_Category
{
    public partial class Form_Cat_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_PUR tb_pur = new TB_PUR();
        public Form_Cat_List()
        {
            InitializeComponent();
            
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.TB_PUR.LoadAsync().ContinueWith(loadTask =>
            {
            gridControl1.DataSource = dbContext.TB_PUR.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_ref_Click(object sender, EventArgs e){
            UpDate_Data();
        }
        private void UpDate_Data(){
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.TB_PUR.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();

            Toast.Message_Box message = new Toast.Message_Box();

            try
            {
                if (rs == DialogResult.Yes)
                {
                    tb_pur = DataBase.TB_PUR.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_pur).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();

                    ToastDel.Show();
                }
                UpDate_Data();
            }
            catch
            {
                message.Message_Text.Text = "الصنف قد تم استلامة من بعض الحالات ولا يمكن حذف , يمكنك حذف الحالات المستلمة و المحاولة مره اخرى";

                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
                message.Show();
                UpDate_Data();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            G_Category.Form_Cat_Add form_Cat_Add = new Form_Cat_Add();
            tb_pur = DataBase.TB_PUR.Where(x => x.ID == id).FirstOrDefault();

            form_Cat_Add.tb_pur_id = id;
            form_Cat_Add.Btn_Add.Text = "تعديل";
            form_Cat_Add.label9.Text = "تعديل صنف";


            try{
                form_Cat_Add.edt_supp_Date.DateTimeOffset = new DateTimeOffset((DateTime)tb_pur.PUR_Date);
                form_Cat_Add.edt_cat_det.Text = tb_pur.PUR_Det;
                form_Cat_Add.edt_cat_name.Text = tb_pur.PUR_Name;
                form_Cat_Add.edt_cat_num.Text = Convert.ToString(tb_pur.PUR_Qt);
                form_Cat_Add.edt_cat_supplyer.EditValue = tb_pur.PUR_supp;
                form_Cat_Add.edt_cat_val.Text = Convert.ToString(tb_pur.PUR_Val);
            }
            catch
            {

            }
            form_Cat_Add.Show();
        }
    }
}
