using Application1.Data;
using System.Collections.Generic;

namespace Application1.Service.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        bool SaveProduct(Product product);
        bool UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
    }
}
