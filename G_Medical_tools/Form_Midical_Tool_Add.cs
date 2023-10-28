using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FWD.BL;


namespace FWD.G_Medical_tools
{
    public partial class Form_Midical_Tool_Add : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Medical_tool tb_medical_tool = new TB_Medical_tool();
        BL.Methods methods = new BL.Methods();
        public Form_Midical_Tool_Add()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();

            try { 
                tb_medical_tool.Medical_tool_Name = edit_tool_name.Text;
                tb_medical_tool.Medical_tool_owner = edit_tool_owner.Text;
                tb_medical_tool.Medical_tool_num = Convert.ToInt32(edit_tool_num.Text);
                tb_medical_tool.Medical_tool_info = edit_tool_info.Text;

                pictureEdit1.Image.Save(methods.ma, System.Drawing.Imaging.ImageFormat.Png);
                tb_medical_tool.Medical_tool_image = methods.convert_byte();
                DataBase.TB_Medical_tool.Add(tb_medical_tool);
                DataBase.SaveChanges();

                ToastDone.LbTitelAlterBox.Text = "تمت عملية التسجيل";
                ToastDone.Show();
                this.Close();
            }
            catch
            {
                ToastWaring.Lable_Text.Text = "حدث خطاء اثناء التسجيل";
                ToastWaring.Show();
            }


        }
    }
}
