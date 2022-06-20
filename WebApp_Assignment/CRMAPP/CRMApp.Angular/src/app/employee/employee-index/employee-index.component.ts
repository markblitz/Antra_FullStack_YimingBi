import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-index',
  templateUrl: './employee-index.component.html',
  styleUrls: ['./employee-index.component.scss']
})
export class EmployeeIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  employees=[
    {id:1, firstName:"demo1", lastName:"demo1", title:"", titleOfCourtesy:"", bitrhDate:new Date, hireDate:new Date,
      address:"", city:"", regionId:0, postalCode:"", country:"", phone:"", reportsTo:0, photoPath:""},
    {id:2, firstName:"demo2", lastName:"demo2", title:"", titleOfCourtesy:"", bitrhDate:new Date, hireDate:new Date,
      address:"", city:"", regionId:0, postalCode:"", country:"", phone:"", reportsTo:0, photoPath:""},
    {id:3, firstName:"demo3", lastName:"demo3", title:"", titleOfCourtesy:"", bitrhDate:new Date, hireDate:new Date,
      address:"", city:"", regionId:0, postalCode:"", country:"", phone:"", reportsTo:0, photoPath:""},
    {id:4, firstName:"demo4", lastName:"demo4", title:"", titleOfCourtesy:"", bitrhDate:new Date, hireDate:new Date,
      address:"", city:"", regionId:0, postalCode:"", country:"", phone:"", reportsTo:0, photoPath:""}
  ]

}
