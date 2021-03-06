using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HandballStatistics.Services.DbServices
{
    public class AccountDataService : IAccountDataService
    {
        private readonly HandballStatisticsDbContext context;

        private readonly NonQueryDataService<Account> nonQueryDataService;

        public AccountDataService(HandballStatisticsDbContext context)
        {
            this.context = context;
            this.nonQueryDataService = new NonQueryDataService<Account>(context);
        }

        public async Task<Account> Create(Account entity)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await this.nonQueryDataService.Create(entity);
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await this.nonQueryDataService.Delete(id);
            }
        }

        public async Task<Account> Update(int id, Account entity)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await this.nonQueryDataService.Update(id, entity);
            }
        }

        public async Task<Account> Get(int id)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                Account entity = await context.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                IEnumerable<Account> entities = await context.Accounts
                    .Include(a => a.AccountHolder)
                    .ToListAsync();
                return entities;
            }
        }

        public Task<bool> Init()
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                try
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                }
                catch (SqlException)
                {
                    return Task.FromResult(false);
                }

                return Task.FromResult(true);
            }
        }

        public async Task<Account> GetByEmail(string email)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await context.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync(a => a.AccountHolder.Email == email);
            }
        }

        public async Task<Account> GetByUsername(string username)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await context.Accounts
                    .Include(a => a.AccountHolder)
                    .FirstOrDefaultAsync(a => a.AccountHolder.UserName == username);
            }
        }
    }
}
