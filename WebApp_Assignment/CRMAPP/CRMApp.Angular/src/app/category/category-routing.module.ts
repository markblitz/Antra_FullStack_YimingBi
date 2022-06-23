import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CategoryAddComponent } from "./category-add/category-add.component";
import { CategoryEditComponent } from "./category-edit/category-edit.component";
import { CategoryIndexComponent } from "./category-index/category-index.component";

const routes:Routes=[
    {path:'index', component:CategoryIndexComponent},
    {path:'add', component:CategoryAddComponent},
    {path:'edit/:id', component:CategoryEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class CategoryRoutingModule{

}