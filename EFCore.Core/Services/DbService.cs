using EFCore.Persistance;
using EFCore.Persistance.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Core.Services
{
    public class DbService : IDbService
    {
        private readonly EfCoreContext _efCoreContext;

        public DbService(EfCoreContext efCoreContext)
        {
            _efCoreContext = efCoreContext;
        }

        public void EnsureCreated() => _efCoreContext.Database.EnsureCreated();

        public Team ShowLazyLoading() => _efCoreContext.Teams.FirstOrDefault();

        public IEnumerable<Team> ForeachProblem()
        {
            var teams = _efCoreContext.Teams.ToList();

            foreach (var team in teams)
            {
                foreach (var member in _efCoreContext.TeamMembers.Where(t => t.Id == team.Id))
                {
                    team.Members.Add(member);
                }
            }

            return teams;
        }

        public void DeleteTeam(Guid teamId)
        {
            if (teamId != Guid.Empty)
            {
                var team = _efCoreContext.Teams.FirstOrDefault(x => x.Id == teamId);
                _efCoreContext.RemoveRange(team.Members);
                _efCoreContext.Remove(team);

                _efCoreContext.SaveChanges();
            }
        }
    }
}
