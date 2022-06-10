using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Entity;
using CRMApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Repository
{
    public class CategoryRepositoryAsync : BaseRepositoryAsync<Category>, ICategoryRepositoryAsync
    {
        private readonly CrmDBContext db;
        public CategoryRepositoryAsync(CrmDBContext _dbContext) : base(_dbContext)
        {
            this.db = _dbContext;
        }
    }
}
