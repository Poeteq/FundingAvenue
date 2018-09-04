using Microsoft.AspNetCore.Mvc;
using SugarTits.FundingAvenue.Models;
using SugarTits.FundingAvenue.Services;

namespace SugarTits.FundingAvenue.Controllers
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

            string mailResponse = iservice.SendMail(excelDoc, request);
            response.MailMessage = mailResponse;

            return Ok(response);
        }
    }

    public class ApplicationResponse
    {
        public string ExcelMessage { get; set; }
        public string MailMessage { get; set; }
    }
}
