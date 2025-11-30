using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class13
{
	public struct Struct5
	{
		public bool bool_0;

		public byte byte_0;

		public int int_0;

		public int int_1;

		public string string_0;

		public string string_1;

		public byte[] cpoahSiso;

		public byte[] byte_1;

		public byte[] byte_2;

		public byte[] byte_3;

		public byte[] byte_4;

		public byte[] byte_5;

		public byte[] byte_6;
	}

	public struct Struct6
	{
		public byte[] byte_0;

		public byte[] byte_1;
	}

	public const string string_0 = "1.60";

	public const string string_1 = "RELEASE";

	public const double double_0 = 1.3;

	public const int int_0 = 116;

	public const int int_1 = 118;

	public const int int_2 = 106;

	public const string string_2 = "http://www.drivehq.com/file/df.aspx/publish/carranzafp/TBX/";

	public const int int_3 = 1000000;

	public const int int_4 = 3;

	public const string string_3 = "SR2:00";

	public const string string_4 = "unlocksound.wav";

	public const int int_5 = 700;

	public const int int_6 = 1065;

	public const string string_5 = "CFW_Templates";

	public const int int_7 = 1000;

	public const int int_8 = 90;

	public const int int_9 = 6;

	public const int int_10 = 21;

	public const int int_11 = 2;

	public const int int_12 = 3;

	public const int int_13 = 16;

	public const int int_14 = 1024;

	public const int int_15 = 30;

	public const int YqUsblhqw = 25;

	public const int int_16 = 0;

	public const int int_17 = 1;

	public const int int_18 = 2;

	public const int int_19 = 3;

	public static string string_6;

	public const int int_20 = 262144;

	public const int int_21 = 524288;

	public const int int_22 = 1048576;

	public const int int_23 = 2097152;

	public const int int_24 = 4194304;

	public const int int_25 = 8388608;

	public const int int_26 = 4096;

	public const int int_27 = 4;

	public const int int_28 = 262144;

	public const int int_29 = 1024;

	public const int int_30 = 1024;

	public const int int_31 = 4096;

	public const int int_32 = 262144;

	public const int int_33 = 786432;

	public const int int_34 = 8192;

	public const int int_35 = 16;

	public const int int_36 = 35;

	public const int int_37 = 16;

	public const int int_38 = 64;

	public const int int_39 = 96;

	public const int int_40 = 256;

	public const int int_41 = 96;

	public const int int_42 = 512;

	public const int int_43 = 512;

	public const int int_44 = 1024;

	public const int int_45 = 320;

	public const int int_46 = 4096;

	public const int int_47 = 4096;

	public const int int_48 = 1536;

	public const int int_49 = 16;

	public const int int_50 = 1792;

	public const int int_51 = 32;

	public const int int_52 = 0;

	public const int int_53 = 255;

	public const int int_54 = 5;

	public const int int_55 = 2;

	public const int int_56 = 3;

	public const int int_57 = 0;

	public const int int_58 = 1;

	public const int int_59 = 2;

	public const int int_60 = 3;

	public const int int_61 = 4;

	public const int int_62 = 5;

	public const int int_63 = 6;

	public const int int_64 = 7;

	public const int int_65 = 8;

	public const int int_66 = 9;

	public const int int_67 = 10;

	public const int int_68 = 11;

	public const int int_69 = 12;

	public const int int_70 = 13;

	public const int int_71 = 14;

	public const int int_72 = 15;

	public const int int_73 = 16;

	public const int int_74 = 17;

	public const int int_75 = 18;

	public const int int_76 = 19;

	public const int int_77 = 20;

	public const int int_78 = 21;

	public const int int_79 = 32;

	public const int int_80 = 33;

	public const int int_81 = 34;

	public const int int_82 = 35;

	public const int int_83 = 36;

	public const int int_84 = 37;

	public const int int_85 = 38;

	public const int int_86 = 39;

	public const int int_87 = 40;

	public const int int_88 = 255;

	public const string string_7 = "4E182B5F4CE255923579BD95DF9013DD";

	public const string string_8 = "83444B9F3C3DD9F1DE859DE71CDA6B09";

	public const string string_9 = "210A7B18BE991825666A5BE7C633DB58";

	public const string string_10 = "519C87822F1024603DF1779998B45A73";

	public const string string_11 = "ABA2B3920389092665D791DF4F5923A6";

	public const string string_12 = "19AC2FD7E20EE60FA4B0CFF63BC025DA";

	public const string string_13 = "93D17FC07E57EEAC820FB82293BFE7A0";

	public const string string_14 = "3A47C41E087F7C34C0E4EEC50F8D2949";

	public const string string_15 = "838C9A42726467EB442DF16D39C55AB7";

	public const string string_16 = "67BF0134E00577C958A6BA9353ECCDEB";

	public const string string_17 = "93BA96F4D4005B6026DD38F2C3C4E1D8";

	public const string string_18 = "F28436F07CA4EA55D62F6732CBFF76B2";

	public const string string_19 = "CAB8E2A8A3C05BC06C8BADDCDD608EE6";

	public const string string_20 = "6A17CB550D61489B37B20A93296A258B";

	public const string maGotvbppi = "849FEFCA4E1C3F0A0583501704F6EBAA";

	public const string string_21 = "83CE61F1DF5CDCAE3D7F93FB000CAA47";

	public const string PcBokmvgxW = "8E023CBB516B49E33058C49F9189E217";

	public const string string_22 = "9C3902A194ABC5BAB35A717D2C47C784";

	public const string string_23 = "11BD065B041C2796A43313B3844A39AD";

	public const string string_24 = "27574D6D0FEFA35FC7B6A5A7C7D8D049";

	public const string string_25 = "145EA63D8558C289A470613C047B0CEE";

	public const string string_26 = "8C2EF3714737A4C8D5E3EE5FC23723E2";

	public const string string_27 = "963AC279E52DD9C00FEC7F617D2E1AF1";

	public const string string_28 = "3FFFABB09931313968C1C9DDCB1D8D1C";

	public const string string_29 = "BFDB9ED823E4F51198726B91D2FA709E";

	public const string string_30 = "ED3B1ED2C80428E4768E31319F74952B";

	public const string string_31 = "B152C2E6EBE9FF6226086F2015773622";

	public const string string_32 = "17CE77A842E6D5325E8228E880318C28";

	public const string string_33 = "0965B229370A02225D314C8807D5BB93";

	public const string string_34 = "457F67A2265AC477F62649EEFCE899E6";

	public const string string_35 = "BEBECAFEBEBECAFEBEBECAFEBEBECAFE";

	public const string string_36 = "DEADBEEFDEADBEEFDEADBEEFDEADBEEF";

	public static byte[] byte_0;

	public static byte[] byte_1;

	public const int int_89 = 502;

	public const int int_90 = 32;

	public const int int_91 = 320;

	public static bool smethod_0(string string_37)
	{
		int num = Strings.Len(string_37);
		int num2 = 1;
		while (true)
		{
			if (num2 <= num)
			{
				if (((Strings.Asc(Strings.Mid(string_37, num2, 1)) < 48) | (Strings.Asc(Strings.Mid(string_37, num2, 1)) > 57)) && ((Strings.Asc(Strings.Mid(string_37, num2, 1)) < 65) | (Strings.Asc(Strings.Mid(string_37, num2, 1)) > 70)))
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string smethod_1(ref byte[] byte_2, int int_92 = 0, int int_93 = 0)
	{
		long num = Conversions.ToLong(Interaction.IIf(int_92 == 0, Information.UBound(byte_2), int_92 - 1));
		string text = "";
		long num2 = int_93;
		long num3 = num;
		for (long num4 = num2; num4 <= num3; num4++)
		{
			text += Conversions.ToString(Strings.Chr(byte_2[(int)num4]));
		}
		return text;
	}

	public static string smethod_2(byte byte_2)
	{
		return Strings.Right("0" + Conversion.Hex(byte_2), 2);
	}

	public static byte smethod_3(byte byte_2, byte byte_3)
	{
		byte b = (byte)((byte_3 ^ byte_2) & 0xFF);
		byte_2 = 0;
		if ((b & 1) != 0)
		{
			byte_2 ^= 0x5E;
		}
		if ((b & 2) != 0)
		{
			byte_2 ^= 0xBC;
		}
		if ((b & 4) != 0)
		{
			byte_2 ^= 0x61;
		}
		if ((b & 8) != 0)
		{
			byte_2 ^= 0xC2;
		}
		if ((b & 0x10) != 0)
		{
			byte_2 ^= 0x9D;
		}
		if ((b & 0x20) != 0)
		{
			byte_2 ^= 0x23;
		}
		if ((b & 0x40) != 0)
		{
			byte_2 ^= 0x46;
		}
		if ((b & 0x80) != 0)
		{
			byte_2 ^= 0x8C;
		}
		return byte_2;
	}

	public static byte smethod_4(byte[] byte_2, int int_92)
	{
		byte b = 0;
		int num = int_92 - 1;
		for (int i = 0; i <= num; i++)
		{
			b = smethod_3(b, byte_2[i]);
		}
		return b;
	}

	public static string smethod_5(ref byte[] byte_2, int int_92 = -1)
	{
		int num = ((int_92 != -1) ? (int_92 - 1) : Information.UBound(byte_2));
		string text = "";
		long num2 = num;
		for (long num3 = 0L; num3 <= num2; num3++)
		{
			text += smethod_2(byte_2[(int)num3]);
		}
		return text;
	}

	public static byte[] cpoahSiso(string string_37)
	{
		long num = (long)Math.Round((double)Strings.Len(string_37) / 2.0);
		byte[] array = new byte[(int)(num - 1L) + 1];
		long num2 = num - 1L;
		for (long num3 = 0L; num3 <= num2; num3++)
		{
			array[(int)num3] = Convert.ToByte(Strings.Mid(string_37, (int)(num3 * 2L + 1L), 2), 16);
		}
		return array;
	}

	public static long smethod_6(string string_37)
	{
		if (Operators.CompareString(string_37, "BF8E", false) == 0)
		{
			return 1048576L;
		}
		if (Operators.CompareString(string_37, "BF4A", false) == 0)
		{
			return 4194304L;
		}
		return 0L;
	}

	public static object smethod_7(string string_37)
	{
		long num = Strings.Len(string_37);
		byte[] array = new byte[(int)(num - 1L) + 1];
		long num2 = num - 1L;
		for (long num3 = 0L; num3 <= num2; num3++)
		{
			array[(int)num3] = (byte)Strings.Asc(Strings.Mid(string_37, (int)(num3 + 1L), 1));
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_8(string string_37, string string_38, long long_0, long long_1)
	{
		if (Operators.CompareString(FileSystem.Dir(string_37), "", false) == 0)
		{
			return false;
		}
		if (FileSystem.FileLen(string_37) < long_0 + long_1)
		{
			return false;
		}
		bool result;
		try
		{
			FileStream fileStream = new FileStream(string_37, FileMode.Open);
			FileStream fileStream2 = new FileStream(string_38, FileMode.Create);
			byte[] array = new byte[1024];
			long num = long_1;
			fileStream.Seek(long_0, SeekOrigin.Begin);
			while (num > 0L)
			{
				int num2 = (int)((num <= 1024L) ? num : 1024);
				fileStream.Read(array, 0, num2);
				fileStream2.Write(array, 0, num2);
				num -= num2;
			}
			fileStream2.Close();
			fileStream.Close();
			result = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool smethod_9(ref byte[] byte_2, long long_0, string string_37, bool bool_0 = false)
	{
		if (!bool_0 && !smethod_28(string_37))
		{
			return false;
		}
		bool result;
		try
		{
			FileStream fileStream = new FileStream(string_37, FileMode.Append);
			fileStream.Write(byte_2, 0, (int)long_0);
			fileStream.Close();
			result = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static int smethod_10(ref byte[] byte_2, string string_37, long long_0, byte byte_3, int int_92 = -1)
	{
		if (Operators.CompareString(FileSystem.Dir(string_37), "", false) == 0)
		{
			return -1;
		}
		if (long_0 > FileSystem.FileLen(string_37))
		{
			return -1;
		}
		long num = FileSystem.FileLen(string_37);
		int num2 = (int)((int_92 != -1) ? int_92 : (num - long_0));
		FileStream fileStream = new FileStream(string_37, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		int i;
		for (i = 0; i + long_0 < num && i != num2; i++)
		{
			byte b = (byte)fileStream.ReadByte();
			if (b == byte_3)
			{
				break;
			}
			byte_2 = (byte[])Utils.CopyArray(byte_2, new byte[i + 1]);
			byte_2[i] = b;
		}
		fileStream.Close();
		return i;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static int smethod_11(ref byte[] byte_2, string string_37, long long_0, int int_92 = -1)
	{
		if (Operators.CompareString(FileSystem.Dir(string_37), "", false) == 0)
		{
			return -1;
		}
		long num = FileSystem.FileLen(string_37);
		if (long_0 > num)
		{
			return -1;
		}
		int count = (int)((int_92 != -1) ? int_92 : (num - long_0));
		FileStream fileStream = new FileStream(string_37, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Read(byte_2, 0, count);
		fileStream.Close();
		return int_92;
	}

	public static byte[] smethod_12(byte[] byte_2, int int_92, int int_93)
	{
		int num = int_93 - 1;
		for (int i = 0; i <= num; i += 2)
		{
			byte b = byte_2[int_92 + i];
			byte_2[int_92 + i] = byte_2[int_92 + i + 1];
			byte_2[int_92 + i + 1] = b;
		}
		return byte_2;
	}

	public static void smethod_13(ref byte[] byte_2, int int_92, int int_93, ref byte[] byte_3, int int_94)
	{
		int num = int_93 - 1;
		for (int i = 0; i <= num; i++)
		{
			byte_3[int_94 + i] = byte_2[int_92 + i];
		}
	}

	public static byte[] smethod_14(int int_92)
	{
		byte[] array = new byte[int_92 - 1 + 1];
		VBMath.Randomize();
		int num = int_92 - 1;
		for (int i = 0; i <= num; i++)
		{
			array[i] = (byte)(int)Math.Round(Conversion.Int(256f * VBMath.Rnd()));
		}
		return array;
	}

	public static byte[] smethod_15(ref byte[] byte_2, byte[] byte_3)
	{
		int length = byte_2.GetLength(0);
		int length2 = byte_3.GetLength(0);
		byte[] byte_4 = new byte[length - 1 + 1];
		smethod_19(ref byte_4, 0, length, 0);
		if (length != length2)
		{
			Interaction.MsgBox("bxorarrays only takes same length arrays to xor", MsgBoxStyle.Critical, "Error:");
			return byte_4;
		}
		int num = length - 1;
		for (int i = 0; i <= num; i++)
		{
			byte_4[i] = (byte)(byte_2[i] ^ byte_3[i]);
		}
		return byte_4;
	}

	public static bool smethod_16(ref byte[] byte_2, int int_92, int int_93, ref byte[] byte_3, int int_94)
	{
		int num = int_93 - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (byte_3[int_94 + num2] != byte_2[int_92 + num2])
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static bool smethod_17(ref byte[] byte_2, int int_92, int int_93, byte byte_3)
	{
		int num = int_93 - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				if (byte_2[int_92 + num2] != byte_3)
				{
					break;
				}
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string smethod_18(ref byte[] byte_2)
	{
		int int_ = byte_2.Length - 1;
		int num = byte_2.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			if (byte_2[i] == 0)
			{
				int_ = i;
				break;
			}
		}
		return smethod_1(ref byte_2, int_);
	}

	public static void smethod_19(ref byte[] byte_2, int int_92, int int_93, byte byte_3)
	{
		int num = int_93 - 1;
		for (int i = 0; i <= num; i++)
		{
			byte_2[int_92 + i] = byte_3;
		}
	}

	public static string smethod_20(string string_37, bool bool_0 = true)
	{
		int num = Strings.InStrRev(string_37, "\\", -1, CompareMethod.Text);
		if (bool_0)
		{
			return Strings.Mid(string_37, 1, num);
		}
		return Strings.Mid(string_37, 1, num - 1);
	}

	public static string smethod_21(string string_37)
	{
		int num = Strings.InStrRev(string_37, "\\", -1, CompareMethod.Text);
		return Strings.Mid(string_37, num + 1);
	}

	public static void smethod_22(int int_92)
	{
		double timer = DateAndTime.Timer;
		double num = timer + (double)int_92;
		while (DateAndTime.Timer < num)
		{
			Application.DoEvents();
		}
	}

	public static void smethod_23(ref int[] int_92, int int_93, int int_94)
	{
		if (int_94 == int_93)
		{
			return;
		}
		int num = int_92[int_93];
		if (int_94 < int_93)
		{
			int num2 = int_94 + 1;
			for (int i = int_93; i >= num2; i += -1)
			{
				int_92[i] = int_92[i - 1];
			}
		}
		else
		{
			int num3 = int_94 - 1;
			for (int i = int_93; i <= num3; i++)
			{
				int_92[i] = int_92[i + 1];
			}
		}
		int_92[int_94] = num;
	}

	public static string smethod_24(ref byte[] byte_2, int int_92, int int_93, int int_94 = 16, bool bool_0 = false, string string_37 = "")
	{
		int num = 0;
		string text = "";
		string text2 = "";
		if (bool_0)
		{
			text = string_37 + "\r\n";
			text = text + Strings.StrDup(66, "-") + "\r\n";
		}
		long num2 = int_93 - 1;
		for (long num3 = 0L; num3 <= num2; num3++)
		{
			byte byte_3 = byte_2[(int)(int_92 + num3)];
			text = text + smethod_2(byte_3) + " ";
			text2 += smethod_25(byte_3);
			num++;
			if (num == int_94)
			{
				text = text + "  " + text2 + "\r\n";
				text2 = "";
				num = 0;
			}
		}
		if (num > 0)
		{
			text = text + Strings.Space((int_94 - num) * 3) + "  " + text2 + "\r\n";
		}
		return text;
	}

	public static string smethod_25(byte byte_2)
	{
		if (byte_2 >= 32 && byte_2 <= 126)
		{
			return Conversions.ToString(Strings.Chr(byte_2));
		}
		return ".";
	}

	public static string smethod_26(string string_37)
	{
		return Strings.Replace(string_37, "\0", "");
	}

	public static double smethod_27(string string_37)
	{
		NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
		numberFormatInfo.NumberDecimalSeparator = ".";
		numberFormatInfo.NumberGroupSeparator = ",";
		numberFormatInfo.NumberGroupSizes = new int[1] { 3 };
		double result = default(double);
		try
		{
			result = Convert.ToDouble(string_37, numberFormatInfo);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox("Error converting ToDouble, Contact the Application Designer", MsgBoxStyle.Exclamation, "Error:");
			Application.Exit();
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_28(string string_37)
	{
		if (Operators.CompareString(FileSystem.Dir(string_37), "", false) == 0)
		{
			return true;
		}
		bool result;
		try
		{
			FileSystem.Kill(string_37);
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Error erasing file " + string_37 + "\r\n" + ex2.Message, MsgBoxStyle.Exclamation, "Error:");
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
