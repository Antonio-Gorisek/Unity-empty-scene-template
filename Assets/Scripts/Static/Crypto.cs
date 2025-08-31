using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;

/// <summary>
/// Utility class for cryptographic operations.
/// </summary>
public static class Crypto
{
	/// <summary>
	/// Generates a random key for cryptographic operations, in this situation is vector part of 16 symbols.
	/// </summary>
	/// <returns>The generated random key.</returns>
	public static string GenerateRandomVectorKey()
	{
		const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		StringBuilder key = new StringBuilder();

		Random random = new Random();

		for (int i = 0; i < 16; i++)
		{
			int index = random.Next(validChars.Length);
			key.Append(validChars[index]);
		}

		return key.ToString();
	}

	/// <summary>
	/// Generates a random key for cryptographic operations, in this situation is key part of 32 symbols.
	/// </summary>
	/// <returns>The generated random key.</returns>
	public static string GenerateRandomKey()
	{
		const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		StringBuilder key = new StringBuilder();

		Random random = new Random();

		for (int i = 0; i < 32; i++)
		{
			int index = random.Next(validChars.Length);
			key.Append(validChars[index]);
		}

		return key.ToString();
	}

	/// <summary>
	/// Encrypts the provided plain text using AES encryption.
	/// </summary>
	/// <param name="plainText">The plain text to encrypt.</param>
	/// <param name="key">The encryption key.</param>
	/// <param name="iv">The initialization vector.</param>
	/// <returns>The encrypted text.</returns>
	public static string Encrypt(string plainText, string key, string iv)
	{
		using (Aes aesAlg = Aes.Create())
		{
			aesAlg.Key = Encoding.UTF8.GetBytes(key);
			aesAlg.IV = Encoding.UTF8.GetBytes(iv);

			ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

			byte[] encryptedBytes;

			using (MemoryStream msEncrypt = new MemoryStream())
			{
				using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
				{
					byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
					csEncrypt.Write(plainBytes, 0, plainBytes.Length);
				}

				encryptedBytes = msEncrypt.ToArray();
			}

			return Convert.ToBase64String(encryptedBytes);
		}
	}

	/// <summary>
	/// Decrypts the provided cipher text using AES decryption.
	/// </summary>
	/// <param name="cipherText">The cipher text to decrypt.</param>
	/// <param name="key">The decryption key.</param>
	/// <param name="iv">The initialization vector.</param>
	/// <returns>The decrypted plain text.</returns>
	public static string Decrypt(string cipherText, string key, string iv)
	{
		using (Aes aesAlg = Aes.Create())
		{
			aesAlg.Key = Encoding.UTF8.GetBytes(key);
			aesAlg.IV = Encoding.UTF8.GetBytes(iv);

			ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            byte[] cipherBytes = Convert.FromBase64String(cipherText);

			using (MemoryStream msDecrypt = new MemoryStream(cipherBytes))
			{
				using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
				{
					using (StreamReader srDecrypt = new StreamReader(csDecrypt))
					{
						return srDecrypt.ReadToEnd();
					}
				}
			}
		}
	}
}
