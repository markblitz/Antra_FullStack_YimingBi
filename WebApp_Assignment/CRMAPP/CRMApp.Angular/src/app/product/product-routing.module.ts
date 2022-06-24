import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ProductAddComponent } from "./product-add/product-add.component";
import { ProductEditComponent } from "./product-edit/product-edit.component";
import { ProductIndexComponent } from "./product-index/product-index.component";

const routes:Routes=[
    {path:'index', component:ProductIndexComponent},
    {path:'add', component:ProductAddComponent},
    {path:'edit/:id', component:ProductEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class ProductRoutingModule{

}