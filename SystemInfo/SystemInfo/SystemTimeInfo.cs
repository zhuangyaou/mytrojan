using System;
using System.Configuration;
using System.Runtime.InteropServices;



// ����ϵͳʱ�����Ϣ�ṹ
[StructLayout(LayoutKind.Sequential)] 
public struct SystemTimeInfo
{
   //�ꡢ�¡����ڡ��졢Сʱ���֡��롢����
    public ushort wYear;
    public ushort wMonth;
    public ushort wDayOfWeek;
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
    public ushort wMilliseconds;
}
