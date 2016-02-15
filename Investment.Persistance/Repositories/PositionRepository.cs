using System;
using System.Collections.Generic;
using System.Linq;
using Investment.Domain;
using Investment.Domain.Interfaces;

namespace Investment.Persistance.Repositories
{
    public class PositionRepository : BaseRepository<Position>, IPositionRepository
    {
        public PositionRepository(IDbContextProvider dbContextProvider) : base(dbContextProvider){}

        public override void AddOrUpdate(Position element)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Position element)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Position> Get()
        {
            return Context.Positions;
        }

        public override Position GetByKey(string Key)
        {
            return Context.Positions.FirstOrDefault(i => i.Key == Key);
        }
    }
}
