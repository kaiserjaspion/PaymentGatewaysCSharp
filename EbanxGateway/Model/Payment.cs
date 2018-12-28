using System;
using EbanxGateway.Enums;


namespace EbanxGateway.Model
{
    public class Payment
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Zipcode { get; set; }
        public string Address { get; set; }
        public string Street_number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone_number { get; set; }
        public string Country { get; set; }
        public string Payment_type_code { get; set; }
        public string Merchant_payment_code { get; set; }
        public string Currency_code { get; set; }
        public string Person_type { get; set; }
        public string Eft_code { get; set; } // unique Eft
        public float Amount { get; set; }
        public float Amount_total { get; set; }
        public int Instalments { get; set; }
        public CreditCard Creditcard { get; set; }
        public Responsible Responsible { get; set; }
    }
}
