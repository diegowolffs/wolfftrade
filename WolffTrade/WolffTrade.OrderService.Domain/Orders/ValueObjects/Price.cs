using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Domain.Orders.ValueObjects
{
    public sealed record Price(decimal Value)
    {
        public static Price Create(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Price must be greater than zero.");

            return new Price(value);
        }
    }
}
