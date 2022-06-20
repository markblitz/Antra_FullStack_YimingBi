import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { ShipperAddComponent } from "./shipper-add/shipper-add.component";
import { ShipperEditComponent } from "./shipper-edit/shipper-edit.component";
import { ShipperIndexComponent } from "./shipper-index/shipper-index.component";



const routes:Routes=[
    {path:'index', component:ShipperIndexComponent},
    {path:'add', component:ShipperAddComponent},
    {path:'edit', component:ShipperEditComponent}
]

@NgModule(
    {
        imports:[RouterModule.forChild(routes)]
    }
)
export class ShipperRoutingModule{

}