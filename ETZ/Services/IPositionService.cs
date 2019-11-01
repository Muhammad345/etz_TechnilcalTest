using ETZ.Common;
using ETZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETZ.Services
{
    public interface IPositionService
    {
        public RepoResponse Create(Position entity);
        public RepoResponse Update(Position entity);
        public RepoResponse Delete(Position entity);
        public IQueryable<Position> GetAll();
        public Position GetSpecific(int Id);
    }
}
