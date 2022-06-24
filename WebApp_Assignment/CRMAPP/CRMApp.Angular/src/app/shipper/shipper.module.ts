import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperIndexComponent } from './shipper-index/shipper-index.component';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';
import { ShipperEditComponent } from './shipper-edit/shipper-edit.component';
import { ShipperRoutingModule } from './shipper-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ShipperService } from 'src/services/shipper.service';



@NgModule({
  declarations: [
    ShipperIndexComponent,
    ShipperAddComponent,
    ShipperEditComponent
  ],
  imports: [
    CommonModule,
    ShipperRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [
    ShipperService
  ]
})
export class ShipperModule { }
