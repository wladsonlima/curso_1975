﻿using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(DateTime date, DateTime expireDate, decimal total, decimal totalPaid, string payer,
            Document document, Address address, Email email, string cardHolderName, string cardNumber,
            string lastTransactionNumber) : base(date, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}