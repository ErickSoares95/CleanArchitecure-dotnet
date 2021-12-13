using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public interface IProductService
    {

        ProductViewModel GetById(int id);

    }
}
