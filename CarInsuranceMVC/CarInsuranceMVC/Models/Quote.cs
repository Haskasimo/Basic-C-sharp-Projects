using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceMVC.Models
{
    public class Quote
    {
        public int ageQuote { get; set; }
        public int carYearQuote { get; set; }
        public int carMakeQuote { get; set; }
        public int speedingTickQuote { get; set; }
        public int DUIQuote { get; set; }
        public int CoverageQuote { get; set; }


    }
}