import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private httpClient:HttpClient) { }

  getAllEmployee(){
    return this.httpClient.get("https://localhost:7016/api/Employee")
  }
}
