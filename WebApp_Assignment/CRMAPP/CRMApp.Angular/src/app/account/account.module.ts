import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignUpComponent } from './sign-up/sign-up.component';
import { AccountRoutingModule } from './account-routing.module';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    SignUpComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    HttpClientModule,
    AccountRoutingModule,
    ReactiveFormsModule
  ]
})
export class AccountModule { }
