using HandballStatistics.Interfaces.Services;
using HandballStatistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.Services
{
    public interface IAccountDataService : IDataService<Account>
    {
        Task<Account> GetByUsername(string username);

        Task<Account> GetByEmail(string email);
    }
}
