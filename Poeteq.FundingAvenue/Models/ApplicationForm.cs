using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Poeteq.FundingAvenue.Models
{
    public class ApplicationForm
    {
        [Required]
        public string applicationType { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        //public string PhoneType { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public string BusinessEntityType { get; set; }
        public string ApplicationCreatedDate { get; set; }
        public string BusinessIncorpDate { get; set; }
        public List<CreditCard> BusinessCreditCards { get; set; }
        public List<LinesOfCredit> BusinessCreditLines { get; set; }
        public string AmountRequested { get; set; }
        public bool HasFiledForBankruptcy { get; set; }
        public bool HasBeenInForeclosure { get; set; }
        public bool HasJudgementsCollectionsLiens { get; set; }
        public string Comments { get; set; }

    }

    public class CreditCard
    {
        public string Lender { get; set; }
        public string Balance { get; set; }
        public string Limit { get; set; }
    }

    public class LinesOfCredit
    {
        public Boolean IsSecured { get; set; }
        public string Lender { get; set; }
        public string Balance { get; set; }
        public string Limit { get; set; }
    }

}
