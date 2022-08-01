using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MonogDb
            _products = new List<Product> {

                new Product{CategoryId=1,ProductID=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{CategoryId=1,ProductID=2,ProductName="Kamera",UnitPrice=300,UnitsInStock=3},
                new Product{CategoryId=2,ProductID=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{CategoryId=2,ProductID=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{CategoryId=2,ProductID=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

    

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID); 
            _products.Remove(productToDelete);  
        }

    

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;   
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
           return _products.Where(p => p.CategoryId == categoryID).ToList();    
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToDUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToDUpdate.ProductName=product.ProductName;
            productToDUpdate.CategoryId=product.CategoryId;
            productToDUpdate.UnitPrice=product.UnitPrice;
            productToDUpdate.UnitsInStock=product.UnitsInStock;
        }

     
    }
}
