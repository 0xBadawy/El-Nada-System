using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWD
{
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new G_Login.SplashScreen_start());
            //  Application.Run(new G_Login.SplashScreen_start());
            // Application.Run(new G_Customers.Form_Cus_Person());
            //   Application.Run(new G_Customers.Form_Cus_List()) ;
            // Application.Run(new G_Setting.Form_DashBoard());
            //    Application.Run(new G_General_Report.Form_General_Report());
            //  Application.Run(new G_General_Report.Form_General_Report_List());
            //  Application.Run(new G_Customers.Form_Cust_Add());
            //    Application.Run(new G_Medical_tools.Form_Medical_Give_List());
             // Application.Run(new MainForm()) ;

       //     try
      //      {
                Application.Run(new G_Login.SplashScreen_start());
    //        }
    //        catch (Exception ex)
    //        {
                // Handle the exception here, for example, you can display an error message
     //           MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     //       }

        }

    }
}
