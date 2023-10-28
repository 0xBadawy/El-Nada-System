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

namespace FWD.Home
{
    public partial class Form_Home_panle_1 : Form
    {
        public Form_Home_panle_1()
        {
            InitializeComponent();
            make_rezizeable();

        }

        private void Form_Home_panle_1_Load(object sender, EventArgs e)
        {
            make_rezizeable();

        }


        private void MakePanelEdgesRound(Panel panel)
        {
            int radius = 15; 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(panel.ClientRectangle.Width - radius, panel.ClientRectangle.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, panel.ClientRectangle.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.CloseFigure();
            panel.Region = new Region(path);
        }


        private void Form_Home_panle_1_Resize(object sender, EventArgs e)
        {
            make_rezizeable();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void make_rezizeable()
        {

            int spaceSize = (flowLayoutPanel1.Width / 90);
            int unitSize = (flowLayoutPanel1.Width - spaceSize) / 5;

            panel1.Margin = new Padding(spaceSize);
            panel2.Margin = new Padding(spaceSize);
            panel3.Margin = new Padding(spaceSize);


            panel1.Size = new Size(unitSize-35, flowLayoutPanel1.Height - 60);
            panel2.Size = new Size((3* unitSize)-70, flowLayoutPanel1.Height - 60);
            panel3.Size = new Size(unitSize - 35, flowLayoutPanel1.Height - 60);

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
          //  MakePanelEdgesRound(panel2);

        }





    }
}
