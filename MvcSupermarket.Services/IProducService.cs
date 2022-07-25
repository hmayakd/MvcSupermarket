using MvcSupermarket.Models;

namespace MvcSupermarket.Services
{
    public interface IProducService
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void Create(Product product);
        void Delete(int id);
        void Update(Product product);
    }
}
