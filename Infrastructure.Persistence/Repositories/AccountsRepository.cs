using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Infrastructure.Persistence.Repositories;

internal class AccountsRepository : GenericRepository<Account>, IAccountsRepository
{
    public override Task<IEnumerable<Account>> GetAll()
    {
        return Task.Run<IEnumerable<Account>>(() =>
        [
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account1"
            },
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account2"
            },
            new Account
            {
                Id = Guid.NewGuid(),
                Name = "Account3"
            }
        ]);
    }
}