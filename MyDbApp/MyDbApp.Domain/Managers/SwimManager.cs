using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public class SwimManager
    {
        private readonly ISwimRepository _repository;
        private readonly DtoMapper _dtoMapper;
        public SwimManager(ISwimRepository repository, DtoMapper dtoMapper)
        {
            _repository = repository;
            _dtoMapper = dtoMapper;
        }
        public IEnumerable<SwimDto> GetAll()
        {
            var result = _repository.GetAll();
            return _dtoMapper.Map(result);
        }
        public bool Add(SwimDto dto)
        {
            var result = _dtoMapper.Map(dto);
            return _repository.Add(result);
        }
        public bool Edit(SwimDto dto)
        {
            var result = _dtoMapper.Map(dto);
            return _repository.Edit(result);
        }
        public bool Remove(int id)
        {
            return _repository.Remove(id);
        }
    }
}
