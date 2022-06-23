import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Shipper } from 'src/entities/shipper';

@Injectable({
  providedIn: 'root'
})
export class ShipperService {

  url:string = environment.api+"Shipper/";

  constructor(private httpClient:HttpClient) { }

  getAllShipper():Observable<Shipper[]>{
    return this.httpClient.get<Shipper[]>(this.url);
  }

  getShipperById(id:number):Observable<Shipper>{
    return this.httpClient.get<Shipper>(this.url+id);
  }

  insertShipper(shipper:Shipper):Observable<any>{
    return this.httpClient.post(this.url,shipper);
  }

  updateShipper(shipper:Shipper):Observable<any>{
    return this.httpClient.put(this.url,shipper);
  }

  deleteShipper(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
