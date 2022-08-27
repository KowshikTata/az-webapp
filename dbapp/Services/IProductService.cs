using dbapp.Models;

namespace dbapp.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}