using System.Text;

namespace Scan_Product_TTTQ.Domain.Utils
{
    public class CommonUtils
    {
        public static (string confirmationCode, DateTime expirationTime) GenerateRandomCode(int length, int expiredTime)
        {
            const string chars = "0123456789";

            var random = new Random();
            var codeBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                codeBuilder.Append(chars[random.Next(chars.Length)]);
            }

            DateTime expirationTime = DateTime.Now.AddMinutes(expiredTime);

            return (codeBuilder.ToString(), expirationTime);
        }

    }
}