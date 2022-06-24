import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { EmployeeAddComponent } from "./employee-add/employee-add.component";
import { EmployeeEditComponent } from "./employee-edit/employee-edit.component";
import { EmployeeIndexComponent } from "./employee-index/employee-index.component";

const routes:Routes=[
    {path:'index', component:EmployeeIndexComponent},
    {path:'add', component:EmployeeAddComponent},
    {path:'edit/:id', component:EmployeeEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class EmployeeRoutingModule{

}