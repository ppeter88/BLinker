using AutoMapper;
using BLinkerTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest.BLinkerAPI.Services
{
    public class BonusesService
    {
        private IBLinkerMapping _mapper;

        public BonusesService(IBLinkerMapping mapper)
        {
            _mapper = mapper;
        }
        public CreateOrderDto CreateOrderWithBonus(Order order, Product product)
        {
            OrderPos additionalGood = new OrderPos
            {
                product_id = product.product_id,
                quantity = 1,
                price_brutto = product.price_brutto,
                name = product.name
            };

            order.products.Add(additionalGood);
            var orderWithBonus = _mapper.MapperOrder().Map<CreateOrderDto>(order);
            orderWithBonus.admin_comments = $"Zamówienie utworzone na podstawie zamówienia nr {order.order_id}";

            return orderWithBonus;
        }
    }
}
