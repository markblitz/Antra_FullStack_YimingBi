import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Shipper } from 'src/entities/shipper';
import { ShipperService } from 'src/services/shipper.service';

@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.scss']
})
export class ShipperAddComponent implements OnInit {

  shipperForm: FormGroup;
  insertSuccessful: boolean = false;
  shipper: Shipper = {
    id: 0,
    name: '',
    phone: ''
  }
  
  constructor(private builder: FormBuilder,
    private shipperService: ShipperService) {
    this.shipperForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'phone': new FormControl(null)
      }
    );
  }

  ngOnInit(): void {
  }

  insertShipper() {
    //console.log(this.customerForm.value)
    this.shipper.name = this.shipperForm.value["name"];
    this.shipper.phone = this.shipperForm.value["phone"];
    
    this.shipperService.insertShipper(this.shipper).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }
}
