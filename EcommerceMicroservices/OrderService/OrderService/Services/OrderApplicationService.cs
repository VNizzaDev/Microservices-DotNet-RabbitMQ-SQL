﻿using Microsoft.EntityFrameworkCore;
using OrderService.Models;
using OrderService.Repositories.Contracts;
using OrderService.Services.Contracts;

namespace OrderService.Services
{
    public class OrderApplicationService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderApplicationService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _repository.GetAllOrdersAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            return await _repository.GetOrderByIdAsync(id);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _repository.AddOrderAsync(order);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            await _repository.UpdateOrderAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _repository.DeleteOrderAsync(id);
        }
    }
}
