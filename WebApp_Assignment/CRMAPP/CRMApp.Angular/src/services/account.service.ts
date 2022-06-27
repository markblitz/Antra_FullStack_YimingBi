import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SignUp } from 'src/entities/signup';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  url:string = environment.api+"Account/";

  constructor(private httpClient:HttpClient) { }

  signUp(signUp:SignUp):Observable<any>{
    return this.httpClient.post(this.url+"signup", signUp)
  }
}
