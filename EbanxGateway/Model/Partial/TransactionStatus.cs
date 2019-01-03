using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model.Partial
{
    public class TransactionStatus
    {
        public string Acquirer { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Authcode { get; set; }
    }
}
