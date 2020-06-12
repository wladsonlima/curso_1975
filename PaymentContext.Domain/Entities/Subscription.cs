using System;
using System.Collections.Generic;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription :Entity
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireData)
        {
            CreateDate = DateTime.Now;
            LastUpdate = DateTime.Now;
            ExpireData = expireData;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public DateTime? ExpireData { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get; }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            LastUpdate = DateTime.Now;
        }
        
        public void Inactivate()
        {
            Active = false;
            LastUpdate = DateTime.Now;
        }
    }
}