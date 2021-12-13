using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(ProductInputModels productInputModel)
        {
            var product = new Product();

            _productRepository.Add(product);
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.GetById(id);
            
            
            return new ProductViewModel(product.Title, product.Price);
        }
    }
}
