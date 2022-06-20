import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerIndexComponent } from './customer-index/customer-index.component';
import { CustomerAddComponent } from './customer-add/customer-add.component';
import { CustomerEditComponent } from './customer-edit/customer-edit.component';
import { CustomerRoutingModule } from './customer-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    CustomerIndexComponent,
    CustomerAddComponent,
    CustomerEditComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule,
    FormsModule
  ]
})
export class CustomerModule { }
