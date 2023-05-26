namespace GolfScore.Services.Interfaces
{
    public interface IAuthService
    {
        bool IsPlayerAuthed(Guid PlayerId, string authCode);
        bool IsPlayerAuthed(string uniqueIdentifier, string authCode);

        //List<string> GetEmojiKeypad();
    }
}
