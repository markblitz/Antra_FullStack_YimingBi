import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CustomerResponse } from 'src/entities/ResponseModel/customerResponse';
import { CustomerService } from 'src/services/customer.service';

@Component({
  selector: 'app-customer-index',
  templateUrl: './customer-index.component.html',
  styleUrls: ['./customer-index.component.scss']
})
export class CustomerIndexComponent implements OnInit {

  customers: CustomerResponse[] = [];

  constructor(private customerService:CustomerService,
    private router:Router) { }

  ngOnInit(): void {
    this.getCustomers();
  }

  getCustomers(){
    this.customerService.getAllCustomer().subscribe(
      (data) => { this.customers = data }
    );
  }

  deleteCustomer(id:number){
    this.customerService.deleteCustomer(id).subscribe(
      (d: any) => { this.getCustomers() }
    );
  }

  editCustomer(id:number){
    this.router.navigate(['/customer/edit/'+id]);
  }
}
