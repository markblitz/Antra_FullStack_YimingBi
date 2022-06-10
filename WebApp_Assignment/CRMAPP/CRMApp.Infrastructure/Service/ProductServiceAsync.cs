﻿using CRMApp.Core.Contract.Repository;
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
    public class ProductServiceAsync : IProductServiceAsync
    {
        private readonly IProductRepositoryAsync productRepositoryAsync;
        public ProductServiceAsync(IProductRepositoryAsync productRepository)
        {
            productRepositoryAsync = productRepository;
        }

        public async Task<int> AddProductAsync(ProductRequestModel newProduct)
        {
            Product product = new Product();
            product.CategoryId = newProduct.CategoryId;
            product.Discontinued = newProduct.Discontinued;
            product.Id = newProduct.Id;
            product.Name = newProduct.Name;
            product.QuantityPerUnit = newProduct.QuantityPerUnit;
            product.ReorderLevel = newProduct.ReorderLevel;
            product.SupplierId = newProduct.SupplierId;
            product.UnitPrice = newProduct.UnitPrice;
            product.UnitsInStock = newProduct.UnitsInStock;
            product.UnitsOnOrder = newProduct.UnitsOnOrder;
            return await productRepositoryAsync.InsertAsync(product);
        }

        public async Task<IEnumerable<ProductResponseModel>> GetAllAsync()
        {
            var collection = await productRepositoryAsync.GetAllAsync();
            if (collection != null)
            {
                List<ProductResponseModel> result = new List<ProductResponseModel>();
                foreach (var item in collection)
                {
                    ProductResponseModel productResponse = new ProductResponseModel();
                    productResponse.CategoryId = item.CategoryId;
                    productResponse.Discontinued = item.Discontinued;
                    productResponse.Id = item.Id;
                    productResponse.Name = item.Name;
                    productResponse.QuantityPerUnit = item.QuantityPerUnit;
                    productResponse.UnitPrice = item.UnitPrice;
                    productResponse.UnitsInStock = item.UnitsInStock;
                    result.Add(productResponse);
                }
                return result;
            }
            return null;
        }
    }
}
