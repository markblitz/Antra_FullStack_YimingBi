import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-index',
  templateUrl: './product-index.component.html',
  styleUrls: ['./product-index.component.scss']
})
export class ProductIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  products=[
    {id:1, name:"demo1", supplierId:0, categoryId:0, quantityPerUnit:"",
      unitPrice:0, unitInStock:0, unitsOnOrder:0, reorderLevel:0,
      discontinued:false},
    {id:2, name:"demo2", supplierId:0, categoryId:0, quantityPerUnit:"",
      unitPrice:0, unitInStock:0, unitsOnOrder:0, reorderLevel:0,
      discontinued:false},
    {id:3, name:"demo3", supplierId:0, categoryId:0, quantityPerUnit:"",
      unitPrice:0, unitInStock:0, unitsOnOrder:0, reorderLevel:0,
      discontinued:false},
    {id:4, name:"demo4", supplierId:0, categoryId:0, quantityPerUnit:"",
      unitPrice:0, unitInStock:0, unitsOnOrder:0, reorderLevel:0,
      discontinued:false}
  ]
}
