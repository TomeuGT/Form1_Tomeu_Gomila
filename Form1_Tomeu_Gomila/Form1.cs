using Microsoft.WindowsAPICodePack.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;


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
            NetworkConnection();
            GetAdapterName();
            VirtualBox();
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

        private void GetAdapterName()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.Name.Equals("Wi-Fi") || adapter.Name.Equals("Ethernet"))
                {
                    if (adapter.OperationalStatus == OperationalStatus.Up)
                    {
                        string mac_address = adapter.GetPhysicalAddress().ToString();
                        lbl_mac_address.Text = mac_address;

                        IPInterfaceProperties properties = adapter.GetIPProperties();

                        foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                        {
                            if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                lbl_ip.Text = unicast.Address.ToString();
                            }
                        }
                        GatewayIPAddressInformationCollection addresses = properties.GatewayAddresses;
                        if (addresses.Count > 0)
                        {

                            foreach (GatewayIPAddressInformation address in addresses)
                            {
                                lbl_getaway.Text = address.Address.ToString();
                            }
                        }

                        Ping myPing = new Ping();
                        PingReply reply = myPing.Send("1.1.1.1", 1000);
                        int PingInternetCounter = 0;
                        for (int numpings = 0; numpings < 4; numpings++)
                        {
                            if (reply.Status == IPStatus.Success)
                            {
                                PingInternetCounter++;

                                if (PingInternetCounter.Equals(4))
                                {
                                    lbl_Internet_Connection.Text = "Established";
                                    lbl_Internet_Connection.ForeColor = Color.Cyan;
                                }
                                if (PingInternetCounter > 0 && PingInternetCounter < 4)
                                {
                                    lbl_Internet_Connection.Text = "Unstable";
                                    lbl_Internet_Connection.ForeColor = Color.Yellow;
                                }
                            }
                            if (reply.Status != IPStatus.Success)
                            {
                                lbl_Internet_Connection.Text = "Disconnected";
                                lbl_Internet_Connection.ForeColor = Color.Red;
                            }
                        }

                    }

                }

            }
        }
        private void NetworkConnection()
        {
            var networks = NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected);
            foreach (var network in networks)
            {

                if (network.IsConnected)
                {
                    lbl_ssid_status.Text = "Connected";
                    lbl_ssid_status.ForeColor = Color.Cyan;

                }
                else if (!network.IsConnected)
                {
                    lbl_ssid_status.Text = "Disconnected";
                    lbl_ssid_status.ForeColor = Color.Red;
                }
                lbl_ssid.Text = network.Name;
            }
        }

        private void VirtualBox()
        {
            string strCmdText;
            strCmdText = "/C" + "\"C:\\Program Files\\Oracle\\virtualbox\\VBoxManage.exe\" --version";

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = strCmdText;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            string VBox_Version = "";
            while (!process.HasExited)
            {
                VBox_Version = VBox_Version + process.StandardOutput.ReadToEnd();
            }



            if (VBox_Version != "")
            {
                lbl_VirtualBoxInstalled.Text = "Yes";
                lbl_VirtualBoxInstalled.ForeColor = Color.Cyan;

                string Vbox_cut_version = VBox_Version.Substring(0, VBox_Version.IndexOf("r"));
                lbl_VBOX_V.Text = Vbox_cut_version;

                if (Vbox_cut_version.Equals("7.0.6"))
                {
                    lbl_VBOX_V.Text = Vbox_cut_version + " " + "(Last Version)";
                    lbl_VBOX_V.ForeColor = Color.Cyan;
                }
                if (!Vbox_cut_version.Equals("7.0.6"))
                {
                    lbl_VBOX_V.Text = Vbox_cut_version + " " + "(Outdated)";
                    lbl_VBOX_V.ForeColor = Color.Yellow;
                }
            }
            if (VBox_Version.Equals(""))
            {
                lbl_VirtualBoxInstalled.Text = "No";
                lbl_VirtualBoxInstalled.ForeColor = Color.Red;
                lbl_VBOX_V.Text = "N/A";
                lbl_VBOX_V.ForeColor = Color.Red;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
