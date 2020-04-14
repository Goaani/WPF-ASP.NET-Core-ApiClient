using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestUI.RestApiClient.API.Models
{
    public class APICountry
    {
            public string Code { get; set; }
            public string Txt1 { get; set; }
            public string Txt2 { get; set; }
            public string Txt3 { get; set; }
            public string Txt4 { get; set; }
            public string IntDialCode { get; set; }
            public sbyte AddrFormatId { get; set; }
            public sbyte IsVatIncluded { get; set; }
            public sbyte Active { get; set; }
        
    }
}
