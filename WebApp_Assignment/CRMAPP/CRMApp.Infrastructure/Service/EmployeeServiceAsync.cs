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
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        private readonly IEmployeeRepositoryAsync employeeRepositoryAsync;
        public EmployeeServiceAsync(IEmployeeRepositoryAsync employeeRepository)
        {
            employeeRepositoryAsync = employeeRepository;
        }

        public async Task<int> AddEmployeeAsync(EmployeeRequestModel newEmployee)
        {
            Employee employee = new Employee();
            employee.Address = newEmployee.Address;
            employee.BirthDate = newEmployee.BirthDate;
            employee.City = newEmployee.City;
            employee.Country = newEmployee.Country;
            employee.FirstName = newEmployee.FirstName;
            employee.HireDate = newEmployee.HireDate;
            employee.LastName = newEmployee.LastName;
            employee.Phone = newEmployee.Phone;
            employee.PhotoPath = newEmployee.PhotoPath;
            employee.PostalCode = newEmployee.PostalCode;
            employee.RegionId = newEmployee.RegionId;
            employee.ReportsTo = newEmployee.ReportsTo;
            employee.Title = newEmployee.Title;
            employee.TitleOfCourtesy = newEmployee.TitleOfCourtesy;
            return await employeeRepositoryAsync.InsertAsync(employee);
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
            return await employeeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeResponseModel>> GetAllAsync()
        {
            var collection = await employeeRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<EmployeeResponseModel> result = new List<EmployeeResponseModel>();
                foreach(var item in collection)
                {
                    EmployeeResponseModel employeeResponse = new EmployeeResponseModel();
                    employeeResponse.City = item.City;
                    employeeResponse.FirstName = item.FirstName;
                    employeeResponse.HireDate = item.HireDate;
                    employeeResponse.Id = item.Id;
                    employeeResponse.LastName = item.LastName;
                    employeeResponse.Phone = item.Phone;
                    employeeResponse.PhotoPath = item.PhotoPath;
                    employeeResponse.Title = item.Title;
                    employeeResponse.TitleOfCourtesy = item.TitleOfCourtesy;
                    result.Add(employeeResponse);
                }
                return result;
            }
            return null;
        }

        public async Task<EmployeeRequestModel> GetByIdAsync(int id)
        {
            var item = await employeeRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                EmployeeRequestModel employeeRequest = new EmployeeRequestModel();
                employeeRequest.Address = item.Address;
                employeeRequest.BirthDate = item.BirthDate;
                employeeRequest.City = item.City;
                employeeRequest.Country = item.Country;
                employeeRequest.FirstName = item.FirstName;
                employeeRequest.HireDate = item.HireDate;
                employeeRequest.Id = item.Id;
                employeeRequest.LastName = item.LastName;
                employeeRequest.Phone = item.Phone;
                employeeRequest.PhotoPath = item.PhotoPath;
                employeeRequest.PostalCode = item.PostalCode;
                employeeRequest.RegionId = item.RegionId;
                employeeRequest.ReportsTo = item.ReportsTo;
                employeeRequest.Title = item.Title;
                employeeRequest.TitleOfCourtesy = item.TitleOfCourtesy;
                return employeeRequest;
            }
            return null;
        }

        public async Task<int> UpdateEmployeeAsync(EmployeeRequestModel newEmployee)
        {
            Employee employee = new Employee();
            employee.Address = newEmployee.Address;
            employee.BirthDate = newEmployee.BirthDate;
            employee.City = newEmployee.City;
            employee.Country = newEmployee.Country;
            employee.FirstName = newEmployee.FirstName;
            employee.HireDate = newEmployee.HireDate;
            employee.Id = newEmployee.Id;
            employee.LastName = newEmployee.LastName;
            employee.Phone = newEmployee.Phone;
            employee.PhotoPath = newEmployee.PhotoPath;
            employee.PostalCode = newEmployee.PostalCode;
            employee.RegionId = newEmployee.RegionId;
            employee.ReportsTo = newEmployee.ReportsTo;
            employee.Title = newEmployee.Title;
            employee.TitleOfCourtesy = newEmployee.TitleOfCourtesy;
            return await employeeRepositoryAsync.UpdateAsync(employee);
        }
    }
}
