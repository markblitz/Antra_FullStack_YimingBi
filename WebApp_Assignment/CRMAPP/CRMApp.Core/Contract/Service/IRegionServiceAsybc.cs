using CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface IRegionServiceAsync
    {
        Task<IEnumerable<RegionModel>> GetAllAsync();
        Task<int> AddRegionAsync(RegionModel newRegion);
    }
}
