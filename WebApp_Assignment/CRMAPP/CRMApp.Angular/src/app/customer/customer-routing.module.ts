import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CustomerAddComponent } from "./customer-add/customer-add.component";
import { CustomerEditComponent } from "./customer-edit/customer-edit.component";
import { CustomerIndexComponent } from "./customer-index/customer-index.component";

const routes:Routes=[
    {path:'index', component:CustomerIndexComponent},
    {path:'add', component:CustomerAddComponent},
    {path:'edit', component:CustomerEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class CustomerRoutingModule{

}