import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Region } from 'src/entities/region';

@Injectable({
  providedIn: 'root'
})
export class RegionService {

  url:string = environment.api+"Region/";

  constructor(private httpClient:HttpClient) { }

  getAllRegion():Observable<Region[]>{
    return this.httpClient.get<Region[]>(this.url);
  }

  getRegionById(id:number):Observable<Region>{
    return this.httpClient.get<Region>(this.url+id);
  }

  insertRegion(region:Region):Observable<any>{
    return this.httpClient.post(this.url,region);
  }

  updateRegion(region:Region):Observable<any>{
    return this.httpClient.put(this.url,region);
  }

  deleteRegion(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }
}
