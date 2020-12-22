using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Reflection;
using System.Net.NetworkInformation;

namespace NetProg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbIP.Text += GetLocalIPAddress();
            cbDrives.Text += GetDrives();
            cbOS.Text += Environment.OSVersion.ToString();
            cbRAM.Text += GetRAM();
            cbAntivirus.Text += GetAntivirus();
            cbDomain.Text += Dns.GetHostName();
            cbInDomain.Text += GetListOfDomainsIn();
            tbPorts.Text += GetPorts();
            cbPorts.Text = "Порты: ";
            cbFormat.Items.Add("doc|.doc");
            cbFormat.Items.Add("csv|.csv");
            cbFormat.Items.Add("txt|.txt");
            cbFormat.Items.Add("rtf|.rtf");
            cbFormat.Items.Add("xml|.xml");
        }

        private static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return ("IPV4 адаптеры не обнаружены");
        }

        private static string GetDrives()
        {
            string Drives = "";
            foreach (var drive in DriveInfo.GetDrives())
            {
                Drives += drive.Name + ": " + String.Format("{0:0.00}", Convert.ToDouble(drive.TotalSize) / 1024 / 1024 / 1024) + " Гб" + "; ";
            }
            return Drives;
        }

        private static string GetRAM()
        {
            ManagementObjectSearcher ramMonitor = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");
            foreach (ManagementObject objram in ramMonitor.Get())
            {
                double totalRam = Convert.ToDouble(objram["TotalVisibleMemorySize"]);    //общая память ОЗУ
                return String.Format("{0:0.00}", totalRam / 1024 / 1024) + " Гб";

            }
            throw new Exception("Неизвестная ошибка при определении ОЗУ");
        }

        private static string GetAntivirus()
        {
            ManagementObjectSearcher av_srch = new ManagementObjectSearcher("root\\SecurityCenter2", "SELECT * FROM AntiVirusProduct");

            foreach (ManagementObject av in av_srch.Get())
            {
                try
                {
                    return av["dispayName"].ToString();
                }
                catch
                {
                    return "не найден";
                }
            }
            throw new Exception("Неизвестная ошибка при определении антивируса");
        }

        public static string GetPorts()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = properties.GetActiveTcpConnections();
            string ports = "";
            foreach (TcpConnectionInformation port in tcpConnections)
            {
                ports += port.LocalEndPoint.Port + "; ";
            }
            return ports;
        }

        public static string GetListOfDomainsIn()
        {
            var hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] ipAddresses = hostEntry.AddressList;
            string DomainsList = "";
            foreach (IPAddress ip in ipAddresses)
                DomainsList += Dns.GetHostEntry(ip.ToString()).HostName + "; ";
            return DomainsList;
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var control in Controls)
                if (control is CheckBox cb && cb.Checked)
                {
                    text += cb.Text + "\n";
                    if (cb == cbPorts)
                    {
                        text += tbPorts.Text;
                    }
                }
            var SFD = new SaveFileDialog();
            SFD.Filter = cbFormat.Text;
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                string filename = SFD.FileName;
                File.WriteAllText(filename, text, Encoding.UTF8);
            }
        }
    }
}
