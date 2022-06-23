import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CustomerRequest } from 'src/entities/RequestModel/customerRequest';

@Component({
  selector: 'app-customer-add',
  templateUrl: './customer-add.component.html',
  styleUrls: ['./customer-add.component.scss']
})
export class CustomerAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  customer:CustomerRequest={
    id: 0,
    name: '',
    title: '',
    address: '',
    city: '',
    regionId: 0,
    postalCode: '',
    country: '',
    phone: ''
  }

  insertCustomer(form:NgForm){
    console.log(form.value)
  }
}
