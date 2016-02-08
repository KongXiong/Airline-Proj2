using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Airline_proj
{
    class EmailReceipt
    {
       
        List<string> carriers = new List<string>();
        public void CarriersAdd()
        {
            carriers.Add("@myboostmobile.com");
            carriers.Add("@tmomail.net");
            carriers.Add("@vmobl.com");
            carriers.Add("@messaging.sprintpcs.com");
            carriers.Add("@vtext.com");
            carriers.Add("@email.uscc.net");
            carriers.Add("@tms.suncom.com");
            carriers.Add("@txt.att.net");
            carriers.Add("@MyMetroPcs.com");
        }

        public string Message()
        {
            Console.WriteLine("Enter Message:  ");
            string mss = Console.ReadLine();
            return mss;

        }

        public string PhoneNumber()
        {
            Console.WriteLine("Enter Phone Number:");
            string num = Console.ReadLine();
            return num;
        }

        public string EmailTo()
        {
            Console.WriteLine("Enter Email : ");
            string email = Console.ReadLine();
            return email;
        }
        public void Email()
        {
            CarriersAdd();
            string phonenumber = PhoneNumber();
            string msm = Message();
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("devcodeairlines@gmail.com", "juan014642");
            foreach(string carrier in carriers)
            {
                 MailMessage mm = new MailMessage("devcodeairlines@gmail.com",phonenumber+carrier, "Airplane Ticket Receipt", msm);
                 mm.BodyEncoding = UTF8Encoding.UTF8;
                 mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                 client.Send(mm);
            }

        }
    }
}
