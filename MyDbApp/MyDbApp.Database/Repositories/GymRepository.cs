using Microsoft.EntityFrameworkCore;
using MyDbApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MyDbApp.Database
{
    public class GymRepository
    {
        private DbSet<GymEntity> gymAccessories { get; set; }
        private MyDbAppDbContext _dbContext;
        public GymRepository(MyDbAppDbContext dbContext)
        {
            _dbContext = dbContext;
            gymAccessories = dbContext.GymAccessories;
        }

        public IEnumerable<GymEntity> GetAll()
        {
            return gymAccessories.ToList<GymEntity>();
        }
        public bool Add(GymEntity entity)
        {
            gymAccessories.Add(entity);
            return _dbContext.SaveChanges() >0;
        }
        public bool Edit(GymEntity entity)
        {
            var result = gymAccessories.FirstOrDefault(x => x.Id == entity.Id);
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
            var result = gymAccessories.FirstOrDefault(x => x.Id==id);
            gymAccessories.Remove(result);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
