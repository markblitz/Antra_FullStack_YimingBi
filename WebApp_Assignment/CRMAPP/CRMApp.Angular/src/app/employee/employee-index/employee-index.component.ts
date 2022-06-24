import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeResponse } from 'src/entities/ResponseModel/employeeResponse';
import { EmployeeService } from 'src/services/employee.service';

@Component({
  selector: 'app-employee-index',
  templateUrl: './employee-index.component.html',
  styleUrls: ['./employee-index.component.scss']
})
export class EmployeeIndexComponent implements OnInit {

  employees:EmployeeResponse[] = [];

  constructor(private employeeService:EmployeeService,
    private router: Router) { }

  ngOnInit(): void {
    this.getEmployees();
  }
  getEmployees() {
    this.employeeService.getAllEmployee().subscribe(
      (data) => { this.employees = data }
    );
  }

  deleteEmployee(id:number){
    this.employeeService.deleteEmployee(id).subscribe(
      (d: any) => { this.getEmployees() }
    );
  }

  editEmployee(id:number){
    this.router.navigate(['/employee/edit/'+id]);
  }

}
