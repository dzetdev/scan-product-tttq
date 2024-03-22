using System.Text.RegularExpressions;

namespace Scan_Product_TTTQ.Domain.Utils;

public class ValidationUtils
{
    public ValidationUtils()
    {
        
    }
    public static readonly string EMAIL_REGEX = "(([^<>()\\[\\]\\\\.,;:\\s@\"]+(\\.[^<>()\\[\\]\\\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))";
    public static readonly string PASSWORD_REGEX = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()-_+=]).{8,16}$";
    public static bool IsEmail(string email)
    {
        return Regex.IsMatch(email, EMAIL_REGEX);
    }
    
    public static bool IsPassword(string password)
    {
        return Regex.IsMatch(password, PASSWORD_REGEX);
    }
}