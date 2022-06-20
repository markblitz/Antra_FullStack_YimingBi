import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperIndexComponent } from './shipper-index/shipper-index.component';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';
import { ShipperEditComponent } from './shipper-edit/shipper-edit.component';
import { ShipperRoutingModule } from './shipper-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    ShipperIndexComponent,
    ShipperAddComponent,
    ShipperEditComponent
  ],
  imports: [
    CommonModule,
    ShipperRoutingModule,
    FormsModule
  ]
})
export class ShipperModule { }
