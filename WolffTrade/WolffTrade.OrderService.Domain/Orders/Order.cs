using System;
using System.Collections.Generic;
using System.Text;
using WolffTrade.OrderService.Domain.Orders.Enuns;
using WolffTrade.OrderService.Domain.Orders.ValueObjects;

namespace WolffTrade.OrderService.Domain.Orders
{
    public class Order
    {
        public Guid Id { get; private set; }
        public Symbol Symbol { get; private set; }
        public OrderType Type { get; private set; }
        public Price Price { get; private set; }
        public Quantity Quantity { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private Order() { } // For ORM later

        public Order(
            Symbol symbol,
            OrderType type,
            Price price,
            Quantity quantity)
        {
            Id = Guid.NewGuid();
            Symbol = symbol;
            Type = type;
            Price = price;
            Quantity = quantity;
            Status = OrderStatus.Created;
            CreatedAt = DateTime.UtcNow;
        }

        public void MarkAsFilled()
        {
            Status = OrderStatus.Filled;
        }

        public void Cancel()
        {
            if (Status == OrderStatus.Filled)
                throw new InvalidOperationException("Filled orders cannot be cancelled.");

            Status = OrderStatus.Cancelled;
        }
    }
}
