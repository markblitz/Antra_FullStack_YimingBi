import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Region } from 'src/entities/region';
import { CustomerRequest } from 'src/entities/RequestModel/customerRequest';
import { CustomerService } from 'src/services/customer.service';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-customer-edit',
  templateUrl: './customer-edit.component.html',
  styleUrls: ['./customer-edit.component.scss']
})
export class CustomerEditComponent implements OnInit {

  customerForm: FormGroup;
  editId: number = 0;
  regions:Region[] = [];
  editSuccessful: boolean = false;

  editCustomer: CustomerRequest = {
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

  constructor(private activatedRoute: ActivatedRoute,
    private customerService: CustomerService,
    private regionService: RegionService,
    builer: FormBuilder) {
    activatedRoute.params.subscribe(d => { this.editId = d["id"] });
    this.customerForm = builer.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'title': new FormControl(null),
        'address': new FormControl(null),
        'city': new FormControl(null),
        'regionId': new FormControl(null, [Validators.required]),
        'postalCode': new FormControl(null),
        'country': new FormControl(null),
        'phone': new FormControl(null)
      }
    );
    this.regionService.getAllRegion().subscribe(
      data=>{this.regions=data}
    );
    this.getCustomer();
  }

  ngOnInit(): void {
  }

  getCustomer(){
    this.customerService.getCustomerById(this.editId).subscribe(data=>{
      this.customerForm.patchValue(data);
    });
  }

  saveCustomer(){
    this.editCustomer.address = this.customerForm.value["address"];
    this.editCustomer.city = this.customerForm.value["city"];
    this.editCustomer.country = this.customerForm.value["country"];
    this.editCustomer.id = this.editId;
    this.editCustomer.name = this.customerForm.value["name"];
    this.editCustomer.phone = this.customerForm.value["phone"];
    this.editCustomer.postalCode = this.customerForm.value["postalCode"];
    this.editCustomer.regionId = this.customerForm.value["regionId"];
    this.editCustomer.title = this.customerForm.value["title"];

    this.customerService.updateCustomer(this.editCustomer).subscribe(d=>{
      this.editSuccessful = true;
    });
  }

}
