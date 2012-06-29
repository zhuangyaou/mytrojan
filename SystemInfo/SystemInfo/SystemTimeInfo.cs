using System;
using System.Configuration;
using System.Runtime.InteropServices;



// 定义系统时间的信息结构
[StructLayout(LayoutKind.Sequential)] 
public struct SystemTimeInfo
{
   //年、月、星期、天、小时、分、秒、毫秒
    public ushort wYear;
    public ushort wMonth;
    public ushort wDayOfWeek;
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
    public ushort wMilliseconds;
}
