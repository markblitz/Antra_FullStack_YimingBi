using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Contract.Service;
using CRMApp.Core.Entity;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Service
{
    public class SupplierServiceAsync : ISupplierServiceAsync
    {
        private readonly ISupplierRepositoryAsync supplierRepositoryAsync;
        public SupplierServiceAsync(ISupplierRepositoryAsync supplierRepository)
        {
            supplierRepositoryAsync = supplierRepository;
        }

        public async Task<int> AddSupplierAsync(SupplierRequestModel newSupplier)
        {
            Supplier supplier = new Supplier();
            supplier.Address = newSupplier.Address;
            supplier.City = newSupplier.City;
            supplier.CompanyName = newSupplier.CompanyName;
            supplier.ContactName = newSupplier.ContactName;
            supplier.ContactTitle = newSupplier.ContactTitle;
            supplier.Country = newSupplier.Country;
            supplier.Id = newSupplier.Id;
            supplier.Phone = newSupplier.Phone;
            supplier.PostalCode = newSupplier.PostalCode;
            supplier.RegionId = newSupplier.RegionId;
            return await supplierRepositoryAsync.InsertAsync(supplier);
        }

        public async Task<IEnumerable<SupplierResponseModel>> GetAllAsync()
        {
            var collection = await supplierRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<SupplierResponseModel> result = new List<SupplierResponseModel>();
                foreach (var item in collection)
                {
                    SupplierResponseModel supplierResponse = new SupplierResponseModel();
                    supplierResponse.City = item.City;
                    supplierResponse.CompanyName = item.CompanyName;
                    supplierResponse.Id = item.Id;
                    result.Add(supplierResponse);
                }
                return result;
            }
            return null;
        }
    }
}
