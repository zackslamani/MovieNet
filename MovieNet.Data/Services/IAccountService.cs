using System;
using System.Collections.Generic;
using System.Text;
using MovieNet.Data.Models;
using System.Threading.Tasks;

namespace MovieNet.Data.Services
{
    public interface IAccountService : IDataService<Account>
    {
        Task<Account> GetByUsername(string username);
        Task<Account> GetByEmail(string email);
    }
}
