using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public class RunManager : IRunManager
    {
        private readonly IRunRepository _repository;
        private readonly DtoMapper _dtoMapper;
        public RunManager(IRunRepository repository, DtoMapper dtoMapper)
        {
            _repository = repository;
            _dtoMapper = dtoMapper;
        }
        public IEnumerable<RunDto> GetAll()
        {
            var result = _repository.GetAll();
            return _dtoMapper.Map(result);
        }
        public bool Add(RunDto dto)
        {
            var result = _dtoMapper.Map(dto);
            return _repository.Add(result);
        }
        public bool Edit(RunDto dto)
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
