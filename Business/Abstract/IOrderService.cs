using System;
using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
    }
}