using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }


        public BoletoPayment(DateTime date, DateTime expireDate, decimal total, decimal totalPaid, string payer,
            Document document, Address address, Email email, string barCode, string boletoNumber) : base(date, expireDate,
            total, totalPaid, payer, document, address, email)
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }
    }
}