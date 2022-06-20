import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SupplierIndexComponent } from './supplier-index/supplier-index.component';
import { SupplierAddComponent } from './supplier-add/supplier-add.component';
import { SupplierEditComponent } from './supplier-edit/supplier-edit.component';
import { SupplierRoutingModule } from './supplier-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    SupplierIndexComponent,
    SupplierAddComponent,
    SupplierEditComponent
  ],
  imports: [
    CommonModule,
    SupplierRoutingModule,
    FormsModule
  ]
})
export class SupplierModule { }
