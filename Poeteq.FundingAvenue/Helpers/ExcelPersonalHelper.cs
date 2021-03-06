﻿using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

using Poeteq.FundingAvenue.Models;

namespace Poeteq.FundingAvenue.Helpers
{
    public class ExcelPersonalHelper
    {
        public static ExcelWorksheet BuildPersonalProfile(ExcelWorksheet ws, ApplicationForm form)
        {
            // ********
            // SECTION: CORPORATION
            // CORP >>
            // ********

            // CORP >> 1
            string CorpProfile = "A1:J1";
            ws.Cells[CorpProfile].Value = "CORPORATION PROFILE";
            ws.Cells[CorpProfile].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[CorpProfile].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells[CorpProfile].Style.Font.Color.SetColor(Color.White);
            ws.Cells[CorpProfile].Style.Font.Bold = true; //Font should be bold
            ws.Cells[CorpProfile].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[CorpProfile].Merge = true;

            // CORP >> 2
            string BusinessName = "A2:B2";
            ws.Cells[BusinessName].Value = "Business Name:";
            ws.Cells[BusinessName].Merge = true;
            ws.Cells[BusinessName].Style.Font.Bold = true;
            ws.Cells["C2:J2"].Value = form.BusinessName;
            ws.Cells["C2:J2"].Merge = true;
            ws.Cells["C2:J2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C2:J2"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C2:J2"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C2:J2"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 3
            ws.Cells["A3:B3"].Value = "Mailing Address:";
            ws.Cells["A3:B3"].Merge = true;
            ws.Cells["A3:B3"].Style.Font.Bold = true; //Font should be bold
            ws.Cells["C3:G3"].Value = form.Address;
            ws.Cells["C3:G3"].Merge = true;
            ws.Cells["C3:G3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C3:G3"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C3:G3"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C3:G3"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["H3"].Value = "Suite #";
            ws.Cells["H3"].Style.Font.Bold = true;
            ws.Cells["I3:J3"].Merge = true;
            ws.Cells["I3:J3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["I3:J3"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["I3:J3"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["I3:J3"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 4, 5
            ws.Cells["A4:B4"].Value = "Mailing Cont.:";
            ws.Cells["A4:B4"].Style.Font.Bold = true;
            ws.Cells["A4:B4"].Merge = true;


            ws.Cells["C4:F4"].Value = form.City;
            ws.Cells["C4:F4"].Merge = true;
            ws.Cells["G4:H4"].Value = form.State;
            ws.Cells["G4:H4"].Merge = true;
            ws.Cells["I4:J4"].Value = form.ZipCode;
            ws.Cells["I4:J4"].Merge = true;
            ws.Cells["C4:J4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["c4:J4"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["c4:J4"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["c4:J4"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["C5:F5"].Value = "City";
            ws.Cells["C5:F5"].Merge = true;
            ws.Cells["C5:F5"].Style.Font.Bold = true;
            ws.Cells["G5:H5"].Value = "State";
            ws.Cells["G5:H5"].Merge = true;
            ws.Cells["G5:H5"].Style.Font.Bold = true;
            ws.Cells["I5:J5"].Value = "Zip Code";
            ws.Cells["I5:J5"].Style.Font.Bold = true;
            ws.Cells["I5:J5"].Merge = true;

            // CORP >> 6
            ws.Cells["A6:B6"].Value = "Tax Identification No.:";
            ws.Cells["A6:B6"].Merge = true;
            ws.Cells["A6:B6"].Style.Font.Bold = true;
            ws.Cells["C6:E6"].Merge = true;
            ws.Cells["C6:E6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C6:E6"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C6:E6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C6:E6"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F6:G6"].Value = "# of Employees";
            ws.Cells["F6:G6"].Style.Font.Bold = true;
            ws.Cells["F6:G6"].Merge = true;
            ws.Cells["H6:J6"].Merge = true;
            ws.Cells["H6:J6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H6:J6"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H6:J6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H6:J6"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 7
            ws.Cells["A7:B7"].Value = "Phone Number:";
            ws.Cells["A7:B7"].Style.Font.Bold = true;
            ws.Cells["A7:B7"].Merge = true;
            ws.Cells["C7:E7"].Value = form.PhoneNumber;
            ws.Cells["C7:E7"].Merge = true;
            ws.Cells["C7:E7"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C7:E7"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C7:E7"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C7:E7"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F7:G7"].Value = "Email Address";
            ws.Cells["F7:G7"].Style.Font.Bold = true;
            ws.Cells["F7:G7"].Merge = true;
            ws.Cells["H7:J7"].Value = form.Email;
            ws.Cells["H7:J7"].Merge = true;
            ws.Cells["H7:J7"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H7:J7"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["H7:J7"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H7:J7"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 8
            ws.Cells["A8:B8"].Value = "Type of Entity:";
            ws.Cells["A8:B8"].Style.Font.Bold = true;
            ws.Cells["A8:B8"].Merge = true;
            ws.Cells["C8:E8"].Value = form.BusinessEntityType;
            ws.Cells["C8:E8"].Merge = true;
            ws.Cells["C8:E8"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C8:E8"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C8:E8"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C8:E8"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F8:G8"].Value = "Email Password";
            ws.Cells["F8:G8"].Style.Font.Bold = true;
            ws.Cells["F8:G8"].Merge = true;
            ws.Cells["H8:J8"].Merge = true;
            ws.Cells["H8:J8"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H8:J8"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["H8:J8"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H8:J8"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 9
            ws.Cells["A9:B9"].Value = "State of Incorporation:";
            ws.Cells["A9:B9"].Merge = true;
            ws.Cells["C9:E9"].Merge = true;
            ws.Cells["C9:E9"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C9:E9"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C9:E9"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C9:E9"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F9:G9"].Value = "Nature of Business";
            ws.Cells["F9:G9"].Style.Font.Bold = true;
            ws.Cells["F9:G9"].Merge = true;
            ws.Cells["H9:J9"].Value = form.BusinessType;
            ws.Cells["H9:J9"].Merge = true;
            ws.Cells["H9:J9"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H9:J9"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H9:J9"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H9:J9"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 10
            ws.Cells["A10:B10"].Value = "Business Incorp Date:";
            ws.Cells["A10:B10"].Style.Font.Bold = true;
            ws.Cells["A10:B10"].Merge = true;
            ws.Cells["C10:E10"].Value = form.BusinessIncorpDate;
            ws.Cells["C10:E10"].Merge = true;
            ws.Cells["C10:E10"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C10:E10"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C10:E10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C10:E10"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F10:G10"].Value = "Business Start Date";
            ws.Cells["F10:G10"].Style.Font.Bold = true;
            ws.Cells["F10:G10"].Merge = true;
            ws.Cells["H10:J10"].Value = form.BusinessIncorpDate;
            ws.Cells["H10:J10"].Merge = true;
            ws.Cells["H10:J10"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H10:J10"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H10:J10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H10:J10"].Style.Border.Bottom.Color.SetColor(Color.Black);




            // CORP >> 11
            ws.Cells["A11:B11"].Value = "Regional:";
            ws.Cells["A11:B11"].Style.Font.Bold = true;
            ws.Cells["A11:B11"].Merge = true;
            ws.Cells["C11:E11"].Merge = true;
            ws.Cells["C11:E11"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C11:E11"].Style.Fill.BackgroundColor.SetColor(Color.Lavender);
            ws.Cells["C11:E11"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C11:E11"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F11:G11"].Value = "# of Locations";
            ws.Cells["F11:G11"].Style.Font.Bold = true;
            ws.Cells["F11:G11"].Merge = true;
            ws.Cells["H11:J11"].Merge = true;
            ws.Cells["H11:J11"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H11:J11"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H11:J11"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H11:J11"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // CORP >> 12
            ws.Cells["A12:B12"].Value = "Business Gross Income:";
            ws.Cells["A12:B12"].Style.Font.Bold = true;
            ws.Cells["A12:B12"].Merge = true;
            ws.Cells["C12:E12"].Merge = true;
            ws.Cells["C12:E12"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C12:E12"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["C12:E12"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C12:E12"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F12:G12"].Value = "Net Profit";
            ws.Cells["F12:G12"].Style.Font.Bold = true;
            ws.Cells["F12:G12"].Merge = true;
            ws.Cells["H12:J12"].Merge = true;
            ws.Cells["H12:J12"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H12:J12"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H12:J12"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H12:J12"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // ********
            // SECTION: OFFICERS / DIRECTOR
            // OFF/DIR >>
            // ********

            // OFF/DIR >> 13
            ws.Cells["A13:J13"].Value = "OFFICERS / DIRECTORS";
            ws.Cells["A13:J13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A13:J13"].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells["A13:J13"].Style.Font.Color.SetColor(Color.White);
            ws.Cells["A13:J13"].Style.Font.Bold = true; //Font should be bold
            ws.Cells["A13:J13"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells["A13:J13"].Merge = true;

            // OFF/DIR >> 14
            ws.Cells["A14:E14"].Value = "GUARANTOR INFO";
            ws.Cells["A14:E14"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells["A14:E14"].Merge = true;

            ws.Cells["G14:H14"].Value = "Industry Experience:";
            ws.Cells["G14:H14"].Merge = true;
            ws.Cells["I14:J14"].Merge = true;
            ws.Cells["I14:J14"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["I14:J14"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["I14:J14"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["I14:J14"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 15
            ws.Cells["A15:B15"].Value = "Full Name:	";
            ws.Cells["A15:B15"].Merge = true;
            ws.Cells["A16:B16"].Merge = true;

            ws.Cells["C15:J15"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C15:J15"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["C15:J15"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C15:J15"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["C15:F15"].Value = form.FirstName;
            ws.Cells["C15:F15"].Merge = true;
            ws.Cells["C16:F16"].Value = "First Name";
            ws.Cells["C16:F16"].Merge = true;

            ws.Cells["G15:I15"].Value = form.LastName;
            ws.Cells["G15:I15"].Merge = true;
            ws.Cells["G16:I16"].Value = "Last Name";
            ws.Cells["G16:I16"].Merge = true;

            ws.Cells["J16"].Value = "M.I.";

            // OFF/DIR >> 17
            ws.Cells["A17:B17"].Value = "Mailing Address:	";
            ws.Cells["A17:B17"].Merge = true;
            ws.Cells["C17:G17"].Value = form.Address;
            ws.Cells["C17:G17"].Merge = true;
            ws.Cells["C17:G17"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C17:G17"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["C17:G17"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C17:G17"].Style.Border.Bottom.Color.SetColor(Color.Black);


            ws.Cells["H17"].Value = "Suite #";
            ws.Cells["I17:J17"].Merge = true;
            ws.Cells["I17:J17"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["I17:J17"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["I17:J17"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["I17:J17"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 18
            ws.Cells["A18:B18"].Value = "Mailing Cont.:	";
            ws.Cells["A18:B18"].Merge = true;
            ws.Cells["C18:I18"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C18:I18"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["C18:I18"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C18:I18"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["C18:F18"].Value = form.City;
            ws.Cells["C18:F18"].Merge = true;
            ws.Cells["G18:H18"].Value = form.State;
            ws.Cells["G18:H18"].Merge = true;
            ws.Cells["I18:J18"].Value = form.ZipCode;
            ws.Cells["I18:J18"].Merge = true;

            // OFF/DIR >> 19
            ws.Cells["C19:F19"].Value = "City";
            ws.Cells["C19:F19"].Merge = true;
            ws.Cells["G19:H19"].Value = "State";
            ws.Cells["G19:H19"].Merge = true;
            ws.Cells["I19:J19"].Value = "Zip Code";
            ws.Cells["I19:J19"].Merge = true;

            // OFF/DIR >> 20

            ws.Cells["A20:B20"].Value = "Social Security Number:	";
            ws.Cells["A20:B20"].Merge = true;
            ws.Cells["C20:E20"].Merge = true;
            ws.Cells["C20:E20"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C20:E20"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["C20:E20"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C20:E20"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F20:G20"].Value = "Birth Date:";
            ws.Cells["F20:G20"].Merge = true;
            ws.Cells["H20:J20"].Value = form.BirthYear;
            ws.Cells["H20:J20"].Merge = true;
            ws.Cells["H20:J20"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H20:J20"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["H20:J20"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H20:J20"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 21
            ws.Cells["A21:B21"].Value = "Email Address:	";
            ws.Cells["A21:B21"].Merge = true;
            ws.Cells["C21:E21"].Value = form.Email;
            ws.Cells["C21:E21"].Merge = true;
            ws.Cells["H21:J21"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H21:J21"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["H21:J21"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H21:J21"].Style.Border.Bottom.Color.SetColor(Color.Black);


            ws.Cells["F21:G21"].Value = "Mother's Maiden Name";
            ws.Cells["F21:G21"].Merge = true;
            ws.Cells["H21:J21"].Merge = true;
            ws.Cells["H21:J21"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H21:J21"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["H21:J21"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H21:J21"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 22
            ws.Cells["A22:B22"].Value = "Home Phone Number:	";
            ws.Cells["A22:B22"].Merge = true;
            ws.Cells["C22:E22"].Merge = true;
            ws.Cells["C22:E22"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C22:E22"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["C22:E22"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C22:E22"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F22:G22"].Value = "Cell Number";
            ws.Cells["F22:G22"].Merge = true;
            ws.Cells["H22:J22"].Merge = true;
            ws.Cells["H22:J22"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H22:J22"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["H22:J22"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H22:J22"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 23
            ws.Cells["A23:B23"].Value = "Time at Residence:	";
            ws.Cells["A23:B23"].Merge = true;
            ws.Cells["C23:E23"].Merge = true;
            ws.Cells["C23:E23"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C23:E23"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["C23:E23"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C23:E23"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F23:G23"].Value = "Gross Annual Income";
            ws.Cells["F23:G23"].Merge = true;
            ws.Cells["H23:J23"].Merge = true;
            ws.Cells["H23:J23"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H23:J23"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H23:J23"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H23:J23"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // OFF/DIR >> 24
            ws.Cells["A24:B24"].Value = "Drivers License:	";
            ws.Cells["A24:B24"].Merge = true;
            ws.Cells["C24:E24"].Merge = true;
            ws.Cells["C24:E24"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["C24:E24"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["C24:E24"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["C24:E24"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["F24:G24"].Value = "Gross Household Income";
            ws.Cells["F24:G24"].Merge = true;
            ws.Cells["H24:J24"].Merge = true;
            ws.Cells["H24:J24"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["H24:J24"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["H24:J24"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["H24:J24"].Style.Border.Bottom.Color.SetColor(Color.Black);


            // OFF/DIR >> 25
            ws.Cells["A25"].Value = "State: ";
            ws.Cells["B25"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["B25"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["B25"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["B25"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["C25"].Value = "Issue Date: ";
            ws.Cells["D25"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["D25"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["D25"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["D25"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["E25"].Value = "Expiration: ";
            ws.Cells["F25"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["F25"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["F25"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["F25"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["G25:H25"].Value = "Monthly House Payment: ";
            ws.Cells["G25:H25"].Merge = true;
            ws.Cells["I25:J25"].Merge = true;
            ws.Cells["I25:J25"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["I25:J25"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["I25:J25"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["I25:J25"].Style.Border.Bottom.Color.SetColor(Color.Black);

            // ********
            // SECTION: BUSINESS QUESTIONS
            // Q/A >>
            // ********

            ws.Cells["A26:J26"].Merge = true; // CLEAR

            // Section: Business Questions
            ws.Cells["A27:J27"].Value = "Business Questions:";
            ws.Cells["A27:J27"].Merge = true;

            ws.Cells["A28:J28"].Value = "1. Can they recieve mail at business address?";
            ws.Cells["A28:J28"].Merge = true;
            ws.Cells["A29:J29"].Merge = true;
            ws.Cells["A29:J29"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A29:J29"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["A29:J29"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A29:J29"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A30:J30"].Value = "2. Does client have business checking account? What Bank? How much in deposits?";
            ws.Cells["A30:J30"].Merge = true;
            ws.Cells["A31:J31"].Merge = true;
            ws.Cells["A31:J31"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A31:J31"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["A31:J31"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A31:J31"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A32:J32"].Value = "3. Are there business Derrogatories/BK?";
            ws.Cells["A32:J32"].Merge = true;
            ws.Cells["A33:J33"].Merge = true;
            ws.Cells["A33:J33"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A33:J33"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["A33:J33"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A33:J33"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A34:J34"].Value = "4. Are there any existing business accounts?";
            ws.Cells["A34:J34"].Merge = true;
            ws.Cells["A35:J35"].Merge = true;
            ws.Cells["A35:J35"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A35:J35"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["A35:J35"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A35:J35"].Style.Border.Bottom.Color.SetColor(Color.Black);


            ws.Cells["A36:A36"].Value = "5. If Yes, Need name of Bank, Credit Limits, Balances, Average monthly payment being made, current/delinquent on account";
            ws.Cells["A36:J36"].Merge = true;
            ws.Cells["A37:J37"].Merge = true;
            ws.Cells["A37:J37"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A37:J37"].Style.Fill.BackgroundColor.SetColor(Color.Red);
            ws.Cells["A37:J37"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A37:J37"].Style.Border.Bottom.Color.SetColor(Color.Black);

            //
            ws.Cells["A38:J38"].Merge = true; // CLEAR
                                              //

            // Section: Personal Questions
            ws.Cells["A39:J39"].Value = "Personal Questions:";
            ws.Cells["A39:J39"].Merge = true;

            ws.Cells["A40:J40"].Value = "1. Can they receive mail at personal address?";
            ws.Cells["A40:J40"].Merge = true;
            ws.Cells["A41:J41"].Merge = true;
            ws.Cells["A41:J41"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A41:J41"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["A41:J41"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A41:J41"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A42:J42"].Value = "2. Personal BK in the past?";
            ws.Cells["A42:J42"].Merge = true;
            ws.Cells["A43:J43"].Merge = true;
            ws.Cells["A43:J43"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A43:J43"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["A43:J43"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A43:J43"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A44:J44"].Value = "3. Personal Checking/Saings? What Banks? Currency Deposit Amounts?";
            ws.Cells["A44:J44"].Merge = true;
            ws.Cells["A45:J45"].Merge = true;
            ws.Cells["A45:J45"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A45:J45"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["A45:J45"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A45:J45"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A46:J46"].Value = "4. Vehicles registered under PG (Year, Model, Color)";
            ws.Cells["A46:J46"].Merge = true;
            ws.Cells["A47:J47"].Merge = true;
            ws.Cells["A47:J47"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A47:J47"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["A47:J47"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A47:J47"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A48:J48"].Value = "5. College graduated at? Any Special Degrees/License? (Example: real estate license)";
            ws.Cells["A48:J48"].Merge = true;
            ws.Cells["A49:J49"].Merge = true;
            ws.Cells["A49:J49"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A49:J49"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["A49:J49"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A49:J49"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A50:J50"].Value = "6. Who else lives in the household? Need First, Middle, Last name for everyone in the household along with Date of Birth";
            ws.Cells["A50:J50"].Merge = true;
            ws.Cells["A51:J51"].Merge = true;
            ws.Cells["A51:J51"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A51:J51"].Style.Fill.BackgroundColor.SetColor(Color.Cyan);
            ws.Cells["A51:J51"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A51:J51"].Style.Border.Bottom.Color.SetColor(Color.Black);


            ws.Cells["A52:J52"].Value = "7. Do they have personal credit cards with BofA/Chase? Last few purchases made (store name)";
            ws.Cells["A52:J52"].Merge = true;

            ws.Cells["A53:J53"].Value = "SEE BELOW";
            ws.Cells["A53:J53"].Merge = true;
            ws.Cells["A53:J53"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A53:J53"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            ws.Cells["A53:J53"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A53:J53"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A54:E54"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["A54:E54"].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells["A54:E54"].Style.Font.Color.SetColor(Color.White);
            ws.Cells["A54:E54"].Style.Font.Bold = true; //Font should be bold
            ws.Cells["A54:E54"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells["A54:E54"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            ws.Cells["A54:E54"].Style.Border.Bottom.Color.SetColor(Color.Black);

            ws.Cells["A54"].Value = "BANK";
            ws.Cells["B54"].Value = "TYPE";
            ws.Cells["C54"].Value = "EMAIL";
            ws.Cells["D54"].Value = "PHONE";
            ws.Cells["E54"].Value = "LIMIT";

            var currentCell = 55;
            foreach (var credCard in form.BusinessCreditCards)
            {
                ws.Cells[$"A{currentCell}"].Value = credCard.Lender;
                ws.Cells[$"B{currentCell}"].Value = "CC";
                ws.Cells[$"C{currentCell}"].Value = "";
                ws.Cells[$"D{currentCell}"].Value = "";
                ws.Cells[$"E{currentCell}"].Value = credCard.Limit;
                currentCell++;
            }

            foreach (var credLine in form.BusinessCreditLines)
            {
                ws.Cells[$"A{currentCell}"].Value = credLine.Lender;
                ws.Cells[$"B{currentCell}"].Value = credLine.IsSecured ? "Secured" : "Unsecured";
                ws.Cells[$"C{currentCell}"].Value = "";
                ws.Cells[$"D{currentCell}"].Value = "";
                ws.Cells[$"E{currentCell}"].Value = credLine.Limit;
                currentCell++;
            }

            // ********
            // SECTION: CREDIT LOGIN
            // CL >>
            // ********

            // CL >> 1
            var CL_CREDIT_LOGIN = "K1:L1";
            ws.Cells[CL_CREDIT_LOGIN].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[CL_CREDIT_LOGIN].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells[CL_CREDIT_LOGIN].Style.Font.Color.SetColor(Color.White);
            ws.Cells[CL_CREDIT_LOGIN].Style.Font.Bold = true; //Font should be bold
            ws.Cells[CL_CREDIT_LOGIN].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[CL_CREDIT_LOGIN].Value = "CREDIT LOGIN";
            ws.Cells[CL_CREDIT_LOGIN].Merge = true;

            // CL >> 2
            var CL_USERNAME = "K2";
            ws.Cells[CL_USERNAME].Value = "Username";

            // CL >> 3
            var CL_PASSWORD = "K3";
            ws.Cells[CL_PASSWORD].Value = "Password";

            // ********
            // SECTION: RING CENTRAL
            // RC >>
            // ********

            // RC >> 4
            var RC_NUM = "K4:L4";
            ws.Cells[RC_NUM].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[RC_NUM].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells[RC_NUM].Style.Font.Color.SetColor(Color.White);
            ws.Cells[RC_NUM].Style.Font.Bold = true; //Font should be bold
            ws.Cells[RC_NUM].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[RC_NUM].Value = "RING CENTRAL #:";
            ws.Cells[RC_NUM].Merge = true;

            // RC >> 5
            var RC_NUMBER = "K5";
            ws.Cells[RC_NUMBER].Value = "#:";
            ws.Cells["L5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["L5"].Style.Fill.BackgroundColor.SetColor(Color.Red);

            // ********
            // SECTION: DOCUMENTS
            // DOCS >>
            // ********

            var DOCUMENTS_TITLES = "K6:N6";
            ws.Cells[DOCUMENTS_TITLES].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[DOCUMENTS_TITLES].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells[DOCUMENTS_TITLES].Style.Font.Color.SetColor(Color.White);
            ws.Cells[DOCUMENTS_TITLES].Style.Font.Bold = true; //Font should be bold
            ws.Cells[DOCUMENTS_TITLES].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            ws.Cells["K6"].Value = "DOCUMENTS";
            ws.Cells["L6"].Value = "HOME OR BUSINESS";
            ws.Cells["M6"].Value = "PG NAME";
            ws.Cells["N6"].Value = "VERIFICATION CHECKLIST";

            ws.Cells["K7"].Value = "Articles";
            ws.Cells["K8"].Value = "SOS";
            ws.Cells["K9"].Value = "SS4";
            ws.Cells["K10"].Value = "DL/SS";
            ws.Cells["K11"].Value = "Credit Report";
            ws.Cells["K12"].Value = "Utility";


            ws.Cells["N7"].Value = "Co. Name / PG title:";
            ws.Cells["N8"].Value = "PG title / Docs visibility:";
            ws.Cells["N9"].Value = "Co. Name / EIN:";
            ws.Cells["N10"].Value = "DOB / SSN / Maiden:";
            ws.Cells["N11"].Value = "Name / Addr / Mort.:";
            ws.Cells["N12"].Value = "Addr / Bill date:";

            // ********
            // SECTION: PAY DOWN
            // PAY DOWN >>
            // ********

            var PAY_DOWN = "K13:M13";
            ws.Cells[PAY_DOWN].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells[PAY_DOWN].Style.Fill.BackgroundColor.SetColor(Color.Black);
            ws.Cells[PAY_DOWN].Style.Font.Color.SetColor(Color.White);
            ws.Cells[PAY_DOWN].Style.Font.Bold = true; //Font should be bold
            ws.Cells[PAY_DOWN].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[PAY_DOWN].Merge = true;
            ws.Cells[PAY_DOWN].Value = "PAY DOWN";

            ws.Cells["K14"].Value = "Bank";
            ws.Cells["L14"].Value = "Amount";

            // ********
            // SECTION: NEEDED ITEMS
            // NEED >>
            // ********

            ws.Cells["K20:M30"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            ws.Cells["K20:M30"].Style.Fill.BackgroundColor.SetColor(Color.Lavender);
            var NEEDED_ITEMS = "K20:M20";
            ws.Cells[NEEDED_ITEMS].Style.Font.Bold = true; //Font should be bold
            ws.Cells[NEEDED_ITEMS].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            ws.Cells[NEEDED_ITEMS].Merge = true;
            ws.Cells[NEEDED_ITEMS].Value = "Needed Items Before Beginning File		";

            ws.Cells["K21"].Value = "1";
            ws.Cells["K22"].Value = "2";
            ws.Cells["K23"].Value = "3";
            ws.Cells["K24"].Value = "4";
            ws.Cells["K25"].Value = "5";
            ws.Cells["K26"].Value = "6";
            ws.Cells["K27"].Value = "7";
            ws.Cells["K28"].Value = "8";
            ws.Cells["K29"].Value = "9";
            ws.Cells["K30"].Value = "10";

            ws.Cells["K32"].Value = form.ApplicationType; //application type inserted 
            ws.Cells["K32:L32"].Merge = true;

            ws.Cells["L21:M21"].Merge = true;
            ws.Cells["L22:M22"].Merge = true;
            ws.Cells["L23:M23"].Merge = true;
            ws.Cells["L24:M24"].Merge = true;
            ws.Cells["L25:M25"].Merge = true;
            ws.Cells["L26:M26"].Merge = true;
            ws.Cells["L27:M27"].Merge = true;
            ws.Cells["L28:M28"].Merge = true;
            ws.Cells["L29:M29"].Merge = true;
            ws.Cells["L30:M30"].Merge = true;

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
            ws.Column(12).Width = 30;
            ws.Column(13).Width = 15;
            ws.Column(14).Width = 40;

            return ws;
        }
    }
}
