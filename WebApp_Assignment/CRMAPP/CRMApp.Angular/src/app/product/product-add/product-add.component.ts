import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Product } from 'src/entities/product';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.scss']
})
export class ProductAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  product:Product={
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
