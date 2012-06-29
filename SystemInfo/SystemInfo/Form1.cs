using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Management;
using System.Diagnostics;

namespace SystemInfo1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
      
        public Form1()
        {
            InitializeComponent();

            TreeNode MyComputerNode = new TreeNode("我的电脑");
            Dit.Nodes.Add(MyComputerNode);
            FileListShow(MyComputerNode);	//初始化ListView控件
            


        }
      
        //等到计算机名
        // 用SystemInformation 类来获取
        public static string GetComputerName()
        {
            return SystemInformation.ComputerName; 
        }

        // 得到用户名
        //用SystemInformation 类来获取
        public static string GetUserName()
        {
            return SystemInformation.UserName;
        }
   
      

       private void LViewProc_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

       private void tabPage1_Click(object sender, EventArgs e)
       {
       }

       private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SystemInfo systemInfo = new SystemInfo();
           CpuInfo cpuInfo = systemInfo.GetCpuInfo();
           MemoryInfo memoryInfo = systemInfo.GetMemoryInfo();
           SystemTimeInfo systemTimeInfo=systemInfo.GetSystemTimeInfo();
           label1.Text += "计算机名 :" + GetComputerName() + "\r\n";
           label1.Text += "用户名 :" + GetUserName() + "\r\n";
           label1.Text += "操作系统：" + systemInfo.GetOperationSystemInName() + "\r\n";
           label1.Text += "CPU编号：" + systemInfo.GetCpuId() + "\r\n";
           label1.Text += "CPU个数：" + cpuInfo.dwNumberOfProcessors + "\r\n";
           label1.Text += "CPU类型：" + cpuInfo.dwProcessorType + "\r\n";
           label1.Text += "CPU等级：" + cpuInfo.dwProcessorLevel + "\r\n";
           label1.Text += "页面大小: " + cpuInfo.dwPageSize + " 字节" + "\r\n"; 
           label1.Text += "操作系统位数：" + memoryInfo.dwLength +" 位"+ "\r\n";
           label1.Text += "可用物理内存大小：" + memoryInfo.dwAvailPhys + " 字节" + "\r\n";
           label1.Text += "可用虚拟内存大小" + memoryInfo.dwAvailVirtual + " 字节" + "\r\n";
           label1.Text += "已经使用内存大小：" + memoryInfo.dwMemoryLoad + " 字节" + "\r\n";
           label1.Text += "总物理内存大小：" + memoryInfo.dwTotalPhys + " 字节" + "\r\n";
           label1.Text += "总虚拟内存大小：" + memoryInfo.dwTotalVirtual + " 字节" + "\r\n";
           label1.Text += "Windows目录所在位置：" + systemInfo.GetSysDirectory() + "\r\n";
           label1.Text += "系统目录所在位置：" + systemInfo.GetWinDirectory() + "\r\n";
           label1.Text += "系统时间: " + systemTimeInfo.wYear + "年 " + systemTimeInfo.wMonth + "月 " + systemTimeInfo.wDay + "日 " + (systemTimeInfo.wHour+8) + ":" + systemTimeInfo.wMinute + "\r\n";
       }
      //获取进程列表
     //用Process来获取进程的ID、名称、进程使用的物理内存和进程出起始时间
       private void 进程信息ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           dataGridView1.Rows.Clear();
           Process[] myProcess = Process.GetProcesses();

           foreach (Process p in myProcess)
           {
               int newRowIndex = dataGridView1.Rows.Add();
               DataGridViewRow row = dataGridView1.Rows[newRowIndex];
               row.Cells[0].Value = p.Id;
               row.Cells[1].Value = p.ProcessName;
               row.Cells[2].Value = string.Format("{0:###,##0.000}MB", p.WorkingSet64 / 1024.0f / 1024.0f);

               try
               {
                   row.Cells[3].Value = string.Format("{0}", p.StartTime);
              
               }
               catch
               {
                   row.Cells[3].Value = "";//有的进程获取不到开始时间即设置为空
                
               }
           }
       }
        //结束进程
        //获取该程序的Pid,通过调用Kill来结束进程
       private void button7_Click(object sender, EventArgs e)
       {
           if (dataGridView1.SelectedCells.Count > 0)
           {

               string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               int Value = int.Parse(value);
               Process killed = Process.GetProcessById(Value);
               killed.Kill();
               MessageBox.Show("已经结束该进程");
           }
       }
        //文件列表显示

       private void FileListShow(TreeNode aDirNode)
       {
           listVie.Clear();

           try
           {
               if (aDirNode.Parent == null)
               {
                   foreach (string DrvName in Directory.GetLogicalDrives())
                   {
                       ListViewItem aItem = new ListViewItem(DrvName);
                       listVie.Items.Add(aItem);
                   }
               }
               else
               {
                   foreach (string DirName in Directory.GetDirectories((string)aDirNode.Tag))
                   {
                       ListViewItem aItem = new ListViewItem(DirName);
                       listVie.Items.Add(aItem);
                   }
                   foreach (string FileName in Directory.GetFiles((string)aDirNode.Tag))
                   {
                       ListViewItem aItem = new ListViewItem(FileName);
                       listVie.Items.Add(aItem);
                   }
               }
           }
           catch { }
       }
        //根目录显示
        
        
       private void DirTreeShow(TreeNode aDirNode)
       {
           try
           {
               if (aDirNode.Nodes.Count == 0)
               {
                   if (aDirNode.Parent == null)
                   {
                       foreach (string DrvName in Directory.GetLogicalDrives())
                       {
                           TreeNode aNode = new TreeNode(DrvName);
                           aNode.Tag = DrvName;
                           aDirNode.Nodes.Add(aNode);
                       }
                   }
                   else
                   {
                       foreach (string DirName in Directory.GetDirectories((string)aDirNode.Tag))
                       {
                           TreeNode aNode = new TreeNode(DirName);
                           aNode.Tag = DirName;
                           aDirNode.Nodes.Add(aNode);
                       }
                   }
               }
           }
           catch { }
       } 

       private void Dit_AfterSelect(object sender, TreeViewEventArgs e)
       {
           FileListShow(e.Node);
           DirTreeShow(e.Node);
       }

       private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (Dit.Focused)
           {
               SourceFileName = Dit.SelectedNode.Text;
           }
        
           MessageBox.Show("原文件路径为：" +SourceFileName +"\n"+ "  请在下面的列表选择请选择要复制的文件");
          

       }
       private void 确定复制ToolStripMenuItem_Click_1(object sender, EventArgs e)
       {
           if (listVie.Focused)
           {

               FileName = listVie.FocusedItem.Text;
               string[] arry = FileName.Split('\\');
               name = arry[arry.Length - 1];
           }
           MessageBox.Show("要复制的文件为 " + name);

       }
      
       private void 粘帖ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           string CurPath = "";

           if (Dit.Focused)
           {
               CurPath = Dit.SelectedNode.Text;
           }
           else if (listVie.Focused)
           {
               CurPath = Directory.GetParent(listVie.Items[0].Text).FullName;
           }
           try
           {
               MessageBox.Show("目标路径为 " + CurPath);
               File.Copy(SourceFileName+"\\"+name,CurPath+"\\"+name, true);
           }
           catch { }
       }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

      


       private void button3_Click(object sender, EventArgs e)
       {

       }

       private void listVie_SelectedIndexChanged(object sender, EventArgs e)
       {

       }

   

      

      private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (Dit.Focused)
          {
              SourceFileName = Dit.SelectedNode.Text;
              if (Directory.Exists(@SourceFileName))
              { Directory.Delete(@SourceFileName);
                MessageBox.Show("已经删除该文件夹");
                }
              else
              { MessageBox.Show("该文件夹已经不存在了"); }

          }
          else if (listVie.Focused)
          {
             
              SourceFileName = listVie.FocusedItem.Text;
               
              if (File.Exists(@SourceFileName))
              { File.Delete(@SourceFileName);
                MessageBox.Show("已经删除该文件");
              }
              else
              { MessageBox.Show("该文件已经不存在了"); }


          }
       
      }

      private void button1_Click(object sender, EventArgs e)
      {
          Process.Start("shutdown", "-r");
      }

      private void button2_Click(object sender, EventArgs e)
      {
          Process.Start("shutdown", "-s");

      }

      private void button5_Click(object sender, EventArgs e)
      {

      }

      private void button6_Click(object sender, EventArgs e)
      {

      }

    
     


    }
}