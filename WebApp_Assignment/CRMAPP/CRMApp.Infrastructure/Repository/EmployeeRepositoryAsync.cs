using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Entity;
using CRMApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRMApp.Infrastructure.Repository
{
    public class EmployeeRepositoryAsync : BaseRepositoryAsync<Employee>, IEmployeeRepositoryAsync
    {
        private readonly CrmDBContext db;
        public EmployeeRepositoryAsync(CrmDBContext _dbContext) : base(_dbContext)
        {
            db = _dbContext;
        }

        public async Task<IEnumerable<Employee>> GetByNameAsync(string name)
        {
            return await db.Employee.Where(
                x=>x.FirstName.Contains(name)).ToListAsync();
        }
    }
}
