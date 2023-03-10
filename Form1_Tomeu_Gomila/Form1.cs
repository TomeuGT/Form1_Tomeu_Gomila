using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Reflection.Emit;



namespace Form1_Tomeu_Gomila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetUserName();
            DisplayIPAddress();
            DisplayGatewayInLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetUserName()
        {
            String UserName = Environment.UserName;
            lbl_Username.Text = UserName;
            string hostName = Dns.GetHostName();
            lbl_Hostname.Text = hostName;

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
        }

        private void DisplayIPAddress()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();

                    foreach (UnicastIPAddressInformation address in ipProperties.UnicastAddresses)
                    {
                        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            lbl_ip.Text = address.Address.ToString();
                            return;
                        }
                    }
                }
            }

            lbl_ip.Text = "IP address: Not found";
        }

        public void DisplayGatewayInLabel()
        {
            
            NetworkInterface activeInterface = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(ni => ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback);

            if (activeInterface != null)
            {
                
                IPInterfaceProperties ipProps = activeInterface.GetIPProperties();

                
                GatewayIPAddressInformation gateway = ipProps.GatewayAddresses.FirstOrDefault();

                if (gateway != null)
                {
                    
                    lbl_getaway.Text = gateway.Address.ToString();
                }
                else
                {
                    lbl_getaway.Text = "No gateway found.";
                }
            }
            else
            {
                lbl_getaway.Text = "No active network interface found.";
            }
        }
       
    }
}
