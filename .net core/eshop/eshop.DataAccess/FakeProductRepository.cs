﻿using eshop.Entities;

namespace eshop.DataAccess
{
    public class FakeProductRepository : IProductRepository
    {
        private List<Product> products;
        public FakeProductRepository()
        {
            products = new()
            {
                new() { Id=1, Description="Test Açıklama", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name", Price=1},
                new() { Id=2, Description="Test Açıklama 2", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 2", Price=1},
                new() { Id=3, Description="Test Açıklama 3", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 3", Price=1},
                new() { Id=4, Description="Test Açıklama 4", DiscountRate=0.2, ImageUrl="https://cdn.dsmcdn.com/ty709/product/media/images/20230131/17/270762905/660823832/1/1_org.jpg", Name="Test Name 4", Price=1},


            };
        }
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return products;
        }

        public IList<Product> SearchProductsByName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
