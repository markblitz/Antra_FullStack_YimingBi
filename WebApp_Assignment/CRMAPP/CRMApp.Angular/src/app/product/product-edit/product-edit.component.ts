import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-edit',
  templateUrl: './product-edit.component.html',
  styleUrls: ['./product-edit.component.scss']
})
export class ProductEditComponent implements OnInit {

  id: number | undefined;

  constructor(private activatedroute: ActivatedRoute) {
    this.activatedroute.params.subscribe(p => {
      this.id = p["id"]
    });
  }

  dummyName = "Some name";

  number1: number = 20
  number2: number = 21
  numberResult: number = 0

  addtion() {
    this.numberResult = parseFloat(this.number1 + "") + parseFloat(this.number2 + "");
  }

  ngOnInit(): void {
  }

}
