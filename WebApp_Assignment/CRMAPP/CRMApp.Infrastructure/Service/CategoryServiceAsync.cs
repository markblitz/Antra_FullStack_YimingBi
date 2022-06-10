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
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync categoryReposotoryAsync;
        public CategoryServiceAsync(ICategoryRepositoryAsync categoryRepository)
        {
            categoryReposotoryAsync = categoryRepository;
        }

        public async Task<int> AddCategoryAsync(CategoryModel newCategpry)
        {
            Category category = new Category();
            category.Description = newCategpry.Description;
            category.Name = newCategpry.Name;
            return await categoryReposotoryAsync.InsertAsync(category);
        }

        public async Task<IEnumerable<CategoryModel>> GetAllAsync()
        {
            var collection = await categoryReposotoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<CategoryModel> result = new List<CategoryModel>();
                foreach (var item in collection)
                {
                    CategoryModel category = new CategoryModel();
                    category.Description = item.Description;
                    category.Id = item.Id;
                    category.Name = item.Name;
                    result.Add(category);
                }
                return (result);
            }
            return null;
        }
    }
}
