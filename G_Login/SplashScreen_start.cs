using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;

namespace FWD.G_Login
{
    public partial class SplashScreen_start : SplashScreen
    {

        private int uu = 1;
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Emploee tb_user = new TB_Emploee();
        MainForm mainform = new MainForm();
        G_Login.Form_Login_Pass form_Login_Pass = new G_Login.Form_Login_Pass();
        view_Emploee_login view_emploee_Login = new view_Emploee_login();
        public SplashScreen_start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2023-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                view_emploee_Login = DataBase.view_Emploee_login.Where(x => x.Emploee_Roll_login_State == "true").FirstOrDefault();

                if (tb_user != null)
                {

                    if (view_emploee_Login != null)
                    {
                        mainform.Show();
                        Class_main.emp_login_id = view_emploee_Login.Emploee_ID;
                        mainform.User_name_home.Caption = view_emploee_Login.Emploee_Name;
                        mainform.user_Roll.Caption = view_emploee_Login.Emploee_Roll_Name;
                    }
                    else
                    {
                        form_Login_Pass.Show();
                    }


                }
                else
                {
                    form_Login_Pass.Show();
                }

                this.Hide();
                timer1.Enabled = false;


            }
            catch
            {
                if (uu == 1)
                {

                    G_Setting.Form_server_name form_Server_Name = new G_Setting.Form_server_name();
                    form_Server_Name.Show();
                    timer1.Enabled = false;

                }
            }
        }

        private void peLogo_EditValueChanged(object sender, EventArgs e)
        {
            G_Setting.Form_server_name form_Server_Name = new G_Setting.Form_server_name();
            form_Server_Name.Show();
        }

        private void SplashScreen_start_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}