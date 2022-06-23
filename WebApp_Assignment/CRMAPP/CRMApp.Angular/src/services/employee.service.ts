import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { EmployeeResponse } from 'src/entities/ResponseModel/employeeResponse';
import { EmployeeRequest } from 'src/entities/RequestModel/employeeRequest';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  url:string = environment.api+"Employee/";

  constructor(private httpClient:HttpClient) { }

  getAllEmployee():Observable<EmployeeResponse[]>{
    return this.httpClient.get<EmployeeResponse[]>(this.url);
  }

  getEmployeeyById(id:number):Observable<EmployeeRequest>{
    return this.httpClient.get<EmployeeRequest>(this.url+id);
  }

  insertEmployee(employee:EmployeeRequest):Observable<any>{
    return this.httpClient.post(this.url,employee);
  }

  updateEmployee(employee:EmployeeRequest):Observable<any>{
    return this.httpClient.put(this.url,employee);
  }

  deleteEmployee(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
