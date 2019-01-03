using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model.Partial
{
    public class Refunds
    {
        public string Id { get; set; }
        public string Merchant_refund_code { get; set; }
        public string Status { get; set; }
        public DateTime? Request_date { get; set; }
        public DateTime? Pending_date { get; set; }
        public DateTime? Confirm_date { get; set; }
        public DateTime? Cancel_date { get; set; }
        public string Amount_ext { get; set; }
        public string Description { get; set; }
    }
}
