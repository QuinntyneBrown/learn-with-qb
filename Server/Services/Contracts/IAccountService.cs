using System.Net.Http;

namespace LearnWithQB.Server.Services.Contracts
{
    public interface IAccountService
    {
        dynamic GetCurrentAccount(HttpRequestMessage request);

        dynamic GetBilling(HttpRequestMessage request);
    }
}