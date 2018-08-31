using System.IO;
using OfficeOpenXml;

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
                var ws = p.Workbook.Worksheets.Add("MySheet");
                ws.Cells["A1"].Value = "First Name";
                ws.Cells["A2"].Value = form.FirstName;

                ws.Cells["B1"].Value = "Last Name";
                ws.Cells["B2"].Value = form.LastName;

                FileInfo fileInfo = new FileInfo(file);
                fileInfo.Attributes = FileAttributes.Temporary;

                p.SaveAs(fileInfo);
            }

            return file;
        }
    }
}
