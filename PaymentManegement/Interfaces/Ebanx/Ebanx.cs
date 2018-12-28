using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentManegement.Models;
using EbanxGateway.Model;
using Newtonsoft.Json;
using RestSharp;

namespace PaymentManegement.Interfaces.Ebanx
{
    public class Ebanx : IGateway
    {

        private Payment Payment = new Payment();
        private readonly RestClient Client = new RestClient("https://sandbox.ebanxpay.com/");
        private RestRequest _request = new RestRequest("ws/request", Method.POST);

        public string CreatePayment(PaymentCollection collection)
        {
            Payment = collection.Ebanx;
            return JsonConvert.SerializeObject(Payment);
        }

        public bool ExecutePaiment(string JsonPayment)
        {
            _request.AddBody(JsonPayment);
            IRestResponse response = Client.Execute(_request);
            var content = response.Content;
            
            return true;
        }
    }
}
