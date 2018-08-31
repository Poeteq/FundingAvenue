using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;
using MailKit.Net.Smtp;
using SugarTits.FundingAvenue.Models;
using MimeKit;
using System.Net.Mail;
using System.IO;

namespace SugarTits.FundingAvenue.Services
{
    public class MailService
    {

        public static bool IsValidEmail(ContactForm contactForm)
        {
            if (contactForm.Email == null || contactForm.Name == null || contactForm.Message == null)
            {
                return false;
            } //make sure .js controller already check and return false; 


            try
            {
                var emailAddress = new MailAddress(contactForm.Email);
                return emailAddress.Address.Any();
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool SendMail(string fileAttachment, ContactForm contactForm)
        {
            var success = false;

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(contactForm.Name, contactForm.Email));
            message.To.Add(new MailboxAddress("Suzie", "suzieahn1117@gmail.com"));
            message.Subject = contactForm.Title;

            var body = new TextPart("plain")
            {
                Text = contactForm.Message
            };

            var attachment = new MimePart("myshit", "xlsx")
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
    }
}
