using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using OfficeOpenXml;

using Poeteq.FundingAvenue.Models;
using Poeteq.FundingAvenue.Helpers;

namespace Poeteq.FundingAvenue.Services
{
    public class ExcelService
    {
        private const string PersonalCreditLoans = "Personal Credit Lines";
        private const string PersonalCashLoans = "Personal Cash Loans";
        private const string RealEstate = "Real Estate";
        private const string BusinessCreditLines = "Business Credit Lines";
        private const string BusinessEntityCreation = "Business Entity Creation";
        private const string ComboFunding = "Combo Funding";

        private const string Sheet1Name = "Client Profile";
        private const string Sheet2Name = "Funding Status";
        private const string Sheet3Name = "Contact Log";

        private static readonly Regex sWhitespace = new Regex(@"\s+");

        public string GenerateClientProfileExcelFile(ApplicationForm form)
        {
            try
            {
                string file = string.Empty;
                using (var p = new ExcelPackage())
                {
                    var worksheet1 = p.Workbook.Worksheets.Add(Sheet1Name);
                    var worksheet2 = p.Workbook.Worksheets.Add(Sheet2Name);
                    var worksheet3 = p.Workbook.Worksheets.Add(Sheet3Name);


                    BuildProfile(worksheet1, form);
                    ExcelFundingHelper.BuildFundingStatus(worksheet2, form);
                    ExcelContactHelper.BuildContactLog(worksheet3);

                    file = GenerateFilePath(form.FirstName, form.LastName, form.BirthYear);
                    FileInfo fileInfo = new FileInfo(file);

                    p.SaveAs(fileInfo);
                }

                return file;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private ExcelWorksheet BuildProfile(ExcelWorksheet ws, ApplicationForm form)
        { 
            List<string> BusinessOptions = new List<string> { BusinessCreditLines, BusinessEntityCreation, ComboFunding };
            List<string> PersonalOptions = new List<string> { PersonalCreditLoans, PersonalCashLoans, RealEstate };

            if (BusinessOptions.Contains(form.ApplicationType))
            {
                return ExcelBusinessHelper.BuildBusinessProfile(ws, form);
            }

            else if (PersonalOptions.Contains(form.ApplicationType))
            {
               return ExcelPersonalHelper.BuildPersonalProfile(ws, form);
            }

            return null as ExcelWorksheet;
        }

        private string GenerateFilePath(string firstName, string lastName, string birthYear)
        {
            string dir = Path.GetTempPath();
            string fileName = string.Empty;
            string file = string.Empty;
            Random rnd = new Random();
            
            if (firstName != null && lastName != null && birthYear!=null)
            {
                fileName = $"{ReplaceWhitespace(lastName, "")}.ClientProfile-{rnd.Next(1, 999)}.xlsx";
            }
            else
            {
                fileName = Path.GetTempFileName();
            }

            return Path.Combine(dir, fileName);
        }

        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }
    }

}