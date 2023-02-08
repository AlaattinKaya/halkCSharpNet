﻿using eshop.DataAccess;
using eshop.Entities;

namespace eshop.Application.Services
{
    public class ProductService
    {
        //Presentation (MVC)'dan gelen talebi işle ve DataAccess'e ilet.

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        private IProductRepository productRepository;
        public IList<Product> GetAllProducts()
        {
            return productRepository.GetAll();
        }
    }
}
