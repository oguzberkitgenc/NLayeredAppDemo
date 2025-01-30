using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System.Data.Entity.Infrastructure;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch 
            {
                throw new Exception("Silme gerçekleşemedi");
            }
        }

        public List<Product> GetAll()
        {
            // Business code
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
