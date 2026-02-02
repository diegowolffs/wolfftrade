using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Domain.Orders.ValueObjects
{
    public sealed record Quantity(int Value)
    {
        public static Quantity Create(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            return new Quantity(value);
        }
    }
}
