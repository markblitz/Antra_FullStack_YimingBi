using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface ISupplierServiceAsync
    {
        Task<IEnumerable<SupplierResponseModel>> GetAllAsync();
        Task<int> AddSupplierAsync(SupplierRequestModel newSupplier);
    }
}
