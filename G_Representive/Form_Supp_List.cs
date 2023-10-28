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

namespace FWD.G_Representive
{
    public partial class Form_Supp_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_SUPP tB_SUPP = new TB_SUPP();
        //private int id = -1;
        public Form_Supp_List()
        {
            InitializeComponent();
           
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.View_supp_list.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.View_supp_list.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_ref_Click(object sender, EventArgs e){
            UpDate_Data();
        }


        private void UpDate_Data(){
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.View_supp_list.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            var rs = MessageBox.Show("عملية حذف", "هل انت متاكد من عملية الحذف", MessageBoxButtons.YesNo);

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toast.Toast_Del ToastDel = new Toast.Toast_Del();
            Toast.Message_Box message_Box = new Toast.Message_Box();


            try
            {
                if (rs == DialogResult.Yes)
                {
                    tB_SUPP = DataBase.TB_SUPP.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tB_SUPP).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();
                    ToastDone.Text = "تم الحذف";
                    ToastDone.Show();
                }
            }
            catch{

                message_Box.Message_Text.Text = "لا يمكنك حذف هذا المندوب لانة مسجل لدى بعض الحالات يمكنك التعديل على بياناتة";
                message_Box.Show();
                ToastWaring.Lable_Text.Text = "خطا اثناء الحذف";
                ToastWaring.Show();
                UpDate_Data();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

            G_Representive.Form_Supp_Add form_Supp_Add = new Form_Supp_Add();
            tB_SUPP = DataBase.TB_SUPP.Where(x => x.ID == id).FirstOrDefault();

            form_Supp_Add.Supp_ID = id;
            form_Supp_Add.Btn_Add.Text = "تعديل";


            try
            {
                form_Supp_Add.edt_supp_add.EditValue = tB_SUPP.SUPP_Adress;

                form_Supp_Add.edt_supp_Date_bairth.DateTimeOffset = new DateTimeOffset((DateTime)tB_SUPP.SUPP_Bairth);
                form_Supp_Add.edt_supp_date_start.DateTimeOffset = new DateTimeOffset((DateTime)tB_SUPP.SUPP_Date_Regest);

                form_Supp_Add.edt_supp_name.Text = tB_SUPP.SUPP_Name;
                form_Supp_Add.edt_supp_phone1.Text = tB_SUPP.SUPP_Phone1;
                form_Supp_Add.edt_supp_phone2.Text = tB_SUPP.SUPP_phone2;
                form_Supp_Add.edt_supp_retion.EditValue = tB_SUPP.SUPP_Retion;
                form_Supp_Add.edt_supp_ssn.Text = tB_SUPP.SUPP_SSN;

            }
            catch
            {

            }
                form_Supp_Add.Show();
        }
    }
}
