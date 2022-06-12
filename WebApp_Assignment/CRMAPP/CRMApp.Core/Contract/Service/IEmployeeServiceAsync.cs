using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface IEmployeeServiceAsync
    {
        Task<IEnumerable<EmployeeResponseModel>> GetAllAsync();
        Task<int> AddEmployeeAsync(EmployeeRequestModel newEmployee);
        Task<EmployeeRequestModel> GetByIdAsync(int id);
        Task<int> UpdateEmployeeAsync(EmployeeRequestModel newEmployee);
        Task<int> DeleteEmployeeAsync(int id);
    }
}
