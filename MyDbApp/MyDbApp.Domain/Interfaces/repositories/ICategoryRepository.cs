using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryEntity> GetAll();
    }
}