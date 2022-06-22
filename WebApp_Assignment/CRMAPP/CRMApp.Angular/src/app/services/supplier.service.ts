import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private httpClient:HttpClient) { }

  getAllSupplier(){
    return this.httpClient.get("https://localhost:7016/api/Supplier")
  }
}
