using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class AesCrypto
{
	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int length = byte_0.GetLength(0);
		byte[] byte_3 = new byte[length - 1 + 1];
		ToolboxUtilities.smethod_19(ref byte_3, 0, length, 0);
		if (length % 16 != 0)
		{
			Interaction.MsgBox("Only buffers multiple of 16 byte can be processed", MsgBoxStyle.Critical, "Error AES_EBC_ENC");
			return byte_3;
		}
		Aes aes = null;
		try
		{
			aes = Aes.Create();
			aes.Key = byte_1;
			aes.Mode = CipherMode.CBC;
			aes.IV = byte_2;
			aes.Padding = PaddingMode.None;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			cryptoTransform.TransformBlock(byte_0, 0, byte_0.GetLength(0), byte_3, 0);
			return byte_3;
		}
		finally
		{
			if (aes != null)
			{
				aes.Clear();
			}
		}
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		int length = byte_0.GetLength(0);
		byte[] byte_3 = new byte[length - 1 + 1];
		ToolboxUtilities.smethod_19(ref byte_3, 0, length, 0);
		if (length % 16 != 0)
		{
			Interaction.MsgBox("Only buffers multiple of 16 byte can be processed", MsgBoxStyle.Critical, "Error AES_EBC_DEC");
			return byte_3;
		}
		Aes aes = null;
		try
		{
			aes = Aes.Create();
			aes.Key = byte_1;
			aes.Mode = CipherMode.CBC;
			aes.IV = byte_2;
			aes.Padding = PaddingMode.None;
			ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
			cryptoTransform.TransformBlock(byte_0, 0, byte_0.GetLength(0), byte_3, 0);
			return byte_3;
		}
		finally
		{
			if (aes != null)
			{
				aes.Clear();
			}
		}
	}

	public static byte[] smethod_2(byte[] byte_0, byte[] byte_1)
	{
		int length = byte_0.GetLength(0);
		byte[] byte_2 = new byte[length - 1 + 1];
		ToolboxUtilities.smethod_19(ref byte_2, 0, length, 0);
		if (length % 16 != 0)
		{
			Interaction.MsgBox("Only buffers multiple of 16 byte can be processed", MsgBoxStyle.Critical, "Error AES_EBC_ENC");
			return byte_2;
		}
		Aes aes = null;
		try
		{
			aes = Aes.Create();
			aes.Key = byte_1;
			aes.Mode = CipherMode.ECB;
			aes.Padding = PaddingMode.None;
			ICryptoTransform cryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV);
			cryptoTransform.TransformBlock(byte_0, 0, byte_0.GetLength(0), byte_2, 0);
			return byte_2;
		}
		finally
		{
			if (aes != null)
			{
				aes.Clear();
			}
		}
	}

	public static byte[] utmuBufTB(byte[] byte_0, byte[] byte_1)
	{
		int length = byte_0.GetLength(0);
		byte[] byte_2 = new byte[length - 1 + 1];
		ToolboxUtilities.smethod_19(ref byte_2, 0, length, 0);
		if (length % 16 != 0)
		{
			Interaction.MsgBox("Only buffers multiple of 16 byte can be processed", MsgBoxStyle.Critical, "Error AES_EBC_DEC");
			return byte_2;
		}
		Aes aes = null;
		try
		{
			aes = Aes.Create();
			aes.Key = byte_1;
			aes.Mode = CipherMode.ECB;
			aes.Padding = PaddingMode.None;
			ICryptoTransform cryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV);
			cryptoTransform.TransformBlock(byte_0, 0, byte_0.GetLength(0), byte_2, 0);
			return byte_2;
		}
		finally
		{
			if (aes != null)
			{
				aes.Clear();
			}
		}
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_1 != null && byte_1.Length > 0)
		{
			if (byte_2 != null && byte_2.Length > 0)
			{
				MemoryStream memoryStream = null;
				CryptoStream cryptoStream = null;
				StreamWriter streamWriter = null;
				Aes aes = null;
				try
				{
					aes = Aes.Create();
					aes.Key = byte_1;
					aes.Mode = CipherMode.CBC;
					aes.IV = byte_2;
					aes.Padding = PaddingMode.None;
					ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
					memoryStream = new MemoryStream();
					cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					streamWriter = new StreamWriter(cryptoStream);
					streamWriter.Write(ToolboxUtilities.smethod_1(ref byte_0));
				}
				finally
				{
					if (streamWriter != null)
					{
						streamWriter.Close();
					}
					if (cryptoStream != null)
					{
						cryptoStream.Close();
					}
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (aes != null)
					{
						aes.Clear();
					}
				}
				return memoryStream.ToArray();
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("Key");
	}

	public static byte[] smethod_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		if (byte_0 != null && byte_0.Length > 0)
		{
			if (byte_1 != null && byte_1.Length > 0)
			{
				if (byte_2 != null && byte_2.Length > 0)
				{
					MemoryStream memoryStream = null;
					CryptoStream cryptoStream = null;
					StreamReader streamReader = null;
					Aes aes = null;
					byte[] array = new byte[byte_0.Length - 1 + 1];
					try
					{
						aes = Aes.Create();
						aes.Key = byte_1;
						aes.Mode = CipherMode.CBC;
						aes.IV = byte_2;
						aes.Padding = PaddingMode.None;
						ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
						memoryStream = new MemoryStream(byte_0);
						cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
						streamReader = new StreamReader(cryptoStream);
						cryptoStream.Read(array, 0, array.Length);
						return array;
					}
					finally
					{
						if (streamReader != null)
						{
							streamReader.Close();
						}
						if (cryptoStream != null)
						{
							cryptoStream.Close();
						}
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (aes != null)
						{
							aes.Clear();
						}
					}
				}
				throw new ArgumentNullException("Key");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("cipherText");
	}
}
