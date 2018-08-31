
using Microsoft.AspNetCore.Mvc;
using SugarTits.FundingAvenue.Models;
using SugarTits.FundingAvenue.Services;

namespace SugarTits.FundingAvenue.Controllers
{
    public class ApplicationController : Controller
    {
        private ExcelService _excelService;
        //private MailService _mailService;
        public ApplicationController()
        {
            _excelService = new ExcelService();
            //_mailService = new MailService();
        }

        [HttpPost]
        public IActionResult Form([FromBody] ApplicationForm request)
        {
            var contactForm = new ContactForm
            {
                Name = $"{request.FirstName} {request.LastName}",
                Email = request.Email,
                PhoneNum = request.PhoneNumber,
                Title = "(╯°□°）╯︵ ┻━┻",
                Message = "YOU HAVE A NEW APPLICATION!"
            };
            // MOCK CODE
            string excelDoc = _excelService.GenerateClientProfileExcelFile(request);
            var mailResponse = MailService.SendMail(excelDoc, contactForm);
            return Ok(mailResponse);
        }
    }
}
