﻿using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        
    }
}
