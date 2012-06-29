using System;
using System.Configuration;
using System.Runtime.InteropServices;


// ����CPU����Ϣ�ṹ
[StructLayout(LayoutKind.Sequential)] 
public struct CpuInfo
{
  
 
    public uint dwOemId;  // ҳ���С
    public uint dwPageSize;
    public uint lpMinimumApplicationAddress;
    public uint lpMaximumApplicationAddress;
    public uint dwActiveProcessorMask;
    public uint dwNumberOfProcessors; // CPU����
    public uint dwProcessorType; // CPU����
    public uint dwAllocationGranularity;
    public uint dwProcessorLevel;// CPU�ȼ�
    public uint dwProcessorRevision; 
}

