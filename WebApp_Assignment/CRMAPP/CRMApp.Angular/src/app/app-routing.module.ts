import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'category', loadChildren:()=>import('./category/category.module').then(m=>m.CategoryModule)},
  {path:'customer', loadChildren:()=>import('./customer/customer.module').then(m=>m.CustomerModule)},
  {path:'employee', loadChildren:()=>import('./employee/employee.module').then(m=>m.EmployeeModule)},
  {path:'product', loadChildren:()=>import('./product/product.module').then(m=>m.ProductModule)},
  {path:'region', loadChildren:()=>import('./region/region.module').then(m=>m.RegionModule)},
  {path:'shipper', loadChildren:()=>import('./shipper/shipper.module').then(m=>m.ShipperModule)},
  {path:'supplier', loadChildren:()=>import('./supplier/supplier.module').then(m=>m.SupplierModule)},
  {path:'account', loadChildren:()=>import('./account/account.module').then(m=>m.AccountModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
