using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence.Contexts;
using static Domain.Hardcoded;

namespace Infrastructure.Persistence;

public static class DbSeeder
{
    private static readonly IEnumerable<Account> Accounts =
    [
        new()
        {
            Id = AccountId1,
            Name = "Account1"
        },
        new()
        {
            Id = AccountId2,
            Name = "Account2"
        },
        new()
        {
            Id = AccountId3,
            Name = "Account3"
        }
    ];

    private static readonly IEnumerable<License> Licenses =
    [
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId1,
            ServiceId = ServiceId1,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(3232523)
        },
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId1,
            ServiceId = ServiceId2,
            State = States.Expired,
            ValidTo = DateOnly.FromDayNumber(323233)
        },
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId1,
            ServiceId = ServiceId3,
            State = States.Canceled,
            ValidTo = DateOnly.FromDayNumber(342421)
        },
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId2,
            ServiceId = ServiceId1,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(3231523)
        },
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId2,
            ServiceId = ServiceId4,
            State = States.Active,
            ValidTo = DateOnly.FromDayNumber(311233)
        },
        new()
        {
            Id = Guid.NewGuid(),
            AccountId = AccountId3,
            ServiceId = ServiceId5,
            State = States.Canceled,
            ValidTo = DateOnly.FromDayNumber(312233)
        }
    ];

    public static void Seed(CloudSalesDbContext dbContext)
    {
        foreach (var account in Accounts) dbContext.Accounts.Add(account);
        foreach (var license in Licenses) dbContext.Licenses.Add(license);
        dbContext.SaveChanges();
    }
}