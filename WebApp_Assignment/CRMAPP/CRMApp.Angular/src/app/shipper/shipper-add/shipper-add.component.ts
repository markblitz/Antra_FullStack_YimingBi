import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Shipper } from 'src/entities/shipper';

@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.scss']
})
export class ShipperAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  shipper:Shipper={
    id: 0,
    name: '',
    phone: ''
  }

  insertShipper(form:NgForm){
    console.log(form.value)
  }
}
