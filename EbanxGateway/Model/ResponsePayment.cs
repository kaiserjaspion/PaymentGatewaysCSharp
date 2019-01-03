using EbanxGateway.Model.Partial;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbanxGateway.Model
{
    public class ResponsePayment
    {
        public string Hash { get; set; }
        public string Pin { get; set; }
        public string Country { get; set; }
        public string Merchant_payment_code { get; set; }
        public string Order_number { get; set; }
        public string Status { get; set; }
        public DateTime? Status_date { get; set; }
        public DateTime? Open_date { get; set; }
        public DateTime? Confirm_date { get; set; }
        public DateTime? Transfer_date { get; set; }
        public string Amount_br { get; set; }
        public string Amount_ext { get; set; }
        public string Amount_iof { get; set; }
        public string Currency_rate { get; set; }
        public string Currency_ext { get; set; }
        public string Due_date { get; set; }
        public int Intalments { get; set; }
        public string Payment_type_code { get; set; }
        public string Voucher_url { get; set; }
        public string Boleto_url { get; set; }
        public string Boleto_barcode { get; set; }
        public string Boleto_barcode_raw { get; set; }
        public string Oxxo_url { get; set; }
        public string Oxxo_barcode { get; set; }
        public string Clabe_account { get; set; }
        public string Clabe_reference { get; set; }
        public string Spei_url { get; set; }
        public string Redirect_url { get; set; }
        public string Cip_url { get; set; }
        public string Cip_code { get; set; }
        public Details Details { get; set; }
        public TransactionStatus Transaction_status { get; set; }
        public bool Pre_approved { get; set; }
        public bool? Capture_available { get; set; }
        public Customer Customer { get; set; }
        public Refunds Refunds { get; set; }
    }
}
