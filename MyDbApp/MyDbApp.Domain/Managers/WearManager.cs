﻿using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public class WearManager
    {
        private readonly IWearRepository _repository;
        private readonly DtoMapper _dtoMapper;
        public WearManager(IWearRepository repository, DtoMapper dtoMapper)
        {
            _repository = repository;
            _dtoMapper = dtoMapper;
        }
        public IEnumerable<WearDto> GetAll()
        {
            var result = _repository.GetAll();
            return _dtoMapper.Map(result);
        }
        public bool Add(WearDto dto)
        {
            var result = _dtoMapper.Map(dto);
            return _repository.Add(result);
        }
        public bool Edit(WearDto dto)
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