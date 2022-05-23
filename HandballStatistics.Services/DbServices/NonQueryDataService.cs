using HandballStatistics.EntityFramework.Contexts;
using HandballStatistics.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Services.DbServices
{
    public class NonQueryDataService<T> where T : DomainObject
    {
        private readonly HandballStatisticsDbContext context;

        public NonQueryDataService(HandballStatisticsDbContext context)
        {
            this.context = context;
        }

        public async Task<T> Create(T entity)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                var createdResult = context.Set<T>().Add(entity);
                await context.SaveChangesAsync();

                return createdResult;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                entity.Id = id;

                entity.Id = id;
                context.Entry(entity).State = entity.Id == 0 ? EntityState.Added : EntityState.Modified;
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (HandballStatisticsDbContext context = this.context.CreateContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }
    }
}
