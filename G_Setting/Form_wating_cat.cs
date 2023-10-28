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

namespace FWD.G_Setting
{
    public partial class Form_wating_cat : Form
    {

        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_WL_CAT tb_WL_CAT = new TB_WL_CAT();

        public Form_wating_cat()
        {
            InitializeComponent();
            
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
             dbContext.TB_WL_CAT.LoadAsync().ContinueWith(loadTask =>
            { gridSplitContainer1Grid.DataSource = dbContext.TB_WL_CAT.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();

            var rs = MessageBox.Show("هل متاكد من ان البيانات صحيحة؟ّ! لا يمكنك الحذف او التعديل ", "تاكد من البيانات", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    if (Edit_Text_1.Text == "")
                    {
                        ToastWaring.Lable_Text.Text = "اضف الحالة التعليمة";
                        ToastWaring.Show();
                    }
                    else
                    {
                        tb_WL_CAT.WL_Category = Edit_Text_1.Text;

                        DataBase.TB_WL_CAT.Add(tb_WL_CAT);
                        DataBase.SaveChanges();


                        ToastDone.Lable_Text.Text = "تمت الاضافة";
                        ToastDone.Show();


                        DataBase = new DB_FWDEntities();
                        gridSplitContainer1Grid.DataSource = DataBase.TB_WL_CAT.ToList();

                        //  this.Close();
                    }
                }
                catch
                {
                    toast_Wrong.Lable_Text.Text = "حدث خطأ";
                    toast_Wrong.Show();

                }
            }
        }
    }
}
