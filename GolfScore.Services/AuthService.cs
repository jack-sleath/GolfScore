using GolfScore.Services.Interfaces;

namespace GolfScore.Services
{
    public class AuthService : IAuthService
    {
        public static List<string> GetEmojiKeypad = new List<string> { "🐈", "🏌", "😎", "🤠", "🤓", "😘", "🚗", "🍔", "🔥" };

        public bool IsPlayerAuthed(Guid PlayerId, string authCode)
        {
            throw new NotImplementedException();
        }

        public bool IsPlayerAuthed(string uniqueIdentifier, string authCode)
        {
            throw new NotImplementedException();
        }
    }
}
