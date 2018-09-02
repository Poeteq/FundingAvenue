using System.Drawing;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

using SugarTits.FundingAvenue.Models;

namespace SugarTits.FundingAvenue.Services
{
    public class ExcelService
    {
        public string GenerateClientProfileExcelFile(ApplicationForm form)
        {

            string dir = Path.GetTempPath();
            string fileName = string.Empty;

            if (form.FirstName != null && form.LastName != null)
                fileName = $"{form.FirstName}-{form.LastName}_clientprofile.xlsx";
            else
                fileName = Path.GetTempFileName();

            string file = Path.Combine(dir, fileName);

            // TODO: Generate Excel Document Here...
            using (var p = new ExcelPackage())
            {
                var ws = p.Workbook.Worksheets.Add("Client Profile");

                // SECTION: CORPORATION
                ws.Cells["A1:J1"].Value = "CORPORATION PROFILE";
                ws.Cells["A1:J1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A1:J1"].Style.Fill.BackgroundColor.SetColor(Color.Black);
                ws.Cells["A1:J1"].Style.Font.Color.SetColor(Color.White);
                ws.Cells["A1:J1"].Style.Font.Bold = true; //Font should be bold
                ws.Cells["A1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Cells["A1:J1"].Merge = true;

                ws.Cells["A2:B2"].Value = "Business Name:";
                ws.Cells["A2:B2"].Merge = true;

                ws.Cells["A3:B3"].Value = "Mailing Address:";
                ws.Cells["A3:B3"].Merge = true;

                ws.Cells["A4:B4"].Value = "Mailing Cont.:";
                ws.Cells["A4:B4"].Merge = true;

                ws.Cells["A6:B6"].Value = "Tax Identification No.:";
                ws.Cells["A6:B6"].Merge = true;

                ws.Cells["A7:B7"].Value = "Phone Number:";
                ws.Cells["A7:B7"].Merge = true;

                ws.Cells["A8:B8"].Value = "Type of Entity:";
                ws.Cells["A8:B8"].Merge = true;

                ws.Cells["A9:B9"].Value = "State of Incorporation:";
                ws.Cells["A9:B9"].Merge = true;

                ws.Cells["A10:B10"].Value = "Business Incorp Date:";
                ws.Cells["A10:B10"].Merge = true;

                ws.Cells["A11:B11"].Value = "Regional:";
                ws.Cells["A11:B11"].Merge = true;

                ws.Cells["A12:B12"].Value = "Business Gross Income:";
                ws.Cells["A12:B12"].Merge = true;

                // SECTION: OFFICERS / DIRECTOR
                ws.Cells["A13:J13"].Value = "OFFICERS / DIRECTORS";
                ws.Cells["A13:J13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A13:J13"].Style.Fill.BackgroundColor.SetColor(Color.Black);
                ws.Cells["A13:J13"].Style.Font.Color.SetColor(Color.White);
                ws.Cells["A13:J13"].Style.Font.Bold = true; //Font should be bold
                ws.Cells["A13:J13"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Cells["A13:J13"].Merge = true;

                ws.Cells["A14:E14"].Value = "GUARANTOR INFO";
                ws.Cells["A14:E14"].Merge = true;

                ws.Cells["A15:B15"].Value = "Full Name:	";
                ws.Cells["A15:B15"].Merge = true;

                ws.Cells["A17:B17"].Value = "Mailing Address:	";
                ws.Cells["A17:B17"].Merge = true;

                ws.Cells["A18:B18"].Value = "Mailing Cont.:	";
                ws.Cells["A18:B18"].Merge = true;

                ws.Cells["A20:B20"].Value = "Social Security Number:	";
                ws.Cells["A20:B20"].Merge = true;

                ws.Cells["A21:B21"].Value = "Email Address:	";
                ws.Cells["A21:B21"].Merge = true;

                ws.Cells["A22:B22"].Value = "Home Phone Number:	";
                ws.Cells["A22:B22"].Merge = true;

                ws.Cells["A23:B23"].Value = "Time at Residence:	";
                ws.Cells["A23:B23"].Merge = true;

                ws.Cells["A24:B24"].Value = "Drivers License:	";
                ws.Cells["A24:B24"].Merge = true;

                ws.Cells["A14:E14"].Value = "GUARANTOR INFO";
                ws.Cells["A14:E14"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ws.Cells["A14:E14"].Merge = true;

                ws.Cells["A25"].Value = "State: ";

                ws.Cells["C25"].Value = "Issue Date: ";

                ws.Cells["E25"].Value = "Expiration: ";

                ws.Cells["G25:H25"].Value = "Monthly House Payment: ";
                ws.Cells["G25:H25"].Merge = true;

                // Section: Business Questions
                ws.Cells["A27:J27"].Value = "Business Questions:";
                ws.Cells["A27:J27"].Merge = true;

                ws.Cells["A28:J28"].Value = "1. Can they recieve mail at business address?";
                ws.Cells["A28:J28"].Merge = true;
                ws.Cells["A29:J29"].Merge = true;

                ws.Cells["A30:J30"].Value = "2. Does client have business checking account? What Bank? How much in deposits?";
                ws.Cells["A30:J30"].Merge = true;
                ws.Cells["A31:J31"].Merge = true;

                ws.Cells["A32:J32"].Value = "3. Are there business Derrogatories/BK?";
                ws.Cells["A32:J32"].Merge = true;
                ws.Cells["A33:J33"].Merge = true;

                ws.Cells["A34:J34"].Value = "4. Are there any existing business accounts?";
                ws.Cells["A34:J34"].Merge = true;
                ws.Cells["A35:J35"].Merge = true;


                ws.Cells["A36:A36"].Value = "5. If Yes, Need name of Bank, Credit Limits, Balances, Average monthly payment being made, current/delinquent on account";
                ws.Cells["A36:J36"].Merge = true;
                ws.Cells["A37:J37"].Merge = true;

                // Section: Personal Questions
                ws.Cells["A39:J39"].Value = "Personal Questions:";
                ws.Cells["A39:J39"].Merge = true;

                ws.Cells["A40:J40"].Value = "1. Can they receive mail at personal address?";
                ws.Cells["A40:J40"].Merge = true;
                ws.Cells["A41:J41"].Merge = true;

                ws.Cells["A42:J42"].Value = "2. Personal BK in the past?";
                ws.Cells["A42:J42"].Merge = true;
                ws.Cells["A43:J43"].Merge = true;

                ws.Cells["A44:J44"].Value = "3. Personal Checking/Saings? What Banks? Currency Deposit Amounts?";
                ws.Cells["A44:J44"].Merge = true;
                ws.Cells["A45:J45"].Merge = true;

                ws.Cells["A46:J46"].Value = "4. Vehicles registered under PG (Year, Model, Color)";
                ws.Cells["A46:J46"].Merge = true;
                ws.Cells["A47:J47"].Merge = true;

                ws.Cells["A48:J48"].Value = "5. College graduated at? Any Special Degrees/License? (Example: real estate license)";
                ws.Cells["A48:J48"].Merge = true;
                ws.Cells["A49:J49"].Merge = true;

                ws.Cells["A50:J50"].Value = "6. Who else lives in the household? Need First, Middle, Last name for everyone in the household along with Date of Birth";
                ws.Cells["A50:J50"].Merge = true;
                ws.Cells["A51:J51"].Merge = true;


                ws.Cells["A52:J52"].Value = "7. Do they have personal credit cards with BofA/Chase? LAst few purchases made (store name)";
                ws.Cells["A52:J52"].Merge = true;

                ws.Cells["A54:E54"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A54:E54"].Style.Fill.BackgroundColor.SetColor(Color.Black);
                ws.Cells["A54:E54"].Style.Font.Color.SetColor(Color.White);
                ws.Cells["A54:E54"].Style.Font.Bold = true; //Font should be bold
                ws.Cells["A54:E54"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A54"].Value = "BANK";
                ws.Cells["B54"].Value = "TYPE";
                ws.Cells["C54"].Value = "EMAIL";
                ws.Cells["D54"].Value = "PHONE";
                ws.Cells["E54"].Value = "LIMIT";


                ws.Column(1).Width = 15;
                ws.Column(2).Width = 15;
                ws.Column(3).Width = 15;
                ws.Column(4).Width = 15;
                ws.Column(5).Width = 15;
                ws.Column(6).Width = 15;
                ws.Column(7).Width = 15;
                ws.Column(8).Width = 15;
                ws.Column(9).Width = 15;
                ws.Column(10).Width = 15;
                ws.Column(11).Width = 15;
                ws.Column(12).Width = 30;
                ws.Column(13).Width = 15;
                ws.Column(14).Width = 40;

                FileInfo fileInfo = new FileInfo(file);
 
                p.SaveAs(fileInfo);
            }

            return file;
        }
    }
}
