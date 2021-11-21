using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface ICategoryManager
    {
        IEnumerable<CategoryDto> GetAll();
    }
}