using System.Threading.Tasks;
using LearnWithQB.Server.Dtos;
using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Services.Contracts
{
    public interface ISessionService
    {
        TokenDto StartSession(int id);

        TokenDto StartSession(User user);

        void EndSession(int sessionId);

        Session GetSession(int sessionId);

        Session GetSession(User user);

        void UpdateSession(Session session);

        UserDto GetCurrentUser(int sessionId);

        Task<UserDto> GetCurrentUser(string username);
    }
}