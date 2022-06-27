import { assertPlatform, Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { SignUp } from 'src/entities/signup';
import { AccountService } from 'src/services/account.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {

  accountForm: FormGroup;
  signUpSuccessful: boolean = false;
  signUp: SignUp = {
    firstName: '',
    lastName: '',
    Email: '',
    password: '',
    confirmPassword: ''
  }

  constructor(private builder: FormBuilder,
    private accountService:AccountService) {
    this.accountForm = builder.group(
      {
        'firstName': new FormControl(null, [Validators.required]),
        'lastName': new FormControl(null, [Validators.required]),
        'Email': new FormControl(null, [Validators.required, Validators.email]),
        'password': new FormControl(null, [Validators.required]),
        'confirmPassword': new FormControl(null, [Validators.required])
      }
    )
  }

  ngOnInit(): void {
  }

  addAcount(){
    console.log(this.accountForm.value);
    this.signUp.Email = this.accountForm.value["Email"];
    this.signUp.confirmPassword = this.accountForm.value["confirmPassword"];
    this.signUp.firstName = this.accountForm.value["firstName"];
    this.signUp.lastName = this.accountForm.value["lastName"];
    this.signUp.password = this.accountForm.value["password"];
    this.accountService.signUp(this.signUp).subscribe(d=>{this.signUpSuccessful = d});
  }

}
