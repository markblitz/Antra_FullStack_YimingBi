import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private httpClient:HttpClient) { }

  getAllCategory(){
    return this.httpClient.get("https://localhost:7016/api/Category")
  }

}
