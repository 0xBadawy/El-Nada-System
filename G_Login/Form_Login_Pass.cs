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
using System.Diagnostics;


namespace FWD.G_Login
{
    public partial class Form_Login_Pass : Form
    {
        DB_FWDEntities DataBase = new DB_FWDEntities();
        TB_Emploee tb_user = new TB_Emploee();
        MainForm mainform = new MainForm();
        string pass = "";
        private const int CornerRadius = 50;
        public Form_Login_Pass()
        {
            InitializeComponent();

      //      Application.EnableVisualStyles();
      //      Application.Run(new Form_Login_Pass());

            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            SetStyle(ControlStyles.ResizeRedraw, true);
            RoundPictureBox(pictureBox1);

            Region roundedRegion1 = new Region(CreateRoundRectangle(simpleButton1.ClientRectangle, 20));

            // Apply the rounded region to the button
            simpleButton1.Region = roundedRegion1;

            Region roundedRegion = new Region(CreateRoundRectangle(simpleButton2.ClientRectangle, 20));
            simpleButton2.Region = roundedRegion;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();

                Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    graphics.DrawPath(pen, path);
                }
            }

            base.OnPaint(e);
        }

        // [STAThread]
        private void RoundPictureBox(PictureBox pictureBox)
        {
            int borderRadius = 52; 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(pictureBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(pictureBox.Width - borderRadius, pictureBox.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, pictureBox.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            pictureBox.Region = new Region(path);
        }

        private GraphicsPath CreateRoundRectangle(Rectangle rectangle, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();      
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }


        private void Form_Login_Pass_Load(object sender, EventArgs e)
        {
            password.Properties.PasswordChar = '*';
            //    mainform.Enabled = false;
            //   mainform.Hide();
            Lable00(label5);
            Lable00(label3);
            Lable00(label7);
            Lable00(label8);
            Lable00(label9);

        }

        private void Lable00(Label lable)
        {
            lable.Parent = pictureBox1;
            lable.BackColor = Color.Transparent;
            lable.ForeColor = Color.White;

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void separatorControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void edt_per_phone_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void edt_per_ssn_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.example.com");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            G_Setting.Form_server_name form_Server_Name = new G_Setting.Form_server_name();
            form_Server_Name.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
          //  MainHomePanel.Controls.Clear();
            G_Setting.Form_server_name form_Server_Name = new G_Setting.Form_server_name();
            form_Server_Name.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            login();


        }

        void login()
        {
            Toise.Toast_Done ToastDone = new Toise.Toast_Done();
            Toise.Toast_Waring ToastWaring = new Toise.Toast_Waring();
            Toise.Toast_Wrong toast_Wrong = new Toise.Toast_Wrong();
            try
            {
                if (user_Name.Text == "" && password.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "ادخل اسم المستخدم و كلمة المرور";
                    ToastWaring.Show();
                    return;
                }

                if (user_Name.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "اسم المستخدم مطلوب";
                    ToastWaring.Show();
                    return;

                }

                if (password.Text == "")
                {
                    ToastWaring.Lable_Text.Text = "كلمة السر مطلوبة";
                    ToastWaring.Show();
                    return;
                }


                tb_user = DataBase.TB_Emploee.Where(x => x.Emploee_UserName == user_Name.Text && x.Emploee_Password == password.Text).FirstOrDefault();

                if (tb_user != null)
                {
                    ToastDone.Lable_Text.Text = "تم تسجيل الدخول";
                    ToastDone.Show();
                    mainform.User_name_home.Caption = tb_user.Emploee_Name;

                    if (tb_user.Emploee_Roll == 1) mainform.user_Roll.Caption = "مدير";
                    else mainform.user_Roll.Caption = "موظف";
                    mainform.Enabled = true;

                    Class_main.emp_login_id = tb_user.Emploee_ID;
                    mainform.primation_id = Convert.ToInt32(tb_user.Emploee_permitions);
                    tb_user.Emploee_Roll_login_State = "true";
                    DataBase.Entry(tb_user).State = System.Data.Entity.EntityState.Modified;
                    DataBase.SaveChanges();
                    mainform.Show();
                    this.Close();

                }
                else
                {

                    toast_Wrong.Lable_Text.Text = "خطا فى تسجيل الدخول";
                    toast_Wrong.Show();
                }



            }
            catch
            {
                toast_Wrong.Lable_Text.Text = "حدث خطأ";
                toast_Wrong.Show();

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.Properties.PasswordChar = '\0';

            }
            else
            {
                password.Properties.PasswordChar = '*';

            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
           
        }

        private void password_DragEnter(object sender, DragEventArgs e)
        {
 login();
        }
    }
}
