using Common.Data.Contracts;
using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Data.Contracts
{
    public interface ILearnWithQBUow
    {
        IRepository<User> Users { get; }
        IRepository<Account> Accounts { get; }
        IRepository<Profile> Profiles { get; }
        IRepository<Role> Roles { get;}        
        IRepository<Group> Groups { get; }
        IRepository<Session> Sessions { get; }
        IRepository<Customer> Customers { get; }
        
        void SaveChanges();
    }
}
