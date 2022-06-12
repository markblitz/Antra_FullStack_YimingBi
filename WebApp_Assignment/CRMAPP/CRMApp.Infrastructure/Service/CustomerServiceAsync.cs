using CRMApp.Core.Contract.Repository;
using CRMApp.Core.Contract.Service;
using CRMApp.Core.Entity;
using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using CRMApp.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Infrastructure.Service
{
    public class CustomerServiceAsync : ICustomerServiceAsync
    {
        private readonly ICustomerRepositoryAsync customerRepositoryAsync;
        public CustomerServiceAsync(ICustomerRepositoryAsync customerRepository)
        {
            customerRepositoryAsync = customerRepository;
        }

        public async Task<int> AddCustomerAsync(CustomerRequestModel newCustomer)
        {
            Customer customer = new Customer();
            customer.Address = newCustomer.Address;
            customer.City = newCustomer.City;
            customer.Country = newCustomer.Country;
            customer.Name = newCustomer.Name;
            customer.Phone = newCustomer.Phone;
            customer.PostalCode = newCustomer.PostalCode;
            customer.RegionId = newCustomer.RegionId;
            customer.Title = newCustomer.Title;
            return await customerRepositoryAsync.InsertAsync(customer);
        }

        public async Task<int> DeleteCustomerAsync(int id)
        {
            return await customerRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<CustomerResponseModel>> GetAllAsync()
        {
            var collection = await customerRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<CustomerResponseModel> result = new List<CustomerResponseModel>();
                foreach (var item in collection)
                {
                    CustomerResponseModel customerResponse = new CustomerResponseModel();
                    customerResponse.Address = item.Address;
                    customerResponse.City = item.City;
                    customerResponse.Country = item.Country;
                    customerResponse.Id = item.Id;
                    customerResponse.Name = item.Name;
                    customerResponse.Phone = item.Phone;
                    customerResponse.PostalCode = item.PostalCode;
                    customerResponse.RegionId = item.RegionId;
                    customerResponse.Title = item.Title;
                    result.Add(customerResponse);
                }
                return result;
            }
            return null;
        }

        public async Task<CustomerRequestModel> GetByIdAsync(int id)
        {
            var item = await customerRepositoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                CustomerRequestModel customerRequest = new CustomerRequestModel();
                customerRequest.Address = item.Address;
                customerRequest.City = item.City;
                customerRequest.Country = item.Country;
                customerRequest.Id = item.Id;
                customerRequest.Name = item.Name;
                customerRequest.Phone = item.Phone;
                customerRequest.PostalCode = item.PostalCode;
                customerRequest.RegionId = item.RegionId;
                customerRequest.Title = item.Title;
                return customerRequest;
            }
            return null;
        }

        public async Task<int> UpdateCustomerAsync(CustomerRequestModel newCustomer)
        {
            Customer customer = new Customer();
            customer.Address = newCustomer.Address;
            customer.City = newCustomer.City;
            customer.Country = newCustomer.Country;
            customer.Id = newCustomer.Id;
            customer.Name = newCustomer.Name;
            customer.Phone = newCustomer.Phone;
            customer.PostalCode = newCustomer.PostalCode;
            customer.RegionId = newCustomer.RegionId;
            customer.Title = newCustomer.Title;
            return await customerRepositoryAsync.UpdateAsync(customer);
        }
    }
}
