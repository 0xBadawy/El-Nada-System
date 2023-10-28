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
    public partial class Form_Famile_Need_Reserch : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Family_Needs_Type tb_Need = new TB_Family_Needs_Type();
        public Form_Famile_Need_Reserch()
        {
            InitializeComponent();

            updatee();
        }

        private void updatee()
        {
            FWD.DB_FWDEntities dbContext = new FWD.DB_FWDEntities();
            dbContext.TB_Family_Needs_Type.LoadAsync().ContinueWith(loadTask =>
            {
                gridSplitContainer1Grid.DataSource = dbContext.TB_Family_Needs_Type.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            // Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();

            var rs = MessageBox.Show("هل متاكد من ان البيانات صحيحة؟ّ! لا يمكنك الحذف او التعديل ", "تاكد من البيانات", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {

                try
                {
                    if (Edit_Text_1.Text == "")
                    {
                        ToastWaring.Lable_Text.Text = "اضف الحالة ";
                        ToastWaring.Show();
                    }
                    else
                    {
                        tb_Need.Family_Needs_Type_Name = Edit_Text_1.Text;

                        DataBase.TB_Family_Needs_Type.Add(tb_Need);
                        DataBase.SaveChanges();



                        ToastDone.Lable_Text.Text = "تمت الاضافة";
                        ToastDone.Show();
                    }
                }
                catch
                {
                    ToastWaring.Lable_Text.Text = "حدث خطأ";
                    ToastWaring.Show();

                }
            }
            updatee();
        }
    }
}
