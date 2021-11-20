using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyDbApp.Database
{
    public class RunRepository
    {
        private DbSet<RunEntity> runAccessories { get; set; }
        private MyDbAppDbContext _dbContext;
        public RunRepository(MyDbAppDbContext dbContext)
        {
            _dbContext = dbContext;
            runAccessories = dbContext.RunAccessories;
        }

        public IEnumerable<RunEntity> GetAll()
        {
            return runAccessories.ToList<RunEntity>();
        }
        public bool Add(RunEntity entity)
        {
            runAccessories.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Edit(RunEntity entity)
        {
            var result = runAccessories.FirstOrDefault(x => x.Id == entity.Id);
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
            var result = runAccessories.FirstOrDefault(x => x.Id == id);
            runAccessories.Remove(result);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
