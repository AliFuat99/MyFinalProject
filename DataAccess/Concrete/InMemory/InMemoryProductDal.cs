﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { new Product {ProductID=1, CategoryID=1,ProductName="Bardak",UnitPrice=20,UnitsInStock=15},
             new Product {ProductID=2, CategoryID=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
             new Product {ProductID=3, CategoryID=2,ProductName="Telefon",UnitPrice=2500,UnitsInStock=22},
             new Product {ProductID=4, CategoryID=2,ProductName="Klavye",UnitPrice=350,UnitsInStock=10},
             new Product {ProductID=5, CategoryID=2,ProductName="Fare",UnitPrice=200,UnitsInStock=40} };       
        }
        public void Add(Product product)
        {
            _products.Add(product);   
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            Product productToDelete = productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);

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

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            //Gönderdiğim ürün ID'sine ürün sahip olan listedeki ürünü bul demek
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
