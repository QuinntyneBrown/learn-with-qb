using Common.Data.Contracts;
using LearnWithQB.Server.Data.Contracts;
using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Data
{
    public class LearnWithQBUow : Common.Data.BaseUow, ILearnWithQBUow
    {
        public LearnWithQBUow(LearnWithQBContext LearnWithQBContext)
            : base(LearnWithQBContext) { }

        public IRepository<User> Users { get { return GetStandardRepo<User>(); } }
        public IRepository<Account> Accounts { get { return GetStandardRepo<Account>(); } }
        public IRepository<Profile> Profiles { get { return GetStandardRepo<Profile>(); } }       
        public IRepository<Role> Roles { get { return GetStandardRepo<Role>(); } }
        public IRepository<Group> Groups { get { return GetStandardRepo<Group>(); } }
        public IRepository<Session> Sessions { get { return GetStandardRepo<Session>(); } }
        public IRepository<Customer> Customers { get { return GetStandardRepo<Customer>(); } }

        public new void SaveChanges() { base.dbContext.SaveChanges(); }
    }
}
