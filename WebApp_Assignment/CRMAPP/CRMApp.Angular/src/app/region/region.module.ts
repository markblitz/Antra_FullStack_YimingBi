import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegionIndexComponent } from './region-index/region-index.component';
import { RegionAddComponent } from './region-add/region-add.component';
import { RegionEditComponent } from './region-edit/region-edit.component';
import { RegionRoutingModule } from './region-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { RegionService } from 'src/services/region.service';



@NgModule({
  declarations: [
    RegionIndexComponent,
    RegionAddComponent,
    RegionEditComponent
  ],
  imports: [
    CommonModule,
    RegionRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [
    RegionService
  ]
})
export class RegionModule { }
