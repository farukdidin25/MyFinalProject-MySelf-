using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15,UnitInStock=1240},
                new Product { ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=165,UnitInStock=1240},
                new Product { ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=154,UnitInStock=1020},
                new Product { ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=152,UnitInStock=12010},
                new Product { ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=1115,UnitInStock=1200}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetAllByCategory(int categoryId) //sql select *
        {
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }


        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId=product.ProductId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitInStock=product.UnitInStock;

        }
    }
}
