import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EmployeeRequest } from 'src/entities/RequestModel/employeeRequest';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.scss']
})
export class EmployeeAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  employee:EmployeeRequest={
    id: 0,
    firstName: '',
    lastName: '',
    title: '',
    titleOfCourtesy: '',
    bitrhDate: new Date(),
    hireDate: new Date(),
    address: '',
    city: '',
    regionId: 0,
    postalCode: '',
    country: '',
    phone: '',
    reportsTo: 0,
    photoPath: ''
  }

  insertEmployee(form:NgForm){
    console.log(form.value)
  }

}
