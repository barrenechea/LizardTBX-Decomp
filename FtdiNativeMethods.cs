using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class FtdiNativeMethods
{
	public struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public short short_0;

		public short short_1;

		public int int_3;

		public int cpoahSiso;

		public int int_4;

		public int int_5;

		public short short_2;

		public short short_3;

		public short short_4;

		public short short_5;

		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public byte byte_4;

		public byte byte_5;

		public short short_6;

		public byte byte_6;

		public byte byte_7;

		public byte byte_8;

		public byte byte_9;

		public byte byte_10;

		public byte byte_11;

		public byte byte_12;

		public byte byte_13;

		public short short_7;

		public byte byte_14;

		public byte byte_15;

		public byte byte_16;

		public byte byte_17;

		public byte byte_18;

		public byte byte_19;

		public byte byte_20;

		public byte byte_21;

		public byte byte_22;

		public byte byte_23;

		public byte byte_24;

		public byte byte_25;

		public byte byte_26;

		public byte byte_27;

		public byte byte_28;

		public byte byte_29;

		public byte byte_30;

		public byte byte_31;

		public byte byte_32;

		public byte byte_33;

		public byte byte_34;

		public byte byte_35;

		public byte byte_36;

		public byte byte_37;

		public byte YqUsblhqw;

		public byte byte_38;

		public byte byte_39;

		public byte byte_40;

		public byte byte_41;
	}

	public const int int_0 = 0;

	public const int int_1 = 1;

	public const int int_2 = 2;

	public const int int_3 = 3;

	public const int int_4 = 4;

	public const int int_5 = 5;

	public const int int_6 = 6;

	public const int int_7 = 7;

	public const int int_8 = 8;

	public const int int_9 = 9;

	public const int int_10 = 10;

	public const int int_11 = 11;

	public const int int_12 = 12;

	public const int int_13 = 13;

	public const int int_14 = 14;

	public const int int_15 = 15;

	public const int int_16 = 16;

	public const int int_17 = 17;

	public const int int_18 = 0;

	public const int int_19 = 1;

	public const int int_20 = 1;

	public const int int_21 = 2;

	public const int int_22 = int.MinValue;

	public const int int_23 = 1073741824;

	public const int int_24 = 536870912;

	private const int int_25 = 1048576;

	private const int int_26 = 1048575;

	private const int int_27 = 65536;

	private const int int_28 = 65535;

	public const int int_29 = 300;

	public const int int_30 = 600;

	public const int int_31 = 1200;

	public const int int_32 = 2400;

	public const int int_33 = 4800;

	public const int int_34 = 9600;

	public const int int_35 = 14400;

	public const int int_36 = 19200;

	public const int int_37 = 38400;

	public const int int_38 = 57600;

	public const int int_39 = 115200;

	public const int int_40 = 230400;

	public const int int_41 = 460800;

	public const int int_42 = 921600;

	public const int int_43 = 7;

	public const int int_44 = 8;

	public const int int_45 = 0;

	public const int int_46 = 2;

	public const int int_47 = 0;

	public const int int_48 = 1;

	public const int int_49 = 2;

	public const int int_50 = 3;

	public const int int_51 = 4;

	public const int int_52 = 0;

	public const int int_53 = 256;

	public const int int_54 = 512;

	public const int int_55 = 1024;

	public const int maGotvbppi = 16;

	public const int int_56 = 32;

	public const int PcBokmvgxW = 64;

	public const int int_57 = 128;

	public const int int_58 = 1;

	public const int int_59 = 2;

	public const int int_60 = 0;

	public const int int_61 = 1;

	public const int int_62 = 2;

	public const int int_63 = 4;

	public const int int_64 = 8;

	public const int int_65 = 16;

	public const int int_66 = 1;

	public const int int_67 = 2;

	public const int int_68 = 128;

	public const int int_69 = 0;

	public const int int_70 = 258;

	public const int int_71 = -1;

	public static int int_72;

	public static int int_73;

	public static string string_0;

	public static string string_1;

	public static int int_74;

	public static string string_2;

	public static string string_3;

	public static int int_75;

	public static byte byte_0;

	public static byte byte_1;

	public static byte byte_2;

	public static int int_76;

	public static byte byte_3;

	public static byte byte_4;

	public static int int_77;

	public static int int_78;

	public static int int_79;

	public static int int_80;

	public static bool bool_0;

	public static bool bool_1;

	public static byte byte_5;

	public static byte byte_6;

	public static byte[] byte_7 = new byte[1048576];

	public static byte[] byte_8 = new byte[65536];

	public static byte byte_9;

	public static Struct2 struct2_0;

	public static string string_4;

	public static string string_5;

	public static string string_6;

	public static string string_7;

	public static int int_81;

	public static byte[] byte_10;

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_ListDevices(ref int int_82, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, EntryPoint = "FT_ListDevices", ExactSpelling = true, SetLastError = true)]
	public static extern int FT_ListDevices_1(int int_82, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetDeviceInfo(int int_82, ref int int_83, ref int int_84, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, ref byte byte_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Open(int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_OpenEx([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, EntryPoint = "FT_OpenEx", ExactSpelling = true, SetLastError = true)]
	public static extern int FT_OpenEx_1([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Close(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Read(int int_82, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_83, ref int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Write(int int_82, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, int int_83, ref int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, EntryPoint = "FT_Read", ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Read_1(int int_82, ref byte byte_11, int int_83, ref int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, EntryPoint = "FT_Write", ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Write_1(int int_82, ref byte byte_11, int int_83, ref int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetBaudRate(int int_82, int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetDivisor(int int_82, int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetDataCharacteristics(int int_82, byte byte_11, byte byte_12, byte byte_13);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetFlowControl(int int_82, int int_83, byte byte_11, byte byte_12);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_ResetDevice(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetDtr(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_ClrDtr(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetRts(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_ClrRts(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetModemStatus(int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetChars(int int_82, byte byte_11, byte byte_12, byte byte_13, byte byte_14);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_Purge(int int_82, int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetTimeouts(int int_82, int int_83, int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetQueueStatus(int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetLatencyTimer(int int_82, ref byte byte_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetLatencyTimer(int int_82, byte byte_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetBitMode(int int_82, ref byte byte_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetBitMode(int int_82, byte byte_11, byte byte_12);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetUSBParameters(int int_82, int int_83, int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetBreakOn(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetBreakOff(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_GetStatus(int int_82, ref int int_83, ref int int_84, ref int int_85);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_SetEventNotification(int int_82, int int_83, int int_84);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Sleep(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EraseEE(int int_82);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_ReadEx(int int_82, ref Struct2 struct2_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_ProgramEx(int int_82, ref Struct2 struct2_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_8, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_9, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_10, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_11);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_Program(int int_82, ref Struct2 struct2_1);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_UASize(int int_82, ref int int_83);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_UARead(int int_82, ref byte byte_11, int int_83, ref int int_84);

	[DllImport("FTD2XX.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int FT_EE_UAWrite(int int_82, ref byte byte_11, int int_83);

	public static int smethod_0()
	{
		int result = 0;
		string string_ = "\0";
		int_72 = FT_ListDevices(ref int_73, ref string_, int.MinValue);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_1(int int_82)
	{
		string string_ = Strings.Space(16);
		int result = 0;
		int_72 = FT_ListDevices_1(int_82, ref string_, 1073741825);
		if (int_72 == 0)
		{
			string_0 = Strings.Left(string_, Strings.InStr(1, string_, "\0") - 1);
			result = 1;
		}
		return result;
	}

	public static int smethod_2(int int_82)
	{
		string string_ = Strings.Space(64);
		int result = 0;
		int_72 = FT_ListDevices_1(int_82, ref string_, 1073741826);
		if (int_72 == 0)
		{
			string_1 = Strings.Left(string_, Strings.InStr(1, string_, "\0") - 1);
			result = 1;
		}
		return result;
	}

	public static int smethod_3(int int_82)
	{
		int result = 0;
		int_72 = FT_Open(int_82, ref int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_4(string string_8)
	{
		int result = 0;
		int_72 = FT_OpenEx_1(ref string_8, 1, ref int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_5(string string_8)
	{
		int result = 0;
		int_72 = FT_OpenEx_1(ref string_8, 2, ref int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_6()
	{
		int result = 0;
		int_72 = FT_Close(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_7()
	{
		int result = 0;
		string string_ = Strings.Space(16);
		string string_2 = Strings.Space(64);
		int int_ = int_74;
		byte byte_ = 0;
		int int_2 = default(int);
		int int_3 = default(int);
		int_72 = FT_GetDeviceInfo(int_, ref int_2, ref int_3, ref string_, ref string_2, ref byte_);
		if (int_72 == 0)
		{
			string_0 = Strings.Left(string_, Strings.InStr(1, string_, "\0") - 1);
			string_1 = Strings.Left(string_2, Strings.InStr(1, string_2, "\0") - 1);
			if ((double)int_2 == Conversions.ToDouble("0"))
			{
				FtdiNativeMethods.string_2 = "FT232/245BM";
			}
			else if ((double)int_2 == Conversions.ToDouble("1"))
			{
				FtdiNativeMethods.string_2 = "FT232/245AM";
			}
			else if ((double)int_2 == Conversions.ToDouble("2"))
			{
				FtdiNativeMethods.string_2 = "FT8U100AX";
			}
			else if ((double)int_2 == Conversions.ToDouble("3"))
			{
				FtdiNativeMethods.string_2 = "Unknown";
			}
			else if ((double)int_2 == Conversions.ToDouble("4"))
			{
				FtdiNativeMethods.string_2 = "FT2232C";
			}
			string text = Conversion.Hex(int_3);
			while (Strings.Len(text) < 8)
			{
				text = "0" + text;
			}
			string_3 = text;
			result = 1;
		}
		return result;
	}

	public static int smethod_8()
	{
		int result = 0;
		int_72 = FT_ResetDevice(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_9()
	{
		int result = 0;
		int_72 = FT_Purge(int_74, 1);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_10()
	{
		int result = 0;
		int_72 = FT_Purge(int_74, 2);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int YqUsblhqw()
	{
		int result = 0;
		int_72 = FT_SetDataCharacteristics(int_74, byte_0, byte_1, byte_2);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_11()
	{
		int result = 0;
		int_72 = FT_SetBaudRate(int_74, int_75);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_12(int int_82)
	{
		int result = 0;
		int_72 = FT_SetDivisor(int_74, int_82);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_13()
	{
		int result = 0;
		int_72 = FT_SetFlowControl(int_74, int_76, byte_3, byte_4);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_14()
	{
		int result = 0;
		int_72 = FT_GetModemStatus(int_74, ref int_77);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_15()
	{
		int result = 0;
		int_72 = FT_GetQueueStatus(int_74, ref int_78);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_16()
	{
		int result = 0;
		byte byte_ = (byte)(bool_0 ? 1 : 0);
		byte byte_2 = (byte)(bool_1 ? 1 : 0);
		int_72 = FT_SetChars(int_74, byte_5, byte_, byte_6, byte_2);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_17(int int_82, int int_83)
	{
		int result = 0;
		int_72 = FT_SetTimeouts(int_74, int_82, int_83);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_18()
	{
		int result = 0;
		int_72 = FT_SetRts(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_19()
	{
		int result = 0;
		int_72 = FT_ClrRts(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_20()
	{
		int result = 0;
		int_72 = FT_SetDtr(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_21()
	{
		int result = 0;
		int_72 = FT_ClrDtr(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_22(string string_8)
	{
		int result = 0;
		int int_ = Strings.Len(string_8);
		int int_2 = default(int);
		int_72 = FT_Write(int_74, ref string_8, int_, ref int_2);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_23(int int_82)
	{
		int result = 0;
		int int_83 = default(int);
		int_72 = FT_Write_1(int_74, ref byte_8[0], int_82, ref int_83);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_24(string string_8)
	{
		string string_9 = Strings.Space(int_78 + 1);
		int result = 0;
		int int_ = default(int);
		int_72 = FT_Read(int_74, ref string_9, int_78, ref int_);
		if (int_72 == 0)
		{
			string_8 = Strings.Trim(string_9);
			result = 1;
		}
		return result;
	}

	public static int smethod_25(int int_82)
	{
		int result = 0;
		int int_83 = default(int);
		int_72 = FT_Read_1(int_74, ref byte_7[0], int_82, ref int_83);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_26()
	{
		int result = 0;
		int_72 = FT_GetLatencyTimer(int_74, ref byte_9);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_27()
	{
		int result = 0;
		int_72 = FT_SetLatencyTimer(int_74, byte_9);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_28(byte byte_11)
	{
		int result = 0;
		int_72 = FT_GetBitMode(int_74, ref byte_11);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_29(byte byte_11, byte byte_12)
	{
		int result = 0;
		int_72 = FT_SetBitMode(int_74, byte_11, byte_12);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_30(int int_82, int int_83)
	{
		int result = 0;
		int_72 = FT_SetUSBParameters(int_74, int_82, int_83);
		if (int_72 == 0)
		{
			result = 0;
		}
		return result;
	}

	public static int smethod_31()
	{
		int result = 0;
		int_72 = FT_SetBreakOn(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_32()
	{
		int result = 0;
		int_72 = FT_SetBreakOff(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_33()
	{
		int result = 0;
		int_72 = FT_GetStatus(int_74, ref int_78, ref int_79, ref int_80);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_34(int int_82, int int_83)
	{
		int result = 0;
		int_72 = FT_SetEventNotification(int_74, int_82, int_83);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_35()
	{
		int result = 0;
		string string_ = Strings.Space(32);
		string string_2 = Strings.Space(16);
		string string_3 = Strings.Space(64);
		string string_4 = Strings.Space(16);
		struct2_0.int_0 = 0;
		struct2_0.int_1 = -1;
		struct2_0.int_2 = 2;
		struct2_0.short_0 = 0;
		struct2_0.short_1 = 0;
		struct2_0.int_3 = 0;
		struct2_0.cpoahSiso = 0;
		struct2_0.int_4 = 0;
		struct2_0.int_5 = 0;
		struct2_0.short_2 = 0;
		struct2_0.short_3 = 0;
		struct2_0.short_4 = 0;
		struct2_0.short_5 = 0;
		struct2_0.byte_0 = 0;
		struct2_0.byte_1 = 0;
		struct2_0.byte_2 = 0;
		struct2_0.byte_3 = 0;
		struct2_0.byte_4 = 0;
		struct2_0.byte_5 = 0;
		struct2_0.short_6 = 0;
		struct2_0.byte_6 = 0;
		struct2_0.byte_7 = 0;
		struct2_0.byte_8 = 0;
		struct2_0.byte_9 = 0;
		struct2_0.byte_10 = 0;
		struct2_0.byte_11 = 0;
		struct2_0.byte_12 = 0;
		struct2_0.byte_13 = 0;
		struct2_0.short_7 = 0;
		struct2_0.byte_14 = 0;
		struct2_0.byte_15 = 0;
		struct2_0.byte_16 = 0;
		struct2_0.byte_17 = 0;
		struct2_0.byte_18 = 0;
		struct2_0.byte_19 = 0;
		struct2_0.byte_20 = 0;
		struct2_0.byte_21 = 0;
		struct2_0.byte_22 = 0;
		struct2_0.byte_23 = 0;
		struct2_0.byte_24 = 0;
		struct2_0.byte_25 = 0;
		struct2_0.byte_26 = 0;
		struct2_0.byte_27 = 0;
		struct2_0.byte_4 = 0;
		struct2_0.byte_29 = 0;
		struct2_0.byte_30 = 0;
		struct2_0.byte_32 = 0;
		struct2_0.byte_33 = 0;
		struct2_0.byte_34 = 0;
		struct2_0.byte_35 = 0;
		struct2_0.byte_36 = 0;
		struct2_0.byte_37 = 0;
		struct2_0.YqUsblhqw = 0;
		struct2_0.byte_38 = 0;
		struct2_0.byte_39 = 0;
		struct2_0.byte_40 = 0;
		struct2_0.byte_41 = 0;
		int_72 = FT_EE_ReadEx(int_74, ref struct2_0, ref string_, ref string_2, ref string_3, ref string_4);
		if (int_72 == 0)
		{
			FtdiNativeMethods.string_4 = Strings.Left(string_, Strings.InStr(1, string_, "\0") - 1);
			string_5 = Strings.Left(string_2, Strings.InStr(1, string_2, "\0") - 1);
			string_6 = Strings.Left(string_3, Strings.InStr(1, string_3, "\0") - 1);
			string_7 = Strings.Left(string_4, Strings.InStr(1, string_4, "\0") - 1);
			result = 1;
		}
		return result;
	}

	public static int smethod_36()
	{
		int result = 0;
		string string_ = Strings.Space(32);
		string string_2 = Strings.Space(16);
		string string_3 = Strings.Space(64);
		string string_4 = Strings.Space(16);
		struct2_0.int_0 = 0;
		struct2_0.int_1 = -1;
		struct2_0.int_2 = 1;
		struct2_0.short_0 = 0;
		struct2_0.short_1 = 0;
		struct2_0.int_3 = 0;
		struct2_0.cpoahSiso = 0;
		struct2_0.int_4 = 0;
		struct2_0.int_5 = 0;
		struct2_0.short_2 = 0;
		struct2_0.short_3 = 0;
		struct2_0.short_4 = 0;
		struct2_0.short_5 = 0;
		struct2_0.byte_0 = 0;
		struct2_0.byte_1 = 0;
		struct2_0.byte_2 = 0;
		struct2_0.byte_3 = 0;
		struct2_0.byte_4 = 0;
		struct2_0.byte_5 = 0;
		struct2_0.short_6 = 0;
		struct2_0.byte_6 = 0;
		struct2_0.byte_7 = 0;
		struct2_0.byte_8 = 0;
		struct2_0.byte_9 = 0;
		struct2_0.byte_10 = 0;
		struct2_0.byte_11 = 0;
		struct2_0.byte_12 = 0;
		struct2_0.byte_13 = 0;
		struct2_0.short_7 = 0;
		struct2_0.byte_14 = 0;
		struct2_0.byte_15 = 0;
		struct2_0.byte_16 = 0;
		struct2_0.byte_17 = 0;
		struct2_0.byte_18 = 0;
		struct2_0.byte_19 = 0;
		struct2_0.byte_20 = 0;
		struct2_0.byte_21 = 0;
		struct2_0.byte_22 = 0;
		struct2_0.byte_23 = 0;
		int_72 = FT_EE_ReadEx(int_74, ref struct2_0, ref string_, ref string_2, ref string_3, ref string_4);
		if (int_72 == 0)
		{
			FtdiNativeMethods.string_4 = Strings.Left(string_, Strings.InStr(1, string_, "\0") - 1);
			string_5 = Strings.Left(string_2, Strings.InStr(1, string_2, "\0") - 1);
			string_6 = Strings.Left(string_3, Strings.InStr(1, string_3, "\0") - 1);
			string_7 = Strings.Left(string_4, Strings.InStr(1, string_4, "\0") - 1);
			result = 1;
		}
		return result;
	}

	public static int smethod_37(Struct2 struct2_1, string string_8, string string_9, string string_10, string string_11, int int_82)
	{
		int result = 0;
		struct2_1.int_0 = 0;
		struct2_1.int_1 = -1;
		struct2_1.int_2 = 2;
		struct2_1.short_5 = 0;
		struct2_1.short_4 = 0;
		if (int_82 == 0)
		{
			struct2_1.byte_27 = 1;
			struct2_1.byte_39 = 1;
		}
		if (int_82 == 1)
		{
			struct2_1.byte_27 = 0;
			struct2_1.byte_39 = 13;
		}
		struct2_1.byte_37 = 3;
		struct2_1.YqUsblhqw = 2;
		struct2_1.byte_38 = 0;
		struct2_1.byte_40 = 5;
		struct2_1.short_2 = 200;
		int_72 = FT_EE_ProgramEx(int_74, ref struct2_1, ref string_8, ref string_9, ref string_10, ref string_11);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_38(Struct2 struct2_1, string string_8, string string_9, string string_10, string string_11)
	{
		int result = 0;
		struct2_1.int_0 = 0;
		struct2_1.int_1 = -1;
		struct2_1.int_2 = 1;
		int_72 = FT_EE_ProgramEx(int_74, ref struct2_1, ref string_8, ref string_9, ref string_10, ref string_11);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_39()
	{
		int result = 0;
		int_72 = FT_EraseEE(int_74);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_40()
	{
		int result = 0;
		int_72 = FT_EE_UASize(int_74, ref int_81);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_41(int int_82)
	{
		int result = 0;
		int int_83 = default(int);
		int_72 = FT_EE_UARead(int_74, ref byte_10[0], int_82, ref int_83);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}

	public static int smethod_42(int int_82)
	{
		int result = 0;
		int_72 = FT_EE_UAWrite(int_74, ref byte_10[0], int_82);
		if (int_72 == 0)
		{
			result = 1;
		}
		return result;
	}
}
