import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SupplierIndexComponent } from './supplier-index/supplier-index.component';
import { SupplierAddComponent } from './supplier-add/supplier-add.component';
import { SupplierEditComponent } from './supplier-edit/supplier-edit.component';
import { SupplierRoutingModule } from './supplier-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { SupplierService } from 'src/services/supplier.service';



@NgModule({
  declarations: [
    SupplierIndexComponent,
    SupplierAddComponent,
    SupplierEditComponent
  ],
  imports: [
    CommonModule,
    SupplierRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [
    SupplierService
  ]
})
export class SupplierModule { }
