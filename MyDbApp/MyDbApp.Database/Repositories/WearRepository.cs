using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyDbApp.Database
{
    public class WearRepository : IWearRepository
    {
        private DbSet<WearEntity> wears { get; set; }
        private MyDbAppDbContext _dbContext;
        public WearRepository(MyDbAppDbContext dbContext)
        {
            _dbContext = dbContext;
            wears = dbContext.Wears;
        }

        public IEnumerable<WearEntity> GetAll()
        {
            return wears.ToList<WearEntity>();
        }
        public bool Add(WearEntity entity)
        {
            wears.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Edit(WearEntity entity)
        {
            var result = wears.FirstOrDefault(x => x.Id == entity.Id);
            if (result != null)
            {
                result.Name = entity.Name;
                result.Count = entity.Count;
                result.Place = entity.Place;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        public bool Remove(int id)
        {
            var result = wears.FirstOrDefault(x => x.Id == id);
            wears.Remove(result);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
