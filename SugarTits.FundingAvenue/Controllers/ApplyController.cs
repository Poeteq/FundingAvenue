using Microsoft.AspNetCore.Mvc;
using SugarTits.FundingAvenue.Models;
using SugarTits.FundingAvenue.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SugarTits.FundingAvenue.Controllers
{
    public class ApplyController : Controller
    {
        private ExcelService _excelService;
        private MailService _mailService;
        public ApplyController()
        {
            _excelService = new ExcelService();
            _mailService = new MailService();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[Route("api/application")]
        //public IActionResult SubmitApplication([FromBody] ApplicationForm applicationFormRequest)
        //{
        //    // MOCK CODE
        //    var excelDoc = _excelService.GenerateClientProfile(applicationFormRequest);
        //    //var mailResponse = _mailService.SendMail(excelDoc);
        //   // return Ok(mailResponse);
        //}
    }
}
