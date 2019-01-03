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
        private RestRequest _request;
        private string _integration_key;

        public string CreatePayment(PaymentCollection collection)
        {
            Payment = collection.Ebanx;
            _request = new RestRequest("ws/request", Method.POST);
            return JsonConvert.SerializeObject(Payment);
        }

        public bool ExecutePayment(string JsonPayment)
        {
            _request.AddBody(JsonPayment);
            IRestResponse response = Client.Execute(_request);
            Response content = JsonConvert.DeserializeObject<Response>(response.Content);
            if (content.Status.ToLower().Contains("ok"))
                return true;
            else return false;
        }

        public string CapturePayment(string identifier)
        {
            _request = new RestRequest("ws/capture", Method.POST);
            Capture capturePayment = new Capture()
            {
                Integration_key = _integration_key,
            };
            capturePayment.Hash = identifier.Contains("HASH--") ? identifier.Replace("HASH--", "") : null;
            capturePayment.Merchant_payment_code = identifier.Contains("MERC--") ? identifier.Replace("MERC--", "") : null;
            return JsonConvert.SerializeObject(capturePayment);
        }

        public string CancelPayment(string identifier)
        {
            _request = new RestRequest("ws/cancel", Method.POST);
            Capture capturePayment = new Capture()
            {
                Integration_key = _integration_key,
            };
            capturePayment.Hash = identifier.Contains("HASH--") ? identifier.Replace("HASH--", "") : null;
            capturePayment.Merchant_payment_code = identifier.Contains("MERC--") ? identifier.Replace("MERC--", "") : null;
            return JsonConvert.SerializeObject(capturePayment);
        }

        public string RefundPayment(string identifier,bool operation)
        {
            _request = new RestRequest("ws/refund", Method.POST);
            RefundPayment refundPayment = new RefundPayment()
            {
                Integration_key = _integration_key,
            };
            refundPayment.Operation = operation ? "request" : "cancel";
            refundPayment.Hash = identifier.Contains("HASH--") ? identifier.Replace("HASH--", "") : null;
            refundPayment.Merchant_refund_code = identifier.Contains("MERC--") ? identifier.Replace("MERC--", "") : null;
            return JsonConvert.SerializeObject(refundPayment);
        }

        public string CheckPayment(string identifier)
        {
            _request = new RestRequest("ws/query", Method.POST);
            Capture capturePayment = new Capture()
            {
                Integration_key = _integration_key,
            };
            capturePayment.Hash = identifier.Contains("HASH--") ? identifier.Replace("HASH--", "") : null;
            capturePayment.Merchant_payment_code = identifier.Contains("MERC--") ? identifier.Replace("MERC--", "") : null;
            return JsonConvert.SerializeObject(capturePayment);
        }
    }
}
