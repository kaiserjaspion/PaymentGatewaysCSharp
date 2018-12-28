using System;
using System.Collections.Generic;
using System.Text;


namespace EbanxGateway.Model
{
    public class EbanxPayment
    {
        public string Integration_key { get; set; }
        public Payment Payment { get; set; }
        public string Redirect_url { get; set; }
        public string Operation { get; set; }

    }
}
