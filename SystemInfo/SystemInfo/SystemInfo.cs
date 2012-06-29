using System;
using System.Configuration;
using System.Runtime.InteropServices;//导入API集合
using System.Management;
using System.Text;

public class SystemInfo
{
    private const int CHAR_COUNT = 128;
    public SystemInfo()
   {
        
    }
    //声明API函数
    [DllImport("kernel32")]
    private static extern void GetWindowsDirectory(StringBuilder WinDir, int count);
    //API作用获得window路径
    [DllImport("kernel32")]
    private static extern void GetSystemDirectory(StringBuilder SysDir, int count);
    //获得系统目录路径
    [DllImport("kernel32")]
    private static extern void GetSystemInfo(ref CpuInfo cpuInfo);
    //获得CPU相关信息
    [DllImport("kernel32")]
    private static extern void GlobalMemoryStatus(ref MemoryInfo memInfo);
    //获得内存相关信息
    [DllImport("kernel32")]
    private static extern void GetSystemTime(ref SystemTimeInfo sysInfo);
    //获得系统时间


    // 查询CPU编号
    // 利用WMI来查询cpuID
  
    public string GetCpuId()
   {
        ManagementClass mClass = new ManagementClass("Win32_Processor");//CPU处理器
        ManagementObjectCollection moc = mClass.GetInstances();
        string cpuId=null;
        foreach (ManagementObject mo in moc)
       {
            cpuId = mo.Properties["ProcessorId"].Value.ToString();
            break;
        }
        return cpuId;
    }

   
  
    // 获取Windows目录
    //通过调用GetWindowsDirectory函数获取
    public string GetWinDirectory()
   {
        StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
        GetWindowsDirectory(sBuilder, CHAR_COUNT);
        return sBuilder.ToString();
    }


    // 获取系统目录
    //通过调用GetSystemDirectory函数来获取
    public string GetSysDirectory()
   {
        StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
        GetSystemDirectory(sBuilder, CHAR_COUNT);
        return sBuilder.ToString();
    }

 
   // 获取CPU信息
    //调用GetSystemInfo函数来获取cpu信息
   
    public CpuInfo GetCpuInfo()
   {
        CpuInfo cpuInfo = new CpuInfo();
        GetSystemInfo(ref cpuInfo);
        return cpuInfo;
    }

  
    // 获取系统内存信息
    //调用GlobalMemoryStatus来活动系统内存信息
    public MemoryInfo GetMemoryInfo()
   {
        MemoryInfo memoryInfo = new MemoryInfo();
        GlobalMemoryStatus(ref memoryInfo);
        return memoryInfo;
    }

   
    // 获取系统时间信息
    //调用  GetSystemTime来获得系统时间
    public SystemTimeInfo GetSystemTimeInfo()
   {
        SystemTimeInfo systemTimeInfo = new SystemTimeInfo();
        GetSystemTime(ref systemTimeInfo);
        return systemTimeInfo;
    }

   
    // 获取系统名称
    //调用Environment类来获得操作系统的平台类型、主版本号、副版本号来确定系统名称
  
    public string GetOperationSystemInName()
   {
        OperatingSystem os = Environment.OSVersion;
        Version ver = System.Environment.OSVersion.Version;

        string osName = " ";

    
        switch (ver.Major)
       {
            case 4:
                switch (ver.Minor)
               { case 0: if (os.Platform == PlatformID.Win32NT) 
                            { osName = "Windows NT 4"; } 
                         if (os.Platform == PlatformID.Win32Windows) 
                            { osName = "Windows 95"; }break;
                 case 90: osName = "Windows Me"; break;
                 case 10: osName = "Windows 98"; break;
               }
                break;
                
            case 5:
                switch (ver.Minor)
               {
                    case 0: osName = "Windws 2000"; break;
                    case 1: osName = "Windows XP"; break;
                   
                }
                break;
            case 6:
                switch (ver.Minor)  
                {
                    case 0: osName = "Windws Vista"; break;
                    case 1: osName = "Windows 7  "; break;   
                }
                break;
        }
        return String.Format("{0},{1},{2}", osName, os.Version.ToString(),os.Platform.ToString());
    }
}

