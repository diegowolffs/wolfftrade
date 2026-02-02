using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Domain.Orders.ValueObjects
{
    public sealed record Symbol(string Value)
    {
        public static Symbol Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Symbol is required.");

            return new Symbol(value.ToUpper());
        }
    }
}
