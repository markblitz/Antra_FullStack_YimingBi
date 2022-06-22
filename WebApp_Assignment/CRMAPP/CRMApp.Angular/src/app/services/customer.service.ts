import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private httpClient:HttpClient) { }

  getAllCustomer(){
    return this.httpClient.get("https://localhost:7016/api/Customer")
  }
}
