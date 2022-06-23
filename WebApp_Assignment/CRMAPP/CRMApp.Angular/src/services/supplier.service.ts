import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { SupplierResponse } from 'src/entities/ResponseModel/supplierResponse';
import { SupplierRequest } from 'src/entities/RequestModel/supplierRequest';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  url:string = environment.api+"Supplier/";

  constructor(private httpClient:HttpClient) { }

  getAllSupplier():Observable<SupplierResponse[]>{
    return this.httpClient.get<SupplierResponse[]>(this.url);
  }

  getSupplierById(id:number):Observable<SupplierRequest>{
    return this.httpClient.get<SupplierRequest>(this.url+id);
  }

  insertSupplier(supplier:SupplierRequest):Observable<any>{
    return this.httpClient.post(this.url,supplier);
  }

  updateSupplier(supplier:SupplierRequest):Observable<any>{
    return this.httpClient.put(this.url,supplier);
  }

  deleteSupplier(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
