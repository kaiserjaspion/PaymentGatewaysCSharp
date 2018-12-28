using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManegement.Models
{
    public class PaymentCollection
    {
        public EbanxGateway.Model.Payment Ebanx { get; set; }
    }
}
