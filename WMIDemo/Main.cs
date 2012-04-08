using System;
using System.Collections.Generic;
using System.Text;
using System.Management;

namespace WMIDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GetSystemInfo getInfo = new GetSystemInfo();
            Console.WriteLine("序列号="+getInfo.GetSerialNumber());
            Console.WriteLine("CPU编号=" + getInfo.GetCpuID());
            Console.WriteLine("硬盘编号=" + getInfo.GetMainHardDiskId());
            Console.WriteLine("网卡编号=" + getInfo.GetNetworkAdapterId());
            Console.WriteLine("用户组=" + getInfo.GetGroupName());
            Console.WriteLine("驱动器情况=" + getInfo.GetDriverInfo());
            Console.ReadLine();
        }
    }
}

   public string GetSerialNumber() //获取操作系统序列号
        {
            string result = "";
            ManagementClass mClass = new ManagementClass("Win32_OperatingSystem");
            ManagementObjectCollection moCollection = mClass.GetInstances();
            foreach (ManagementObject mObject in moCollection)
            {
                result += mObject["SerialNumber"].ToString() + " ";
            }
            return result;
        }


   public string GetCpuID()   //查询CPU编号
        {
            string result = "";
            ManagementClass mClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moCollection = mClass.GetInstances();
            foreach (ManagementObject mObject in moCollection)
            {
                result += mObject["ProcessorId"].ToString() + " ";
            }
            return result;
        }


    public string GetMainHardDiskId()  //查询硬盘编号
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection moCollection = searcher.Get();
            foreach (ManagementObject mObject in moCollection)
            {
                result += mObject["SerialNumber"].ToString() + " ";
            }
            return result;
        }

     public string GetDriverInfo() //查询驱动器状态
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root/CIMV2", "SELECT * FROM Win32_LogicalDisk");
            ManagementObjectCollection moCollection = searcher.Get();
            foreach (ManagementObject mObject in moCollection)
            {
              
                if (mObject["DriveType"].ToString() == "3")
                {
                    result += string.Format("Name={0},FileSystem={1},Size={2},FreeSpace={3} ", mObject["Name"].ToString(),
                        mObject["FileSystem"].ToString(), mObject["Size"].ToString(), mObject["FreeSpace"].ToString());
                }
            }
            return result;
        }

   public string GetGroupName() //获取用户组信息
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root/CIMV2", "SELECT * FROM Win32_Group");
            ManagementObjectCollection moCollection = searcher.Get();
            foreach (ManagementObject mObject in moCollection)
            {
                result += mObject["Name"].ToString() + " ";
            }
            return result;
        }
 
   public string GetNetworkAdapterId()//查询网卡编号
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT MACAddress FROM Win32_NetworkAdapter WHERE ((MACAddress Is Not NULL)AND (Manufacturer <> 'Microsoft'))");
            ManagementObjectCollection moCollection = searcher.Get();
            foreach (ManagementObject mObject in moCollection)
            {
                result += mObject["MACAddress"].ToString() + " ";
            }
            return result;
        }


