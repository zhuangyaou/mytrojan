using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.Collections;
using System.ServiceProcess;
using System.Management;
using Microsoft.VisualBasic.Devices;

namespace Jackch
{
    public class SystemInfo
    {
        public string GetMyOSName()
        {
            //��ȡ��ǰ����ϵͳ��Ϣ
            OperatingSystem MyOS = Environment.OSVersion;
            string MyOSName = "";
            //����汾���� 5, ����Ӧ���� Win2K, XP��2003
            if (MyOS.Version.Major == 5)
            {
                switch (MyOS.Version.Minor)
                {
                    case 0:
                        MyOSName = "Windows 2000";
                        break;
                    case 1:
                        MyOSName = "Windows XP";
                        break;
                    case 2:
                        MyOSName = "Windows Server 2003";
                        break;
                    default:
                        MyOSName = MyOS.ToString();
                        break;
                }
            }
            else
            {
                // ������ NT4 
                MyOSName = MyOS.VersionString;
            }
            //��ȡSP��Ϣ
            string MySPName = MyOS.ServicePack;
            return MyOSName + " " + MySPName;
        }
        public string GetMyComputerName()
        {//��ȡ��ǰ���������
            string MyComputerName = Environment.GetEnvironmentVariable("ComputerName");
            return MyComputerName;
        }
        public string GetMyUserName()
        {//��ȡ��ǰ�û�����
            string MyUserName = Environment.GetEnvironmentVariable("UserName");
            return MyUserName;
        }
        public string GetMyPaths()
        {//��ȡ��ǰϵͳĬ��·��������Ϣ,��������
            string MyPaths = Environment.GetEnvironmentVariable("Path");
            return MyPaths;
        }
        public string GetMyDriveInfo()
        {//��ȡ�������Ĵ洢�ռ��С
            string[] MyDrive = Environment.GetLogicalDrives();
            long s0 = 0, s1 = 0;
            foreach (string MyDriveLetter in MyDrive)
            {
                try
                {
                    DriveInfo MyDriveInfo = new DriveInfo(MyDriveLetter);
                    if (MyDriveInfo.DriveType == DriveType.CDRom || MyDriveInfo.DriveType == DriveType.Removable)
                        continue;
                    s0 += MyDriveInfo.TotalSize;
                    s1 += MyDriveInfo.TotalFreeSpace;
                }
                catch { }
            }
            return (s1 / 1073741824).ToString() + "G/" + (s0 / 1073741824).ToString() + "G";
        }

        public string GetMyMemoryInfo()
        {//��ȡ��ǰ��������ڴ���Ϣ
            try
            {
                Microsoft.VisualBasic.Devices.Computer My = new Microsoft.VisualBasic.Devices.Computer();
                return (My.Info.AvailablePhysicalMemory / 1024 / 1024).ToString() + "M/" + (My.Info.TotalPhysicalMemory / 1024 / 1024).ToString() + "M";
            }
            catch
            {
                return "";
            }
        }
        public string GetMyScreens()
        {//��ȡ���������ʾ�豸��Ϣ
            Screen[] MyScreens = Screen.AllScreens;
            int MyBound = MyScreens.GetUpperBound(0);
            return MyScreens[0].DeviceName;
            /*
            string MyInfo = "";
            for (int i = 0; i <= MyBound; i++)
            {
                MyInfo += "\n��ʾ�߽�: " + MyScreens[i].Bounds.ToString();
                MyInfo += "\n��ʾ��������: " + MyScreens[i].WorkingArea.ToString();
                MyInfo += "\n�Ƿ�������ʾ��: " + MyScreens[i].Primary.ToString();
                MyInfo += "\n��ʾ�豸����: " + MyScreens[i].DeviceName;
            }
            */
        }
        public string GetMyCpuInfo()
        {
            RegistryKey reg = Registry.LocalMachine;
            reg = reg.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            return reg.GetValue("ProcessorNameString").ToString();
        } 
    }
}
