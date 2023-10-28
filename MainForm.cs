using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using DevExpress.XtraGauges.Win;
using DevExpress.XtraGauges.Win.Gauges;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Win.Gauges.Circular;


namespace FWD
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        //  private string connectionString = @"Data Source=DESKTOP-2V1AEKV\SQLEXPRESS;Initial Catalog=DB_FWD;Integrated Security=True;";

        int vart = 0;
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Emploee tb_user = new TB_Emploee();
        public int primation_id = 0;

        G_Waiting.Form_Wat_List form_Wat_List = new G_Waiting.Form_Wat_List();
        G_Waiting.Form_Wat_Add form_Wat_Add = new G_Waiting.Form_Wat_Add();
        G_Receives.Form_Receive_Add form_Receive_Add = new G_Receives.Form_Receive_Add();
        G_Receives.Form_Recive_List form_Recive_List = new G_Receives.Form_Recive_List();
        G_Representive.Form_Supp_Add form_Supp_Add = new G_Representive.Form_Supp_Add();
        G_Representive.Form_Supp_List form_Supp_List = new G_Representive.Form_Supp_List();
        G_Category.Form_Cat_Add form_Cat_Add = new G_Category.Form_Cat_Add();
        G_Category.Form_Cat_List form_Cat_List = new G_Category.Form_Cat_List();
        G_Donations.Form_Donation_Add form_Donation_Add = new G_Donations.Form_Donation_Add();
        G_Pocet.Form_Pocet_Add form_Pocet_Add = new G_Pocet.Form_Pocet_Add();
        G_Report_Forms.Form_Doctors form_Doctors = new G_Report_Forms.Form_Doctors();
        G_Report_Forms.Form_Pharmasy form_Pharmasy = new G_Report_Forms.Form_Pharmasy();
        G_Registered_Users.Form_Registered_Users_List form_registered_users_list = new G_Registered_Users.Form_Registered_Users_List();
        G_Courses.Form_Courses_List form_courses_list = new G_Courses.Form_Courses_List();
        G_Courses.Form_Take_Course_List form_take_courses_list = new G_Courses.Form_Take_Course_List();
        G_Medical_tools.Form_Midical_Tool_List form_midical_tool_list = new G_Medical_tools.Form_Midical_Tool_List();
        G_Medical_tools.Form_Medical_Give_List form_medical_give_list = new G_Medical_tools.Form_Medical_Give_List();
        G_Volanteer.Form_Volanteer_List form_volanteer_list = new G_Volanteer.Form_Volanteer_List();
        G_Volanteer.Form_Volanter_Subscribtion form_Volanter_Subscribtion = new G_Volanteer.Form_Volanter_Subscribtion();
        G_General_Report.Form_General_Report_List form_General_Report_list_1 = new G_General_Report.Form_General_Report_List();
        G_General_Report.Form_General_Report_List_2 form_General_Report_list_2 = new G_General_Report.Form_General_Report_List_2();
        G_General_Report.Form_General_Report form_General_Report = new G_General_Report.Form_General_Report();
        G_Registered_Users.Form_Registered_Users_Add form_registered_users_add = new G_Registered_Users.Form_Registered_Users_Add();
        G_Medical_tools.Form_Midical_Tool_Add form_Midical_Tool_Add = new G_Medical_tools.Form_Midical_Tool_Add();
        G_Volanteer.Form_Volanteer_Add form_Volanteer_Add = new G_Volanteer.Form_Volanteer_Add();

        G_Donations.Form_Donner_Add form_Donner_Add = new G_Donations.Form_Donner_Add();
        G_Doctors.Form_Doctor_info_Add form_Doctor_Info_Add = new G_Doctors.Form_Doctor_info_Add();
        G_Doctors.Form_Parmasist_Add form_Parmasist_Add = new G_Doctors.Form_Parmasist_Add();
        G_Courses.Form_Courses_Add form_courses_add = new G_Courses.Form_Courses_Add();
        G_Courses.Form_Take_Courses_Add form_take_courses_add = new G_Courses.Form_Take_Courses_Add();
        G_Medical_tools.Form_Medical_Give form_Medical_Give = new G_Medical_tools.Form_Medical_Give();

        G_Users.Form_User_Add form_User_Add = new G_Users.Form_User_Add();
        G_Users.Form_User_List form_User_list = new G_Users.Form_User_List();
        G_Customers.Form_Cus_List form_Cus_List = new G_Customers.Form_Cus_List();
        G_Customers.Form_cus_print form_Cus_Print = new G_Customers.Form_cus_print();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            make_rezizeable();
            MainForm_permations(primation_id);
        }

        private void MainForm_permations(int PiD)
        {
            TB_User_Permitions tb_permation = new TB_User_Permitions();
            tb_permation = DataBase.TB_User_Permitions.Where(x => x.Permition_ID == PiD).FirstOrDefault();

            if (tb_permation != null)
            {
                barButtonItem10.Enabled = tb_permation.Category_add == true;
                form_Cat_List.btn_del.Enabled = tb_permation.Category_del == true;
                form_Cat_List.simpleButton2.Enabled = tb_permation.Category_edit == true;
                barButtonItem9.Enabled = tb_permation.Category_list == true;
                barButtonItem21.Enabled = tb_permation.Course_add == true;
                form_courses_list.btn_del.Enabled = tb_permation.Course_del == true;
                form_courses_list.btn_edt.Enabled = tb_permation.Course_edit == true;
                barButtonItem22.Enabled = tb_permation.Course_list == true;
                barButtonItem15.Enabled = tb_permation.Doctor_add == true;
                form_Doctors.btn_del.Enabled = tb_permation.Doctor_del == true;
                barButtonItem32.Enabled = tb_permation.Doctor_doc_add == true;
                form_Doctor_Info_Add.btn_del.Enabled = tb_permation.Doctor_doc_del == true;
                form_Donation_Add.btn_del.Enabled = tb_permation.Donation_del == true;
                barButtonItem11.Enabled = tb_permation.Donation_List == true;
                barButtonItem52.Enabled = tb_permation.General_backup == true;
                barButtonItem46.Enabled = tb_permation.General_report_add == true;
                form_General_Report_list_1.btn_del.Enabled = tb_permation.General_report_del == true;
                form_General_Report_list_1.simpleButton2.Enabled = tb_permation.General_report_edit == true;
                form_General_Report_list_2.btn_del.Enabled = tb_permation.General_report_del == true;
                form_General_Report_list_2.simpleButton2.Enabled = tb_permation.General_report_edit == true;
                barButtonItem47.Enabled = tb_permation.General_report_list == true;
                barButtonItem48.Enabled = tb_permation.General_report_list == true;
                barButtonItem39.Enabled = tb_permation.General_server == true;
                barButtonItem45.Enabled = tb_permation.General_user_add == true;
                barButtonItem53.Enabled = tb_permation.General_user_list == true;
                barButtonItem26.Enabled = tb_permation.Midical_List_add == true;
                form_midical_tool_list.btn_del.Enabled = tb_permation.Midical_List_del == true;
                // barButtonItem1.Enabled = tb_permation.Midical_List_edit ==true;
                barButtonItem25.Enabled = tb_permation.Midical_List_list == true;
                barButtonItem29.Enabled = tb_permation.Midical_Receve_add == true;
                form_medical_give_list.btn_del.Enabled = tb_permation.Midical_Receve_del == true;
                form_medical_give_list.btn_edt.Enabled = tb_permation.Midical_Receve_edit == true;
                form_medical_give_list.simpleButton2.Enabled = tb_permation.Midical_Receve_return == true;
                barButtonItem16.Enabled = tb_permation.Pharmasy_add == true;
                form_Pharmasy.btn_del.Enabled = tb_permation.Pharmasy_del == true;
                barButtonItem33.Enabled = tb_permation.Pharmasy_doc_add == true;
                // barButtonItem1.Enabled = tb_permation.Pharmasy_doc_del ==true;
                form_Pocet_Add.btn_del.Enabled = tb_permation.Poket_del == true;
                barButtonItem12.Enabled = tb_permation.Poket_list == true;
                // barButtonItem6.Enabled = tb_permation.Receve_add ==true;
                form_Recive_List.btn_del.Enabled = tb_permation.Receve_del == true;
                barButtonItem5.Enabled = tb_permation.Receve_list == true;
                barButtonItem20.Enabled = tb_permation.Record_add == true;
                form_registered_users_list.btn_del.Enabled = tb_permation.Record_del == true;
                form_registered_users_list.btn_edt.Enabled = tb_permation.Record_edit == true;
                barButtonItem19.Enabled = tb_permation.Record_lisr == true;
                barButtonItem8.Enabled = tb_permation.Supp_add == true;
                form_Supp_List.btn_del.Enabled = tb_permation.Supp_del == true;
                form_Supp_List.simpleButton2.Enabled = tb_permation.Supp_edit == true;
                barButtonItem7.Enabled = tb_permation.Supp_list == true;
                barButtonItem23.Enabled = tb_permation.Trainer_add == true;
                form_take_courses_list.btn_del.Enabled = tb_permation.Trainer_del == true;
                // barButtonItem1.Enabled = tb_permation.Trainer_edit ==true;
                barButtonItem24.Enabled = tb_permation.Trainer_list == true;
                barButtonItem30.Enabled = tb_permation.volanteer_add == true;
                form_volanteer_list.btn_edt.Enabled = tb_permation.volanteer_edit == true;
                barButtonItem31.Enabled = tb_permation.Volanteer_list == true;
                barButtonItem37.Enabled = tb_permation.volanteer_subscription == true;
                barButtonItem2.Enabled = tb_permation.Wat_list_add == true;
                form_Wat_List.btn_del.Enabled = tb_permation.Wat_list_del == true;
                form_Wat_List.simpleButton2.Enabled = tb_permation.Wat_list_edit == true;
                barButtonItem1.Enabled = tb_permation.Wat_list_list == true;

                barButtonItem49.Enabled = tb_permation.Donation_Donnner == true;
                barButtonItem38.Enabled = tb_permation.Donation_Donnner == true;

                skinDropDownButtonItem2.Enabled = tb_permation.General_programe_set == true;
                barButtonItem34.Enabled = tb_permation.General_programe_set == true;
                barButtonItem35.Enabled = tb_permation.General_programe_set == true;
                barButtonItem36.Enabled = tb_permation.General_programe_set == true;
                barButtonItem53.Enabled = tb_permation.General_user_list == true;

                //     general_home.Enabled = tb_permation.General_home ?? false;
                //       barButtonItem45.Enabled = tb_permation.General_user_del ?? false;
            }
        }


        /*
         * 
       
        private string connectionString = @"Data Source=DESKTOP-2V1AEKV\SQLEXPRESS;Initial Catalog=DB_FWD;Integrated Security=True;";
        private int CountRecords(int num){
        int recordCount = 0;
            try{
                using (SqlConnection connection = new SqlConnection(connectionString)){
                    connection.Open();
                    string query1 = "SELECT COUNT(*) FROM TB_Registered_Users where Registered_Users_Rank = " + num;
                    using (SqlCommand command = new SqlCommand(query1, connection)) { recordCount = (int) command.ExecuteScalar();
                } 

                connection.Close();
                                }
            }
            catch (Exception ex){
                MessageBox.Show($"Error occurred while counting records: {ex.Message}");
            }
            return recordCount;
        }

        */

        private void Rools()
        {
            if (true)
            {
                barButtonItem2.Enabled = false;
                barButtonItem6.Enabled = false;

            }

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Wat_Add.Paner_wat_add);

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Wat_List.Pn_frm_wat);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            // MainHomePanel.Controls.Add(form_Cus_List.Pn_frm_cus);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Receive_Add.panel1);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Recive_List.Pn_frm_receive);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Supp_Add.panel1);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Supp_List.Pn_frm_supp);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {


            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Cat_Add.panel1);

        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Cat_List.Pn_frm_cat);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Donation_Add.Pn_frm_don);

        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Pocet_Add.Pn_frm_poc);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //        G_Customer.Form_Cus_Add form_Cus_Add = new G_Customer.Form_Cus_Add();
            //    form_Cus_Add.Show();

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Doctors.Pn_frm_doc);

        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Pharmasy.Pn_frm_phar);
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            G_Customers.Form1 form_Cust_Add = new G_Customers.Form1();
            form_Cust_Add.Show();

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            G_Customers.Form_Cust_Add f = new G_Customers.Form_Cust_Add();
            f.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_registered_users_add.panel1);
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_registered_users_list.Pn_frm_cat);

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_courses_add.panel1);

        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_take_courses_list.Pn_frm_cat);

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_courses_list.Pn_frm_cat);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_take_courses_add.panel1);
        }

        private void MakePanelEdgesRound(Panel panel)
        {
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - radius, panel.ClientRectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.ClientRectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void make_rezizeable()
        {

            int spaceSize = (flowLayoutPanel1.Width / 90);
            int unitSize = (flowLayoutPanel1.Width - spaceSize) / 5;
            vart = unitSize;
            panel1.Margin = new Padding(spaceSize);
            panel2.Margin = new Padding(spaceSize);
            panel3.Margin = new Padding(spaceSize);


            panel1.Size = new Size(unitSize - 35, flowLayoutPanel1.Height - 60);
            panel2.Size = new Size((3 * unitSize) - 55, flowLayoutPanel1.Height - 60);
            panel3.Size = new Size(unitSize - 35, flowLayoutPanel1.Height - 60);



            flowLayoutPanel_Min.Size = new Size((3 * unitSize) - 70, panel2.Height - 300);


            //flowLayoutPanel3.Size = new Size((3 * unitSize) - 100, 215);

            panel12.Size = new Size(unitSize - 75, 43);
            panel13.Size = new Size(unitSize - 75, 43);
            panel14.Size = new Size(unitSize - 75, 43);
            panel15.Size = new Size(unitSize - 75, 43);
            panel16.Size = new Size(unitSize - 75, 43);
            panel21.Size = new Size(unitSize - 75, 44);
            panel22.Size = new Size(unitSize - 75, 44);
            panel23.Size = new Size(unitSize - 75, 44);
            panel24.Size = new Size(unitSize - 75, 44);

            panel18.Size = new Size((3 * unitSize) - 100, 46);
            panel19.Size = new Size((3 * unitSize) - 100, 46);
            //panel20.Size = new Size((3 * unitSize) - 100, 46);

            searchControl1.Size = new Size(unitSize - 75, 10);
            //  separatorControl1.Size = new Size(unitSize - 75, 10);
            flowLayoutPanel2.Size = new Size(unitSize - 55, 300);
            progressBarControl1.Size = new Size(unitSize - 75, 10);
            progressBarControl2.Size = new Size(unitSize - 75, 10);
            progressBarControl3.Size = new Size(unitSize - 75, 10);
            progressBarControl4.Size = new Size(unitSize - 75, 10);

            panel25.Size = new Size(unitSize - 50, 44);
            panel27.Size = new Size(unitSize - 50, 44);
            panel26.Size = new Size(unitSize - 50, 44);


            gaugeControl6.Size = new Size((flowLayoutPanel4.Width / 5) - 15, 175 - 24);
            gaugeControl5.Size = new Size((flowLayoutPanel4.Width / 5) - 15, 175 - 24);
            gaugeControl4.Size = new Size((flowLayoutPanel4.Width / 5) - 15, 175 - 24);
            gaugeControl3.Size = new Size((flowLayoutPanel4.Width / 5) - 15, 175 - 24);
            gaugeControl2.Size = new Size((flowLayoutPanel4.Width / 5) - 15, 175 - 24);
            //  gaugeControl2.Size = new Size((flowLayoutPanel4.Width / 5) - 60, 175 - 24);

            int panelWidth = Math.Min(((panel2.Width - 115) / 5), 130); ;
            int panelHigt = Math.Min(((flowLayoutPanel_Min.Height - 36) / 2), 130);


            panel4.Size = new Size(panelWidth, panelHigt);
            panel5.Size = new Size(panelWidth, panelHigt);
            panel6.Size = new Size(panelWidth, panelHigt);
            panel7.Size = new Size(panelWidth, panelHigt);
            panel8.Size = new Size(panelWidth, panelHigt);
            panel9.Size = new Size(panelWidth, panelHigt);
            panel10.Size = new Size(panelWidth, panelHigt);
            panel11.Size = new Size(panelWidth, panelHigt);
            panel18.Size = new Size(panelWidth, panelHigt);
            panel19.Size = new Size(panelWidth, panelHigt);


            pictureBox1.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox2.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox3.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox4.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox5.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox6.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox7.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox8.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox14.Size = new Size(panelWidth, panelHigt - 40);
            pictureBox16.Size = new Size(panelWidth, panelHigt - 40);


            MakePanelEdgesRound(panel1);
            MakePanelEdgesRound(panel2);
            MakePanelEdgesRound(panel3);
            MakePanelEdgesRound(panel4);
            MakePanelEdgesRound(panel5);
            MakePanelEdgesRound(panel6);
            MakePanelEdgesRound(panel7);
            MakePanelEdgesRound(panel8);
            MakePanelEdgesRound(panel9);
            MakePanelEdgesRound(panel10);
            MakePanelEdgesRound(panel11);
            MakePanelEdgesRound(panel12);
            MakePanelEdgesRound(panel13);
            MakePanelEdgesRound(panel14);
            MakePanelEdgesRound(panel15);
            MakePanelEdgesRound(panel16);
            MakePanelEdgesRound(panel18);
            MakePanelEdgesRound(panel19);
            //   MakePanelEdgesRound(panel20);
            RoundPictureBox(pictureBox15);
            MakePanelEdgesRound(flowLayoutPanel2);

            Git_Data();


            //         labelComponent1.Text = "3456";

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            make_rezizeable();


        }


        private void CountRecordsButton_Click(object sender, EventArgs e)
        {

        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoundPictureBox(PictureBox pictureBox)
        {
            int borderRadius = 52; // Adjust this value to control the roundness of the edges

            // Create a rounded rectangle using GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            // Set the PictureBox's region to the rounded rectangle
            pictureBox.Region = new Region(path);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Wat_List.Pn_frm_wat);
        }



        void Git_Data()
        {
            try
            {
                List<TB_SUPP> tb_supp = DataBase.TB_SUPP.ToList();
                List<TB_SELL> tb_sell = DataBase.TB_SELL.ToList();
                List<TB_Course_info> tB_Course = DataBase.TB_Course_info.ToList();
                List<TB_volunteer> tB_Volunteers = DataBase.TB_volunteer.ToList();
                List<TB_WAT> tb_wat = DataBase.TB_WAT.ToList();



                List<TB_SELL> sell = DataBase.TB_SELL.ToList();
                List<TB_SUPP> supp = DataBase.TB_SUPP.ToList();
                List<TB_Take_Course> Take_Course = DataBase.TB_Take_Course.ToList();
                List<TB_Registered_Users> tB_Registered_Users = DataBase.TB_Registered_Users.ToList();
                List<TB_Registered_Users> rankA = tB_Registered_Users.Where(x => x.Registered_Users_Rank == 1).ToList();
                List<TB_Registered_Users> rankB = tB_Registered_Users.Where(x => x.Registered_Users_Rank == 2).ToList();
                List<TB_Registered_Users> rankC = tB_Registered_Users.Where(x => x.Registered_Users_Rank == 3).ToList();
                List<TB_Registered_Users> rankNO = tB_Registered_Users.Where(x => x.Registered_Users_Rank == 5).ToList();


                int sum = tB_Registered_Users.Count;
                if (sum == 0) sum = 1;

                label32.Text = Convert.ToString((rankA.Count * 100) / sum) + '%';
                progressBarControl4.EditValue = (rankA.Count * 100) / sum;

                label33.Text = Convert.ToString((rankB.Count * 100) / sum) + '%';
                progressBarControl1.EditValue = (rankB.Count * 100) / sum;

                label35.Text = Convert.ToString((rankC.Count * 100) / sum) + '%';
                progressBarControl2.EditValue = (rankC.Count * 100) / sum;

                label37.Text = Convert.ToString((rankNO.Count * 100) / sum) + '%';
                progressBarControl3.EditValue = (rankNO.Count * 100) / sum;


                int RT1 = (tB_Registered_Users.Count * 100) / 5000;
                labelComponent2.Text = Convert.ToString(tB_Registered_Users.Count);
                arcScaleRangeBarComponent3.Value = RT1 + 25;





                int RT2 = (tb_supp.Count * 100) / 120;
                labelComponent3.Text = Convert.ToString(tb_supp.Count);
                arcScaleRangeBarComponent4.Value = RT2 + 30;

                int RT3 = (tb_sell.Count * 100) / 5000;
                labelComponent5.Text = Convert.ToString(tb_sell.Count);
                arcScaleRangeBarComponent5.Value = RT3 + 30;


                int RT4 = (tB_Course.Count * 100) / 150;
                labelComponent7.Text = Convert.ToString(tB_Course.Count);
                arcScaleRangeBarComponent6.Value = RT4 + 30;


                int RT5 = (tB_Volunteers.Count * 100) / 200;
                labelComponent9.Text = Convert.ToString(tB_Volunteers.Count);
                arcScaleRangeBarComponent7.Value = RT5 + 30;

                int RT6 = (tb_wat.Count * 100) / 5000;
                labelComponent11.Text = Convert.ToString(tb_wat.Count);
                arcScaleRangeBarComponent8.Value = RT5 + 30;











                lable_git_help.Text = Convert.ToString(sell.Count);
                label_supp.Text = Convert.ToString(supp.Count);
                label_take_course.Text = Convert.ToString(Take_Course.Count);






            }
            catch
            {

            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sunburstControl1_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void separatorControl5_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Toast.Form_Loding form_Loding = new Toast.Form_Loding();
            form_Loding.Show();
            make_rezizeable();
        }

        private void Go_Home_ItemClick(object sender, ItemClickEventArgs e)
        {


            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(flowLayoutPanel1);
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            //**..
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_midical_tool_list.panel_Midical_tool);
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Medical_Give.panel1);
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_medical_give_list.Pn_frm_cat);
            G_Medical_tools.Form_Midical_Return form_N = new G_Medical_tools.Form_Midical_Return();
            form_N.Show();

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Midical_Tool_Add.panel1);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_medical_give_list.Pn_frm_cat);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            //  Toise.Toast_Waring ToastDone2 = new Toise.Toast_Waring();
            //   ToastDone2.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //Toise.Toast_Wrong ToastDone3 = new Toise.Toast_Wrong();
            // ToastDone3.Show();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {


            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Volanteer_Add.panel1);
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {


            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_volanteer_list.Pn_frm_cat);
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Doctor_Info_Add.panel2);
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Parmasist_Add.panel2);
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Addres_Add form_Addres_Add = new G_Setting.Form_Addres_Add();
            form_Addres_Add.Show();

        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Education_State_Add form_Education_State_Add = new G_Setting.Form_Education_State_Add();
            form_Education_State_Add.Show();


        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Helth_Add form_Helth_Add = new G_Setting.Form_Helth_Add();
            form_Helth_Add.Show();


        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Volanter_Subscribtion.Pn_frm_doc);
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Donner_Add.Pn_frm_don);
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_server_name form_Server_Name = new G_Setting.Form_server_name();
            form_Server_Name.Show();
        }

        private void buton_logout_ItemClick(object sender, ItemClickEventArgs e)
        {


            var rs = MessageBox.Show("هل انت متأكد من عملية تسجيل الخروج", "تسجيل الخروج", MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                G_Login.Form_Login_Pass form_Login_Pass = new G_Login.Form_Login_Pass();
                tb_user = DataBase.TB_Emploee.Where(x => x.Emploee_Roll_login_State == "true").FirstOrDefault();

                tb_user.Emploee_Roll_login_State = "false";
                DataBase.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
                this.Enabled = false;
                this.Hide();
                form_Login_Pass.Show();

            }





        }

        private void progressBarControl4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            //ribbon

        }

        private void ribbon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {

        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();

        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {


            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_User_Add.panel3);
        }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_General_Report.panel1);
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_General_Report_list_1.panel1);
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_General_Report_list_2.panel1);
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Donner_Add.Pn_frm_don);

        }

        private void flowLayoutPanel_Min_Paint(object sender, PaintEventArgs e)
        {

        }

        int arrow = 0;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            arrow++;
            if (arrow % 2 == 0) flowLayoutPanel_Min.Size = new Size((3 * vart) - 70, panel2.Height - 100);
            else flowLayoutPanel_Min.Size = new Size((3 * vart) - 70, 0);


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {
            arrow++;
            if (arrow % 2 == 0) flowLayoutPanel_Min.Size = new Size((3 * vart) - 70, panel2.Height - 100);
            else flowLayoutPanel_Min.Size = new Size((3 * vart) - 70, 0);

        }

        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_User_list.User_list_panel);
        }

        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_wating_cat form_add_cat = new G_Setting.Form_wating_cat();
            form_add_cat.Show();
        }

        private void barButtonItem52_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Backup backup = new G_Setting.Form_Backup();
            backup.Show();
        }

        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Cus_List.panel1);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            MainHomePanel.Controls.Add(form_Cus_Print.panel1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem55_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Donate_Dir form_Donate_Dir = new G_Setting.Form_Donate_Dir();
            form_Donate_Dir.Show();
        }

        private void barButtonItem56_ItemClick(object sender, ItemClickEventArgs e)
        {

            MainHomePanel.Controls.Clear();
            G_Setting.Form_commit_add form_commit_add = new G_Setting.Form_commit_add();
            form_commit_add.Show();
        }
        /*
        private void اضافة_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        */
        private void barButtonItem57_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_resercher form_resercher = new G_Setting.Form_resercher();
            form_resercher.Show();
        }

        private void barButtonItem58_ItemClick(object sender, ItemClickEventArgs e)
        {
            MainHomePanel.Controls.Clear();
            G_Setting.Form_Famile_Need_Reserch form_resercher_Need = new G_Setting.Form_Famile_Need_Reserch();
            form_resercher_Need.Show();
        }
    }
}