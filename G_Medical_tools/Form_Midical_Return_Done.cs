using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD.G_Medical_tools
{
    public partial class Form_Midical_Return_Done : Form
    {
        public int Midical_Done_id = 0;
        DB_FWDEntities DataBase = new DB_FWDEntities();

        View_Medical_Give_List view_Medical_Give_And_Tool_2 = new View_Medical_Give_List();
        TB_Medical_give tb_medical_give = new TB_Medical_give();

        TB_Medical_give tb_medical_giveR = new TB_Medical_give();



        public Form_Midical_Return_Done()
        {
            InitializeComponent();
 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

 
            try
            {

                tb_medical_give.Medical_give_ID = Midical_Done_id;
                tb_medical_give.Medical_give_return_status = "تم الارجاع";
                tb_medical_give.Medical_give_return_Date = DateTime.Today;

                DataBase.Set<TB_Medical_give>().Attach(tb_medical_give);
                var entry = DataBase.Entry(tb_medical_give);

                entry.Property(x => x.Medical_give_return_status).IsModified = true;
                entry.Property(x => x.Medical_give_return_Date).IsModified = true;

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

        private void Edit_Lable_Click(object sender, EventArgs e)
        {

        }

        private void Form_Midical_Return_Done_Load(object sender, EventArgs e)
        {
            view_Medical_Give_And_Tool_2 = DataBase.View_Medical_Give_List.Where(x => x.Medical_give_ID == Midical_Done_id).FirstOrDefault();
            Edit_Lable.Text = view_Medical_Give_And_Tool_2.Medical_give_recever;
            label_Pationt.Text = view_Medical_Give_And_Tool_2.Medical_give_patient;
            label_Date.Text = view_Medical_Give_And_Tool_2.Medical_give_date.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
