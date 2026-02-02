using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Domain.Orders.Enuns
{
    public enum OrderStatus
    {
        Created = 1,
        PartiallyFilled = 2,
        Filled = 3,
        Cancelled = 4
    }
}
