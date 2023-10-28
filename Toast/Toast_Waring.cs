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

namespace FWD.Toise
{
    public partial class Toast_Waring : Form
    {
        private const int CornerRadius = 35;
        private int targetWidth = 500; 
        private int currentWidth = 0;
        private int animationDuration = 2000; 
        private Timer animationTimer;

        public Toast_Waring()
        {
            InitializeComponent();
            Start_possiton();

            timer1 = new Timer();
            timer1.Interval = 1000;  
            timer1.Tick += timer1_Tick;

            animationTimer = new Timer();
            animationTimer.Interval = 100; // Set the interval for the timer (adjust as needed)
            animationTimer.Tick += timer1_Tick;

            LbTitelAlterBox.Text = "تـحــذيـر حدث خطأ";
            Lable_Text.Text = "حدث خطا اثناء حفظ البيانات";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (linePanel != null)
            {
                linePanel.Width = currentWidth;
            }

            int increment = (int)Math.Ceiling(targetWidth / (double)animationDuration * animationTimer.Interval);

            if (currentWidth < targetWidth)
            {
                currentWidth += increment;
                if (currentWidth > targetWidth)
                    currentWidth = targetWidth;
                linePanel.Width = currentWidth;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void Toast_Waring_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Toast_Waring_Load(object sender, EventArgs e)
        {
            animationTimer = new Timer();
            animationTimer.Interval = 20;
            animationTimer.Tick += timer1_Tick;
            animationTimer.Start();

            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            SetStyle(ControlStyles.ResizeRedraw, true);
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            SetStyle(ControlStyles.ResizeRedraw, true);
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

        private void Start_possiton()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            int formX = screenWidth - formWidth;
            int formY = screenHeight - formHeight;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(formX, formY);
        }

        private void Lable_Text_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
