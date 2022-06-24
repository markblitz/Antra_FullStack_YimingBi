import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Region } from 'src/entities/region';
import { EmployeeRequest } from 'src/entities/RequestModel/employeeRequest';
import { EmployeeResponse } from 'src/entities/ResponseModel/employeeResponse';
import { EmployeeService } from 'src/services/employee.service';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-employee-edit',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.scss']
})
export class EmployeeEditComponent implements OnInit {

  employeeForm: FormGroup;
  regions: Region[] = [];
  editId: number = 0;
  employees: EmployeeResponse[] = [];
  editSuccessful: boolean = false;
  employee: EmployeeRequest = {
    id: 0,
    firstName: '',
    lastName: '',
    title: '',
    titleOfCourtesy: '',
    birthDate: new Date,
    hireDate: new Date,
    address: '',
    city: '',
    regionId: 0,
    postalCode: '',
    country: '',
    phone: '',
    reportsTo: 0,
    photoPath: ''
  }

  constructor(private builder: FormBuilder,
    private activatedRoute: ActivatedRoute,
    private employeeService: EmployeeService,
    private regionService: RegionService) {
    activatedRoute.params.subscribe(d => { this.editId = d["id"] });
    this.employeeForm = builder.group(
      {
        'firstName': new FormControl(null, [Validators.required]),
        'lastName': new FormControl(null, [Validators.required]),
        'title': new FormControl(null),
        'titleOfCourtesy': new FormControl(null),
        'birthDate': new FormControl(null),
        'hireDate': new FormControl(null),
        'address': new FormControl(null),
        'city': new FormControl(null),
        'regionId': new FormControl(null, [Validators.required]),
        'postalCode': new FormControl(null),
        'country': new FormControl(null),
        'phone': new FormControl(null),
        'reportsTo': new FormControl(null),
        'photoPath': new FormControl(null),
      }
    );
    this.regionService.getAllRegion().subscribe(
      data => { this.regions = data }
    );
    this.employeeService.getAllEmployee().subscribe(
      data => { this.employees = data }
    );
    this.getEmployee();
  }

  ngOnInit(): void {
  }

  getEmployee() {
    this.employeeService.getEmployeeyById(this.editId).subscribe(data => {
      this.employeeForm.patchValue(data);
    });
  }

  saveEmployee() {
    //console.log(this.employeeForm.value)
    this.employee.address = this.employeeForm.value["address"];
    this.employee.birthDate = this.employeeForm.value["birthDate"];
    this.employee.city = this.employeeForm.value["city"];
    this.employee.country = this.employeeForm.value["country"];
    this.employee.firstName = this.employeeForm.value["firstName"];
    this.employee.hireDate = this.employeeForm.value["hireDate"];
    this.employee.id = this.editId;
    this.employee.lastName = this.employeeForm.value["lastName"];
    this.employee.phone = this.employeeForm.value["phone"];
    this.employee.photoPath = this.employeeForm.value["photoPath"];
    this.employee.postalCode = this.employeeForm.value["postalCode"];
    this.employee.regionId = this.employeeForm.value["regionId"];
    this.employee.title = this.employeeForm.value["title"];
    this.employee.titleOfCourtesy = this.employeeForm.value["titleOfCourtesy"];

    this.employeeService.updateEmployee(this.employee).subscribe((d: any) => {
      this.editSuccessful = true;
    });
  }

}
