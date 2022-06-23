import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ProductResponse } from 'src/entities/ResponseModel/productRespoonse';
import { ProductRequest } from 'src/entities/RequestModel/productRequest';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  url:string = environment.api+"Product/";

  constructor(private httpClient:HttpClient) { }

  getAllProduct():Observable<ProductResponse[]>{
    return this.httpClient.get<ProductResponse[]>(this.url);
  }

  getProductById(id:number):Observable<ProductRequest>{
    return this.httpClient.get<ProductRequest>(this.url+id);
  }

  insertProduct(product:ProductRequest):Observable<any>{
    return this.httpClient.post(this.url,product);
  }

  updateProduct(product:ProductRequest):Observable<any>{
    return this.httpClient.put(this.url,product);
  }

  deleteProduct(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
