import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { SupplierAddComponent } from "./supplier-add/supplier-add.component";
import { SupplierEditComponent } from "./supplier-edit/supplier-edit.component";
import { SupplierIndexComponent } from "./supplier-index/supplier-index.component";




const routes:Routes=[
    {path:'index', component:SupplierIndexComponent},
    {path:'add', component:SupplierAddComponent},
    {path:'edit/:id', component:SupplierEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class SupplierRoutingModule{

}