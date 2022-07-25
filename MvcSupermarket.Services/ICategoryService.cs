using MvcSupermarket.Models;

namespace MvcSupermarket.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category Get(int id);
        void Create(Category product);
        void Delete(int id);
        void Update(Category product);
    }
}
