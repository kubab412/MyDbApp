using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface ISwimRepository
    {
        bool Add(SwimEntity entity);
        bool Edit(SwimEntity entity);
        IEnumerable<SwimEntity> GetAll();
        bool Remove(int id);
    }
}