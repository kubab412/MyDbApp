using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IGymManager
    {
        bool Add(GymDto dto);
        bool Edit(GymDto dto);
        IEnumerable<GymDto> GetAll();
        bool Remove(int id);
    }
}