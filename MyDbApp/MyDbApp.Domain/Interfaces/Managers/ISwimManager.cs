using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface ISwimManager
    {
        bool Add(SwimDto dto);
        bool Edit(SwimDto dto);
        IEnumerable<SwimDto> GetAll();
        bool Remove(int id);
    }
}