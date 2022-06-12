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

        public async Task<int> DeleteCategoryAsync(int id)
        {
            return await categoryReposotoryAsync.DeleteAsync(id);
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

        public async Task<CategoryModel> GetByIdAsync(int id)
        {
            var item = await categoryReposotoryAsync.GetByIdAsync(id);
            if (item != null)
            {
                CategoryModel category = new CategoryModel();
                category.Description = item.Description;
                category.Id = item.Id;
                category.Name = item.Name;
                return category;
            }
            return null;
        }

        public async Task<int> UpdateCategoryAsync(CategoryModel newCategory)
        {
            Category category = new Category();
            category.Description = newCategory.Description;
            category.Id = newCategory.Id;
            category.Name = newCategory.Name;
            return await categoryReposotoryAsync.UpdateAsync(category);
        }
    }
}
