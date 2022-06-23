import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { SupplierRequest } from 'src/entities/RequestModel/supplierRequest';

@Component({
  selector: 'app-supplier-add',
  templateUrl: './supplier-add.component.html',
  styleUrls: ['./supplier-add.component.scss']
})
export class SupplierAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  supplier:SupplierRequest={
    id: 0,
    companyName: '',
    contactName: '',
    contactTitle: '',
    address: '',
    city: '',
    regionId: 0,
    postalCode: '',
    country: '',
    phone: ''
  }

  insertSupplier(form:NgForm){
    console.log(form.value)
  }
}
