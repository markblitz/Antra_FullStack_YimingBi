using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMApp.Core.Entity;

namespace CRMApp.Core.Contract.Repository
{
    public interface IEmployeeRepositoryAsync : IRepositoryAsync<Employee>
    {
        Task<IEnumerable<Employee>> GetByNameAsync(string name);
    }
}
