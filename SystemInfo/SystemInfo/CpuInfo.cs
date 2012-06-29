using System;
using System.Configuration;
using System.Runtime.InteropServices;


// 定义CPU的信息结构
[StructLayout(LayoutKind.Sequential)] 
public struct CpuInfo
{
  
 
    public uint dwOemId;  // 页面大小
    public uint dwPageSize;
    public uint lpMinimumApplicationAddress;
    public uint lpMaximumApplicationAddress;
    public uint dwActiveProcessorMask;
    public uint dwNumberOfProcessors; // CPU个数
    public uint dwProcessorType; // CPU类型
    public uint dwAllocationGranularity;
    public uint dwProcessorLevel;// CPU等级
    public uint dwProcessorRevision; 
}

