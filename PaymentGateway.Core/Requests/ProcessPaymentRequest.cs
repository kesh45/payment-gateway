﻿using PaymentGateway.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Core.Requests
{
    public class ProcessPaymentRequest : IPayment
    {
        public Guid Id { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public uint ExpiryYear { get; set; }
        public uint ExpiryMonth { get; set; }
        public uint Amount { get; set; }
        public string Currency { get; set; }
        public string Cvv { get; set; }
        public bool BankSuccess { get; set; }
    }
}
