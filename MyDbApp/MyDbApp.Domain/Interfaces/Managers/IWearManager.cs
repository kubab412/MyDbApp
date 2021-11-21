using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IWearManager
    {
        bool Add(WearDto dto);
        bool Edit(WearDto dto);
        IEnumerable<WearDto> GetAll();
        bool Remove(int id);
    }
}