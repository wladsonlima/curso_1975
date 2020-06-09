using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime? ExpireData { get; set; }
        public bool Active { get; set; }
        public List<Payment> Payments { get; set; }
    }
}