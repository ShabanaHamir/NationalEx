﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class clsSecurity
    {
        public class clsEmail
        {
            //
            public string Subject { get; internal set; }
            public string Recipient { get; internal set; }
            public string Sender { get; internal set; }
            public string Body { get; internal set; }

            public void SendEmail()
            {
                //sends a email
                System.Net.Mail.MailMessage eMail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient Server = new System.Net.Mail.SmtpClient("mail.dmu.ac.uk");
                eMail = new System.Net.Mail.MailMessage(this.Sender, this.Recipient, this.Subject, this.Body);
                //Server.Send(eMail);
            }

        }
    }
}
