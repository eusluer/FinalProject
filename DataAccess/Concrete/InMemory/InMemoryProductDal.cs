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
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;   
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
