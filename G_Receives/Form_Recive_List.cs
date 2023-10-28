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

namespace FWD.G_Receives
{
    public partial class Form_Recive_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_SELL tb_sell = new TB_SELL();
        public Form_Recive_List()
        {
            InitializeComponent();
            // Instantiate a new DBContext

            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.View_Sell_to_Customers.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    h.DataSource = dbContext.View_Sell_to_Customers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            UpDate_Data();
        }

        private void UpDate_Data(){
            DataBase = new DB_FWDEntities();
            h.DataSource = DataBase.View_Sell_to_Customers.ToList();
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
                if (rs == DialogResult.Yes){
                    tb_sell = DataBase.TB_SELL.Where(x => x.ID == id).FirstOrDefault();
                    DataBase.Entry(tb_sell).State = EntityState.Deleted;
                    DataBase.SaveChanges();
                    UpDate_Data();
                    ToastDel.Show();
                }
            }
            catch{
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
