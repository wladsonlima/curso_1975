﻿using System;

namespace PaymentContext.Shared.Entities
{
    public  abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}