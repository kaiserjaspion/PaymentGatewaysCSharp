using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model
{
    public class Response
    {
        public string Redirect_url { get; set; }
        public ResponsePayment Payment { get; set; }
        public string Status { get; set; }
    }
}
