using System;
using System.Collections.Generic;
using System.Text;
using WolffTrade.OrderService.Domain.Orders;

namespace WolffTrade.OrderService.Application.Interfaces
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
    }
}
