using System;
using System.Collections.Generic;
using System.Text;

namespace WolffTrade.OrderService.Application.Interfaces
{
    public interface IEventPublisher
    {
        Task PublishAsync<TEvent>(TEvent @event);
    }
}
