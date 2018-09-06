using Microsoft.AspNetCore.Mvc;
using Poeteq.FundingAvenue.Models;
using Poeteq.FundingAvenue.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poeteq.FundingAvenue.Controllers
{
    public class ApplyController : Controller
    {
        private ExcelService _excelService;
        private IMailService _mailService;
        public ApplyController(IMailService mail_service)
        {
            _excelService = new ExcelService();
            _mailService = mail_service;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Form([FromBody] ApplicationForm applicationFormRequest)
        //{
        //    // MOCK CODE
        //    string excelDoc = _excelService.GenerateClientProfileExcelFile(applicationFormRequest);
            
        //    bool mailResponse = _mailService.SendMail(excelDoc, applicationFormRequest);
        //    return Ok(mailResponse);
        //}
    }
}
