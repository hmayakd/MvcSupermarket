using MvcSupermarket.Models;

namespace MvcSupermarket.Services
{
    internal class CategoryService : ICategoryService
    {
        static List<Category> _categories = new List<Category>();
        public void Create(Category category)
        {
            if (category != null)
            {
                _categories.Add(category);
            }
        }

        public void Delete(int id)
            => _categories.RemoveAll(c => c.Id == id);

        public Category Get(int id)
            => _categories.First(c => c.Id == id);

        public IEnumerable<Category> GetAll()
            => _categories;

        public void Update(Category category)
        {
            Category? currentCategory = _categories.FirstOrDefault(c => c.Id == category?.Id);
            int index = -1;
            if (currentCategory != null)
                index = _categories.IndexOf(currentCategory);
            if (category != null)
                _categories[index] = category;
        }
    }
}