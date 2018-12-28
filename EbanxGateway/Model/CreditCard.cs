using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model
{
    public class CreditCard
    {
        public string Card_number { get; set; }
        public string Card_name { get; set; }
        public string Card_due_date { get; set; }
        public string Card_cvv { get; set; }
        public Boolean Auto_capture { get; set; }
        public string Token { get; set; }
    }
}
