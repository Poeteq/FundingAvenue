﻿using Microsoft.AspNetCore.Mvc;
using Poeteq.FundingAvenue.Models;
using Poeteq.FundingAvenue.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poeteq.FundingAvenue.Controllers
{
    public class ContactController : Controller
    {

        private IMailService iservice;
        public ContactController(IMailService mailService) //Constructor
        {
            iservice = mailService;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail([FromBody]ContactForm contactForm)
        {
            bool sent = iservice.SendMail(null, contactForm);
            return Ok(sent);
        }
    }
}
