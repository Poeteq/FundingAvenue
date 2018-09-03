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

            string excelDoc = _excelService.GenerateClientProfileExcelFile(request);
            //bool mailResponse = iservice.SendMail(excelDoc, request);
            return Ok(excelDoc);
        }
    }
}
