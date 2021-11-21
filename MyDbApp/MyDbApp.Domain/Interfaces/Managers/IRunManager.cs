using System.Collections.Generic;

namespace MyDbApp.Domain
{
    public interface IRunManager
    {
        bool Add(RunDto dto);
        bool Edit(RunDto dto);
        IEnumerable<RunDto> GetAll();
        bool Remove(int id);
    }
}