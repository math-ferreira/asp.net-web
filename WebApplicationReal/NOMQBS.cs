using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplicationReal
{
    public class NOMQBS
    {
        private string xml = "< list >" +
            "< despesa >< id > 2 </ id >< valor > 900.00 </ valor ></ despesa >< despesa >< id > 2 </ id >< valor > 1299.99 </ valor ></ despesa >" + 
            "< despesa >< id > 1 </ id >< valor > 300.00 </ valor ></ despesa >< despesa >< id > 2 </ id >< valor > 560.33 </ valor ></ despesa >";

        public string retornoXml()
        {
            return xml;
        }
    }
}