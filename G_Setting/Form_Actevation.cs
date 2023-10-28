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

namespace FWD.G_Setting
{
    public partial class Form_Actevation : Form
    {
        public Form_Actevation()
        {
            InitializeComponent();
        }
    }

    public void GetMACAddress()
    {
        NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        String sMacAddress = string.Empty;
        foreach (NetworkInterface adapter in nics)
        {
            if (sMacAddress == String.Empty)// only return MAC Address from first card  
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                sMacAddress = adapter.GetPhysicalAddress().ToString();
            }
        }

        long decimalValue = Convert.ToInt64(sMacAddress, 16);
        //  return decimalValue;
      //  txtMacAddress.Text = decimalValue.ToString();
    }


}
