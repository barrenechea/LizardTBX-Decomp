using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class CfwTemplateParser
{
	public struct Struct3
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;
	}

	public struct Struct4
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;

		public string string_5;

		public string cpoahSiso;

		public long long_0;

		public long long_1;

		public string string_6;
	}

	public const int int_0 = 1024;

	public const int int_1 = 128;

	public const int int_2 = 32768;

	public static bool smethod_0(string string_0, ref Struct3 struct3_0)
	{
		byte[] byte_ = new byte[61];
		if (FileSystem.FileLen(string_0) < 256L)
		{
			return false;
		}
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Read(byte_, 0, 5);
		string left = ToolboxUtilities.smethod_1(ref byte_, 5);
		fileStream.Seek(20L, SeekOrigin.Begin);
		fileStream.Read(byte_, 0, 60);
		string string_1 = Strings.Trim(ToolboxUtilities.smethod_1(ref byte_, 60));
		fileStream.Seek(80L, SeekOrigin.Begin);
		fileStream.Read(byte_, 0, 4);
		string string_2 = ToolboxUtilities.smethod_1(ref byte_, 4);
		fileStream.Seek(84L, SeekOrigin.Begin);
		fileStream.Read(byte_, 0, 8);
		string string_3 = ToolboxUtilities.smethod_1(ref byte_, 8);
		fileStream.Close();
		if (Operators.CompareString(left, "CFWFS", false) == 0)
		{
			struct3_0.string_0 = string_1;
			struct3_0.string_1 = string_3;
			struct3_0.string_2 = string_2;
			struct3_0.string_3 = string_0;
			return true;
		}
		return false;
	}

	public static bool smethod_1(string string_0, ref Struct4[] struct4_0, ref int int_3)
	{
		byte[] byte_ = new byte[128];
		if (FileSystem.FileLen(string_0) < 33792L)
		{
			return false;
		}
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Seek(1024L, SeekOrigin.Begin);
		int_3 = 0;
		int num = 0;
		Struct4 @struct = default(Struct4);
		do
		{
			fileStream.Read(byte_, 0, 128);
			if (byte_[0] == 0)
			{
				break;
			}
			string str = ToolboxUtilities.smethod_1(ref byte_);
			@struct.string_0 = Strings.Mid(str, 1, 10);
			@struct.string_1 = Strings.Mid(str, 11, 10);
			@struct.string_2 = Strings.Mid(str, 21, 10);
			@struct.string_3 = Strings.Mid(str, 31, 10);
			@struct.string_4 = Strings.Mid(str, 41, 10);
			@struct.string_5 = Strings.Mid(str, 51, 10);
			@struct.cpoahSiso = Strings.Mid(str, 61, 1);
			long num2 = (long)((ulong)byte_[64] << 24);
			num2 += (long)((ulong)byte_[63] << 16);
			num2 += (long)((ulong)byte_[62] << 8);
			num2 += byte_[61];
			@struct.long_0 = num2;
			num2 = (long)((ulong)byte_[68] << 24);
			num2 += (long)((ulong)byte_[67] << 16);
			num2 += (long)((ulong)byte_[66] << 8);
			num2 += byte_[65];
			@struct.long_1 = num2;
			@struct.string_6 = Strings.Trim(Strings.Mid(str, 71, 30));
			struct4_0 = (Struct4[])Utils.CopyArray(struct4_0, new Struct4[int_3 + 1]);
			struct4_0[int_3] = @struct;
			int_3++;
			num++;
		}
		while (num <= 255);
		fileStream.Close();
		return false;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_2(string string_0, string string_1)
	{
		if (Operators.CompareString(FileSystem.Dir(string_0), "", false) == 0)
		{
			Interaction.MsgBox("Template file does not exists", MsgBoxStyle.Exclamation, "Error:");
			return;
		}
		Struct4[] struct4_ = default(Struct4[]);
		int int_ = default(int);
		smethod_1(string_0, ref struct4_, ref int_);
		if (int_ == 0)
		{
			Interaction.MsgBox("No TOC Entries found on the Fileset " + string_0, MsgBoxStyle.Exclamation, "Error:");
			return;
		}
		int num = int_ - 1;
		int num2 = 0;
		while (true)
		{
			if (num2 <= num)
			{
				string string_2 = string_1 + struct4_[num2].string_6;
				if (!ToolboxUtilities.smethod_8(string_0, string_2, 33792L + struct4_[num2].long_1, struct4_[num2].long_0))
				{
					break;
				}
				num2++;
				continue;
			}
			Interaction.MsgBox("File extraction completed on path: " + string_1, MsgBoxStyle.Information, "Error:");
			return;
		}
		Interaction.MsgBox("The temporary file cannot be created, check the application is on folder with write privileges", MsgBoxStyle.Exclamation, "Error:");
	}
}
