using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Waiting
{
    public partial class Form_WAT_Done : Form
    {
        public int Done_id = 0;
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_WAT tb_wat = new TB_WAT();
        View_Whating_List_Date View = new View_Whating_List_Date();
        public Form_WAT_Done()
        {
            InitializeComponent();
        }

        private void Form_WAT_Done_Load(object sender, EventArgs e)
        {
            View = DataBase.View_Whating_List_Date.Where(x => x.ID == Done_id).FirstOrDefault();
            Edit_Lable.Text = View.WAT_Name;
            textEdit1.Text = View.WAT_Done_state;

        }

        private void edt_tool_give_emploee_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void edt_tool_give_tool_name_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();


            try
            {
                tb_wat.ID=Done_id;                
                tb_wat.WAT_Done_state = textEdit1.Text;
                tb_wat.WAT_Done_Date = DateTime.Today;

                DataBase.Set<TB_WAT>().Attach(tb_wat);

                var entry = DataBase.Entry(tb_wat);
                entry.Property(x => x.WAT_Done_state).IsModified = true;
                entry.Property(x => x.WAT_Done_Date).IsModified = true;

                DataBase.SaveChanges();

                ToastDone.LbTitelAlterBox.Text = "تم التغير ";
                ToastDone.Show();
                this.Close();
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "حدث خطا , حاول مره اخرى";
                ToastWaring.Show();
            }

        }
    }
}
