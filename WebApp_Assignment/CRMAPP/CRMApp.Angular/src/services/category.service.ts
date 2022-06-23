import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Category } from 'src/entities/category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  url:string = environment.api+"Category/";

  constructor(private httpClient:HttpClient) { }

  getAllCategory():Observable<Category[]>{
    return this.httpClient.get<Category[]>(this.url);
  }

  getCategoryById(id:number):Observable<Category>{
    return this.httpClient.get<Category>(this.url+id);
  }

  insertCategory(category:Category):Observable<any>{
    return this.httpClient.post(this.url,category);
  }

  updateCategory(category:Category):Observable<any>{
    return this.httpClient.put(this.url,category);
  }

  deleteCategory(id:number):Observable<any>{
    return this.httpClient.delete(this.url+id);
  }

}
