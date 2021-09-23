using AutoMapper;
using BLinkerTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLinkerTest
{
    public class BLinkerMappingProfile : IBLinkerMapping
    {
        public Mapper MapperOrder()
        {
            var orderConfig = new MapperConfiguration(cfg => cfg.CreateMap<Order, CreateOrderDto>());
            var orderMapper = new Mapper(orderConfig);
            return orderMapper;
        }
    }
}
