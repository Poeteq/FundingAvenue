namespace SugarTits.FundingAvenue.Services
{
    public class MailService
    {
        public object SendMail(object fileAttachment)
        {
            var success = false;

            // TODO: Send mail w/ file attachment to Chris' email here

            // ************
            // ** FAKE CODE
            // ************
            // var mail = new Mail();
            // mail.SetSubject('New Application From FundingAvenue.com')
            // mail.SetBody('Congrats! New application received.')
            // mail.AddAttachment(fileAttachment);
            // mail.SendTo('Randall@fundingavenue.com');
            // success = mail.IsSuccessfullySent;

            return success;
        }
    }
}
