using System.Net.Http;

namespace LearnWithQB.Server.Services.Contracts
{
    public interface IProfileService
    {
        dynamic GetCurrentProfile(HttpRequestMessage request);
        void UpdateIsPersonalizedFlag(HttpRequestMessage request);
    }
}