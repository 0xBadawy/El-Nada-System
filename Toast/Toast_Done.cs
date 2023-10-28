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

namespace FWD.Toise
{
    public partial class Toast_Done : Form
    {
        private const int CornerRadius = 35;

        public Toast_Done()
        {
            InitializeComponent();
            Start_possiton();
            animationTimer = new Timer();
            animationTimer.Interval = 100; // Set the interval for the timer (adjust as needed)
            animationTimer.Tick += timer1_Tick_1;


            LbTitelAlterBox.Text = "تــم بـنـجـاح";
            Lable_Text.Text = "تمت الاضافة بنجاح";
        }
        private int targetWidth = 500; // Set the desired final width
        private int currentWidth = 0;
        private int animationDuration = 2000; // Set the duration of the animation in milliseconds
        private Timer animationTimer ;

        private void timer1_Tick(object sender, EventArgs e)
        {

            linePanel.Width = linePanel.Width + 2;
            if (linePanel.Width == 550)
                this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int increment = (int)Math.Ceiling(targetWidth / (double)animationDuration * animationTimer.Interval);

            if (currentWidth < targetWidth){
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                   
        }


        private void Toast_Done_Load(object sender, EventArgs e)
        {
            animationTimer = new Timer();
            animationTimer.Interval = 20; 
            animationTimer.Tick += timer1_Tick_1;
            animationTimer.Start();

            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            SetStyle(ControlStyles.ResizeRedraw, true);
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;

            SetStyle(ControlStyles.ResizeRedraw, true);

        }


        private void Lable_Text_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
