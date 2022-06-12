using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Contract.Service;
using CRMApp.Core.Entity;
using CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Service
{
    public class RegionServiceAsync : IRegionServiceAsync
    {
        private readonly IRegionRepositoryAsync regionRepositoryAsync;
        public RegionServiceAsync(IRegionRepositoryAsync regionRepository)
        {
            regionRepositoryAsync = regionRepository;
        }
        public async Task<int> AddRegionAsync(RegionModel newRegion)
        {
            Region region = new Region();
            region.Name = newRegion.Name;
            return await regionRepositoryAsync.InsertAsync(region);
        }

        public async Task<int> DeleteRegionAsync(int id)
        {
            return await regionRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<RegionModel>> GetAllAsync()
        {
            var collection = await regionRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<RegionModel> result = new List<RegionModel>();
                foreach(var item in collection)
                {
                    RegionModel region = new RegionModel();
                    region.Id = item.Id;
                    region.Name = item.Name;
                    result.Add(region);
                }
                return result;
            }
            return null;
        }

        public async Task<RegionModel> GetByIdAsync(int id)
        {
            var item = await regionRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                RegionModel region = new RegionModel();
                region.Id = item.Id;
                region.Name = item.Name;
                return region;
            }
            return null;
        }

        public async Task<int> UpdateRegionAsync(RegionModel newRegion)
        {
            Region region = new Region();
            region.Id = newRegion.Id;
            region.Name = newRegion.Name;
            return await regionRepositoryAsync.UpdateAsync(region);
        }
    }
}
