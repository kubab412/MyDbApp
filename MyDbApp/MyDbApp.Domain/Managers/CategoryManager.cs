using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbApp.Domain
{
    public class CategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly DtoMapper _dtoMapper;
        public CategoryManager(ICategoryRepository categoryRepository, DtoMapper dtoMapper)
        {
            _categoryRepository = categoryRepository;
            _dtoMapper = dtoMapper;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var result =  _categoryRepository.GetAll();
            return _dtoMapper.Map(result);
        }
    }
}
