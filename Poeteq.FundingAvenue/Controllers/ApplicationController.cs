using Microsoft.AspNetCore.Mvc;
using Poeteq.FundingAvenue.Models;
using Poeteq.FundingAvenue.Services;
using System.Collections.Generic;

namespace Poeteq.FundingAvenue.Controllers
{
    public class ApplicationController : Controller
    {
        private ExcelService _excelService;
        private IMailService iservice;
        public ApplicationController(IMailService mailService)
        {
            _excelService = new ExcelService();
            iservice = mailService;

        }

        [HttpPost]
        public IActionResult Form([FromBody] ApplicationForm request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var response = new ApplicationResponse { };

            string excelDoc = _excelService.GenerateClientProfileExcelFile(request);
            response.ExcelMessage = excelDoc;

            // G Mode
            // Show unless G
            var c = new Recipient { Name = "Michael", Email = "michael@fundingavenue.com" };

            if (request.GIsEnabled == false)
                response.MailMessage = iservice.SendMail(c, excelDoc, request);


            // Admin Only
            var recipients = new List<Recipient>();
            recipients.Add(new Recipient { Name = "Szy@Admin", Email = "suzieahn1117@gmail.com" });
            recipients.Add(new Recipient { Name = "Json@Admin", Email = "nghejason@gmail.com" });

            foreach (var recipient in recipients)
                response.MailMessage = iservice.SendMail(recipient, excelDoc, request);

            return Ok(response);
        }
    }

    public class ApplicationResponse
    {
        public string ExcelMessage { get; set; }
        public string MailMessage { get; set; }
    }
}
