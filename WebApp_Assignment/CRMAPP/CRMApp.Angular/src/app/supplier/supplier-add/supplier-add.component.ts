import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Supplier } from 'src/entities/supplier';

@Component({
  selector: 'app-supplier-add',
  templateUrl: './supplier-add.component.html',
  styleUrls: ['./supplier-add.component.scss']
})
export class SupplierAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  supplier:Supplier={
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
