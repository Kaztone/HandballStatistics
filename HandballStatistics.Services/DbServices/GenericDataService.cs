using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.EntityFramework.Factories;
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
        public HandballStatisticsDbContext context;

        public GenericDataService()
        {
            this.context = new HandballStatisticsDbContextFactory().Context;
        }

        public async Task<T> Create(T entity)
        {
            using (HandballStatisticsDbContext context = this.context)
            {
                var createdResult = context.Set<T>().Add(entity);
                await context.SaveChangesAsync();

                return createdResult;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (HandballStatisticsDbContext context = this.context)
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (HandballStatisticsDbContext context = this.context)
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (HandballStatisticsDbContext context = this.context)
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public Task<bool> Init()
        {
            using (HandballStatisticsDbContext context = this.context)
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

        public async Task<T> Update(int id, T entity)
        {
            using (HandballStatisticsDbContext context = this.context)
            {
                entity.Id = id;
                context.Entry(entity).State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
