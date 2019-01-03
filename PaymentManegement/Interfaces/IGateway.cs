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
        bool ExecutePayment(string JsonPayment);
        string CapturePayment(string identifier);
        string CancelPayment(string identifier);
        string RefundPayment(string identifier, bool operation);
        string CheckPayment(string identifier);

    }
}
