import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CRMApp.Angular'
  pageName = 'Employee Table'
  myPlaceHolder = "Please type here"
  toyBoolVar = false
  colors = ["red", "yellow", "green", "blue", "black"]

  stateChange(){
    this.toyBoolVar = !this.toyBoolVar;
  }
}
