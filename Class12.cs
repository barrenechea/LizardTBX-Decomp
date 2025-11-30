using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class12
{
	public const int int_0 = 0;

	public const int int_1 = 1;

	public const int int_2 = 2;

	public const int int_3 = 16;

	public const int YqUsblhqw = 17;

	public const int int_4 = 18;

	public const int int_5 = 20;

	public const int int_6 = 32;

	public const int int_7 = 33;

	public const int int_8 = 34;

	public const int int_9 = 35;

	public const int int_10 = 36;

	public const int int_11 = 37;

	public const int int_12 = 38;

	public const int int_13 = 39;

	public const int int_14 = 40;

	public const int int_15 = 41;

	public const int int_16 = 48;

	public const int int_17 = 49;

	public const int int_18 = 50;

	public const int int_19 = 51;

	public const int int_20 = 52;

	public const int int_21 = 53;

	public const int int_22 = 64;

	public const int int_23 = 65;

	public const int int_24 = 66;

	public const int int_25 = 67;

	public const int int_26 = 68;

	public const int int_27 = 69;

	public const int int_28 = 160;

	public const int int_29 = 160;

	public const int int_30 = 161;

	public const int int_31 = 255;

	public const int int_32 = 40;

	public const int int_33 = 40;

	public const int int_34 = 52;

	public const int int_35 = 40;

	public const int int_36 = 52;

	public const int int_37 = 40;

	public const int int_38 = 172032;

	public const int int_39 = 176112;

	public static bool bool_0;

	public static bool smethod_0(string string_0)
	{
		switch (string_0)
		{
		case "HITACHI":
			return true;
		case "SAMSUNG":
			return true;
		case "BENQ":
			return true;
		case "LITEON":
			return true;
		default:
			return false;
		}
	}

	public static bool smethod_1(string string_0, string string_1)
	{
		if (Operators.CompareString(string_0, "HITACHI", false) == 0 && Operators.CompareString(string_1, "GDR3120L", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(string_0, "SAMSUNG", false) == 0 && Operators.CompareString(string_1, "TSH943A", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(string_0, "BENQ", false) == 0 && Operators.CompareString(string_1, "VAD6038", false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(string_0, "LITEON", false) == 0)
		{
			switch (string_1)
			{
			case "DG16D2S":
				return true;
			case "DG16D4S":
				return true;
			case "DG16D5S":
				return true;
			}
		}
		return false;
	}

	public static bool smethod_2(string string_0, string string_1, string string_2)
	{
		if (Operators.CompareString(string_0, "HITACHI", false) == 0 && Operators.CompareString(string_1, "GDR3120L", false) == 0)
		{
			switch (string_2)
			{
			case "32":
				return true;
			case "36":
				return true;
			case "40":
				return true;
			case "46":
				return true;
			case "47":
				return true;
			case "58":
				return true;
			case "59":
				return true;
			case "78":
				return true;
			case "79":
				return true;
			}
		}
		if (Operators.CompareString(string_0, "SAMSUNG", false) == 0 && Operators.CompareString(string_1, "TSH943A", false) == 0)
		{
			if (Operators.CompareString(string_2, "MS25", false) == 0)
			{
				return true;
			}
			if (Operators.CompareString(string_2, "MS28", false) == 0)
			{
				return true;
			}
		}
		if (Operators.CompareString(string_0, "BENQ", false) == 0 && Operators.CompareString(string_1, "VAD6038", false) == 0)
		{
			switch (string_2)
			{
			case "62430":
				return true;
			case "64930":
				return true;
			case "04421":
				return true;
			}
		}
		if (Operators.CompareString(string_0, "LITEON", false) == 0)
		{
			if (Operators.CompareString(string_1, "DG16D2S", false) == 0)
			{
				switch (string_2)
				{
				case "74850":
					return true;
				case "83850V1":
					return true;
				case "83850V2":
					return true;
				case "93450":
					return true;
				case "02510":
					return true;
				}
			}
			if (Operators.CompareString(string_1, "DG16D4S", false) == 0)
			{
				switch (string_2)
				{
				case "9504":
					return true;
				case "0272":
					return true;
				case "0225":
					return true;
				case "0401":
					return true;
				case "1071":
					return true;
				}
			}
			if (Operators.CompareString(string_1, "DG16D5S", false) == 0)
			{
				if (Operators.CompareString(string_2, "1175", false) == 0)
				{
					return true;
				}
				if (Operators.CompareString(string_2, "1532", false) == 0)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static string smethod_3(string string_0, ref string string_1)
	{
		string_1 = "";
		if (FileSystem.FileLen(string_0) != 262144L)
		{
			string_1 = "INVALID FILE SIZE, MUST BE 256KB";
			return "";
		}
		byte[] byte_ = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "F2D22E2EBE2AAE0B8E2CF7DED2DAB7A5", false) == 0)
		{
			return "HITACHI   ";
		}
		byte_ = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "D56EB91215D228221C91EE78F709F900", false) == 0)
		{
			return "HITACHI   ";
		}
		byte_ = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "021C30021D924A4C0000000000000000", false) == 0)
		{
			return "SAMSUNG   ";
		}
		byte_ = smethod_35(string_0, 0L, 4);
		bool num = Operators.CompareString(Class13.smethod_5(ref byte_, 4), "02003002", false) == 0;
		byte[] byte_2 = smethod_35(string_0, 12L, 4);
		if (num & (Operators.CompareString(Class13.smethod_5(ref byte_2, 4), "EE341CFE", false) == 0))
		{
			return "BENQ      ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31800199C0C5836B7922C", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31852448A4E5870E6C3F8", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "187A533A5DE318F016E27509147FE4CA", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "187A533A5DE318DE72A7D0D21B71FE40", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE318308D5AB8ECC8791E39", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE318308D5AB8ECC8791E39", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31884B0E2CE2652850420", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "09EF6C2B03BD23D821AE092B011D558E", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "0922962B0F1223D821AE092B011D558E", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
		{
			return "LITEON    ";
		}
		byte_2 = smethod_35(string_0, 0L, 16);
		if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "4DAFE66F4B84679C65FA4D6F454901DA", false) == 0)
		{
			return "LITEON    ";
		}
		string_1 = "UN-IDENTIFIED VENDOR";
		return "";
	}

	public static string smethod_4(string string_0, string string_1, ref string string_2)
	{
		string_2 = "";
		if (FileSystem.FileLen(string_1) != 262144L)
		{
			string_2 = "INVALID FILE SIZE, MUST BE 256KB";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			byte[] byte_ = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "F2D22E2EBE2AAE0B8E2CF7DED2DAB7A5", false) == 0)
			{
				return "GDR3120L  ";
			}
			byte_ = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "D56EB91215D228221C91EE78F709F900", false) == 0)
			{
				return "GDR3120L  ";
			}
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			byte[] byte_ = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "021C30021D924A4C0000000000000000", false) == 0)
			{
				return "TSH943A   ";
			}
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			byte[] byte_ = smethod_35(string_1, 0L, 4);
			bool num = Operators.CompareString(Class13.smethod_5(ref byte_, 4), "02003002", false) == 0;
			byte[] byte_2 = smethod_35(string_1, 12L, 4);
			if (num & (Operators.CompareString(Class13.smethod_5(ref byte_2, 4), "EE341CFE", false) == 0))
			{
				return "VAD6038   ";
			}
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			byte[] byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31800199C0C5836B7922C", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31852448A4E5870E6C3F8", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "187A533A5DE318F016E27509147FE4CA", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "187A533A5DE318DE72A7D0D21B71FE40", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE318308D5AB8ECC8791E39", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE318308D5AB8ECC8791E39", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "18B21F3A5DE31884B0E2CE2652850420", false) == 0)
			{
				return "DG16D2S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "09EF6C2B03BD23D821AE092B011D558E", false) == 0)
			{
				return "DG16D4S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "0922962B0F1223D821AE092B011D558E", false) == 0)
			{
				return "DG16D4S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
			{
				return "DG16D4S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
			{
				return "DG16D4S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "096D882B0F1223D821AE092B011D558E", false) == 0)
			{
				return "DG16D4S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "4DAFE66F4B84679C65FA4D6F454901DA", false) == 0)
			{
				return "DG16D5S   ";
			}
			byte_2 = smethod_35(string_1, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_2, 16), "4DAFA16F0398679C65FA4D6F454901DA", false) == 0)
			{
				return "DG16D5S   ";
			}
		}
		string_2 = "UN-IDENTIFIED VENDOR-MODEL";
		return "";
	}

	public static bool smethod_5(string string_0, string string_1, string string_2, bool bool_1, ref string string_3)
	{
		string_3 = "";
		if (FileSystem.FileLen(string_2) != 262144L)
		{
			string_3 = "INVALID FILE SIZE, MUST BE 256KB";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0 && Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
		{
			byte[] array = new byte[4096];
			array = Class10.smethod_7(string_2, 12288L, 4096, bool_1);
			int num = 0;
			do
			{
				if (array[num] == byte.MaxValue)
				{
					num++;
					continue;
				}
				return false;
			}
			while (num <= 4095);
			return true;
		}
		string_3 = "UN-IDENTIFIED VENDOR-MODEL";
		return false;
	}

	public static bool cpoahSiso(string string_0, string string_1, string string_2, ref string string_3)
	{
		string_3 = "";
		if (FileSystem.FileLen(string_2) != 262144L)
		{
			string_3 = "INVALID FILE SIZE, MUST BE 256KB";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0 && Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
		{
			byte[] byte_ = smethod_35(string_2, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "F2D22E2EBE2AAE0B8E2CF7DED2DAB7A5", false) == 0)
			{
				return false;
			}
			byte_ = smethod_35(string_2, 0L, 16);
			if (Operators.CompareString(Class13.smethod_5(ref byte_, 16), "D56EB91215D228221C91EE78F709F900", false) == 0)
			{
				return true;
			}
		}
		string_3 = "UN-IDENTIFIED VENDOR-MODEL";
		return false;
	}

	public static bool smethod_6(string string_0, ref bool bool_1, ref uint uint_0)
	{
		byte[] array = new byte[4];
		uint num = 0u;
		bool_1 = false;
		uint_0 = 0u;
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(255996L, SeekOrigin.Begin);
		fileStream.Read(array, 0, 4);
		uint num2 = (uint)(((ulong)array[3] << 24) + ((ulong)array[2] << 16) + ((ulong)array[1] << 8) + array[0]);
		if ((long)num2 == 0L)
		{
			bool_1 = true;
			return true;
		}
		fileStream.Seek(24576L, SeekOrigin.Begin);
		long num3 = 24576L;
		do
		{
			fileStream.Read(array, 0, 4);
			num = (uint)(num + (((ulong)array[3] << 24) + ((ulong)array[2] << 16) + ((ulong)array[1] << 8) + array[0]));
			num3 += 4L;
		}
		while (num3 <= 255992L);
		fileStream.Close();
		if ((long)(num2 + num) == 0L)
		{
			bool_1 = false;
			return true;
		}
		uint_0 = (uint)((ulong)(~num) + 1uL);
		return false;
	}

	public static void smethod_7(string string_0, uint uint_0)
	{
		byte[] array = new byte[4];
		array[3] = (byte)((ulong)(uint_0 >> 24) & 0xFFuL);
		array[2] = (byte)((ulong)(uint_0 >> 16) & 0xFFuL);
		array[1] = (byte)((ulong)(uint_0 >> 8) & 0xFFuL);
		array[0] = (byte)((ulong)uint_0 & 0xFFuL);
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(255996L, SeekOrigin.Begin);
		fileStream.Write(array, 0, 4);
		fileStream.Close();
	}

	public static bool smethod_8(string string_0)
	{
		if (FileSystem.FileLen(string_0) != 262144L)
		{
			return false;
		}
		byte[] array = smethod_35(string_0, 256L, 256);
		int num = 0;
		do
		{
			if (array[num] == 0)
			{
				num++;
				continue;
			}
			return false;
		}
		while (num <= 255);
		array = smethod_35(string_0, 11264L, 2);
		if ((array[0] != 192) | (array[1] != 133))
		{
			return false;
		}
		array = smethod_35(string_0, 11776L, 2);
		if ((array[0] != 5) | (array[1] != 128))
		{
			return false;
		}
		array = smethod_35(string_0, 44800L, 256);
		num = 0;
		do
		{
			if (array[num] == byte.MaxValue)
			{
				num++;
				continue;
			}
			return false;
		}
		while (num <= 255);
		return true;
	}

	public static string smethod_9(string string_0, string string_1, string string_2, ref string string_3)
	{
		string_3 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				bool flag = cpoahSiso(string_0, string_1, string_2, ref string_3);
				if (Operators.CompareString(string_3, "", false) != 0)
				{
					return "";
				}
				byte[] byte_ = Class10.smethod_7(string_2, 4136L, 4, flag);
				if (Operators.CompareString(Class13.smethod_5(ref byte_), "C005A00A", false) == 0)
				{
					byte_ = Class10.smethod_7(string_2, 4580L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_), "DD00F100", false) == 0)
					{
						return "32        ";
					}
					byte_ = Class10.smethod_7(string_2, 4580L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_), "DD12F000", false) == 0)
					{
						return "40        ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 32/40 IDENTIFIER";
					return "";
				}
				byte_ = Class10.smethod_7(string_2, 4136L, 4, flag);
				if (Operators.CompareString(Class13.smethod_5(ref byte_), "BC05A00A", false) == 0)
				{
					return "36        ";
				}
				byte_ = Class10.smethod_7(string_2, 4136L, 4, flag);
				if (Operators.CompareString(Class13.smethod_5(ref byte_), "C405A00A", false) == 0)
				{
					byte_ = Class10.smethod_7(string_2, 33836L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_), "CAED0200", false) == 0)
					{
						return "46        ";
					}
					byte_ = Class10.smethod_7(string_2, 33836L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_), "E0ED0200", false) == 0)
					{
						return "47        ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 46/47 IDENTIFIER";
					return "";
				}
				byte_ = Class10.smethod_7(string_2, 4136L, 4, flag);
				byte[] byte_2;
				if (Operators.CompareString(Class13.smethod_5(ref byte_), "C805A00A", false) == 0)
				{
					byte_2 = Class10.smethod_7(string_2, 33836L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "00DD39F0", false) == 0)
					{
						return "58        ";
					}
					byte_2 = Class10.smethod_7(string_2, 33836L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "00DD4FF0", false) == 0)
					{
						return "59        ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 58/59 IDENTIFIER";
					return "";
				}
				byte_2 = Class10.smethod_7(string_2, 109936L, 4, flag);
				switch (Class13.smethod_5(ref byte_2))
				{
				case "004B0090":
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DDAF", false) == 0)
					{
						return "78-4B00   ";
					}
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DDC5", false) == 0)
					{
						return "79-4B00   ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 78/79 4B00 IDENTIFIER";
					return "";
				case "104E0090":
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DDC8", false) == 0)
					{
						return "78-4E10   ";
					}
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DDDE", false) == 0)
					{
						return "79-4E10   ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 78/79 4E10 IDENTIFIER";
					return "";
				case "304C0090":
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DD3A", false) == 0)
					{
						return "78-4C30   ";
					}
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DD41", false) == 0)
					{
						return "79-4C30   ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 78/79 4C30 IDENTIFIER";
					return "";
				case "204D0090":
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DD38", false) == 0)
					{
						return "78-4D20   ";
					}
					byte_2 = Class10.smethod_7(string_2, 30540L, 4, flag);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "C809DD3F", false) == 0)
					{
						return "79-4D20   ";
					}
					string_3 = "UNKNOWN HITACHI GDR3120 78/79 4D20 IDENTIFIER";
					return "";
				default:
					string_3 = "UNKNOWN HITACHI GDR3120 IDENTIFIER";
					return "";
				}
			}
			string_3 = "UNKNOWN HITACHI IDENTIFIER";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				byte[] byte_2 = smethod_35(string_2, 2152L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "E8460100", false) == 0)
				{
					return "MS25      ";
				}
				byte_2 = smethod_35(string_2, 2152L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "E6A00100", false) == 0)
				{
					return "MS25      ";
				}
				byte_2 = smethod_35(string_2, 2152L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "E8D30100", false) == 0)
				{
					return "MS28      ";
				}
				byte_2 = smethod_35(string_2, 2152L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "E7C10100", false) == 0)
				{
					return "MS28      ";
				}
				return "MS28      ";
			}
			string_3 = "UNKNOWN SAMSUNG IDENTIFIER";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				byte[] byte_2 = smethod_35(string_2, 4L, 4);
				bool num = Operators.CompareString(Class13.smethod_5(ref byte_2), "2E334A4C", false) == 0;
				byte[] byte_ = smethod_35(string_2, 4L, 4);
				if (num | (Operators.CompareString(Class13.smethod_5(ref byte_), "34EA4A4C", false) == 0))
				{
					return "62430     ";
				}
				byte_2 = smethod_35(string_2, 4L, 4);
				bool num2 = Operators.CompareString(Class13.smethod_5(ref byte_2), "2E384A4C", false) == 0;
				byte_ = smethod_35(string_2, 4L, 4);
				if (num2 | (Operators.CompareString(Class13.smethod_5(ref byte_), "34EF4A4C", false) == 0))
				{
					return "64930     ";
				}
				byte_2 = smethod_35(string_2, 4L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "2E6F4A4C", false) == 0)
				{
					return "04421     ";
				}
				string_3 = "UNKNOWN BENQ VAD6038 IDENTIFIER";
				return "";
			}
			string_3 = "UNKNOWN BENQ IDENTIFIER";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long num3 = Class8.smethod_4(string_2, "60067408F0", ref string_3, 4096, 0L, 65536L);
				if (Operators.CompareString(string_3, "", false) != 0)
				{
					string_3 += " - CANNOT DETERMINE TYPE";
					return "";
				}
				byte[] byte_2;
				if (num3 != -1L)
				{
					byte_2 = smethod_35(string_2, 4L, 4);
					bool num4 = Operators.CompareString(Class13.smethod_5(ref byte_2), "5DE31800", false) == 0;
					byte[] byte_ = smethod_35(string_2, 4L, 4);
					if (num4 | (Operators.CompareString(Class13.smethod_5(ref byte_), "5DE31852", false) == 0))
					{
						object left = Class8.smethod_4(string_2, "60067408F0000000", ref string_3, 4096, 0L, 65536L);
						if (Operators.CompareString(string_3, "", false) != 0)
						{
							string_3 += " - CANNOT DETERMINE TYPE 2";
							return "";
						}
						if (Operators.ConditionalCompareObjectNotEqual(left, -1, false))
						{
							return "93450     ";
						}
						return "74850     ";
					}
					byte_2 = smethod_35(string_2, 4L, 4);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "5DE31830", false) == 0)
					{
						return "93450     ";
					}
					byte_2 = smethod_35(string_2, 0L, 16);
					if (Operators.CompareString(Class13.smethod_5(ref byte_2), "18B21F3A5DE31884B0E2CE2652850420", false) == 0)
					{
						return "02510     ";
					}
					return "93450     ";
				}
				byte_2 = smethod_35(string_2, 4L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "5DE318F0", false) == 0)
				{
					return "83850     ";
				}
				byte_2 = smethod_35(string_2, 4L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "5DE318DE", false) == 0)
				{
					return "83850V2   ";
				}
				string_3 = "UNKNOWN LITEON DG16D2S IDENTIFIER";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				byte[] byte_2 = smethod_35(string_2, 0L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "09EF6C2B", false) == 0)
				{
					return "9504      ";
				}
				byte_2 = smethod_35(string_2, 0L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "0922962B", false) == 0)
				{
					return "0272      ";
				}
				byte_2 = smethod_35(string_2, 0L, 4);
				bool num5 = Operators.CompareString(Class13.smethod_5(ref byte_2), "096D882B", false) == 0;
				byte[] byte_ = smethod_35(string_2, 23L, 4);
				if (num5 & (Operators.CompareString(Class13.smethod_5(ref byte_), "DCAD3ACD", false) == 0))
				{
					return "0225      ";
				}
				byte_2 = smethod_35(string_2, 0L, 4);
				bool num6 = Operators.CompareString(Class13.smethod_5(ref byte_2), "096D882B", false) == 0;
				byte_ = smethod_35(string_2, 23L, 4);
				if (num6 & (Operators.CompareString(Class13.smethod_5(ref byte_), "A24D02EC", false) == 0))
				{
					return "0401      ";
				}
				byte_2 = smethod_35(string_2, 0L, 4);
				bool num7 = Operators.CompareString(Class13.smethod_5(ref byte_2), "096D882B", false) == 0;
				byte_ = smethod_35(string_2, 23L, 4);
				if (num7 & (Operators.CompareString(Class13.smethod_5(ref byte_), "70AE16D4", false) == 0))
				{
					return "1071      ";
				}
				string_3 = "UNKNOWN LITEON DG16D4S IDENTIFIER";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				byte[] byte_2 = smethod_35(string_2, 0L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "4DAFE66F", false) == 0)
				{
					return "1175      ";
				}
				byte_2 = smethod_35(string_2, 0L, 4);
				if (Operators.CompareString(Class13.smethod_5(ref byte_2), "4DAFA16F", false) == 0)
				{
					return "1532      ";
				}
				string_3 = "UNKNOWN LITEON DG16D5S IDENTIFIER";
				return "";
			}
			string_3 = "UNKNOWN LITEON IDENTIFIER";
			return "";
		}
		return "";
	}

	public static string smethod_10(string string_0, ref string string_1, ref long long_0)
	{
		string_1 = "";
		long num = 40960L;
		string text = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
		int num2 = 0;
		byte[] byte_;
		while ((Operators.CompareString(text, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) == 0) | (Operators.CompareString(Strings.Mid(text, 17), "FFFFFFFFFFFFFFFF", false) == 0))
		{
			byte_ = smethod_35(string_0, num + num2 * 16, 16);
			text = Class13.smethod_5(ref byte_);
			num2++;
		}
		while (Operators.CompareString(text, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) != 0)
		{
			byte_ = smethod_35(string_0, num + num2 * 16, 16);
			text = Class13.smethod_5(ref byte_);
			num2++;
		}
		num += (num2 - 2) * 16;
		byte_ = smethod_35(string_0, num, 16);
		text = Class13.smethod_5(ref byte_);
		if (Operators.CompareString(text, "00112233445566778899AABBCCDDEEFA", false) == 0)
		{
			num += 16L;
		}
		long_0 = num;
		byte_ = smethod_35(string_0, long_0, 16);
		return Class13.smethod_5(ref byte_);
	}

	public static bool smethod_11(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref byte[] byte_0, ref long long_0, ref byte[] byte_1, ref long long_1)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long_0 = -1L;
				long_1 = -1L;
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					long_1 = 172032L;
					byte_1 = smethod_35(string_3, long_1, 4096);
					long_0 = 176112L;
					byte_0 = smethod_35(string_3, long_0, 16);
					return true;
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return Conversions.ToBoolean("");
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		string_4 = "UNKNOWN VENDOR-MODEL-ROM IDENTIFIER";
		return false;
	}

	public static bool smethod_12(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref byte[] byte_0, ref long long_0, ref int int_40)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			long_0 = -1L;
			int_40 = -1;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			long_0 = -1L;
			int_40 = -1;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			long_0 = -1L;
			int_40 = -1;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long_0 = -1L;
				int_40 = -1;
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					byte[] array = new byte[17];
					long_0 = 0L;
					array = smethod_35(string_3, 258048L, 16);
					int num = 0;
					while (array[num] != byte.MaxValue)
					{
						long_0++;
						num++;
						if (num > 15)
						{
							break;
						}
					}
					byte_0 = smethod_35(string_3, 258048L, (int)long_0);
					if (long_0 > 2L && ((byte_0[0] == 0) & (byte_0[1] == 0)))
					{
						long_0 = -1L;
					}
					byte[] array2 = smethod_35(string_3, 61440L, 1);
					if ((array2[0] == 0) | (array2[0] == byte.MaxValue))
					{
						if (Operators.CompareString(Strings.Trim(string_2), "9504", false) != 0)
						{
							string_4 = "OLD DUMMY NOT ALLOWED FOR THIS DRIVE PLEASE REDUMP YOUR DUMMY WITH LATEST GECKO";
							return false;
						}
						array2[0] = 1;
					}
					int_40 = array2[0];
					return true;
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return false;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				long_0 = -1L;
				int_40 = -1;
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		string_4 = "UNKNOWN VENDOR-MODEL-ROM IDENTIFIER";
		return false;
	}

	public static bool smethod_13(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref byte[] byte_0, ref long long_0, ref byte[] byte_1, ref long long_1)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			long_0 = -1L;
			long_1 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long_0 = -1L;
				long_1 = -1L;
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0))
				{
					byte b = 0;
					long long_2 = 65536L;
					long num = default(long);
					while (true)
					{
						byte[] array;
						if ((byte)(~b) != 0)
						{
							num = Class8.smethod_7(string_3, "7D387C01E4FF", ref string_4, 4096, long_2);
							if (num == -1L)
							{
								break;
							}
							array = Class8.smethod_8(string_3, num - 8L, 2, true, ref string_4);
							if ((array[0] == 84) & (array[1] == 15))
							{
								b = byte.MaxValue;
							}
							long_2 = num + 1L;
							continue;
						}
						array = Class8.smethod_8(string_3, num - 13L + 3L, 8, true, ref string_4);
						long num2 = (long)((ulong)array[0] << 8);
						array[5] = (byte)((uint)array[5] >> 4);
						num2 += (long)((ulong)array[5] << 16);
						byte_1 = smethod_35(string_3, num2, 4096);
						long_1 = num2;
						long_0 = num2 + 4080L;
						byte_0 = smethod_35(string_3, long_0, 16);
						return true;
					}
					string_4 += " - NOT FOUND";
					return Conversions.ToBoolean("");
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					byte b2 = 0;
					long long_3 = 65536L;
					long num3 = default(long);
					while (true)
					{
						byte[] array2;
						if ((byte)(~b2) != 0)
						{
							num3 = Class8.smethod_7(string_3, "1205EF127CE7", ref string_4, 4096, long_3);
							if (num3 == -1L)
							{
								break;
							}
							array2 = Class8.smethod_8(string_3, num3 - 5L, 2, true, ref string_4);
							if ((array2[0] == 84) & (array2[1] == 15))
							{
								b2 = byte.MaxValue;
							}
							long_3 = num3 + 1L;
							continue;
						}
						array2 = Class8.smethod_8(string_3, num3 - 7L, 8, true, ref string_4);
						long num4 = (long)((ulong)array2[0] << 8);
						array2[5] = (byte)((uint)array2[5] >> 4);
						num4 += (long)((ulong)array2[5] << 16);
						byte_1 = smethod_35(string_3, num4, 4096);
						long_1 = num4;
						long_0 = num4 + 4080L;
						byte_0 = smethod_35(string_3, long_0, 16);
						return true;
					}
					string_4 += " - NOT FOUND";
					return Conversions.ToBoolean("");
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return false;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				long_0 = -1L;
				long_1 = -1L;
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static bool smethod_14(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref byte[] byte_0, ref long long_0)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			long_0 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			long_0 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			long_0 = -1L;
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long_0 = -1L;
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					long_0 = 4096L;
					byte_0 = smethod_35(string_3, 126976L, 4096);
					return true;
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return false;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				long_0 = -1L;
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static string smethod_15(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref long long_0)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				bool flag = cpoahSiso(string_0, string_1, string_3, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return "";
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "32", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "36", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "40", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "46", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "47", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "58", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "59", false) == 0))
				{
					long_0 = 20224L;
					byte[] byte_ = Class10.smethod_7(string_3, 20224L, 16, flag);
					return Class13.smethod_5(ref byte_);
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4B00", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4B00", false) == 0))
				{
					long_0 = 19200L;
					byte[] byte_ = Class10.smethod_7(string_3, 19200L, 16, flag);
					return Class13.smethod_5(ref byte_);
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4E10", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4E10", false) == 0))
				{
					long_0 = 19984L;
					byte[] byte_ = Class10.smethod_7(string_3, 19984L, 16, flag);
					return Class13.smethod_5(ref byte_);
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4D20", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4D20", false) == 0))
				{
					long_0 = 19744L;
					byte[] byte_ = Class10.smethod_7(string_3, 19744L, 16, flag);
					return Class13.smethod_5(ref byte_);
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4C30", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4C30", false) == 0))
				{
					long_0 = 19504L;
					byte[] byte_ = Class10.smethod_7(string_3, 19504L, 16, flag);
					return Class13.smethod_5(ref byte_);
				}
				string_4 = "UNKNOWN HITACHI GDR3120 ROM";
				return "";
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "MS25", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "MS28", false) == 0))
				{
					string result = "";
					string str = "";
					int num = 0;
					while (Operators.CompareString(Strings.Mid(str, 1, 2), "FF", false) != 0)
					{
						result = Strings.Mid(str, 11);
						byte[] byte_ = smethod_35(string_3, 16384 + num * 21, 21);
						str = Class13.smethod_5(ref byte_);
						num++;
					}
					if (num == 1)
					{
						string_4 = "SAMSUNG KEY SECTOR FAIL";
						return "";
					}
					long_0 = 16384 + (num - 2) * 21 + 5;
					return result;
				}
				string_4 = "UNKNOWN SAMSUNG TSH943A ROM";
				return "";
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "62430", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "64930", false) == 0))
				{
					byte[] array = smethod_35(string_3, 34462L, 1);
					long num2 = (long)((ulong)array[0] << 8);
					string result = "";
					string str = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
					int num = 0;
					byte[] byte_;
					while ((Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) == 0) | (Operators.CompareString(Strings.Mid(str, 17), "FFFFFFFFFFFFFFFF", false) == 0))
					{
						byte_ = smethod_35(string_3, num2 + num * 16, 16);
						str = Class13.smethod_5(ref byte_);
						num++;
					}
					while (Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) != 0)
					{
						byte_ = smethod_35(string_3, num2 + num * 16, 16);
						str = Class13.smethod_5(ref byte_);
						num++;
					}
					num2 += (num - 2) * 16;
					byte_ = smethod_35(string_3, num2, 16);
					str = Class13.smethod_5(ref byte_);
					if (Operators.CompareString(str, "00112233445566778899AABBCCDDEEFA", false) == 0)
					{
						num2 += 16L;
					}
					long_0 = num2;
					byte_ = smethod_35(string_3, long_0, 16);
					return Class13.smethod_5(ref byte_);
				}
				if (Operators.CompareString(Strings.Trim(string_2), "04421", false) == 0)
				{
					string str = "00112233445566778899AABBCCDDEEFA";
					long num2 = smethod_37(string_3, str, 128);
					string result;
					int num;
					byte[] byte_;
					if (num2 == -1L)
					{
						byte[] array2 = smethod_35(string_3, 27187L, 1);
						num2 = (long)((ulong)array2[0] << 8);
						while (true)
						{
							long num3 = num2;
							result = "";
							str = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
							num = 0;
							while ((Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) == 0) | (Operators.CompareString(Strings.Mid(str, 17), "FFFFFFFFFFFFFFFF", false) == 0))
							{
								byte_ = smethod_35(string_3, num2 + num * 16, 16);
								str = Class13.smethod_5(ref byte_);
								num++;
							}
							while (Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) != 0)
							{
								byte_ = smethod_35(string_3, num2 + num * 16, 16);
								str = Class13.smethod_5(ref byte_);
								num++;
							}
							num2 += (num - 2) * 16;
							byte_ = smethod_35(string_3, num2, 16);
							str = Class13.smethod_5(ref byte_);
							if (Operators.CompareString(str, "00112233445566778899AABBCCDDEEFA", false) == 0)
							{
								num2 += 16L;
							}
							if (num2 - num3 <= 256L)
							{
								break;
							}
							num2 = num3 + 4096L;
						}
						long_0 = num2;
						byte_ = smethod_35(string_3, long_0, 16);
						return Class13.smethod_5(ref byte_);
					}
					result = "";
					str = "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF";
					num = 0;
					while ((Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) == 0) | (Operators.CompareString(Strings.Mid(str, 17), "FFFFFFFFFFFFFFFF", false) == 0))
					{
						byte_ = smethod_35(string_3, num2 + num * 16, 16);
						str = Class13.smethod_5(ref byte_);
						num++;
					}
					while (Operators.CompareString(str, "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", false) != 0)
					{
						byte_ = smethod_35(string_3, num2 + num * 16, 16);
						str = Class13.smethod_5(ref byte_);
						num++;
					}
					num2 += (num - 2) * 16;
					byte_ = smethod_35(string_3, num2, 16);
					str = Class13.smethod_5(ref byte_);
					if (Operators.CompareString(str, "00112233445566778899AABBCCDDEEFA", false) == 0)
					{
						num2 += 16L;
					}
					long_0 = num2;
					byte_ = smethod_35(string_3, long_0, 16);
					return Class13.smethod_5(ref byte_);
				}
				string_4 = "UNKNOWN BENQ VAD6038 ROM";
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long num4 = Class8.smethod_4(string_3, "7C017D387F00", ref string_4, 4096, 65536L);
				if (num4 == -1L)
				{
					string_4 += " - NOT FOUND";
					return "";
				}
				byte[] array3 = Class8.smethod_5(string_3, num4 - 13L + 1L, 8, true, ref string_4);
				long num5 = (long)((ulong)array3[0] << 16);
				num5 += (long)((ulong)array3[2] << 8);
				string text = "";
				string text2 = text;
				byte[] byte_ = smethod_35(string_3, num5 + 312L, 1);
				text = text2 + Class13.smethod_5(ref byte_, 1);
				string text3 = text;
				byte_ = smethod_35(string_3, num5 + 2796L, 1);
				text = text3 + Class13.smethod_5(ref byte_, 1);
				string text4 = text;
				byte_ = smethod_35(string_3, num5 + 1858L, 1);
				text = text4 + Class13.smethod_5(ref byte_, 1);
				string text5 = text;
				byte_ = smethod_35(string_3, num5 + 1664L, 1);
				text = text5 + Class13.smethod_5(ref byte_, 1);
				string text6 = text;
				byte_ = smethod_35(string_3, num5 + 3789L, 1);
				text = text6 + Class13.smethod_5(ref byte_, 1);
				string text7 = text;
				byte_ = smethod_35(string_3, num5 + 2868L, 1);
				text = text7 + Class13.smethod_5(ref byte_, 1);
				string text8 = text;
				byte_ = smethod_35(string_3, num5 + 2111L, 1);
				text = text8 + Class13.smethod_5(ref byte_, 1);
				string text9 = text;
				byte_ = smethod_35(string_3, num5 + 1829L, 1);
				text = text9 + Class13.smethod_5(ref byte_, 1);
				string text10 = text;
				byte_ = smethod_35(string_3, num5 + 1322L, 1);
				text = text10 + Class13.smethod_5(ref byte_, 1);
				string text11 = text;
				byte_ = smethod_35(string_3, num5 + 513L, 1);
				text = text11 + Class13.smethod_5(ref byte_, 1);
				string text12 = text;
				byte_ = smethod_35(string_3, num5 + 2527L, 1);
				text = text12 + Class13.smethod_5(ref byte_, 1);
				string text13 = text;
				byte_ = smethod_35(string_3, num5 + 35L, 1);
				text = text13 + Class13.smethod_5(ref byte_, 1);
				string text14 = text;
				byte_ = smethod_35(string_3, num5 + 1184L, 1);
				text = text14 + Class13.smethod_5(ref byte_, 1);
				string text15 = text;
				byte_ = smethod_35(string_3, num5 + 1434L, 1);
				text = text15 + Class13.smethod_5(ref byte_, 1);
				string text16 = text;
				byte_ = smethod_35(string_3, num5 + 1022L, 1);
				text = text16 + Class13.smethod_5(ref byte_, 1);
				string text17 = text;
				byte_ = smethod_35(string_3, num5 + 3913L, 1);
				text = text17 + Class13.smethod_5(ref byte_, 1);
				long_0 = num5;
				return text;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0))
				{
					byte b = 0;
					long long_1 = 65536L;
					long num6 = default(long);
					while (true)
					{
						byte[] array4;
						if ((byte)(~b) != 0)
						{
							num6 = Class8.smethod_7(string_3, "7D387C01E4FF", ref string_4, 4096, long_1);
							if (num6 == -1L)
							{
								break;
							}
							array4 = Class8.smethod_8(string_3, num6 - 8L, 2, true, ref string_4);
							if ((array4[0] == 84) & (array4[1] == 15))
							{
								b = byte.MaxValue;
							}
							long_1 = num6 + 1L;
							continue;
						}
						array4 = Class8.smethod_8(string_3, num6 - 13L + 3L, 8, true, ref string_4);
						long num7 = (long)((ulong)array4[0] << 8);
						array4[5] = (byte)((uint)array4[5] >> 4);
						num7 += (long)((ulong)array4[5] << 16);
						string text18 = "";
						string text19 = text18;
						byte[] byte_ = smethod_35(string_3, num7 + 312L, 1);
						text18 = text19 + Class13.smethod_5(ref byte_, 1);
						string text20 = text18;
						byte_ = smethod_35(string_3, num7 + 2796L, 1);
						text18 = text20 + Class13.smethod_5(ref byte_, 1);
						string text21 = text18;
						byte_ = smethod_35(string_3, num7 + 1858L, 1);
						text18 = text21 + Class13.smethod_5(ref byte_, 1);
						string text22 = text18;
						byte_ = smethod_35(string_3, num7 + 1664L, 1);
						text18 = text22 + Class13.smethod_5(ref byte_, 1);
						string text23 = text18;
						byte_ = smethod_35(string_3, num7 + 3789L, 1);
						text18 = text23 + Class13.smethod_5(ref byte_, 1);
						string text24 = text18;
						byte_ = smethod_35(string_3, num7 + 2868L, 1);
						text18 = text24 + Class13.smethod_5(ref byte_, 1);
						string text25 = text18;
						byte_ = smethod_35(string_3, num7 + 2111L, 1);
						text18 = text25 + Class13.smethod_5(ref byte_, 1);
						string text26 = text18;
						byte_ = smethod_35(string_3, num7 + 1829L, 1);
						text18 = text26 + Class13.smethod_5(ref byte_, 1);
						string text27 = text18;
						byte_ = smethod_35(string_3, num7 + 1322L, 1);
						text18 = text27 + Class13.smethod_5(ref byte_, 1);
						string text28 = text18;
						byte_ = smethod_35(string_3, num7 + 513L, 1);
						text18 = text28 + Class13.smethod_5(ref byte_, 1);
						string text29 = text18;
						byte_ = smethod_35(string_3, num7 + 2527L, 1);
						text18 = text29 + Class13.smethod_5(ref byte_, 1);
						string text30 = text18;
						byte_ = smethod_35(string_3, num7 + 35L, 1);
						text18 = text30 + Class13.smethod_5(ref byte_, 1);
						string text31 = text18;
						byte_ = smethod_35(string_3, num7 + 1184L, 1);
						text18 = text31 + Class13.smethod_5(ref byte_, 1);
						string text32 = text18;
						byte_ = smethod_35(string_3, num7 + 1434L, 1);
						text18 = text32 + Class13.smethod_5(ref byte_, 1);
						string text33 = text18;
						byte_ = smethod_35(string_3, num7 + 1022L, 1);
						text18 = text33 + Class13.smethod_5(ref byte_, 1);
						string text34 = text18;
						byte_ = smethod_35(string_3, num7 + 3913L, 1);
						text18 = text34 + Class13.smethod_5(ref byte_, 1);
						long_0 = num7;
						return text18;
					}
					string_4 += " - NOT FOUND";
					return "";
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					byte b2 = 0;
					long long_2 = 65536L;
					long num8 = default(long);
					while (true)
					{
						byte[] array5;
						if ((byte)(~b2) != 0)
						{
							num8 = Class8.smethod_7(string_3, "1205EF127CE7", ref string_4, 4096, long_2);
							if (num8 == -1L)
							{
								break;
							}
							array5 = Class8.smethod_8(string_3, num8 - 5L, 2, true, ref string_4);
							if ((array5[0] == 84) & (array5[1] == 15))
							{
								b2 = byte.MaxValue;
							}
							long_2 = num8 + 1L;
							continue;
						}
						array5 = Class8.smethod_8(string_3, num8 - 7L, 8, true, ref string_4);
						long num9 = (long)((ulong)array5[0] << 8);
						array5[5] = (byte)((uint)array5[5] >> 4);
						num9 += (long)((ulong)array5[5] << 16);
						byte[] array6 = new byte[4096];
						byte[] array7 = new byte[97];
						byte[] byte_2 = new byte[16];
						array6 = smethod_35(string_3, num9, 4096);
						array7 = smethod_35(string_3, 130816L, 96);
						string string_5 = "00000000000000000000000000000000";
						if (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0)
						{
							string_5 = "C3DC125B6E55B7382BCEF1BE1336441E";
						}
						if (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0)
						{
							string_5 = "11B16105FC2A4320CA81B84FB55CEA7A";
						}
						if (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0)
						{
							string_5 = "ED5898345105595BB1E3DFE60FE5AC1C";
						}
						if (!smethod_41(array6, Class13.cpoahSiso(string_5), array7, ref byte_2))
						{
							string_4 = "Error retrieving key from " + Strings.Trim(string_2) + " file";
							return "";
						}
						long_0 = num9;
						return Class13.smethod_5(ref byte_2, 16);
					}
					string_4 += " - NOT FOUND";
					return "";
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				long_0 = 126960L;
				byte[] byte_ = Class8.smethod_11(string_3, long_0, 16, true, ref string_4);
				return Class13.smethod_5(ref byte_);
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return "";
		}
		return "";
	}

	public static bool smethod_16(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref long long_0, ref int int_40, ref byte[] byte_0)
	{
		int_40 = 0;
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				int_40 = 80;
				long_0 = 130816L;
				byte_0 = smethod_35(string_3, long_0, int_40);
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				int_40 = 224;
				long_0 = 130816L;
				byte_0 = smethod_35(string_3, long_0, int_40);
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return true;
	}

	public static bool smethod_17(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref long long_0, ref int int_40, ref byte[] byte_0)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				int_40 = 0;
				return true;
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				int_40 = 0;
				return true;
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				int_40 = 0;
				return true;
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				int_40 = 80;
				long_0 = 130816L;
				byte_0 = smethod_35(string_3, long_0, int_40);
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				int_40 = 224;
				long_0 = 130816L;
				byte_0 = smethod_35(string_3, long_0, int_40);
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				int_40 = 112;
				long_0 = 261888L;
				byte_0 = smethod_35(string_3, long_0, int_40);
				return true;
			}
			string_4 = "UNKNOWN LITEON MODEL";
			return false;
		}
		return false;
	}

	public static bool smethod_18(string string_0, string string_1, string string_2, string string_3, ref string string_4, long long_0, string string_5)
	{
		string_4 = "";
		byte[] array = Class13.cpoahSiso(string_5);
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				bool flag = cpoahSiso(string_0, string_1, string_3, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return Class10.smethod_8(string_3, long_0, 16, flag, array);
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				return smethod_36(string_3, long_0, 16, array);
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				return smethod_36(string_3, long_0, 16, array);
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return false;
		}
		if ((Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0) | (Operators.CompareString(Strings.Trim(string_0), "LTUMT1319E", false) == 0))
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				string_4 = "Error while patching Liteon DG16D2S Key";
				if (!smethod_36(string_3, long_0 + 312L, 1, array))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 2796L, 1, array, 1))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1858L, 1, array, 2))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1664L, 1, array, 3))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 3789L, 1, array, 4))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 2868L, 1, array, 5))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 2111L, 1, array, 6))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1829L, 1, array, 7))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1322L, 1, array, 8))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 513L, 1, array, 9))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 2527L, 1, array, 10))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 35L, 1, array, 11))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1184L, 1, array, 12))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1434L, 1, array, 13))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 1022L, 1, array, 14))
				{
					return false;
				}
				if (!smethod_36(string_3, long_0 + 3913L, 1, array, 15))
				{
					return false;
				}
				string_4 = "";
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0))
				{
					string_4 = "Error while patching Liteon DG16D4S Key";
					if (!smethod_36(string_3, long_0 + 312L, 1, array))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 2796L, 1, array, 1))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1858L, 1, array, 2))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1664L, 1, array, 3))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 3789L, 1, array, 4))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 2868L, 1, array, 5))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 2111L, 1, array, 6))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1829L, 1, array, 7))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1322L, 1, array, 8))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 513L, 1, array, 9))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 2527L, 1, array, 10))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 35L, 1, array, 11))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1184L, 1, array, 12))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1434L, 1, array, 13))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 1022L, 1, array, 14))
					{
						return false;
					}
					if (!smethod_36(string_3, long_0 + 3913L, 1, array, 15))
					{
						return false;
					}
					string_4 = "";
					return true;
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0))
				{
					return true;
				}
				string_4 = "UNKNOWN LITEON DG16D4S ROM";
				return false;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static bool smethod_19(string string_0, string string_1, string string_2, string string_3, ref string string_4, long long_0, byte[] byte_0, int int_40, long long_1, byte[] byte_1, string string_5)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				bool flag = cpoahSiso(string_0, string_1, string_3, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				if (!Class10.smethod_8(string_3, long_0, int_40, flag, byte_0))
				{
					string_4 = "Error Patching Inquiry";
					return false;
				}
				if (!Class10.smethod_8(string_3, long_1, Conversions.ToInteger(string_5), flag, byte_1))
				{
					string_4 = "Error Patching Identify";
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				if (!smethod_36(string_3, long_0, int_40, byte_0))
				{
					string_4 = "Error Patching Inquiry";
					return false;
				}
				if (!smethod_36(string_3, long_1, Conversions.ToInteger(string_5), byte_1))
				{
					string_4 = "Error Patching Identify";
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				if (!smethod_36(string_3, long_0, int_40, byte_0))
				{
					string_4 = "Error Patching Inquiry";
					return false;
				}
				if (!smethod_36(string_3, long_1, Conversions.ToInteger(string_5), byte_1))
				{
					string_4 = "Error Patching Identify";
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				if (!Class8.smethod_6(string_3, long_0, Conversions.ToInteger(Interaction.IIf(int_40 > 40, 40, int_40)), true, ref string_4, byte_0))
				{
					string_4 = "Error Patching Inquiry";
					return false;
				}
				if (!Class8.smethod_6(string_3, long_1, Conversions.ToInteger(string_5), true, ref string_4, byte_1))
				{
					string_4 = "Error Patching Identify";
					return false;
				}
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if (!Class8.smethod_9(string_3, long_0, Conversions.ToInteger(Interaction.IIf(int_40 > 52, 52, int_40)), true, ref string_4, byte_0))
				{
					string_4 = "Error Patching Inquiry";
					return false;
				}
				if (!Class8.smethod_9(string_3, long_1, Conversions.ToInteger(string_5), true, ref string_4, byte_1))
				{
					string_4 = "Error Patching Identify";
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static bool smethod_20(string string_0, string string_1, string string_2, string string_3, ref string string_4, long long_0, byte[] byte_0, int int_40)
	{
		string_4 = "";
		if (int_40 == 0)
		{
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				return true;
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				return true;
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				return true;
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				if (!smethod_36(string_3, long_0, int_40, byte_0))
				{
					string_4 = "Error Patching Serial";
					return false;
				}
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if (!smethod_36(string_3, long_0, int_40, byte_0))
				{
					string_4 = "Error Patching Serial";
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static string smethod_21(string string_0, ref string string_1)
	{
		int num = Strings.InStr(string_0, "HL-DT");
		if (num > 0)
		{
			return "HITACHI   ";
		}
		num = Strings.InStr(string_0, "TSST");
		if (num > 0)
		{
			return "SAMSUNG   ";
		}
		num = Strings.InStr(string_0, "PBDS");
		if (num > 0)
		{
			return "BENQ      ";
		}
		num = Strings.InStr(string_0, "SATA    DVD-ROM");
		if (num > 0)
		{
			return "BENQ      ";
		}
		num = Strings.InStr(string_0, "PLDS");
		if (num > 0)
		{
			return "LITEON    ";
		}
		return "";
	}

	public static string smethod_22(string string_0, string string_1, ref string string_2)
	{
		if (Operators.CompareString(Strings.Trim(string_1), "HITACHI", false) == 0)
		{
			int num = Strings.InStr(string_0, "GDR3120L");
			if (num > 0)
			{
				return "GDR3120L  ";
			}
			num = Strings.InStr(string_0, "DL10N");
			if (num > 0)
			{
				return "DL10N     ";
			}
			string_2 = "UNKNOWN LOGICAL HITACHI MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "SAMSUNG", false) == 0)
		{
			int num = Strings.InStr(string_0, "TS-H943A");
			if (num > 0)
			{
				return "TSH943A   ";
			}
			string_2 = "UNKNOWN LOGICAL SAMSUNG MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "BENQ", false) == 0)
		{
			int num = Strings.InStr(string_0, "VAD6038");
			if (num > 0)
			{
				return "VAD6038   ";
			}
			num = Strings.InStr(string_0, "SATA    DVD-ROM");
			if (num > 0)
			{
				return "VAD6038   ";
			}
			string_2 = "UNKNOWN LOGICAL BENQ MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "LITEON", false) == 0)
		{
			int num = Strings.InStr(Strings.Mid(string_0, 1, 25), "DG-16D2S");
			if (num > 0)
			{
				return "DG16D2S   ";
			}
			num = Strings.InStr(Strings.Mid(string_0, 1, 25), "DG-16D4S");
			if (num > 0)
			{
				return "DG16D4S   ";
			}
			num = Strings.InStr(Strings.Mid(string_0, 1, 25), "DG-16D5S");
			if (num > 0)
			{
				return "DG16D5S   ";
			}
			string_2 = "UNKNOWN LOGICAL LITEON MODEL";
			return "";
		}
		return "";
	}

	public static bool smethod_23(string string_0, ref string string_1, ref string string_2, ref string string_3, ref byte[] byte_0, ref int int_40, ref byte[] byte_1, ref int int_41, ref byte[] byte_2, ref int int_42)
	{
		switch (string_0)
		{
		case "HITACHI-GDR3120L-32":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "32        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030333230424D424220202030352F30342F30372020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303233202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-36":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "36        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030333630424D424220202030352F30362F32302020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303633202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-40":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "40        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030343030424D424220202030352F30372F31332020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303034202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-46":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "46        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030343630424D424220202030352F30372F32372020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303634202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-47":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "47        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030343730424D424220202030352F30372F32372020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303734202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-58":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "58        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030353830424D424220202030362F30312F31302020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303835202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		case "HITACHI-GDR3120L-59":
			string_1 = "HITACHI   ";
			string_2 = "GDR3120L  ";
			string_3 = "59        ";
			byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030353930424D424220202030362F30312F32342020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
			int_40 = 96;
			byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303935202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
			int_42 = 180;
			int_41 = 0;
			return true;
		default:
			if (Strings.InStr(string_0, "HITACHI-GDR3120L-78", CompareMethod.Text) > 0)
			{
				string_1 = "HITACHI   ";
				string_2 = "GDR3120L  ";
				string_3 = "78        ";
				byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030373830424D424220202030362F30352F32352020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303837202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
				int_42 = 180;
				int_41 = 0;
				return true;
			}
			if (Strings.InStr(string_0, "HITACHI-GDR3120L-79", CompareMethod.Text) > 0)
			{
				string_1 = "HITACHI   ";
				string_2 = "GDR3120L  ";
				string_3 = "79        ";
				byte_0 = Class13.cpoahSiso("058000325B000000484C2D44542D53544456442D524F4D20474452333132304C3030373930424D424220202030362F30352F32352020200001000000000000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030303937202020204C48442D2D54545356442D444F52204D4447335232314C302020202020202020202020202020202000000000000F0000000200020600000000000000000000000000000000000000070003007800780078007800000000000000000000000000000000000000000000007C0019001842004000401842000000403F000000");
				int_42 = 180;
				int_41 = 0;
				return true;
			}
			switch (string_0)
			{
			case "SAMSUNG-TSH943A-MS25":
				string_1 = "SAMSUNG   ";
				string_2 = "TSH943A   ";
				string_3 = "MS25      ";
				byte_0 = Class13.cpoahSiso("058000325B00000054535354636F72704456442D524F4D2054532D48393433416D73323520202000000000000000000000000000000000000000160003A000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C0850000000000000000000000000000000000002020202020202020202020202020202020202020000000000000736D353220202020535454536F63707256442D444F52204D5354482D343941332020202020202020202020202020202000000000000B00000002000206000000000000000000000000000000000000000700030078007800E300780000000000000000000000000000000200080008000000000000000000000000000000000000003F000000");
				int_42 = 180;
				int_41 = 0;
				return true;
			case "SAMSUNG-TSH943A-MS28":
				string_1 = "SAMSUNG   ";
				string_2 = "TSH943A   ";
				string_3 = "MS28      ";
				byte_0 = Class13.cpoahSiso("058000325B00000054535354636F72704456442D524F4D2054532D48393433416D73323820202000000000000000000000000000000000000000160003A000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C0850000000000000000000000000000000000002020202020202020202020202020202020202020000000000000736D383220202020535454536F63707256442D444F52204D5354482D343941332020202020202020202020202020202000000000000B00000002000206000000000000000000000000000000000000000700030078007800E300780000000000000000000000000000000200080008000000000000000000000000000000000000003F000000");
				int_42 = 180;
				int_41 = 0;
				return true;
			case "BENQ-VAD6038-62430":
				string_1 = "BENQ      ";
				string_2 = "VAD6038   ";
				string_3 = "62430     ";
				byte_0 = Class13.cpoahSiso("058000321F00000053415441202020204456442D524F4D20202020202020202036323433304320200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C0850000000000000000000000000000000000002020202020202020202020202020202020202020000000000000363234333043202053415441202020204456442D524F4D2020202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000700030078007800E300780000000000000000000000000000000200080008000000000000000000000000000000000000003F200000");
				int_42 = 180;
				int_41 = 0;
				return true;
			case "BENQ-VAD6038-64930":
				string_1 = "BENQ      ";
				string_2 = "VAD6038   ";
				string_3 = "64930     ";
				byte_0 = Class13.cpoahSiso("058000321F0000005042445320202020564144363033382D363439333043202020202020202020200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000020202020202020205042445320202020564144363033382D36343933304320202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000700030078007800E300780000000000000000000000000000000200080008000000000000000000000000000000000000003F200000");
				int_42 = 180;
				int_41 = 0;
				return true;
			case "BENQ-VAD6038-04421":
				string_1 = "BENQ      ";
				string_2 = "VAD6038   ";
				string_3 = "04421     ";
				byte_0 = Class13.cpoahSiso("058000321F00000050424453202020205641443630333820202020202020202030343432314320200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
				int_40 = 96;
				byte_2 = Class13.cpoahSiso("C085000000000000000000000000000000000000202020202020202020202020202020202020202000000000000030343432314320205042445320202020564144363033382020202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000700030078007800E300780000000000000000000000000000000200080008000000000000000000000000000000000000003F200000");
				int_42 = 180;
				int_41 = 0;
				return true;
			case "LITEON-DG16D2S-74850":
				string_1 = "LITEON    ";
				string_2 = "DG16D2S   ";
				string_3 = "74850     ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203734383530432020");
				int_40 = 40;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003734383530432020504C44532020202044472D313644325320202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000000030078007800E3007800000000000000000000000000000002020000680000000000000000000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203734393130432020");
				int_41 = 40;
				return true;
			case "LITEON-DG16D2S-83850":
				string_1 = "LITEON    ";
				string_2 = "DG16D2S   ";
				string_3 = "83850     ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203833383530432020");
				int_40 = 40;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003833383530432020504C44532020202044472D313644325320202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000000030078007800E3007800000000000000000000000000000002020000680000000000000000000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203835303530432D32");
				int_41 = 40;
				return true;
			case "LITEON-DG16D2S-83850V2":
				string_1 = "LITEON    ";
				string_2 = "DG16D2S   ";
				string_3 = "83850V2   ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203833383530432020");
				int_40 = 40;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003833383530432020504C44532020202044472D313644325320202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000000030078007800E3007800000000000000000000000000000002020000680000000000000000000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D3136443253202020202020202039333032534C2D32");
				int_41 = 40;
				return true;
			case "LITEON-DG16D2S-93450":
				string_1 = "LITEON    ";
				string_2 = "DG16D2S   ";
				string_3 = "93450     ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203933343530432020");
				int_40 = 40;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003933343530432020504C44532020202044472D313644325320202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000000030078007800E3007800000000000000000000000000000002020000680000000000000000000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203734393130432020");
				int_41 = 40;
				return true;
			case "LITEON-DG16D2S-02510":
				string_1 = "LITEON    ";
				string_2 = "DG16D2S   ";
				string_3 = "02510     ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203032353130432020");
				int_40 = 40;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003032353130432020504C44532020202044472D313644325320202020202020202020202020202020202020202020202000000000000B00000004000206000000000000000000000000000000000000000000030078007800E3007800000000000000000000000000000002020000680000000000000000000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644325320202020202020203032353130432020");
				int_41 = 40;
				return true;
			case "LITEON-DG16D4S-9504":
				string_1 = "LITEON    ";
				string_2 = "DG16D4S   ";
				string_3 = "9504      ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203935303400000000000000000000000000000000FFFFFFFF");
				int_40 = 56;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003935303420202020504C44532020202044472D313644345320202020202020200000000000000000000000000000000000000000000F00400004000206000000000000000000000000000000000000000000030078007800780078000000000000000000F800100200000202000060004000F800100200000000000000000000000020200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203935303454455354");
				int_41 = 40;
				return true;
			case "LITEON-DG16D4S-0272":
				string_1 = "LITEON    ";
				string_2 = "DG16D4S   ";
				string_3 = "0272      ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203032373200000000000000000000000000000000FFFFFFFF");
				int_40 = 56;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003032373220202020504C44532020202044472D313644345320202020202020200000000000000000000000000000000000000000000F00400004000206000000000000000000000000000000000000000000030078007800780078000000000000000000F800100200000202000060004000F80010020000000000000000000000003F200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203032373254455354");
				int_41 = 40;
				return true;
			case "LITEON-DG16D4S-0225":
				string_1 = "LITEON    ";
				string_2 = "DG16D4S   ";
				string_3 = "0225      ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203032323500000000000000000000000000000000FFFFFFFF");
				int_40 = 56;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003032323520202020504C44532020202044472D313644345320202020202020200000000000000000000000000000000000000000000F00400004000206000000000000000000000000000000000000000000030078007800780078000000000000000000F800100200000202000060004000F80010020000000000000000000000003F200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203032323554455354");
				int_41 = 40;
				return true;
			case "LITEON-DG16D4S-0401":
				string_1 = "LITEON    ";
				string_2 = "DG16D4S   ";
				string_3 = "0401      ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203034303100000000000000000000000000000000FFFFFFFF");
				int_40 = 56;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003034303120202020504C44532020202044472D313644345320202020202020200000000000000000000000000000000000000000000F00400004000206000000000000000000000000000000000000000000030078007800780078000000000000000000F800100200000202000060004000F80010020000000000000000000000003F200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203034303154455354");
				int_41 = 40;
				return true;
			case "LITEON-DG16D4S-1071":
				string_1 = "LITEON    ";
				string_2 = "DG16D4S   ";
				string_3 = "0401      ";
				byte_0 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203130373100000000000000000000000000000000FFFFFFFF");
				int_40 = 56;
				byte_2 = Class13.cpoahSiso("C08500000000000000000000000000000000000020202020202020202020202020202020202020200000000000003130373120202020504C44532020202044472D313644345320202020202020200000000000000000000000000000000000000000000F00400004000206000000000000000000000000000000000000000000030078007800780078000000000000000000F800100200000202000060004000F80010020000000000000000000000003F200000");
				int_42 = 180;
				byte_1 = Class13.cpoahSiso("058000325B000000504C44532020202044472D313644345320202020202020203130373154455354");
				int_41 = 40;
				return true;
			default:
				return false;
			}
		}
	}

	public static string smethod_24(string string_0, string string_1, string string_2, ref string string_3)
	{
		if (Operators.CompareString(Strings.Trim(string_1), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_2), "GDR3120L", false) == 0)
			{
				int num = Strings.InStr(string_0, "GDR3120L0032");
				if (num > 0)
				{
					return "32        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0036");
				if (num > 0)
				{
					return "36        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0040");
				if (num > 0)
				{
					return "40        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0046");
				if (num > 0)
				{
					return "46        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0047");
				if (num > 0)
				{
					return "47        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0058");
				if (num > 0)
				{
					return "58        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0059");
				if (num > 0)
				{
					return "59        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0078");
				if (num > 0)
				{
					return "78        ";
				}
				num = Strings.InStr(string_0, "GDR3120L0079");
				if (num > 0)
				{
					return "79        ";
				}
				string_3 = "UNKNOWN LOGICAL HITACHI GDR3120L ROM";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_2), "DL10N", false) == 0)
			{
				int num = Strings.InStr(string_0, "0500");
				if (num > 0)
				{
					return "0500      ";
				}
				num = Strings.InStr(string_0, "0502");
				if (num > 0)
				{
					return "0502      ";
				}
				string_3 = "UNKNOWN LOGICAL HITACHI DL10N ROM";
				return "";
			}
			string_3 = "UNKNOWN LOGICAL HITACHI MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_2), "TSH943A", false) == 0)
			{
				int num = Strings.InStr(string_0, "ms25");
				if (num > 0)
				{
					return "MS25      ";
				}
				num = Strings.InStr(string_0, "ms28");
				if (num > 0)
				{
					return "MS28      ";
				}
				string_3 = "UNKNOWN LOGICAL SAMSUNG TSH943A ROM";
				return "";
			}
			string_3 = "UNKNOWN LOGICAL SAMSUNG MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_2), "VAD6038", false) == 0)
			{
				int num = Strings.InStr(string_0, "64930");
				if (num > 0)
				{
					return "64930     ";
				}
				num = Strings.InStr(string_0, "62430");
				if (num > 0)
				{
					return "62430     ";
				}
				num = Strings.InStr(string_0, "04421");
				if (num > 0)
				{
					return "04421     ";
				}
				string_3 = "UNKNOWN LOGICAL BENQ VAD6038 ROM";
				return "";
			}
			string_3 = "UNKNOWN LOGICAL BENQ MODEL";
			return "";
		}
		if (Operators.CompareString(Strings.Trim(string_1), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_2), "DG16D2S", false) == 0)
			{
				int num = Strings.InStr(Strings.Mid(string_0, 1, 40), "74850");
				if (num > 0)
				{
					return "74850     ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "83850");
				if (num > 0)
				{
					num = Strings.InStr(string_0, "85050");
					if (num > 0)
					{
						return "83850     ";
					}
					num = Strings.InStr(string_0, "9302");
					if (num > 0)
					{
						return "83850V2   ";
					}
					return "83850     ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "93450");
				if (num > 0)
				{
					return "93450     ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "02510");
				if (num > 0)
				{
					return "02510     ";
				}
				string_3 = "UNKNOWN LOGICAL LITEON DG16D2S ROM";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_2), "DG16D4S", false) == 0)
			{
				int num = Strings.InStr(Strings.Mid(string_0, 1, 40), "9504");
				if (num > 0)
				{
					return "9504      ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "0272");
				if (num > 0)
				{
					return "0272      ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "0225");
				if (num > 0)
				{
					return "0225      ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "0401");
				if (num > 0)
				{
					return "0401      ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "1071");
				if (num > 0)
				{
					return "1071      ";
				}
				string_3 = "UNKNOWN LOGICAL LITEON DG16D4S ROM";
				return "";
			}
			if (Operators.CompareString(Strings.Trim(string_2), "DG16D5S", false) == 0)
			{
				int num = Strings.InStr(Strings.Mid(string_0, 1, 40), "1175");
				if (num > 0)
				{
					return "1175      ";
				}
				num = Strings.InStr(Strings.Mid(string_0, 1, 40), "1532");
				if (num > 0)
				{
					return "1532      ";
				}
				string_3 = "UNKNOWN LOGICAL LITEON DG16D5S ROM";
				return "";
			}
			string_3 = "UNKNOWN LOGICAL LITEON MODEL";
			return "";
		}
		return "";
	}

	public static bool smethod_25(string string_0, string string_1, string string_2, string string_3, ref string string_4, ref string string_5, ref string string_6, ref string string_7, ref long long_0, ref long long_1, ref long long_2, ref byte[] byte_0, ref int int_40, ref byte[] byte_1, ref int int_41, ref byte[] byte_2, ref int int_42)
	{
		string_4 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				bool flag = cpoahSiso(string_0, string_1, string_3, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return Conversions.ToBoolean("");
				}
				if (Operators.CompareString(Strings.Trim(string_2), "32", false) == 0)
				{
					long_0 = 250976L;
					long_2 = 251088L;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "36", false) == 0)
				{
					long_0 = 250948L;
					long_2 = 251060L;
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "40", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "46", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "47", false) == 0))
				{
					long_0 = 251004L;
					long_2 = 251116L;
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "58", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "59", false) == 0))
				{
					long_0 = 251032L;
					long_2 = 251144L;
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4B00", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "78-4C30", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "78-4D20", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4B00", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4C30", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4D20", false) == 0))
				{
					long_0 = 248496L;
					long_2 = 248592L;
				}
				if ((Operators.CompareString(Strings.Trim(string_2), "78-4E10", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "79-4E10", false) == 0))
				{
					long_0 = 248636L;
					long_2 = 248732L;
				}
				int_40 = 96;
				int_42 = 180;
				int_41 = 0;
				byte_0 = Class10.smethod_7(string_3, long_0, int_40, flag);
				byte_2 = Class10.smethod_7(string_3, long_2, int_42, flag);
				string string_8 = Class13.smethod_1(ref byte_0);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN HITACHI MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				long_0 = 8372L;
				long_2 = 8192L;
				int_40 = 96;
				int_42 = 180;
				int_41 = 0;
				byte_0 = smethod_35(string_3, long_0, int_40);
				byte_2 = smethod_35(string_3, long_2, int_42);
				string string_8 = Class13.smethod_1(ref byte_0);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN SAMSUNG MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				long_2 = smethod_37(string_3, "C08500000000", 4096);
				if (long_2 == -1L)
				{
					string_4 = "BENQ VAD6038 INQUIRY OFFSET - NOT FOUND";
					return Conversions.ToBoolean("");
				}
				long_0 = long_2 + 180L;
				int_40 = 96;
				int_42 = 180;
				int_41 = 0;
				byte_0 = smethod_35(string_3, long_0, int_40);
				byte_2 = smethod_35(string_3, long_2, int_42);
				string string_8 = Class13.smethod_1(ref byte_0);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN BENQ MODEL";
			return Conversions.ToBoolean("");
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				long num = Class8.smethod_4(string_3, "C08500000000", ref string_4, 4096, 65536L);
				if (num == -1L)
				{
					string_4 += " - NOT FOUND";
					return false;
				}
				long_2 = num;
				long_0 = long_2 + 180L;
				long_1 = long_0 + 40L;
				int_40 = 40;
				int_42 = 180;
				int_41 = 40;
				byte_0 = Class8.smethod_5(string_3, long_0, int_40, true, ref string_4);
				byte_1 = Class8.smethod_5(string_3, long_1, int_41, true, ref string_4);
				byte_2 = Class8.smethod_5(string_3, long_2, int_42, true, ref string_4);
				byte[] byte_3 = Class8.smethod_5(string_3, long_0, 96, true, ref string_4);
				string text = Class13.smethod_1(ref byte_3);
				byte[] byte_4 = Class8.smethod_5(string_3, long_1, 96, true, ref string_4);
				string string_8 = text + Class13.smethod_1(ref byte_4);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				long num2 = Class8.smethod_7(string_3, "C08500000000", ref string_4, 4096, 65536L);
				if (num2 == -1L)
				{
					string_4 += " - NOT FOUND";
					return false;
				}
				long_2 = num2;
				long_0 = long_2 + 180L;
				long_1 = long_0 + 56L;
				int_40 = 52;
				int_42 = 180;
				int_41 = 40;
				byte_0 = Class8.smethod_8(string_3, long_0, int_40, true, ref string_4);
				byte_1 = Class8.smethod_8(string_3, long_1, int_41, true, ref string_4);
				byte_2 = Class8.smethod_8(string_3, long_2, int_42, true, ref string_4);
				byte[] byte_4 = Class8.smethod_8(string_3, long_0, 96, true, ref string_4);
				string text2 = Class13.smethod_1(ref byte_4);
				byte[] byte_3 = Class8.smethod_8(string_3, long_1, 96, true, ref string_4);
				string string_8 = text2 + Class13.smethod_1(ref byte_3);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D5S", false) == 0)
			{
				long num3 = Class8.smethod_10(string_3, "C08500000000", ref string_4, 4096, 65536L);
				if (num3 == -1L)
				{
					string_4 += " - NOT FOUND";
					return false;
				}
				long_2 = num3;
				long_0 = long_2 + 180L;
				long_1 = long_0 + 56L;
				int_40 = 52;
				int_42 = 180;
				int_41 = 40;
				byte_0 = Class8.smethod_11(string_3, long_0, int_40, true, ref string_4);
				byte_1 = Class8.smethod_11(string_3, long_1, int_41, true, ref string_4);
				byte_2 = Class8.smethod_11(string_3, long_2, int_42, true, ref string_4);
				byte[] byte_4 = Class8.smethod_11(string_3, long_0, 96, true, ref string_4);
				string text3 = Class13.smethod_1(ref byte_4);
				byte[] byte_3 = Class8.smethod_11(string_3, long_1, 96, true, ref string_4);
				string string_8 = text3 + Class13.smethod_1(ref byte_3);
				string_5 = smethod_21(string_8, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_6 = smethod_22(string_8, string_5, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				string_7 = smethod_24(string_8, string_5, string_6, ref string_4);
				if (Operators.CompareString(string_4, "", false) != 0)
				{
					return false;
				}
				return true;
			}
			string_4 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		return false;
	}

	public static bool smethod_26(string string_0, ref string string_1)
	{
		if (Strings.Len(string_0) != 32)
		{
			string_1 = "Key must be 32 hexadecimal characters";
			return false;
		}
		if (!Class13.smethod_0(string_0))
		{
			string_1 = "Only hexadecimal characters allowed (0-9 and A-F)";
			return false;
		}
		return true;
	}

	public static bool smethod_27(string string_0, ref string string_1)
	{
		byte[] array = new byte[16];
		array = Class13.cpoahSiso(string_0);
		byte b = array[0];
		int num = 0;
		int num2 = 0;
		do
		{
			if (array[num2] == b)
			{
				num++;
			}
			num2++;
		}
		while (num2 <= 15);
		if (num >= 8)
		{
			string_1 = "The key you are using seems not proper for a retail console";
			return false;
		}
		return true;
	}

	public static bool smethod_28(string string_0, ref string string_1, ref string string_2, ref string string_3, ref string string_4, ref long long_0, ref byte[] byte_0, ref int int_40, ref long long_1, ref byte[] byte_1, ref int int_41, ref long long_2, ref byte[] byte_2, ref int int_42)
	{
		long_2 = 11264L;
		long_0 = 11776L;
		long_1 = 12032L;
		int_40 = 96;
		int_41 = 96;
		int_42 = 180;
		byte_0 = smethod_35(string_0, long_0, int_40);
		byte_1 = smethod_35(string_0, long_1, int_41);
		byte_2 = smethod_35(string_0, long_2, int_42);
		string_1 = "";
		string string_5 = Class13.smethod_1(ref byte_0) + Class13.smethod_1(ref byte_1);
		string_2 = smethod_21(string_5, ref string_1);
		if (Operators.CompareString(string_1, "", false) != 0)
		{
			return false;
		}
		string_3 = smethod_22(string_5, string_2, ref string_1);
		if (Operators.CompareString(string_1, "", false) != 0)
		{
			return false;
		}
		string_4 = smethod_24(string_5, string_2, string_3, ref string_1);
		if (Operators.CompareString(string_1, "", false) != 0)
		{
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_2), "LITEON", false) == 0 && Operators.CompareString(Strings.Trim(string_3), "DG16D2S", false) == 0)
		{
			int_40 = 40;
		}
		return true;
	}

	public static byte[] smethod_29(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, byte[] byte_0, ref string string_6, bool bool_1 = false)
	{
		string_6 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_3), "HITACHI", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "GDR3120L", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "SAMSUNG", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "TSH943A", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "BENQ", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "VAD6038", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "LITEON", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D2S", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D4S", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
				return Class13.smethod_12(byte_0, 46, 48);
			}
			string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " Source Specified on IDENTIFY byte swap rules";
			return Class13.smethod_12(byte_0, 46, 48);
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_3), "HITACHI", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "GDR3120L", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "SAMSUNG", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "TSH943A", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "BENQ", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "VAD6038", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "LITEON", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D2S", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D4S", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
				return Class13.smethod_12(byte_0, 46, 48);
			}
			string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " Source Specified on IDENTIFY byte swap rules";
			return Class13.smethod_12(byte_0, 46, 48);
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_3), "HITACHI", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "GDR3120L", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "SAMSUNG", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "TSH943A", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "BENQ", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "VAD6038", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "LITEON", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D2S", false) == 0)
					{
						return byte_0;
					}
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D4S", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
				return byte_0;
			}
			string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " Source Specified on IDENTIFY byte swap rules";
			return byte_0;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_3), "HITACHI", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "GDR3120L", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "SAMSUNG", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "TSH943A", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "BENQ", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "VAD6038", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "LITEON", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D2S", false) == 0)
					{
						if (bool_1)
						{
							byte[] byte_1 = (byte[])Class13.smethod_7(Strings.Space(20));
							Class13.smethod_13(ref byte_1, 0, 20, ref byte_0, 20);
						}
						return byte_0;
					}
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D4S", false) == 0)
					{
						if (bool_1)
						{
							byte[] byte_1 = (byte[])Class13.smethod_7(Strings.Space(20));
							Class13.smethod_13(ref byte_1, 0, 20, ref byte_0, 20);
						}
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
				return byte_0;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_3), "HITACHI", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "GDR3120L", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "SAMSUNG", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "TSH943A", false) == 0)
					{
						return Class13.smethod_12(byte_0, 46, 48);
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return Class13.smethod_12(byte_0, 46, 48);
				}
				if (Operators.CompareString(Strings.Trim(string_3), "BENQ", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "VAD6038", false) == 0)
					{
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				if (Operators.CompareString(Strings.Trim(string_3), "LITEON", false) == 0)
				{
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D2S", false) == 0)
					{
						if (bool_1)
						{
							byte[] byte_1 = (byte[])Class13.smethod_7(Strings.Space(20));
							Class13.smethod_13(ref byte_1, 0, 20, ref byte_0, 20);
						}
						return byte_0;
					}
					if (Operators.CompareString(Strings.Trim(string_4), "DG16D4S", false) == 0)
					{
						if (bool_1)
						{
							byte[] byte_1 = (byte[])Class13.smethod_7(Strings.Space(20));
							Class13.smethod_13(ref byte_1, 0, 20, ref byte_0, 20);
						}
						return byte_0;
					}
					string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
					return byte_0;
				}
				string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " to " + Strings.Trim(string_3) + "-" + Strings.Trim(string_4) + " Specified on IDENTIFY byte swap rules";
				return byte_0;
			}
			string_6 = "No " + Strings.Trim(string_0) + "-" + Strings.Trim(string_1) + " Source Specified on IDENTIFY byte swap rules";
			return byte_0;
		}
		string_6 = "No " + Strings.Trim(string_0) + " Specified on IDENTIFY byte swap rules";
		return byte_0;
	}

	public static bool smethod_30(string string_0, byte[] byte_0, byte[] byte_1, int int_40, byte[] byte_2, int int_41, byte[] byte_3, byte[] byte_4, byte[] byte_5, byte[] byte_6, byte[] byte_7, byte[] byte_8)
	{
		byte[] byte_9 = new byte[1024];
		try
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Create);
			Class13.smethod_19(ref byte_9, 0, 1024, 0);
			int num = 0;
			do
			{
				fileStream.Write(byte_9, 0, 1024);
				num++;
			}
			while (num <= 255);
			fileStream.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox(ex2.Message, MsgBoxStyle.Exclamation, "Error Generating Dummy:");
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		Class13.smethod_19(ref byte_9, 0, 1024, byte.MaxValue);
		if (!smethod_36(string_0, 40960L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KA000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 41984L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KA400", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 43008L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KA800", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 44032L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KAC00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 258048L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code K3F000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 259072L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code K3F400", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 260096L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code K3F800", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 261120L, 1024, byte_9))
		{
			Interaction.MsgBox("Problem Generating Dummy File code K3FC00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 40960L, 16, Class13.cpoahSiso("7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KD00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 40976L, 16, Class13.cpoahSiso("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF")))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KD10", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 40992L, 16, Class13.cpoahSiso("00112233445566778899AABBCCDDEEFA")))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KD20", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 41008L, 16, byte_3))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KD30", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 11264L, 512, smethod_31(byte_0)))
		{
			Interaction.MsgBox("Problem Generating Dummy File code ID2C00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 11776L, int_40, byte_1))
		{
			Interaction.MsgBox("Problem Generating Dummy File code IQ2E00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 12032L, int_41, byte_2))
		{
			Interaction.MsgBox("Problem Generating Dummy File code IQ2F00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 24320L, 16, (byte[])Class13.smethod_7("LIZARD SNAPSHOT ")))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SI5F00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 130816L, byte_4.Length, byte_4))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SE1FF00", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (byte_5.Length == 4096 && !smethod_36(string_0, 172032L, byte_5.Length, byte_5))
		{
			Interaction.MsgBox("Problem Generating Dummy File code KA2A000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 258048L, byte_6.Length, byte_6))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SE3F000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 61440L, byte_7.Length, byte_7))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SEF000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		if (!smethod_36(string_0, 61456L, byte_8.Length, byte_8))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SEF010", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		byte[] array = new byte[1] { 3 };
		if (!smethod_36(string_0, 0L, array.Length, array))
		{
			Interaction.MsgBox("Problem Generating Dummy File code SE0000", MsgBoxStyle.Exclamation, "Error:");
			return false;
		}
		return true;
	}

	public static byte[] smethod_31(byte[] byte_0)
	{
		string @string = Class13.smethod_1(ref byte_0, 96);
		bool flag = false;
		if (Strings.InStr(1, @string, "LPSD") != 0)
		{
			flag = true;
		}
		if (Strings.InStr(1, @string, "BPSD") != 0)
		{
			flag = true;
		}
		if (Strings.InStr(1, @string, "ASAT") != 0)
		{
			flag = true;
		}
		if (flag)
		{
			return Class13.smethod_12(byte_0, 46, 48);
		}
		return byte_0;
	}

	public static byte[] smethod_32(byte[] byte_0)
	{
		string @string = Class13.smethod_1(ref byte_0, 96);
		bool flag = false;
		if (Strings.InStr(1, @string, "PLDS") != 0)
		{
			flag = true;
		}
		if (Strings.InStr(1, @string, "PBDS") != 0)
		{
			flag = true;
		}
		if (Strings.InStr(1, @string, "SATA") != 0)
		{
			flag = true;
		}
		if (flag)
		{
			return Class13.smethod_12(byte_0, 46, 48);
		}
		return byte_0;
	}

	public static bool smethod_33(byte[] byte_0, ref string string_0)
	{
		string @string = Class13.smethod_1(ref byte_0, 96);
		if (Strings.InStr(1, @string, "GD1-D6S2") != 0)
		{
			string_0 = "DG16D2S";
			return true;
		}
		if (Strings.InStr(1, @string, "GD1-D6S4") != 0)
		{
			string_0 = "DG16D4S";
			return true;
		}
		return false;
	}

	public static string smethod_34(string string_0)
	{
		string expression = Strings.Replace(string_0, "-4B00", "");
		expression = Strings.Replace(expression, "-4C30", "");
		expression = Strings.Replace(expression, "-4D20", "");
		return Strings.Replace(expression, "-4E10", "");
	}

	public static byte[] smethod_35(string string_0, long long_0, int int_40)
	{
		byte[] array = new byte[int_40 - 1 + 1];
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Read(array, 0, int_40);
		fileStream.Close();
		return array;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_36(string string_0, long long_0, int int_40, byte[] byte_0, int int_41 = 0)
	{
		if (Operators.CompareString(FileSystem.Dir(string_0), "", false) == 0)
		{
			return false;
		}
		if (long_0 + int_40 > FileSystem.FileLen(string_0))
		{
			return false;
		}
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(long_0, SeekOrigin.Begin);
		fileStream.Write(byte_0, int_41, int_40);
		fileStream.Close();
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static long smethod_37(string string_0, string string_1, int int_40, long long_0 = 0L)
	{
		if (Operators.CompareString(FileSystem.Dir(string_0), "", false) == 0)
		{
			return -1L;
		}
		long num = FileSystem.FileLen(string_0);
		long num2 = long_0;
		int num3;
		while (true)
		{
			if (num2 < num)
			{
				byte[] byte_ = smethod_35(string_0, num2, int_40);
				string @string = Class13.smethod_5(ref byte_);
				num3 = Strings.InStr(1, @string, string_1, CompareMethod.Text);
				if (num3 != 0)
				{
					break;
				}
				num2 += int_40;
				continue;
			}
			return -1L;
		}
		return (long)Math.Round((double)num2 + (double)(num3 - 1) / 2.0);
	}

	public static void smethod_38(ref byte[] byte_0, ref byte[] byte_1, ref byte[] byte_2, int int_40, string string_0)
	{
		if (int_40 == 0)
		{
			return;
		}
		bool flag = true;
		int num = int_40 - 1;
		for (int i = 0; i <= num; i++)
		{
			if (byte_2[i] != 0)
			{
				flag = false;
			}
		}
		bool flag2 = true;
		int num2 = int_40 - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (byte_2[i] != byte.MaxValue)
			{
				flag2 = false;
			}
		}
		if (!(flag2 || flag))
		{
			return;
		}
		Class13.smethod_19(ref byte_2, 0, int_40, byte.MaxValue);
		if (Operators.CompareString(Strings.Trim(string_0), "DG16D2S", false) == 0)
		{
			Class13.smethod_13(ref byte_1, 20, 20, ref byte_2, 0);
			Class13.smethod_13(ref byte_0, 38, 2, ref byte_2, 40);
			Class13.smethod_13(ref byte_0, 40, 2, ref byte_2, 76);
		}
		if (Operators.CompareString(Strings.Trim(string_0), "DG16D4S", false) == 0)
		{
			byte[] byte_3 = Class13.smethod_12(byte_1, 20, 20);
			Class13.smethod_13(ref byte_3, 20, 20, ref byte_2, 0);
			if (Class13.smethod_17(ref byte_2, 0, 20, 32))
			{
				Class13.smethod_19(ref byte_2, 0, 20, byte.MaxValue);
			}
			Class13.smethod_13(ref byte_0, 52, 2, ref byte_2, 40);
			Class13.smethod_13(ref byte_0, 54, 2, ref byte_2, 76);
		}
	}

	public static void smethod_39(string string_0, string string_1, ref int[] int_40, ref int int_41, bool bool_1 = false)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		FileStream fileStream2 = new FileStream(string_1, FileMode.Open);
		byte[] byte_ = new byte[4096];
		byte[] byte_2 = new byte[4096];
		if (!bool_1)
		{
			int num = 0;
			do
			{
				fileStream.Read(byte_, 0, 4096);
				fileStream2.Read(byte_2, 0, 4096);
				if (!Class13.smethod_16(ref byte_, 0, 4096, ref byte_2, 0))
				{
					int_40 = (int[])Utils.CopyArray(int_40, new int[int_41 + 1]);
					int_40[int_41] = num * 4096;
					int_41++;
				}
				num++;
			}
			while (num <= 63);
		}
		else
		{
			int num = 63;
			do
			{
				fileStream.Seek(num * 4096, SeekOrigin.Begin);
				fileStream.Read(byte_, 0, 4096);
				fileStream2.Seek(num * 4096, SeekOrigin.Begin);
				fileStream2.Read(byte_2, 0, 4096);
				if (!Class13.smethod_16(ref byte_, 0, 4096, ref byte_2, 0))
				{
					int_40 = (int[])Utils.CopyArray(int_40, new int[int_41 + 1]);
					int_40[int_41] = num * 4096;
					int_41++;
				}
				num += -1;
			}
			while (num >= 0);
		}
		fileStream.Close();
		fileStream2.Close();
	}

	public static bool smethod_40(string string_0, string string_1, string string_2, ref string string_3, ref byte[] byte_0, ref byte[] byte_1, ref byte[] byte_2)
	{
		string_3 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0))
				{
					byte_2[0] = byte_0[312];
					byte_2[1] = byte_0[2796];
					byte_2[2] = byte_0[1858];
					byte_2[3] = byte_0[1664];
					byte_2[4] = byte_0[3789];
					byte_2[5] = byte_0[2868];
					byte_2[6] = byte_0[2111];
					byte_2[7] = byte_0[1829];
					byte_2[8] = byte_0[1322];
					byte_2[9] = byte_0[513];
					byte_2[10] = byte_0[2527];
					byte_2[11] = byte_0[35];
					byte_2[12] = byte_0[1184];
					byte_2[13] = byte_0[1434];
					byte_2[14] = byte_0[1022];
					byte_2[15] = byte_0[3913];
					return true;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0)
				{
					if (!smethod_41(byte_0, Class13.cpoahSiso("C3DC125B6E55B7382BCEF1BE1336441E"), byte_1, ref byte_2))
					{
						string_3 = "Error Retrieving Key on 0225 drive";
						return false;
					}
					return true;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0)
				{
					if (!smethod_41(byte_0, Class13.cpoahSiso("11B16105FC2A4320CA81B84FB55CEA7A"), byte_1, ref byte_2))
					{
						string_3 = "Error Retrieving Key on 0401 drive";
						return false;
					}
					return true;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0)
				{
					if (!smethod_41(byte_0, Class13.cpoahSiso("ED5898345105595BB1E3DFE60FE5AC1C"), byte_1, ref byte_2))
					{
						string_3 = "Error Retrieving Key on 1071 drive";
						return false;
					}
					return true;
				}
				string_3 = "NO KEYAREA DEFINITION FOR THIS LITEON-MODEL-ROM";
				return false;
			}
			string_3 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		string_3 = "NO KEYAREA DEFINITION FOR THIS VENDOR-MODEL-ROM";
		return false;
	}

	public static bool smethod_41(byte[] byte_0, byte[] byte_1, byte[] byte_2, ref byte[] byte_3)
	{
		byte[] array = new byte[16];
		byte[] byte_4 = new byte[16];
		byte[] array2 = new byte[16];
		byte[] array3 = new byte[16];
		byte[] array4 = new byte[16];
		ushort[] array5 = new ushort[16];
		array4 = byte_1;
		Class13.smethod_13(ref byte_2, 1, 16, ref byte_4, 0);
		if (Class13.smethod_17(ref byte_4, 0, 16, byte.MaxValue))
		{
			Class13.smethod_19(ref byte_4, 0, 16, 32);
		}
		int num = 0;
		do
		{
			byte_4[num] ^= array4[num];
			num++;
		}
		while (num <= 15);
		array = Class13.cpoahSiso("00000000000000000000000000000000");
		array2 = Class6.smethod_3(array, byte_4, array4);
		array3 = Class6.smethod_3(array, byte_4, array2);
		num = 0;
		do
		{
			byte b = (byte)(array2[num] & 0xF);
			b <<= 4;
			array2[num] = (byte)(b & 0xF0);
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			byte b = (byte)(array3[num] & 0xF0);
			b = (byte)((uint)b >> 4);
			array3[num] = (byte)(b & 0xF);
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			byte b = (byte)(array2[num] | array3[num]);
			if ((b & 0xF) == 15)
			{
				b--;
			}
			array2[num] = b;
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			string text = "Offset for Key[" + num + "]=";
			array5[num] = array2[num];
			array5[num] *= 16;
			array5[num] = (ushort)(array5[num] | num);
			text += Conversion.Hex(array5[num]);
			num++;
		}
		while (num <= 15);
		byte[] array6 = new byte[16];
		num = 0;
		do
		{
			array6[num] = byte_0[array5[num]];
			num++;
		}
		while (num <= 15);
		array = array6;
		byte_3 = Class6.smethod_4(array, byte_4, array4);
		return true;
	}

	public static bool smethod_42(string string_0, string string_1, string string_2, ref byte[] byte_0, ref string string_3, ref byte[] byte_1, ref byte[] byte_2)
	{
		string_3 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				if ((Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0) | (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0))
				{
					byte_1[312] = byte_2[0];
					byte_1[2796] = byte_2[1];
					byte_1[1858] = byte_2[2];
					byte_1[1664] = byte_2[3];
					byte_1[3789] = byte_2[4];
					byte_1[2868] = byte_2[5];
					byte_1[2111] = byte_2[6];
					byte_1[1829] = byte_2[7];
					byte_1[1322] = byte_2[8];
					byte_1[513] = byte_2[9];
					byte_1[2527] = byte_2[10];
					byte_1[35] = byte_2[11];
					byte_1[1184] = byte_2[12];
					byte_1[1434] = byte_2[13];
					byte_1[1022] = byte_2[14];
					byte_1[3913] = byte_2[15];
					return true;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0 && !smethod_43(ref byte_1, Class13.cpoahSiso("C3DC125B6E55B7382BCEF1BE1336441E"), byte_0, ref byte_2))
				{
					string_3 = "Error Setting Keyarea on 0225 drive";
					return false;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0 && !smethod_43(ref byte_1, Class13.cpoahSiso("11B16105FC2A4320CA81B84FB55CEA7A"), byte_0, ref byte_2))
				{
					string_3 = "Error Setting Keyarea on 0401 drive";
					return false;
				}
				if (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0 && !smethod_43(ref byte_1, Class13.cpoahSiso("ED5898345105595BB1E3DFE60FE5AC1C"), byte_0, ref byte_2))
				{
					string_3 = "Error Setting Keyarea on 0401 drive";
					return false;
				}
				string_3 = "NO KEYAREA DEFINITION FOR THIS LITEON-MODEL-ROM";
				return false;
			}
			string_3 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		string_3 = "NO KEYAREA DEFINITION FOR THIS VENDOR-MODEL-ROM";
		return false;
	}

	public static bool smethod_43(ref byte[] byte_0, byte[] byte_1, byte[] byte_2, ref byte[] byte_3)
	{
		byte[] array = new byte[16];
		byte[] array2 = new byte[16];
		byte[] byte_4 = new byte[16];
		byte[] array3 = new byte[16];
		byte[] array4 = new byte[16];
		byte[] array5 = new byte[16];
		ushort[] array6 = new ushort[16];
		array5 = byte_1;
		Class13.smethod_13(ref byte_2, 1, 16, ref byte_4, 0);
		int num = 0;
		do
		{
			byte_4[num] ^= array5[num];
			num++;
		}
		while (num <= 15);
		array = Class13.cpoahSiso("00000000000000000000000000000000");
		array2 = Class6.smethod_3(byte_3, byte_4, array5);
		array3 = Class6.smethod_3(array, byte_4, array5);
		array4 = Class6.smethod_3(array, byte_4, array3);
		num = 0;
		do
		{
			byte b = (byte)(array3[num] & 0xF);
			b <<= 4;
			array3[num] = (byte)(b & 0xF0);
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			byte b = (byte)(array4[num] & 0xF0);
			b = (byte)((uint)b >> 4);
			array4[num] = (byte)(b & 0xF);
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			byte b = (byte)(array3[num] | array4[num]);
			if ((b & 0xF) == 15)
			{
				b--;
			}
			array3[num] = b;
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			string text = "Offset for Key[" + num + "]=";
			array6[num] = array3[num];
			array6[num] *= 16;
			array6[num] = (ushort)(array6[num] | num);
			text += Conversion.Hex(array6[num]);
			num++;
		}
		while (num <= 15);
		num = 0;
		do
		{
			byte_0[num] = (byte)Math.Round(VBMath.Rnd());
			num++;
		}
		while (num <= 3839);
		num = 0;
		do
		{
			byte_0[array6[num]] = array2[num];
			num++;
		}
		while (num <= 15);
		return true;
	}

	public static bool smethod_44(string string_0, string string_1, string string_2, ref string string_3)
	{
		string_3 = "";
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "GDR3120L", false) == 0)
			{
				return true;
			}
			string_3 = "UNKNOWN HITACHI IDENTIFIER";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "TSH943A", false) == 0)
			{
				return true;
			}
			string_3 = "UNKNOWN SAMSUNG IDENTIFIER";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "VAD6038", false) == 0)
			{
				return true;
			}
			string_3 = "UNKNOWN BENQ IDENTIFIER";
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				if (Operators.CompareString(Strings.Trim(string_2), "02510", false) == 0)
				{
					return false;
				}
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				return false;
			}
			string_3 = "UNKNOWN LITEON IDENTIFIER";
			return false;
		}
		string_3 = "NO IS-SPOOFEABLE DEFINITION FOR THIS VENDOR-MODEL-ROM";
		return false;
	}

	public static bool smethod_45(string string_0, string string_1, string string_2, string string_3, ref byte[] byte_0, ref byte[] byte_1, ref byte[] byte_2)
	{
		byte_1 = Class13.cpoahSiso("00202020");
		byte_2 = Class13.cpoahSiso(Strings.StrDup(32, "00"));
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) != 0)
		{
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) != 0)
		{
			return true;
		}
		string expression = Class13.smethod_5(ref byte_0);
		expression = Strings.Replace(expression, "FF", "", 1, -1, CompareMethod.Text);
		if (Operators.CompareString(Strings.Trim(string_2), "9504", false) == 0)
		{
			byte_1[0] = 1;
			byte_1[1] = 0;
			byte_1[2] = 0;
			byte_1[3] = 0;
			byte_2 = Class13.cpoahSiso("4E182B5F4CE255923579BD95DF9013DD" + Strings.StrDup(16, "00"));
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_2), "0272", false) == 0)
		{
			byte_1[0] = 4;
			byte_2 = Class13.cpoahSiso("519C87822F1024603DF1779998B45A73" + Strings.StrDup(16, "00"));
			return true;
		}
		if (Operators.CompareString(Strings.Trim(string_2), "0225", false) == 0)
		{
			switch (expression)
			{
			case "BB01":
				byte_1[0] = 3;
				byte_2 = Class13.cpoahSiso("210A7B18BE991825666A5BE7C633DB58" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB":
				byte_1[0] = 6;
				byte_2 = Class13.cpoahSiso("19AC2FD7E20EE60FA4B0CFF63BC025DA" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB7F":
				byte_1[0] = 7;
				byte_2 = Class13.cpoahSiso("93D17FC07E57EEAC820FB82293BFE7A0" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB":
				byte_1[0] = 8;
				byte_2 = Class13.cpoahSiso("3A47C41E087F7C34C0E4EEC50F8D2949" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB3F":
				byte_1[0] = 12;
				byte_2 = Class13.cpoahSiso("F28436F07CA4EA55D62F6732CBFF76B2" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB1F":
				byte_1[0] = 13;
				byte_2 = Class13.cpoahSiso("CAB8E2A8A3C05BC06C8BADDCDD608EE6" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB0F":
				byte_1[0] = 16;
				byte_2 = Class13.cpoahSiso("83CE61F1DF5CDCAE3D7F93FB000CAA47" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB0F":
				byte_1[0] = 18;
				byte_2 = Class13.cpoahSiso("9C3902A194ABC5BAB35A717D2C47C784" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB01BB01BB3F":
				byte_1[0] = 20;
				byte_2 = Class13.cpoahSiso("27574D6D0FEFA35FC7B6A5A7C7D8D049" + Strings.StrDup(16, "00"));
				return true;
			default:
			{
				byte[] byte_3 = smethod_35(string_3, 126976L, 16);
				string left = Class13.smethod_5(ref byte_3);
				if (Operators.CompareString(left, "60792A1CF5D5AF185A20BDC6CD48D262", false) == 0)
				{
					byte_1[0] = 2;
					byte_1[1] = 0;
					byte_1[2] = 0;
					byte_1[3] = 0;
					byte_2 = Class13.cpoahSiso("83444B9F3C3DD9F1DE859DE71CDA6B09" + Strings.StrDup(16, "00"));
					return true;
				}
				byte_1[0] = 3;
				byte_2 = Class13.cpoahSiso("210A7B18BE991825666A5BE7C633DB58" + Strings.StrDup(16, "00"));
				return true;
			}
			}
		}
		if (Operators.CompareString(Strings.Trim(string_2), "0401", false) == 0)
		{
			switch (expression)
			{
			case "BB01":
				byte_1[0] = 5;
				byte_2 = Class13.cpoahSiso("ABA2B3920389092665D791DF4F5923A6" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB":
				byte_1[0] = 9;
				byte_2 = Class13.cpoahSiso("838C9A42726467EB442DF16D39C55AB7" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB7F":
				byte_1[0] = 10;
				byte_2 = Class13.cpoahSiso("67BF0134E00577C958A6BA9353ECCDEB" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB":
				byte_1[0] = 11;
				byte_2 = Class13.cpoahSiso("93BA96F4D4005B6026DD38F2C3C4E1D8" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB3F":
				byte_1[0] = 14;
				byte_2 = Class13.cpoahSiso("6A17CB550D61489B37B20A93296A258B" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB1F":
				byte_1[0] = 15;
				byte_2 = Class13.cpoahSiso("849FEFCA4E1C3F0A0583501704F6EBAA" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB0F":
				byte_1[0] = 17;
				byte_2 = Class13.cpoahSiso("8E023CBB516B49E33058C49F9189E217" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB0F":
				byte_1[0] = 19;
				byte_2 = Class13.cpoahSiso("11BD065B041C2796A43313B3844A39AD" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB01BB01BB3F":
				byte_1[0] = 21;
				byte_2 = Class13.cpoahSiso("145EA63D8558C289A470613C047B0CEE" + Strings.StrDup(16, "00"));
				return true;
			}
		}
		if (Operators.CompareString(Strings.Trim(string_2), "1071", false) == 0)
		{
			switch (expression)
			{
			case "BB01":
				byte_1[0] = 32;
				byte_2 = Class13.cpoahSiso("8C2EF3714737A4C8D5E3EE5FC23723E2" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB":
				byte_1[0] = 33;
				byte_2 = Class13.cpoahSiso("838C9A42726467EB442DF16D39C55AB7" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB7F":
				byte_1[0] = 34;
				byte_2 = Class13.cpoahSiso("3FFFABB09931313968C1C9DDCB1D8D1C" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB":
				byte_1[0] = 35;
				byte_2 = Class13.cpoahSiso("BFDB9ED823E4F51198726B91D2FA709E" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB3F":
				byte_1[0] = 36;
				byte_2 = Class13.cpoahSiso("ED3B1ED2C80428E4768E31319F74952B" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB1F":
				byte_1[0] = 37;
				byte_2 = Class13.cpoahSiso("B152C2E6EBE9FF6226086F2015773622" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB0F":
				byte_1[0] = 38;
				byte_2 = Class13.cpoahSiso("17CE77A842E6D5325E8228E880318C28" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB0F":
				byte_1[0] = 39;
				byte_2 = Class13.cpoahSiso("0965B229370A02225D314C8807D5BB93" + Strings.StrDup(16, "00"));
				return true;
			case "BB01BB01BB01BB01BB3F":
				byte_1[0] = 40;
				byte_2 = Class13.cpoahSiso("457F67A2265AC477F62649EEFCE899E6" + Strings.StrDup(16, "00"));
				return true;
			}
		}
		Interaction.MsgBox("Unable to identify the hash bytes for this file\r\nPlease send your source file to: carranzafp@hotmail.com\r\nto add support for your file", MsgBoxStyle.Exclamation, "Error at calculate hash bytes");
		return false;
	}

	public static bool smethod_46(string string_0, string string_1)
	{
		if (Operators.CompareString(Strings.Trim(string_0), "SAMSUNG", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "HITACHI", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "BENQ", false) == 0)
		{
			return false;
		}
		if (Operators.CompareString(Strings.Trim(string_0), "LITEON", false) == 0)
		{
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D2S", false) == 0)
			{
				return true;
			}
			if (Operators.CompareString(Strings.Trim(string_1), "DG16D4S", false) == 0)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static int smethod_47(string string_0, string string_1)
	{
		switch (Strings.Trim(string_0) + "-" + Strings.Trim(string_1))
		{
		case "TSH943-MS25":
			return 1;
		case "TSH943-MS28":
			return 2;
		case "VAD6038-62430":
			return 17;
		case "VAD6038-64930":
			return 18;
		case "VAD6038-04421":
			return 20;
		case "GDR3120-32":
			return 33;
		case "GDR3120-36":
			return 34;
		case "GDR3120-40":
			return 35;
		case "GDR3120-46":
			return 36;
		case "GDR3120-47":
			return 37;
		case "GDR3120-58":
			return 38;
		case "GDR3120-59":
			return 39;
		case "GDR3120-78":
			return 40;
		case "GDR3120-79":
			return 41;
		case "DG16D2S-74850":
			return 49;
		case "DG16D2S-83850":
			return 50;
		case "DG16D2S-83850V2":
			return 51;
		case "DG16D2S-93450":
			return 52;
		case "DG16D2S-02510":
			return 53;
		case "DG16D4S-9504":
			return 65;
		case "DG16D4S-0225":
			return 66;
		case "DG16D4S-0272":
			return 67;
		case "DG16D4S-0401":
			return 68;
		case "DG16D4S-1071":
			return 69;
		default:
			return 255;
		}
	}
}
