using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface ICustomerServiceAsync
    {
        Task<IEnumerable<CustomerResponseModel>> GetAllAsync();
        Task<int> AddCustomerAsync(CustomerRequestModel newCustomer);
        Task<CustomerRequestModel> GetByIdAsync(int id);
        Task<int> UpdateCustomerAsync(CustomerRequestModel newCustomer);
        Task<int> DeleteCustomerAsync(int id);
    }
}
