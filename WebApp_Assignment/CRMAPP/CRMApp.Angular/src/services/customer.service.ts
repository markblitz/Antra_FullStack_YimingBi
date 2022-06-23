import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { CustomerResponse } from 'src/entities/ResponseModel/customerResponse';
import { CustomerRequest } from 'src/entities/RequestModel/customerRequest';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  url:string = environment.api+"Customer/";

  constructor(private httpClient:HttpClient) { }

  getAllCustomer():Observable<CustomerResponse[]>{
    return this.httpClient.get<CustomerResponse[]>(this.url);
  }

  getCustomerById(id:number):Observable<CustomerRequest>{
    return this.httpClient.get<CustomerRequest>(this.url+id);
  }

  insertCustomer(customer:CustomerRequest):Observable<any>{
    return this.httpClient.post(this.url,customer);
  }

  updateCustomer(customer:CustomerRequest):Observable<any>{
    return this.httpClient.put(this.url,customer);
  }

  deleteCustomer(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
