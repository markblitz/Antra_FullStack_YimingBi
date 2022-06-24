import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { RegionAddComponent } from "./region-add/region-add.component";
import { RegionEditComponent } from "./region-edit/region-edit.component";
import { RegionIndexComponent } from "./region-index/region-index.component";


const routes:Routes=[
    {path:'index', component:RegionIndexComponent},
    {path:'add', component:RegionAddComponent},
    {path:'edit/:id', component:RegionEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class RegionRoutingModule{

}