
using Microsoft.AspNetCore.Mvc;
using SugarTits.FundingAvenue.Models;
using SugarTits.FundingAvenue.Services;

namespace SugarTits.FundingAvenue.Controllers
{
    public class ApplicationController : Controller
    {
        private ExcelService _excelService;
        private MailService _mailService;
        public ApplicationController()
        {
            _excelService = new ExcelService();
            _mailService = new MailService();
        }

        [HttpPost]
        public IActionResult Form([FromBody] ApplicationForm applicationFormRequest)
        {
            // MOCK CODE
            var excelDoc = _excelService.GenerateClientProfileExcelFile(applicationFormRequest);
            var mailResponse = _mailService.SendMail(excelDoc);
            return Ok(mailResponse);
        }
    }
}
