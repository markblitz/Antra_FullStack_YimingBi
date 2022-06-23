import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ProductRequest } from 'src/entities/RequestModel/productRequest';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.scss']
})
export class ProductAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  product:ProductRequest={
    id: 0,
    name: '',
    supplierId: 0,
    categoryId: 0,
    quantityPerUnit: '',
    unitPrice: 0,
    unitInStock: 0,
    unitsOnOrder: 0,
    reorderLevel: 0,
    discontinued: false
  }

  insertProduct(form:NgForm){
    console.log(form.value)
  }
}
