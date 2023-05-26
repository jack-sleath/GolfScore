using GolfScore.Models;
using GolfScore.Repositories.Interfaces;

namespace GolfScore.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public bool IsExistingUniqueIdentifier(string uniqueIdentifier)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(string uniqueIdentifier)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayer(Guid playerId)
        {
            throw new NotImplementedException();
        }

        public Player SavePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public void DeletePlayer(string externalIdentifier)
        {
            throw new NotImplementedException();
        }
    }
}