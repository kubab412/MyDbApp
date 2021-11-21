using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IWearRepository
    {
        bool Add(WearEntity entity);
        bool Edit(WearEntity entity);
        IEnumerable<WearEntity> GetAll();
        bool Remove(int id);
    }
}