using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();   // List<Product> GetAll();   -  IDataResult< T >
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);    // void Add(Product product);
        IDataResult<Product> GetById(int id);  // Product GetById(int id);
    }
}
