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

                ws.Cells["A25:B25"].Value = "State: ";
                ws.Cells["A25:B25"].Merge = true;

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
