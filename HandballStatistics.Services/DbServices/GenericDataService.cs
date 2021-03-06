using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HandballStatistics.Services.DbServices
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly HandballStatisticsDbContext context;
        private readonly NonQueryDataService<T> nonQueryDataService;

        public GenericDataService(HandballStatisticsDbContext context)
        {
            this.context = context;
            this.nonQueryDataService = new NonQueryDataService<T>(context);
        }

        public async Task<T> Create(T entity)
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

        public async Task<T> Update(int id, T entity)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                return await this.nonQueryDataService.Update(id, entity);
            }
        }

        public async Task<T> Get(int id)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
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
    }
}
