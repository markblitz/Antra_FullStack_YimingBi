import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryModule } from './category/category.module';
import { CustomerModule } from './customer/customer.module';
import { EmployeeModule } from './employee/employee.module';
import { ProductModule } from './product/product.module';
import { RegionModule } from './region/region.module';
import { ShipperModule } from './shipper/shipper.module';
import { SupplierModule } from './supplier/supplier.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CategoryModule,
    CustomerModule,
    EmployeeModule,
    ProductModule,
    RegionModule,
    ShipperModule,
    SupplierModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
