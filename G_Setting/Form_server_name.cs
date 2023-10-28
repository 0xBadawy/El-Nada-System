using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FWD.G_Setting
{
    public partial class Form_server_name : Form
    {
        public Form_server_name()
        {
            InitializeComponent();
        }

        private void Form_server_name_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            const string QU = "\"";
            var SV = Edit_Server.Text;
            var constr = @"metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string="+QU+";data source="+SV+";initial catalog=DB_FWD;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["DB_FWDEntities"].ConnectionString = constr;


            config.Save();
            ConfigurationManager.RefreshSection("connectionString");

            var strl = config.ConnectionStrings.ConnectionStrings["DB_FWDEntities"].ConnectionString = constr;

            MessageBox.Show(strl);

            Application.Restart();
            

        }
    }
}
