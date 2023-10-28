using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Management;
using DevExpress.XtraPrinting.BarCode;
using System.Diagnostics;


namespace FWD.G_Setting
{
    public partial class Form_Active_program : Form
    {
        private string MacAdd = "";
        private string MacAddHexa = "";
        long Value_Key = 0;
        public Form_Active_program()
        {
            InitializeComponent();
        }




        private void Form_Active_program_Load(object sender, EventArgs e) {
            GetMACAddress();
            barCode.Text = MacAdd;
            textBox1.Text = MacAdd;
            MacHexa.Text = MacAddHexa;
            info();

        }
        public void GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics) {
                if (sMacAddress == String.Empty) {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            long decimalValue = Convert.ToInt64(sMacAddress, 16);
            Value_Key = decimalValue;
      //      txtMacAddress.Text = decimalValue.ToString();
            MacAdd = decimalValue.ToString();
            MacAddHexa = sMacAddress;
        }

        private void txtMacAddress_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void info()
        {
            DateText.Text = DateTime.Today.ToString("yyyy / MM / dd");
        }

        private void Acctive_Click(object sender, EventArgs e) {

            if (txtMacAddress.Text == code_01() && Edit_Key.Text==code_02())
            {

            }
            else
            {
                G_Setting.Form_Message_wrong form_Message_Wrong = new Form_Message_wrong();
                form_Message_Wrong.textBox2.Visible = true;
                form_Message_Wrong.Show();
            }

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MacHexa_TextChanged(object sender, EventArgs e)
        {

        }

        private string code_01 (){
            long num = Convert.ToInt64(MacAdd);
            string Day= DateTime.Today.ToString("MMdd");
            num *= 98;
            num += 68;
            num *= 19;
            num += 95;
            string c_01 = "FM" + num.ToString() + "FK89"+ Day;
            return c_01;
        }

        private string code_02(){
            long num = Convert.ToInt64(MacAdd);
            string Day = DateTime.Today.ToString("yyyy");
            num -= 54895;
            num *= 2;
            num *= 6;
            num += 13;
            string c_02 = "DB-"+Day + num.ToString() + "-FWD";
            return c_02; 
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://wa.me/qr/7NENXXVXZCAPI1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string textToCopy = MacAdd;
            Clipboard.SetText(textToCopy);
            MessageBox.Show("! تم نسخ كود النسخة");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string textToCopy = MacAdd;
            Clipboard.SetText(textToCopy);
            MessageBox.Show("! تم نسخ كود النسخة");
        }
    }
}
