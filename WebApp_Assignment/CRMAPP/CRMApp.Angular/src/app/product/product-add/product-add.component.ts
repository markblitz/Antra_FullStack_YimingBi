import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Category } from 'src/entities/category';
import { ProductRequest } from 'src/entities/RequestModel/productRequest';
import { SupplierResponse } from 'src/entities/ResponseModel/supplierResponse';
import { CategoryService } from 'src/services/category.service';
import { ProductService } from 'src/services/product.service';
import { SupplierService } from 'src/services/supplier.service';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.scss']
})
export class ProductAddComponent implements OnInit {

  productForm: FormGroup;
  insertSuccessful: boolean = false;
  categories:Category[]=[];
  suppliers:SupplierResponse[]=[];
  product: ProductRequest = {
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

  constructor(private productService: ProductService,
    private supplierService:SupplierService,
    private categoryService:CategoryService,
    private builder: FormBuilder) {
    this.productForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'supplierId': new FormControl(null, [Validators.required]),
        'categoryId': new FormControl(null, [Validators.required]),
        'quantityPerUnit': new FormControl(null),
        'unitPrice': new FormControl(null),
        'unitInStock': new FormControl(null),
        'unitsOnOrder': new FormControl(null),
        'reorderLevel': new FormControl(null),
        'discontinued': new FormControl(null, [Validators.required]),
      }
    );
    this.supplierService.getAllSupplier().subscribe(
      data=>{this.suppliers=data}
    );
    this.categoryService.getAllCategory().subscribe(
      data=>{this.categories=data}
    );
  }

  ngOnInit(): void {
  }

  insertProduct(){
    this.product.categoryId = this.productForm.value["categoryId"];
    this.product.discontinued = this.productForm.value["discontinued"];
    this.product.name = this.productForm.value["name"];
    this.product.quantityPerUnit = this.productForm.value["quantityPerUnit"];
    this.product.reorderLevel = this.productForm.value["reorderLevel"];
    this.product.supplierId = this.productForm.value["supplierId"];
    this.product.unitInStock = this.productForm.value["unitInStock"];
    this.product.unitPrice = this.productForm.value["unitPrice"];
    this.product.unitsOnOrder = this.productForm.value["unitsOnOrder"];

    this.productService.insertProduct(this.product).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }

}
