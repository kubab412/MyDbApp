using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public class GymManager : IGymManager
    {
        private readonly IGymRepository _repository;
        private readonly DtoMapper _dtoMapper;
        public GymManager(IGymRepository repository, DtoMapper dtoMapper)
        {
            _repository = repository;
            _dtoMapper = dtoMapper;
        }
        public IEnumerable<GymDto> GetAll()
        {
            var result = _repository.GetAll();
            return _dtoMapper.Map(result);
        }
        public bool Add(GymDto dto)
        {
            var result = _dtoMapper.Map(dto);
            return _repository.Add(result);
        }
        public bool Edit(GymDto dto)
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
