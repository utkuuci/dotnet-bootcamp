using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}