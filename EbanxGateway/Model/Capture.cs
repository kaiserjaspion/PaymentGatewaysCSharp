using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model
{
    public class Capture
    {
        public string Integration_key { get; set; }
        public string Hash { get; set; }
        public string Merchant_payment_code { get; set; }
    }
}
