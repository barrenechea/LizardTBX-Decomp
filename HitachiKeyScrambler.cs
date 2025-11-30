using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class HitachiKeyScrambler
{
	private static byte[] byte_0 = new byte[32];

	public static void smethod_0()
	{
		byte_0[0] = 2;
		byte_0[1] = 8;
		byte_0[2] = 17;
		byte_0[3] = 24;
		byte_0[4] = 30;
		byte_0[5] = 23;
		byte_0[6] = 0;
		byte_0[7] = 13;
		byte_0[8] = 5;
		byte_0[9] = 31;
		byte_0[10] = 20;
		byte_0[11] = 12;
		byte_0[12] = 18;
		byte_0[13] = 10;
		byte_0[14] = 6;
		byte_0[15] = 26;
		byte_0[16] = 21;
		byte_0[17] = 27;
		byte_0[18] = 11;
		byte_0[19] = 16;
		byte_0[20] = 14;
		byte_0[21] = 28;
		byte_0[22] = 7;
		byte_0[23] = 1;
		byte_0[24] = 22;
		byte_0[25] = 3;
		byte_0[26] = 19;
		byte_0[27] = 9;
		byte_0[28] = 29;
		byte_0[29] = 15;
		byte_0[30] = 25;
		byte_0[31] = 4;
	}

	public static void smethod_1()
	{
		byte_0[0] = 22;
		byte_0[1] = 27;
		byte_0[2] = 3;
		byte_0[3] = 10;
		byte_0[4] = 14;
		byte_0[5] = 16;
		byte_0[6] = 1;
		byte_0[7] = 28;
		byte_0[8] = 26;
		byte_0[9] = 7;
		byte_0[10] = 15;
		byte_0[11] = 21;
		byte_0[12] = 5;
		byte_0[13] = 19;
		byte_0[14] = 29;
		byte_0[15] = 12;
		byte_0[16] = 2;
		byte_0[17] = 11;
		byte_0[18] = 24;
		byte_0[19] = 20;
		byte_0[20] = 13;
		byte_0[21] = 18;
		byte_0[22] = 4;
		byte_0[23] = 30;
		byte_0[24] = 9;
		byte_0[25] = 17;
		byte_0[26] = 23;
		byte_0[27] = 0;
		byte_0[28] = 6;
		byte_0[29] = 31;
		byte_0[30] = 8;
		byte_0[31] = 25;
	}

	public static byte[] smethod_2(ref byte[] byte_1)
	{
		double double_ = (double)(byte_1[0] ^ 0x66) * 16777216.0 + (double)(byte_1[1] ^ 0x64) * 65536.0 + (double)(byte_1[2] ^ 0x60) * 256.0 + (double)(byte_1[3] ^ 0xF7);
		string text = smethod_5(double_);
		string sDest = text;
		int num = 0;
		do
		{
			StringType.MidStmtStr(ref sDest, 32 - num, 1, Strings.Mid(text, 32 - byte_0[num], 1));
			num++;
		}
		while (num <= 31);
		return cpoahSiso(sDest);
	}

	public static byte[] smethod_3(ref byte[] byte_1)
	{
		double double_ = (double)(byte_1[0] ^ 0x10) * 16777216.0 + (double)(byte_1[1] ^ 0x30) * 65536.0 + (double)(byte_1[2] ^ 0x68) * 256.0 + (double)(byte_1[3] ^ 0x32);
		string text = smethod_5(double_);
		string string_ = text;
		return cpoahSiso(string_);
	}

	public static byte[] smethod_4(ref byte[] byte_1)
	{
		double double_ = (double)(byte_1[0] ^ 0x8B) * 16777216.0 + (double)(byte_1[1] ^ 0x8B) * 65536.0 + (double)(byte_1[2] ^ 0x8B) * 256.0 + (double)(byte_1[3] ^ 0x8B);
		string text = smethod_5(double_);
		string sDest = text;
		int num = 0;
		do
		{
			StringType.MidStmtStr(ref sDest, 32 - num, 1, Strings.Mid(text, 32 - byte_0[num], 1));
			num++;
		}
		while (num <= 31);
		return cpoahSiso(sDest);
	}

	public static string smethod_5(double double_0)
	{
		string sDest = Strings.StrDup(32, " ");
		long num = (long)Math.Round(Conversion.Fix(double_0 / 65536.0));
		long num2 = (long)Math.Round(double_0 - (double)num * 65536.0);
		byte b = 1;
		do
		{
			if ((ulong)(num2 & 1L) > 0uL)
			{
				StringType.MidStmtStr(ref sDest, 33 - b, 1, "1");
			}
			num2 /= 2L;
			b++;
		}
		while ((uint)b <= 16u);
		b = 17;
		do
		{
			if ((ulong)(num & 1L) > 0uL)
			{
				StringType.MidStmtStr(ref sDest, 33 - b, 1, "1");
			}
			num /= 2L;
			b++;
		}
		while ((uint)b <= 32u);
		return sDest;
	}

	public static byte[] cpoahSiso(string string_0)
	{
		byte[] array = new byte[4] { 0, 0, 0, 0 };
		int num = 0;
		do
		{
			if (Operators.CompareString(Strings.Mid(string_0, 1 + num, 1), "1", false) == 0)
			{
				array[3] = (byte)Math.Round((double)(int)array[3] + Math.Pow(2.0, num));
			}
			if (Operators.CompareString(Strings.Mid(string_0, 9 + num, 1), "1", false) == 0)
			{
				array[2] = (byte)Math.Round((double)(int)array[2] + Math.Pow(2.0, num));
			}
			if (Operators.CompareString(Strings.Mid(string_0, 17 + num, 1), "1", false) == 0)
			{
				array[1] = (byte)Math.Round((double)(int)array[1] + Math.Pow(2.0, num));
			}
			if (Operators.CompareString(Strings.Mid(string_0, 25 + num, 1), "1", false) == 0)
			{
				array[0] = (byte)Math.Round((double)(int)array[0] + Math.Pow(2.0, num));
			}
			num++;
		}
		while (num <= 7);
		return array;
	}

	public static byte[] smethod_6(ref byte[] byte_1)
	{
		double double_ = (double)(byte_1[0] ^ 0x8B) * 16777216.0 + (double)(byte_1[1] ^ 0x8B) * 65536.0 + (double)(byte_1[2] ^ 0x8B) * 256.0 + (double)(byte_1[3] ^ 0x8B);
		string text = smethod_5(double_);
		string string_ = text;
		return cpoahSiso(string_);
	}

	public static byte[] smethod_7(string string_0, long long_0, int int_0, bool bool_0)
	{
		byte[] byte_ = new byte[4];
		byte[] array = new byte[4];
		long num = long_0 & -4L;
		int num2 = int_0 & 0xFFFC;
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(num, SeekOrigin.Begin);
		byte[] array2 = default(byte[]);
		if (bool_0)
		{
			smethod_0();
			int num3 = (int)Math.Round((double)num2 / 4.0);
			int num4 = num3 - 1;
			for (int i = 0; i <= num4; i++)
			{
				fileStream.Read(byte_, 0, 4);
				array = smethod_2(ref byte_);
				array2 = (byte[])Utils.CopyArray(array2, new byte[(i + 1) * 4 - 1 + 1]);
				array2[i * 4] = array[0];
				array2[i * 4 + 1] = array[1];
				array2[i * 4 + 2] = array[2];
				array2[i * 4 + 3] = array[3];
				num += 4L;
			}
		}
		else
		{
			array2 = new byte[int_0 - 1 + 1];
			fileStream.Read(array2, 0, int_0);
		}
		fileStream.Close();
		return array2;
	}

	public static bool smethod_8(string string_0, long long_0, int int_0, bool bool_0, byte[] byte_1)
	{
		byte[] array = new byte[4];
		byte[] byte_2 = new byte[4];
		long num = long_0 & -4L;
		int num2 = int_0 & 0xFFFC;
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(num, SeekOrigin.Begin);
		if (bool_0)
		{
			smethod_1();
			int num3 = (int)Math.Round((double)num2 / 4.0);
			int num4 = num3 - 1;
			for (int i = 0; i <= num4; i++)
			{
				byte_2[0] = byte_1[i * 4];
				byte_2[1] = byte_1[i * 4 + 1];
				byte_2[2] = byte_1[i * 4 + 2];
				byte_2[3] = byte_1[i * 4 + 3];
				array = smethod_4(ref byte_2);
				fileStream.Write(array, 0, 4);
				num += 4L;
			}
		}
		else
		{
			fileStream.Write(byte_1, 0, int_0);
		}
		fileStream.Close();
		return true;
	}

	public static bool smethod_9(ref byte[] byte_1, int int_0)
	{
		byte[] array = new byte[4];
		byte[] byte_2 = new byte[4];
		int num = int_0 & 0xFFFC;
		smethod_1();
		int num2 = (int)Math.Round((double)num / 4.0);
		int num3 = num2 - 1;
		long num4 = default(long);
		for (int i = 0; i <= num3; i++)
		{
			byte_2[0] = byte_1[i * 4];
			byte_2[1] = byte_1[i * 4 + 1];
			byte_2[2] = byte_1[i * 4 + 2];
			byte_2[3] = byte_1[i * 4 + 3];
			array = smethod_4(ref byte_2);
			byte_1[i * 4] = array[0];
			byte_1[i * 4 + 1] = array[1];
			byte_1[i * 4 + 2] = array[2];
			byte_1[i * 4 + 3] = array[3];
			num4 += 4L;
		}
		return true;
	}
}
