using LearnWithQB.Server.Models;

namespace LearnWithQB.Server.Dtos
{
    public class AccountDto
    {
        public AccountDto()
        {

        }

        public AccountDto(Account account)
        {
            this.AccountStatus = account.AccountStatus;
        }

        public AccountStatus AccountStatus { get; set; }
    }
}