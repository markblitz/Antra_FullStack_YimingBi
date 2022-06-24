import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProductResponse } from 'src/entities/ResponseModel/productRespoonse';
import { ProductService } from 'src/services/product.service';

@Component({
  selector: 'app-product-index',
  templateUrl: './product-index.component.html',
  styleUrls: ['./product-index.component.scss']
})
export class ProductIndexComponent implements OnInit {

  products:ProductResponse[]=[];

  constructor(private productService:ProductService,
    private router:Router) { }

  ngOnInit(): void {
    this.getProducts();
  }

  getProducts(){
    this.productService.getAllProduct().subscribe(
      (data) => { this.products = data }
    );
  }

  deleteProduct(id:number){
    this.productService.deleteProduct(id).subscribe(
      (d: any) => { this.getProducts() }
    );
  }

  editProduct(id:number){
    this.router.navigate(['/product/edit/'+id]);
  }
}
