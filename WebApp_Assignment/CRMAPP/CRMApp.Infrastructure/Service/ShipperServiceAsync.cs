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
    public class ShipperServiceAsync : IShipperServiceAsync
    {
        private readonly IShipperRepositoryAsync shipperRepositoryAsync;
        public ShipperServiceAsync(IShipperRepositoryAsync shipperRepository)
        {
            shipperRepositoryAsync = shipperRepository;
        }

        public async Task<int> AddShipperAsync(ShipperModel newShipper)
        {
            Shipper shipper = new Shipper();
            shipper.Id = newShipper.Id;
            shipper.Name = newShipper.Name;
            shipper.Phone = newShipper.Phone;
            return await shipperRepositoryAsync.InsertAsync(shipper);
        }

        public async Task<IEnumerable<ShipperModel>> GetAllAsync()
        {
            var collection = await shipperRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<ShipperModel> result = new List<ShipperModel>();
                foreach(var item in collection)
                {
                    ShipperModel shipper = new ShipperModel();
                    shipper.Id = item.Id;
                    shipper.Name = item.Name;
                    shipper.Phone = item.Phone;
                    result.Add(shipper);
                }
                return result;
            }
            return null;
        }
    }
}
