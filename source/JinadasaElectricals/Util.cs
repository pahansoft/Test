using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;

using System.Net;
using System.Net.Mail;

namespace  BarcodeGenarator
{
   public class Util
    {
        #region --- Encrytion & Dycrypt ---

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        #endregion

        public void SendMail(List<string> toList, string fromMail, string message, string subject, string recipient)
        {
            System.Net.Mail.MailMessage msgMail = new System.Net.Mail.MailMessage();

            string emailFrom = System.Configuration.ConfigurationManager.AppSettings["FromMail"].ToString();

            if (toList == null || toList.Count == 0)
            {
                msgMail.To.Add("pahansoft2@gmail.com");
            }
            else
            {
                foreach (string item in toList)
                {
                    msgMail.To.Add(item);
                }
            }

            MailAddress mailFrom = new MailAddress(emailFrom);
            msgMail.From = mailFrom;

            msgMail.Subject = subject;

            msgMail.IsBodyHtml = true;
            StringBuilder strBody = new StringBuilder("<html><body>");
            strBody.Append("<br>" + recipient + "</br>");
            strBody.Append("<br>" + message.ToString() + "</br>");
            strBody.Append("<br>");
            strBody.Append("<br><br>System generated e-mail from Chillies Sales Managment System </br></br>");
            strBody.Append("</body></html>");

            msgMail.Priority = System.Net.Mail.MailPriority.High;
            msgMail.Body = strBody.ToString();
            string smtp = System.Configuration.ConfigurationManager.AppSettings["SMTP"].ToString();
            string userName = System.Configuration.ConfigurationManager.AppSettings["EmailUserName"].ToString();
            string password = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"].ToString();

            SmtpClient client = new SmtpClient();
            client.Host = smtp;

            //if use gmail
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(userName, password);

            client.Send(msgMail); //please comment doen't want to mail sent

        }
        public DateTime GetDate()
        {
            return new DataAccess.dcInventoryDataContext().ExecuteQuery<DateTime>("SELECT GETDATE()").First();
        }
    }
}
