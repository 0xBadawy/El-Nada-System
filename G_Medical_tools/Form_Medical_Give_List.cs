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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;


namespace FWD.G_Medical_tools
{
    public partial class Form_Medical_Give_List : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Medical_give tB_Medical_Give = new TB_Medical_give();
        public Form_Medical_Give_List()
        {
            InitializeComponent();
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.View_Medical_Give_List.LoadAsync().ContinueWith(loadTask =>
            {
            gridControl1.DataSource = dbContext.View_Medical_Give_List.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;

        }


        private void Form_Medical_Give_List_Load(object sender, EventArgs e)
        {
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;


        }

        private void gridControl1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Medical_give_return_status"){
                string cellValue = e.CellValue.ToString();
                if (cellValue == "قيد الاستخدام"){
                    e.Appearance.BackColor = Color.OrangeRed;
                    e.Appearance.ForeColor = Color.White;
                }
                else{
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.White;

                }
            }
        }





        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {

        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            gridView1.CustomDrawCell += gridControl1_CustomDrawCell;
            DataBase = new DB_FWDEntities();
            gridControl1.DataSource = DataBase.View_Medical_Give_List.ToList();
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

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
                    tB_Medical_Give = DataBase.TB_Medical_give.Where(x => x.Medical_give_ID == id).FirstOrDefault();
                    DataBase.Entry(tB_Medical_Give).State = EntityState.Deleted;
                    DataBase.SaveChanges();


                    DataBase = new DB_FWDEntities();
                    gridControl1.DataSource = DataBase.View_Medical_Give_List.ToList();

                    ToastDel.Show();
                }
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "لا يوجد شئ لحذفة";
                ToastWaring.Show();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            G_Medical_tools.Form_Midical_Return_Done form_Midical_Return_Done = new Form_Midical_Return_Done();
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Medical_give_ID"));
            form_Midical_Return_Done.Midical_Done_id = id;
            form_Midical_Return_Done.Show();

         //   btn_edt.Text = id.ToString();

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridView1.ShowPrintPreview();
        }
    }
}
