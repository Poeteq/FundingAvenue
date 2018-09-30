using OfficeOpenXml;
using OfficeOpenXml.Style;
using Poeteq.FundingAvenue.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Poeteq.FundingAvenue.Helpers
{
    public class ExcelFundingHelper
    {
        public static ExcelWorksheet BuildFundingStatus(ExcelWorksheet ws, ApplicationForm form)
        {
            Color LightPink = ColorTranslator.FromHtml("#c27ba0");
            Color LightGreen = ColorTranslator.FromHtml("#93c47d");
            Color LightBlue = ColorTranslator.FromHtml("#cfe2f3");
            Color LightViolet = ColorTranslator.FromHtml("#d9d2e9");

            var HEADER_CELLS = "A1:J3";
            ws.Cells[HEADER_CELLS].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[HEADER_CELLS].Style.Font.Color.SetColor(Color.White);
            ws.Cells[HEADER_CELLS].Style.Fill.BackgroundColor.SetColor(LightPink);
            ws.Cells[HEADER_CELLS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[HEADER_CELLS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A1"].Value = "Contract %";
            ws.Cells["A3"].Value = "Approved Amount";
            ws.Cells["C1"].Value = "*****";

            ws.Cells["D1"].Value = "New after agreement";
            ws.Cells["D1"].Style.Font.Color.SetColor(LightGreen);

            ws.Cells["E1"].Value = "Client Minimum";
            ws.Cells["E2"].Value = "Client Requested";
            ws.Cells["F2"].Value = form.AmountRequested;
            ws.Cells["E3"].Value = "Client Maximum";

            // ********
            // SECTION: Business Applications
            // ********

            var BUS_APP_TITLE_CELLS = "A4:J4";
            ws.Cells[BUS_APP_TITLE_CELLS].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[BUS_APP_TITLE_CELLS].Style.Font.Color.SetColor(Color.White);
            ws.Cells[BUS_APP_TITLE_CELLS].Style.Fill.BackgroundColor.SetColor(LightGreen);
            ws.Cells[BUS_APP_TITLE_CELLS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[BUS_APP_TITLE_CELLS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[BUS_APP_TITLE_CELLS].Merge = true;
            ws.Cells[BUS_APP_TITLE_CELLS].Value = "BUSINESS APPLICATIONS";
            ws.Cells[BUS_APP_TITLE_CELLS].Style.Font.Size = 23;

            var BUS_APP_CELL_HEADERS = "A5:J5";
            ws.Cells[BUS_APP_CELL_HEADERS].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[BUS_APP_CELL_HEADERS].Style.Font.Color.SetColor(Color.Black);
            ws.Cells[BUS_APP_CELL_HEADERS].Style.Fill.BackgroundColor.SetColor(LightBlue);
            ws.Cells[BUS_APP_CELL_HEADERS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[BUS_APP_CELL_HEADERS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A5"].Value = "Submission Date";
            ws.Cells["B5"].Value = "Name of Bank";
            ws.Cells["C5"].Value = "Approved Amount";
            ws.Cells["D5"].Value = "Approval Date";
            ws.Cells["E5"].Value = "Account Received";
            ws.Cells["F5"].Value = "Last Updated";
            ws.Cells["G5:J5"].Value = "Notes";
            ws.Cells["G5:J5"].Merge = true;

            var BUS_APP_TOTAL_ROW = "A19:J19";
            ws.Cells[BUS_APP_TOTAL_ROW].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[BUS_APP_TOTAL_ROW].Style.Font.Color.SetColor(Color.Black);
            ws.Cells[BUS_APP_TOTAL_ROW].Style.Fill.BackgroundColor.SetColor(LightViolet);
            ws.Cells[BUS_APP_TOTAL_ROW].Style.Font.Bold = true; //Font should be bold
            ws.Cells[BUS_APP_TOTAL_ROW].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A19:B19"].Merge = true;
            ws.Cells["A19:B19"].Value = "Total Funding";
            ws.Cells["C19"].Value = "$0.00";

            // ********
            // SECTION: Personal Applications
            // ********

            var PERSONAL_APP_TITLE_CELLS = "A20:J20";
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.Font.Color.SetColor(Color.White);
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.Fill.BackgroundColor.SetColor(LightGreen);
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Merge = true;
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Value = "PERSONAL APPLICATIONS";
            ws.Cells[PERSONAL_APP_TITLE_CELLS].Style.Font.Size = 23;

            var PERSONAL_APP_CELL_HEADERS = "A21:J21";
            ws.Cells[PERSONAL_APP_CELL_HEADERS].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[PERSONAL_APP_CELL_HEADERS].Style.Font.Color.SetColor(Color.Black);
            ws.Cells[PERSONAL_APP_CELL_HEADERS].Style.Fill.BackgroundColor.SetColor(LightBlue);
            ws.Cells[PERSONAL_APP_CELL_HEADERS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[PERSONAL_APP_CELL_HEADERS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A21"].Value = "Submission Date";
            ws.Cells["B21"].Value = "Name of Bank";
            ws.Cells["C21"].Value = "Approved Amount";
            ws.Cells["D21"].Value = "Approval Date";
            ws.Cells["E21"].Value = "Account Received";
            ws.Cells["F21"].Value = "Last Updated";
            ws.Cells["G21:J21"].Value = "Notes";
            ws.Cells["G21:J21"].Merge = true;

            var PERSONAL_APP_TOTAL_ROW = "A43:J43";
            ws.Cells[PERSONAL_APP_TOTAL_ROW].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[PERSONAL_APP_TOTAL_ROW].Style.Font.Color.SetColor(Color.Black);
            ws.Cells[PERSONAL_APP_TOTAL_ROW].Style.Fill.BackgroundColor.SetColor(LightViolet);
            ws.Cells[PERSONAL_APP_TOTAL_ROW].Style.Font.Bold = true; //Font should be bold
            ws.Cells[PERSONAL_APP_TOTAL_ROW].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["A43:B43"].Merge = true;
            ws.Cells["A43:B43"].Value = "Total Funding";
            ws.Cells["C43"].Value = "$0.00";


            ws.Cells["A46:B46"].Merge = true;
            ws.Cells["A46:B46"].Value = "Total Funding";
            ws.Cells["C46"].Value = "$0.00";
            ws.Cells["A46:C46"].Style.Font.Size = 12;

            ws.Cells["B48"].Value = "Invoice A";
            ws.Cells["B49"].Value = "Invoice B";

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
            ws.Column(12).Width = 15;
            ws.Column(13).Width = 15;
            ws.Column(14).Width = 15;

            return ws;
        }

    }
}
