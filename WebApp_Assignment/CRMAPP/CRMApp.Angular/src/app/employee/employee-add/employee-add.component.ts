import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Employee } from 'src/entities/employee';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.scss']
})
export class EmployeeAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  employee:Employee={
    firstName:'',
    lastName:'',
    title:'',
    titleOfCourtesy:'',
    bitrhDate:new Date(),
    hireDate:new Date(),
    address:'',
    city:'',
    regionId:0,
    postalCode:'',
    country:'',
    phone:'',
    reportsTo:0,
    photoPath:''
  }

  insertEmployee(form:NgForm){
    console.log(form.value)
  }

}
