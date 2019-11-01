using ETZ.Common;
using ETZ.Models;
using ETZ.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETZ.Services
{
    public class PositionService : IPositionService
    {
        private readonly IRepo<Position> PositionRepo;

        public PositionService(IRepo<Position> positionRepo)
        {
            this.PositionRepo = positionRepo;
        }

        public RepoResponse Create(Position entity)
        {
            try
            {
                if(this.PositionRepo.Create(entity))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Create.Message};
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} PositionRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message =e.ToString()};
            }

           
        }

        public RepoResponse Delete(Position entity)
        {
            try
            {
                if (this.PositionRepo.Delete(entity.Id))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Delete.Message };
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} PositionRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message = e.ToString() };
            }
        }

        public IQueryable<Position> GetAll()
        {
            return this.PositionRepo.GetAll();
        }

        public Position GetSpecific(int Id)
        {
            return this.PositionRepo.GetSpecific(Id);
        }

        public RepoResponse Update(Position entity)
        {
            try
            {
                if (this.PositionRepo.Update(entity.Id, entity))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Update.Message };
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} PositionRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message = e.ToString() };
            }
        }
    }
}
