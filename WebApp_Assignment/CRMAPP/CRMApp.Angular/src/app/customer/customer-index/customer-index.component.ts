import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-index',
  templateUrl: './customer-index.component.html',
  styleUrls: ['./customer-index.component.scss']
})
export class CustomerIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  customers = [
    {
      id: 1, name: "demo1", title: "", address: "", city: "", regionId: 0,
      postalCode: "", country: "", phone: ""
    },
    {
      id: 2, name: "demo2", title: "", address: "", city: "", regionId: 0,
      postalCode: "", country: "", phone: ""
    },
    {
      id: 3, name: "demo3", title: "", address: "", city: "", regionId: 0,
      postalCode: "", country: "", phone: ""
    },
    {
      id: 4, name: "demo4", title: "", address: "", city: "", regionId: 0,
      postalCode: "", country: "", phone: ""
    }
  ]
}
