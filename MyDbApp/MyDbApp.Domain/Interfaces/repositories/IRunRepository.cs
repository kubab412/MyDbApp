using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IRunRepository
    {
        bool Add(RunEntity entity);
        bool Edit(RunEntity entity);
        IEnumerable<RunEntity> GetAll();
        bool Remove(int id);
    }
}