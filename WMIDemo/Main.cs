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
            Console.WriteLine("���к�="+getInfo.GetSerialNumber());
            Console.WriteLine("CPU���=" + getInfo.GetCpuID());
            Console.WriteLine("Ӳ�̱��=" + getInfo.GetMainHardDiskId());
            Console.WriteLine("�������=" + getInfo.GetNetworkAdapterId());
            Console.WriteLine("�û���=" + getInfo.GetGroupName());
            Console.WriteLine("���������=" + getInfo.GetDriverInfo());
            Console.ReadLine();
        }
    }
}

   public string GetSerialNumber() //��ȡ����ϵͳ���к�
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


   public string GetCpuID()   //��ѯCPU���
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


    public string GetMainHardDiskId()  //��ѯӲ�̱��
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

     public string GetDriverInfo() //��ѯ������״̬
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

   public string GetGroupName() //��ȡ�û�����Ϣ
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
 
   public string GetNetworkAdapterId()//��ѯ�������
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


