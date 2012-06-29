using System;
using System.Configuration;
using System.Runtime.InteropServices;


// 定义内存的信息结构

[StructLayout(LayoutKind.Sequential)]
public struct MemoryInfo
{
    //操作系统位数
    public uint dwLength;
    // 已经使用的内存
    public uint dwMemoryLoad;
    // 总物理内存大小
    public uint dwTotalPhys;
    //可用物理内存大小
    public uint dwAvailPhys;
    // 交换文件总大小
    public uint dwTotalPageFile;
    // 可用交换文件大小
    public uint dwAvailPageFile;
    // 总虚拟内存大小
    public uint dwTotalVirtual;
    //可用虚拟内存大小
    public uint dwAvailVirtual;
}

