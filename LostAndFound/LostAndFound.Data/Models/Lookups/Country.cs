using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostAndFound.Data.Models.Lookups
{

    //Structure from http://www.nationsonline.org/oneworld/country_code_list.htm and Dialing codes from http://www.nationsonline.org/oneworld/international-calling-codes.htm
    public class Country
    {
        public string Name { get; set; }
        //ISO "ALPHA-2 Code
        public string IsoAlpha2Code { get; set; }
        //ISO ALPHA-3 Code
        public string IsoAlpha3Code { get; set; }
        //ISO Numeric Code UN M49 Numerical Code
        public string IsoNumericCode { get; set; }

        public string DialingCode { get; set; }
        public string InternationalDialingPrefix { get; set; }

    }
}
