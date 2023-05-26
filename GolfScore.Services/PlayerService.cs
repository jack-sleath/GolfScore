using GolfScore.Models;
using GolfScore.Models.Request;
using GolfScore.Repositories.Interfaces;
using GolfScore.Services.Interfaces;

namespace GolfScore.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public Player CreatePlayer(CreatePlayerRequest request)
        {
            var bleh = new Player("", "", "", "");
            _playerRepository.SavePlayer(bleh);
            return bleh;
        }

        public Player GetPlayer(string externalIdentifier, string authCode)
        {
            return new Player("BrianTest", "😎", "", "brian@test.com");
        }
    }
}