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
            //获取当前操作系统信息
            OperatingSystem MyOS = Environment.OSVersion;
            string MyOSName = "";
            //如果版本号是 5, 则它应该是 Win2K, XP或2003
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
                // 可能是 NT4 
                MyOSName = MyOS.VersionString;
            }
            //获取SP信息
            string MySPName = MyOS.ServicePack;
            return MyOSName + " " + MySPName;
        }
        public string GetMyComputerName()
        {//获取当前计算机名称
            string MyComputerName = Environment.GetEnvironmentVariable("ComputerName");
            return MyComputerName;
        }
        public string GetMyUserName()
        {//获取当前用户名称
            string MyUserName = Environment.GetEnvironmentVariable("UserName");
            return MyUserName;
        }
        public string GetMyPaths()
        {//获取当前系统默认路径配置信息,环境变量
            string MyPaths = Environment.GetEnvironmentVariable("Path");
            return MyPaths;
        }
        public string GetMyDriveInfo()
        {//获取驱动器的存储空间大小
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
        {//获取当前计算机的内存信息
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
        {//获取计算机的显示设备信息
            Screen[] MyScreens = Screen.AllScreens;
            int MyBound = MyScreens.GetUpperBound(0);
            return MyScreens[0].DeviceName;
            /*
            string MyInfo = "";
            for (int i = 0; i <= MyBound; i++)
            {
                MyInfo += "\n显示边界: " + MyScreens[i].Bounds.ToString();
                MyInfo += "\n显示器工作区: " + MyScreens[i].WorkingArea.ToString();
                MyInfo += "\n是否是主显示器: " + MyScreens[i].Primary.ToString();
                MyInfo += "\n显示设备名称: " + MyScreens[i].DeviceName;
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
