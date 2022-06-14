using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using CRMApp.Core.Contract.Service;
using CRMApp.Infrastructure.Service;
using CRMApp.Infrastructure.Data;
using CRMApp.Core.Contract.Repository;
using CRMApp.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSqlServer<CrmDBContext>(builder.Configuration.GetConnectionString("OnlineCRM"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency injection for repositoryies
builder.Services.AddScoped<ICategoryRepositoryAsync, CategoryRepositoryAsync>();
builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
builder.Services.AddScoped<IEmployeeRepositoryAsync, EmployeeRepositoryAsync>();
builder.Services.AddScoped<IProductRepositoryAsync, ProductRepositoryAsync>();
builder.Services.AddScoped<IRegionRepositoryAsync, RegionRepositoryAsync>();
builder.Services.AddScoped<IShipperRepositoryAsync, ShipperRepositoryAsync>();
builder.Services.AddScoped<ISupplierRepositoryAsync, SupplierRepositoryAsync>();

// Dependency injection for services
builder.Services.AddScoped<ICategoryServiceAsync, CategoryServiceAsync>();
builder.Services.AddScoped<ICustomerServiceAsync, CustomerServiceAsync>();
builder.Services.AddScoped<IEmployeeServiceAsync, EmployeeServiceAsync>();
builder.Services.AddScoped<IProductServiceAsync, ProductServiceAsync>();
builder.Services.AddScoped<IRegionServiceAsync, RegionServiceAsync>();
builder.Services.AddScoped<IShipperServiceAsync, ShipperServiceAsync>();
builder.Services.AddScoped<ISupplierServiceAsync, SupplierServiceAsync>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
