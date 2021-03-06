﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Poeteq.FundingAvenue.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/

        public IActionResult BusinessCreditLines()
        {
            return View();
        }

        public IActionResult PersonalCreditLines()
        {
            return View();
        }

        public IActionResult PersonalLoans()
        {
            return View();
        }

        public IActionResult ComboFunding()
        {
            return View();
        }
        
        public IActionResult BusinessEntityCreation()
        {
            return View();
        }

        public IActionResult RealEstate()   
        {
            return View();
        }
    }
}
