using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IGymRepository
    {
        bool Add(GymEntity entity);
        bool Edit(GymEntity entity);
        IEnumerable<GymEntity> GetAll();
        bool Remove(int id);
    }
}