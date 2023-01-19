using RunningActivityTracker.Entities;
using System.Collections.Generic;

namespace RunningActivityTracker.Repositories
{
    internal class TeamRepository : ITeamRepository
    {
        public void AddTeamMember(TeamEntity team, UserEntity member)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public void CreateTeam(TeamEntity team)
        {
            throw new System.NotImplementedException();
        }

        public TeamEntity FindTeamByAdmin(string userName)
        {
            throw new System.NotImplementedException();
        }

        public TeamEntity FindTeamByMember(string userName)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TeamEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}