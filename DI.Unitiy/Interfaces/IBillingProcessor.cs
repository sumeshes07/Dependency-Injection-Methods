﻿namespace DI.Unitiy.Interfaces
{
    public interface IBillingProcessor
    {
        void ProcessPayment(string customer, string creditCard, double price);
    }
}
