import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerIndexComponent } from './customer-index/customer-index.component';
import { CustomerAddComponent } from './customer-add/customer-add.component';
import { CustomerEditComponent } from './customer-edit/customer-edit.component';
import { CustomerRoutingModule } from './customer-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CustomerService } from 'src/services/customer.service';



@NgModule({
  declarations: [
    CustomerIndexComponent,
    CustomerAddComponent,
    CustomerEditComponent
  ],
  imports: [
    CommonModule,
    CustomerRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [
    CustomerService
  ]
})
export class CustomerModule { }
