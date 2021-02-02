using EFCore.Core.Services;
using EFCore.Persistance;
using System;

namespace EFCore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbService = new DbService(new EfCoreContext());
            dbService.EnsureCreated();

            /* lazy loading */
            var testTeamWithMembers = dbService.ShowLazyLoading();

            /* lazy loading */
            var foreachTeams = dbService.ForeachProblem();

            /* delete with members */
            dbService.DeleteTeam(Guid.Parse("8E3C5F4C-1CEF-4620-B521-0871CC0019F4"));
        }
    }
}
