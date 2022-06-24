import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Region } from 'src/entities/region';
import { SupplierRequest } from 'src/entities/RequestModel/supplierRequest';
import { RegionService } from 'src/services/region.service';
import { SupplierService } from 'src/services/supplier.service';

@Component({
  selector: 'app-supplier-add',
  templateUrl: './supplier-add.component.html',
  styleUrls: ['./supplier-add.component.scss']
})
export class SupplierAddComponent implements OnInit {

  supplierForm: FormGroup;
  regions: Region[] = [];
  insertSuccessful: boolean = false;
  supplier: SupplierRequest = {
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

  constructor(private builder: FormBuilder,
    private supplierService: SupplierService,
    private regionService: RegionService) {
    this.supplierForm = builder.group(
      {
        'companyName': new FormControl(null, [Validators.required]),
        'contactName': new FormControl(null),
        'contactTitle': new FormControl(null),
        'address': new FormControl(null),
        'city': new FormControl(null),
        'regionId': new FormControl(null, [Validators.required]),
        'postalCode': new FormControl(null),
        'country': new FormControl(null),
        'phone': new FormControl(null)
      }
    );
    this.regionService.getAllRegion().subscribe(
      data => { this.regions = data }
    );
  }

  ngOnInit(): void {
  }

  insertCustomer() {
    console.log(this.supplierForm.value)
    this.supplier.address = this.supplierForm.value["address"];
    this.supplier.city = this.supplierForm.value["city"];
    this.supplier.companyName = this.supplierForm.value["companyName"];
    this.supplier.contactName = this.supplierForm.value["contactName"];
    this.supplier.contactTitle = this.supplierForm.value["contactTitle"];
    this.supplier.country = this.supplierForm.value["country"];
    this.supplier.phone = this.supplierForm.value["phone"];
    this.supplier.postalCode = this.supplierForm.value["postalCode"];
    this.supplier.regionId = this.supplierForm.value["regionId"];

    this.supplierService.insertSupplier(this.supplier).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }
}
