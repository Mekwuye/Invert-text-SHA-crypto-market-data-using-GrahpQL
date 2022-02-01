using System.Security.Cryptography;
using System.IO;
using System.Text;

//ShaHex class implements SHA to HEX

namespace cSharpYoloLibrary
{
    public static class ShaHex
    {
        //calculate SHA hash using  filestream without loading into memory
        public async static Task<byte[]> calculateSHaAsync(string filename)
        {
            await Task.Delay(1000);

            if (filename == null) { throw new ArgumentNullException("filename is required"); }

            using (FileStream stream = File.OpenRead(filename))
            {
                SHA256 sha256Hash = SHA256.Create();

                return sha256Hash.ComputeHash(stream);
            }
        }
        public static byte[] calculateSHA(string filename)
        {
            if (filename == null) { throw new ArgumentNullException("filename is required"); }

            using (FileStream stream = File.OpenRead(filename))
            {
                SHA256 sha256Hash = SHA256.Create();

                return sha256Hash.ComputeHash(stream);
            }
        }
        // convert byte array to hex.
        public async static Task<string> toHexAsync(byte[] bytes)
        {
            await Task.Delay(1000);
            if (bytes == null) { throw new ArgumentNullException("bytes parameter is null"); }

            /*
            instead of using string variable to concatenate results [byte in bytes array]; 
            am using stringbuilder to improve performanc

             */
            StringBuilder hexResult = new StringBuilder();

            foreach (byte _byte in bytes)
            {
                hexResult.Append(_byte.ToString("x2"));
            }

            return hexResult.ToString();
        }
        public static string toHex(byte[] bytes)
        {
            if (bytes == null) { throw new ArgumentNullException("bytes parameter is null"); }

            /*
           instead of using string variable to concatenate results [byte in bytes array]; 
           am using stringbuilder to improve performanc

            */

            StringBuilder hexResult = new StringBuilder();

            foreach (byte _byte in bytes)
            {
                hexResult.Append(_byte.ToString("x2"));
            }

            return hexResult.ToString();
        }



    }

}