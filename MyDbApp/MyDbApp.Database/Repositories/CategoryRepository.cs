using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyDbApp.Database
{
    public class CategoryRepository
    {
        private DbSet<CategoryEntity> _categories { get; set; }
        private MyDbAppDbContext _dbContext;
        public CategoryRepository(MyDbAppDbContext dbContext)
        {
            _dbContext = dbContext;
            _categories = dbContext.Categories;
        }

        public IEnumerable<CategoryEntity> GetAll()
        {
            return _categories.ToList<CategoryEntity>();
        }
    }
}
