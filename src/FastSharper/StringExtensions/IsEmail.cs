using System.Net.Mail;

namespace FastSharper.StringExtensions
{
    public static partial class FC
    {
        public static bool IsEmail(this string str)
        {
            try
            {
                MailAddress mail = new MailAddress(str);
                return mail.Address == str;
            }
            catch
            {
                return false;
            }
        }
    }
}
