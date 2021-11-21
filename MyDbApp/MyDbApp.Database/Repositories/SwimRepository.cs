using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyDbApp.Database
{
    public class SwimRepository : ISwimRepository
    {
        private DbSet<SwimEntity> swimAccessories { get; set; }
        private MyDbAppDbContext _dbContext;
        public SwimRepository(MyDbAppDbContext dbContext)
        {
            _dbContext = dbContext;
            swimAccessories = dbContext.SwimAccessories;
        }

        public IEnumerable<SwimEntity> GetAll()
        {
            return swimAccessories.ToList<SwimEntity>();
        }
        public bool Add(SwimEntity entity)
        {
            swimAccessories.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Edit(SwimEntity entity)
        {
            var result = swimAccessories.FirstOrDefault(x => x.Id == entity.Id);
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
            var result = swimAccessories.FirstOrDefault(x => x.Id == id);
            swimAccessories.Remove(result);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
