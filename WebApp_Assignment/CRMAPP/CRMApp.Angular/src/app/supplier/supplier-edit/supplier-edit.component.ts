import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Region } from 'src/entities/region';
import { SupplierRequest } from 'src/entities/RequestModel/supplierRequest';
import { RegionService } from 'src/services/region.service';
import { SupplierService } from 'src/services/supplier.service';

@Component({
  selector: 'app-supplier-edit',
  templateUrl: './supplier-edit.component.html',
  styleUrls: ['./supplier-edit.component.scss']
})
export class SupplierEditComponent implements OnInit {

  supplierForm: FormGroup;
  regions: Region[] = [];
  editSuccessful: boolean = false;
  editId:number=0;
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

  constructor(private activatedRoute: ActivatedRoute,
    private builder: FormBuilder,
    private supplierService: SupplierService,
    private regionService: RegionService) {
    activatedRoute.params.subscribe(d => { this.editId = d["id"] });
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
    this.getCustomer();
  }

  ngOnInit(): void {
  }

  getCustomer(){
    this.supplierService.getSupplierById(this.editId).subscribe(data=>{
      this.supplierForm.patchValue(data);
    });
  }

  saveCustomer() {
    console.log(this.supplierForm.value)
    this.supplier.address = this.supplierForm.value["address"];
    this.supplier.city = this.supplierForm.value["city"];
    this.supplier.companyName = this.supplierForm.value["companyName"];
    this.supplier.contactName = this.supplierForm.value["contactName"];
    this.supplier.contactTitle = this.supplierForm.value["contactTitle"];
    this.supplier.country = this.supplierForm.value["country"];
    this.supplier.id = this.editId;
    this.supplier.phone = this.supplierForm.value["phone"];
    this.supplier.postalCode = this.supplierForm.value["postalCode"];
    this.supplier.regionId = this.supplierForm.value["regionId"];

    this.supplierService.updateSupplier(this.supplier).subscribe((d: any) => {
      this.editSuccessful = true;
    });
  }
}
