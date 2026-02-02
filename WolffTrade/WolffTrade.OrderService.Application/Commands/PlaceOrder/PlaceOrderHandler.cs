using System;
using System.Collections.Generic;
using System.Text;
using WolffTrade.OrderService.Application.Interfaces;
using WolffTrade.OrderService.Domain.Orders;
using WolffTrade.OrderService.Domain.Orders.Enuns;
using WolffTrade.OrderService.Domain.Orders.ValueObjects;

namespace WolffTrade.OrderService.Application.Commands.PlaceOrder
{
    public class PlaceOrderHandler
    {
        private readonly IOrderRepository _repository;
        private readonly IEventPublisher _eventPublisher;

        public PlaceOrderHandler(
            IOrderRepository repository,
            IEventPublisher eventPublisher)
        {
            _repository = repository;
            _eventPublisher = eventPublisher;
        }

        public async Task<Guid> HandleAsync(PlaceOrderCommand command)
        {
            var order = new Order(
                Symbol.Create(command.Symbol),
                Enum.Parse<OrderType>(command.OrderType, true),
                Price.Create(command.Price),
                Quantity.Create(command.Quantity)
            );

            await _repository.AddAsync(order);

            await _eventPublisher.PublishAsync(new
            {
                OrderId = order.Id,
                order.Symbol.Value,
                order.Type,
                order.Price,
                order.Quantity
            });

            return order.Id;
        }
    }
}
