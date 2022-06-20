import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegionIndexComponent } from './region-index/region-index.component';
import { RegionAddComponent } from './region-add/region-add.component';
import { RegionEditComponent } from './region-edit/region-edit.component';
import { RegionRoutingModule } from './region-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    RegionIndexComponent,
    RegionAddComponent,
    RegionEditComponent
  ],
  imports: [
    CommonModule,
    RegionRoutingModule,
    FormsModule
  ]
})
export class RegionModule { }
