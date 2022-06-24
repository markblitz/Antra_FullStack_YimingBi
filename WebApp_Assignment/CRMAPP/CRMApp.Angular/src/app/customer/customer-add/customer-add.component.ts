import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Region } from 'src/entities/region';
import { CustomerRequest } from 'src/entities/RequestModel/customerRequest';
import { CustomerService } from 'src/services/customer.service';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-customer-add',
  templateUrl: './customer-add.component.html',
  styleUrls: ['./customer-add.component.scss']
})
export class CustomerAddComponent implements OnInit {

  customerForm: FormGroup;
  regions:Region[] = [];
  insertSuccessful: boolean = false;
  customer: CustomerRequest = {
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
  
  constructor(private builder: FormBuilder,
    private customerService: CustomerService,
    private regionService: RegionService) {
    this.customerForm = builder.group(
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
  }

  ngOnInit(): void {
  }

  insertCustomer() {
    //console.log(this.customerForm.value)
    this.customer.address = this.customerForm.value["address"];
    this.customer.city = this.customerForm.value["city"];
    this.customer.country = this.customerForm.value["country"];
    this.customer.name = this.customerForm.value["name"];
    this.customer.phone = this.customerForm.value["phone"];
    this.customer.postalCode = this.customerForm.value["postalCode"];
    this.customer.regionId = this.customerForm.value["regionId"];
    this.customer.title = this.customerForm.value["title"];
    
    this.customerService.insertCustomer(this.customer).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }
}
