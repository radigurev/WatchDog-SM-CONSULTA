﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace WatchDog.Service
{

    class EmailService
    {

        const string from = "smc.developer@outlook.com";
        const string to = "rg00749943@edu.mon.bg";

        const string username = "smc.developer@outlook.com";
        const string password = "EQu6aD,{m.";

        const string host = "smtp.office365.com";
        const int port = 587;

        //readonly SmtpClient EmailClient = new SmtpClient(host, port)
        //{
        //    UseDefaultCredentials = false,
        //    Credentials = new NetworkCredential(username, password),
        //    EnableSsl = true
        //};


        public void sendEmail(string domain, HttpResponseMessage response,string subject,string body)
        {
             var EmailClient = new SmtpClient(host, port)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(username, password),
                EnableSsl = true
            };

            EmailClient.Send(from, to,subject, body);
        }

    }
}
