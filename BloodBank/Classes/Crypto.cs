using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

// Encrypt and decrypt string data

public class Crypto
{
    public static string Encrypt(string plainInput)
    {
        string key = AppData.GetEncryptionKey();
        byte[] iv = new byte[16];
        byte[] array;
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                    {
                        streamWriter.Write(plainInput);
                    }

                    array = memoryStream.ToArray();
                }
            }
        }

        return Convert.ToBase64String(array);
    }

    public static string Decrypt(string cipherText)
    {
        string key = AppData.GetEncryptionKey();
        byte[] iv = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = iv;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }

    public static string GeneratePassword(string email)
    {
        var now = DateTime.UtcNow;
        var autoId = Guid.NewGuid().ToString().Substring(0, 8);
        var autoSymbol = GenerateRandomString(4);

        var password = $"{email}{now:yyyy-MM-dd-HH-mm-ss}{autoId}{autoSymbol}";

        // You can use any encryption method you like here to encrypt the password
        // I'm using a simple SHA256 hash as an example
        using (var sha256 = SHA256.Create())
        {
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            password = Convert.ToBase64String(hashBytes);
        }

        return password;
    }

    public static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();

        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

   

}