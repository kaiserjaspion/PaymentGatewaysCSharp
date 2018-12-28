using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentManegement.Models;

namespace PaymentManegement.Interfaces.Paypal
{
    public class Paypal : IGateway
    {
        public string CreatePayment(PaymentCollection collection)
        {
            throw new NotImplementedException();
        }

        public bool ExecutePaiment(string JsonPayment)
        {
            throw new NotImplementedException();
        }
    }
}
