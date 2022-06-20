import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-shipper-index',
  templateUrl: './shipper-index.component.html',
  styleUrls: ['./shipper-index.component.scss']
})
export class ShipperIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  shippers=[
    {id:1, name:"demo1", phone:""},
    {id:2, name:"demo2", phone:""},
    {id:3, name:"demo3", phone:""},
    {id:4, name:"demo4", phone:""}
  ]
}
