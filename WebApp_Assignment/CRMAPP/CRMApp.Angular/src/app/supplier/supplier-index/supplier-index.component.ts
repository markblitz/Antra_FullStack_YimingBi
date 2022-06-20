import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-supplier-index',
  templateUrl: './supplier-index.component.html',
  styleUrls: ['./supplier-index.component.scss']
})
export class SupplierIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  suppliers = [
    {
      id: 1, companyName: "demo1", contactName: "demo1", contactTitle: "",
      address: "", city: "", regionId: 0, postalCode: "", country: "", phone: ""
    },
    {
      id: 2, companyName: "demo2", contactName: "demo2", contactTitle: "",
      address: "", city: "", regionId: 0, postalCode: "", country: "", phone: ""
    },
    {
      id: 3, companyName: "demo3", contactName: "demo3", contactTitle: "",
      address: "", city: "", regionId: 0, postalCode: "", country: "", phone: ""
    },
    {
      id: 4, companyName: "demo4", contactName: "demo4", contactTitle: "",
      address: "", city: "", regionId: 0, postalCode: "", country: "", phone: ""
    }
  ]
}
