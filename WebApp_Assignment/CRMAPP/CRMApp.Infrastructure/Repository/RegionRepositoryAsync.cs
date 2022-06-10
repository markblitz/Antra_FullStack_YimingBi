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
    public class RegionRepositoryAsync : BaseRepositoryAsync<Region>, IRegionRepositoryAsync
    {
        private readonly CrmDBContext db;
        public RegionRepositoryAsync(CrmDBContext _dbContext) : base(_dbContext)
        {
            db = _dbContext;
        }
    }
}
