import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Shipper } from 'src/entities/shipper';
import { ShipperService } from 'src/services/shipper.service';

@Component({
  selector: 'app-shipper-edit',
  templateUrl: './shipper-edit.component.html',
  styleUrls: ['./shipper-edit.component.scss']
})
export class ShipperEditComponent implements OnInit {

  shipperForm: FormGroup;
  editSuccessful: boolean = false;
  editId: number = 0;
  shipper: Shipper = {
    id: 0,
    name: '',
    phone: ''
  }

  constructor(private activatedRoute: ActivatedRoute,
    private builder: FormBuilder,
    private shipperService: ShipperService) {
    activatedRoute.params.subscribe(d => { this.editId = d["id"] });
    this.shipperForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'phone': new FormControl(null)
      }
    );
    this.getCustomer();
  }

  ngOnInit(): void {
  }

  getCustomer() {
    this.shipperService.getShipperById(this.editId).subscribe(data => {
      this.shipperForm.patchValue(data);
    });
  }

  saveShipper() {
    //console.log(this.customerForm.value)
    this.shipper.id = this.editId;
    this.shipper.name = this.shipperForm.value["name"];
    this.shipper.phone = this.shipperForm.value["phone"];

    this.shipperService.updateShipper(this.shipper).subscribe((d: any) => {
      this.editSuccessful = true;
    });
  }

}
