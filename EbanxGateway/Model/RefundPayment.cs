using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model
{
    public class RefundPayment
    {
        public string Integration_key { get; set; }
        public string Operation { get; set; }
        public string Merchant_refund_code { get; set; }
        public string Hash { get; set; }
        public string Amout { get; set; }
        public string Description { get; set; }
    }
}
