import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ShipperService {

  constructor(private httpClient:HttpClient) { }

  getAllShipper(){
    return this.httpClient.get("https://localhost:7016/api/Shipper")
  }
}
