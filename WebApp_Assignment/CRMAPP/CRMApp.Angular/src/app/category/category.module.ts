import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryIndexComponent } from './category-index/category-index.component';
import { CategoryAddComponent } from './category-add/category-add.component';
import { CategoryEditComponent } from './category-edit/category-edit.component';
import { CategoryRoutingModule } from './category-routing.module';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    CategoryIndexComponent,
    CategoryAddComponent,
    CategoryEditComponent
  ],
  imports: [
    CommonModule,
    CategoryRoutingModule,
    FormsModule
  ]
})
export class CategoryModule { }
