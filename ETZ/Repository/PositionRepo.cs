using System.Linq;
using ETZ.Data;
using ETZ.Models;
using Microsoft.EntityFrameworkCore;

namespace ETZ.Repository
{
    public class PositionRepo : IRepo<Position>
    {
        private readonly AppDbContext _appDbContext;

        public PositionRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool Create(Position entity)
        {
            _appDbContext.Positions.Add(entity);
            _appDbContext.SaveChanges();

            return true;
        }

        public bool Delete(int key)
        {
            var firestation = _appDbContext.Positions.Find(key);
            if (firestation == null)
            {
                return false;
            }

            _appDbContext.Positions.Remove(firestation);
            _appDbContext.SaveChanges();

            return true;
        }

        public IQueryable<Position> GetAll()
        {
            return _appDbContext.Positions;
        }

        public Position GetSpecific(int Id)
        {
            return _appDbContext.Positions.Find(Id);
        }

        public bool Update(int key, Position entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;

            try
            {
                _appDbContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw e;
            }

            return true;
        }

        private bool FirestationExists(int id)
        {
            return _appDbContext.Positions.Count(e => e.Id == id) > 0;
        }
    }
}
