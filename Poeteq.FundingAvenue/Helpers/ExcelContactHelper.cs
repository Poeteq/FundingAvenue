using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using System.Linq;

namespace Poeteq.FundingAvenue.Helpers
{
    public class ExcelContactHelper
    {

        public static ExcelWorksheet BuildContactLog(ExcelWorksheet ws)
        {
            Color LightGreen = ColorTranslator.FromHtml("#93c47d");
            Color LightBlue = ColorTranslator.FromHtml("#cfe2f3");

            var ClientContactLogCells = "A1:H1";
            ws.Cells[ClientContactLogCells].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[ClientContactLogCells].Style.Font.Color.SetColor(Color.White);
            ws.Cells[ClientContactLogCells].Style.Fill.BackgroundColor.SetColor(LightGreen);
            ws.Cells[ClientContactLogCells].Style.Font.Bold = true; //Font should be bold
            ws.Cells[ClientContactLogCells].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[ClientContactLogCells].Merge = true;
            ws.Cells[ClientContactLogCells].Value = "CLIENT CONTACT LOG";
            ws.Cells[ClientContactLogCells].Style.Font.Size = 23;

            var ContactLogCellHeaders = "A2:H2";
            ws.Cells[ContactLogCellHeaders].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[ContactLogCellHeaders].Style.Font.Color.SetColor(Color.Black);
            ws.Cells[ContactLogCellHeaders].Style.Fill.BackgroundColor.SetColor(LightBlue);
            ws.Cells[ContactLogCellHeaders].Style.Font.Bold = true; //Font should be bold
            ws.Cells[ContactLogCellHeaders].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A2"].Value = "Contact Date";
            ws.Cells["B2"].Value = "Contact Person";
            ws.Cells["H2"].Value = "Initials";

            ws.Cells["C2:G2"].Value = "Notes";
            ws.Cells["C2:G2"].Merge = true;
            foreach (int i in Enumerable.Range(3, 50))
            {
                ws.Cells[$"C{i}:G{i}"].Merge = true;
            }

            // Sets column width
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

            return ws;
        }

    }
}
