using System;
using System.Configuration;
using System.Runtime.InteropServices;


// �����ڴ����Ϣ�ṹ

[StructLayout(LayoutKind.Sequential)]
public struct MemoryInfo
{
    //����ϵͳλ��
    public uint dwLength;
    // �Ѿ�ʹ�õ��ڴ�
    public uint dwMemoryLoad;
    // �������ڴ��С
    public uint dwTotalPhys;
    //���������ڴ��С
    public uint dwAvailPhys;
    // �����ļ��ܴ�С
    public uint dwTotalPageFile;
    // ���ý����ļ���С
    public uint dwAvailPageFile;
    // �������ڴ��С
    public uint dwTotalVirtual;
    //���������ڴ��С
    public uint dwAvailVirtual;
}

