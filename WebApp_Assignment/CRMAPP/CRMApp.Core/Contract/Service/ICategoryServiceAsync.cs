using CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMApp.Core.Contract.Service
{
    public interface ICategoryServiceAsync
    {
        Task<IEnumerable<CategoryModel>> GetAllAsync();
        Task<int> AddCategoryAsync(CategoryModel newCategpry);
        Task<CategoryModel> GetByIdAsync(int id);
        Task<int> UpdateCategoryAsync(CategoryModel newCategory);
        Task<int> DeleteCategoryAsync(int id);
    }
}
