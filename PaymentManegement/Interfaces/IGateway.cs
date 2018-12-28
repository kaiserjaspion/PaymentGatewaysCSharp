using PaymentManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace PaymentManegement.Interfaces
{
    interface IGateway
    {
        string CreatePayment(PaymentCollection collection);
        bool ExecutePaiment(string JsonPayment);

    }
}
