using System;
using System.Configuration;
using System.Runtime.InteropServices;//����API����
using System.Management;
using System.Text;

public class SystemInfo
{
    private const int CHAR_COUNT = 128;
    public SystemInfo()
   {
        
    }
    //����API����
    [DllImport("kernel32")]
    private static extern void GetWindowsDirectory(StringBuilder WinDir, int count);
    //API���û��window·��
    [DllImport("kernel32")]
    private static extern void GetSystemDirectory(StringBuilder SysDir, int count);
    //���ϵͳĿ¼·��
    [DllImport("kernel32")]
    private static extern void GetSystemInfo(ref CpuInfo cpuInfo);
    //���CPU�����Ϣ
    [DllImport("kernel32")]
    private static extern void GlobalMemoryStatus(ref MemoryInfo memInfo);
    //����ڴ������Ϣ
    [DllImport("kernel32")]
    private static extern void GetSystemTime(ref SystemTimeInfo sysInfo);
    //���ϵͳʱ��


    // ��ѯCPU���
    // ����WMI����ѯcpuID
  
    public string GetCpuId()
   {
        ManagementClass mClass = new ManagementClass("Win32_Processor");//CPU������
        ManagementObjectCollection moc = mClass.GetInstances();
        string cpuId=null;
        foreach (ManagementObject mo in moc)
       {
            cpuId = mo.Properties["ProcessorId"].Value.ToString();
            break;
        }
        return cpuId;
    }

   
  
    // ��ȡWindowsĿ¼
    //ͨ������GetWindowsDirectory������ȡ
    public string GetWinDirectory()
   {
        StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
        GetWindowsDirectory(sBuilder, CHAR_COUNT);
        return sBuilder.ToString();
    }


    // ��ȡϵͳĿ¼
    //ͨ������GetSystemDirectory��������ȡ
    public string GetSysDirectory()
   {
        StringBuilder sBuilder = new StringBuilder(CHAR_COUNT);
        GetSystemDirectory(sBuilder, CHAR_COUNT);
        return sBuilder.ToString();
    }

 
   // ��ȡCPU��Ϣ
    //����GetSystemInfo��������ȡcpu��Ϣ
   
    public CpuInfo GetCpuInfo()
   {
        CpuInfo cpuInfo = new CpuInfo();
        GetSystemInfo(ref cpuInfo);
        return cpuInfo;
    }

  
    // ��ȡϵͳ�ڴ���Ϣ
    //����GlobalMemoryStatus���ϵͳ�ڴ���Ϣ
    public MemoryInfo GetMemoryInfo()
   {
        MemoryInfo memoryInfo = new MemoryInfo();
        GlobalMemoryStatus(ref memoryInfo);
        return memoryInfo;
    }

   
    // ��ȡϵͳʱ����Ϣ
    //����  GetSystemTime�����ϵͳʱ��
    public SystemTimeInfo GetSystemTimeInfo()
   {
        SystemTimeInfo systemTimeInfo = new SystemTimeInfo();
        GetSystemTime(ref systemTimeInfo);
        return systemTimeInfo;
    }

   
    // ��ȡϵͳ����
    //����Environment������ò���ϵͳ��ƽ̨���͡����汾�š����汾����ȷ��ϵͳ����
  
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

