using CRMApp.Core.Model.RequestModel;
using CRMApp.Core.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface IProductServiceAsync
    {
        Task<IEnumerable<ProductResponseModel>> GetAllAsync();
        Task<int> AddProductAsync(ProductRequestModel newProduct);
        Task<ProductRequestModel> GetByIdAsync(int id);
        Task<int> UpdateProductAsync(ProductRequestModel newProduct);
        Task<int> DeleteProductAsync(int id);
    }
}
