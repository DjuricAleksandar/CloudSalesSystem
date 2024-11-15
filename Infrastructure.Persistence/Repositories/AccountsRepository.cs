﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Repositories;

internal class AccountsRepository(CloudSalesDbContext cloudSalesDbContext)
    : GenericRepository<Account>(cloudSalesDbContext), IAccountsRepository;