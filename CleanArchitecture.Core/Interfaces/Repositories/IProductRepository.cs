using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Product GetById(int id);

        void Add(Product product);
    }
}
