using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using MailKit.Net.Smtp;
using SugarTits.FundingAvenue.Models;
using MimeKit;
using System.IO;

namespace SugarTits.FundingAvenue.Services
{
    public class MailService
    {

        private static bool SendSMTPClient(bool success, MimeMessage message)
        {
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);
                client.AuthenticationMechanisms.Remove("XOQUTH2");
                client.Authenticate("suzieahn1117@gmail.com", "dorothy1117");
                client.Send(message);
                client.Disconnect(true);
                success = true;
            }

            return success;
        }


        public static bool SendMail(string fileAttachment, ContactForm form)
        {
            var success = false;

            if (form.Email == null || form.Name == null || form.Message == null)
            {
                return false;
            }


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(form.Name, form.Email));
            message.To.Add(new MailboxAddress("Suzie", "suzieahn1117@gmail.com"));
            message.Subject = form.Title;

            var body = new TextPart("plain")
            {
                Text = form.Message
            };

            message.Body = body;

         
            return SendSMTPClient(success, message);
        }

        public static bool SendMail(string fileAttachment, ApplicationForm form)
        {
            var success = false;


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(form.FirstName + form.LastName, form.Email));
            message.To.Add(new MailboxAddress("Suzie", "suzieahn1117@gmail.com"));
            message.Subject = "Application Form";

            var body = new TextPart("plain")
            {
                Text = "Business Application Form"
            };

            var attachment = new MimePart("mysheet", "xlsx")
            {
                Content = new MimeContent(File.OpenRead(fileAttachment), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(fileAttachment)
            };

            var multipart = new Multipart("mixed");
            multipart.Add(body);
            multipart.Add(attachment);

            // now set the multipart/mixed as the message body
            message.Body = multipart;

            return SendSMTPClient(success, message);
        }
    }
}
