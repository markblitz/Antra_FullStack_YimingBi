import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-index',
  templateUrl: './product-index.component.html',
  styleUrls: ['./product-index.component.scss']
})
export class ProductIndexComponent implements OnInit {

  dummyProducts = [
    {id:1, name:"IPhone 13 mini", price:"799"},
    {id:2, name:"IPhone 13", price:"899"},
    {id:3, name:"IPhone 13 pro", price:"999"},
    {id:4, name:"IPhone 13 pro max", price:"1099"}
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
