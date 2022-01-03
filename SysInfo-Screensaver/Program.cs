using System;
using System.Management;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysInfo_Screensaver
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }

    public class WMIC_Interface
    {   
        //CPU QUERY
        static SelectQuery qCPU = new SelectQuery("Win32_Processor");
        static ManagementObjectSearcher sCPU = new ManagementObjectSearcher(qCPU);
        ManagementObjectCollection cCPU = sCPU.Get();

        //RAM QUERY
        static SelectQuery qRAM = new SelectQuery("Win32_ComputerSystem");
        static ManagementObjectSearcher sRAM = new ManagementObjectSearcher(qRAM);
        ManagementObjectCollection cRAM = sRAM.Get();

        //HDD QUERY
        static SelectQuery qHDD = new SelectQuery("Win32_ComputerSystem");
        static ManagementObjectSearcher sHDD = new ManagementObjectSearcher(qHDD);
        ManagementObjectCollection cHDD = sHDD.Get();

        //GPU QUERY

        public WMIC_Interface()
        {

        }
        public String getCPU()
        {
            String cputemp = "";
            foreach(ManagementObject o in cCPU)
            {
                cputemp = (string)o["Name"];
            }
            return cputemp;
        }
        public String getRAM()
        {
            String ramFinal = "";
            UInt64 temp;
            foreach(ManagementObject o in cRAM)
            {
                ramFinal = o["TotalPhysicalMemory"].ToString();
            }
            temp = Convert.ToUInt64(ramFinal);
            temp = temp / 1073741824;
            ramFinal = temp.ToString() + " GB";
            return ramFinal;
        }
        public String getHDD()
        {
            String HDD_size = "240 GB";
            return HDD_size;
        }
        public String getGPU()
        {
            String gpuName = "Intel HD Graphics";
            return gpuName;
        }
    }
}
