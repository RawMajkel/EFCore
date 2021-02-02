using System;
using System.Collections.Generic;
using EFCore.Persistance.Model;

namespace EFCore.Core.Services
{
    public interface IDbService
    {
        void EnsureCreated();
        Team ShowLazyLoading();
        IEnumerable<Team> ForeachProblem();
        void DeleteTeam(Guid teamId);
    }
}
