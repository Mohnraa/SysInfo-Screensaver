using System;
using System.Management;

namespace SysInfo_Screensaver
{
    internal class WMIC_Interface
    {

        //Objetos para hacer un query WMIC para CPU
        static SelectQuery qCPU = new SelectQuery("Win32_Processor");
        static ManagementObjectSearcher sCPU = new ManagementObjectSearcher(qCPU);
        ManagementObjectCollection cCPU = sCPU.Get();

        //Objetos para hacer un query WMIC para RAM
        static SelectQuery qRAM = new SelectQuery("Win32_ComputerSystem");
        static ManagementObjectSearcher sRAM = new ManagementObjectSearcher(qRAM);
        ManagementObjectCollection cRAM = sRAM.Get();

        //Objetos para hacer un query WMIC para Almacenamiento
        static SelectQuery qHDD = new SelectQuery("Win32_DiskDrive");
        static ManagementObjectSearcher sHDD = new ManagementObjectSearcher(qHDD);
        ManagementObjectCollection cHDD = sHDD.Get();

        //Objetos para hacer un query WMIC para GPU
        static SelectQuery qGPU = new SelectQuery("Win32_VideoController");
        static ManagementObjectSearcher sGPU = new ManagementObjectSearcher(qGPU);
        ManagementObjectCollection cGPU = sGPU.Get();

        public WMIC_Interface()
        {

        }

        public String getCPU()
        {
            String cputemp = "";
            foreach (ManagementObject o in cCPU)
            {
                cputemp = (string)o["Name"];
            }

            return removeTM(cputemp);
        }

        public String getRAM()
        {
            String ramFinal = "";
            UInt64 temp;
            foreach (ManagementObject o in cRAM)
            {
                ramFinal = o["TotalPhysicalMemory"].ToString();
            }
            temp = Convert.ToUInt64(ramFinal);
            temp = temp / 1073741824;
            if (temp == 31 || temp == 15 || temp == 7 || temp == 3 || temp == 1) temp = temp + 1;
            ramFinal = temp.ToString() + " GB";
            return ramFinal;
        }

        public String getHDD()
        {
            String HDD_size = "";
            String HDD_size2 = "";
            string HDD_name = "";
            Boolean PD2 = false;

            foreach (ManagementObject o in cHDD)
            {
                HDD_name = o["Name"].ToString();
                if (HDD_name.Contains("PHYSICALDRIVE0")) HDD_size = o["Size"].ToString();
                if (HDD_name.Contains("PHYSICALDRIVE1")) HDD_size2 = o["Size"].ToString();
                if (HDD_name.Contains("PHYSICALDRIVE2")) PD2 = true;
            }
            if (PD2) return formatHDDString(HDD_size) + ", " + formatHDDString(HDD_size2);
            return formatHDDString(HDD_size);
        }

        public String getGPU()
        {
            String gpuName = "";

            foreach (ManagementObject o in cGPU)
            {
                gpuName = o["Name"].ToString();
            }
            return removeTM(gpuName);
        }

        private String formatHDDString(String HDD_raw)
        {
            if (HDD_raw.Length == 13) HDD_raw = HDD_raw.Substring(0, 1) + " TB";
            if (HDD_raw.Length == 12) HDD_raw = HDD_raw.Substring(0, 3) + " GB";
            if (HDD_raw.Length == 11) HDD_raw = HDD_raw.Substring(0, 2) + " GB";
            if (HDD_raw.Length == 10) HDD_raw = HDD_raw.Substring(0, 1) + " GB";
            return HDD_raw;
        }

        private String removeTM(String temp)
        {
            temp = temp.Replace("(TM)", "");
            temp = temp.Replace("(R)", "");
            temp = temp.Replace("CPU ", "");
            return temp;
        }
    }
}