using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Application.Commands.PlaceOrder
{
    public sealed record PlaceOrderCommand(
        string Symbol,
        int Quantity,
        decimal Price,
        string OrderType
    );
}
