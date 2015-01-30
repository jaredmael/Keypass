using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using KeyPassBusiness;
using System.IO;


namespace KeyPassBusiness
{
    public static class CryptoHelper
    {
		static byte[] code = ASCIIEncoding.ASCII.GetBytes("FooBar11");
       
        public static byte[] Encrypt(byte[] b, string PasswordSet)
        {
			byte[] userPassword =ASCIIEncoding.ASCII.GetBytes(PasswordSet);
            if (b==null)
            {
                throw new ArgumentNullException
                       ("The byte which needs to be encrypted can not be null.");
            }
			byte[] encrypted;
            DESCryptoServiceProvider crypto = new DESCryptoServiceProvider();
			crypto.Key = userPassword;
			crypto.Mode = CipherMode.ECB;
			ICryptoTransform transformer = crypto.CreateEncryptor();
			encrypted = transformer.TransformFinalBlock(b, 0, b.Length);
			return encrypted;
        }


		public static byte[] Decrypt(byte[] b, string passwordpass)
		{
			 byte[]enteredpassword = ASCIIEncoding.ASCII.GetBytes(passwordpass); 
			if (b==null)
			{
				throw new ArgumentNullException
				   ("The array which needs to be decrypted can not be null.");
			}
			byte[] decrypted;
			DESCryptoServiceProvider decrypto = new DESCryptoServiceProvider();
			decrypto.Key = enteredpassword;
			decrypto.Mode = CipherMode.ECB;
			try
        {
			ICryptoTransform transformer = decrypto.CreateDecryptor();
			decrypted = transformer.TransformFinalBlock(b, 0, b.Length);
        
        }
        catch (Exception)
			{
				decrypted = null;
				
			}
			
			return decrypted;
		}
    }



}
