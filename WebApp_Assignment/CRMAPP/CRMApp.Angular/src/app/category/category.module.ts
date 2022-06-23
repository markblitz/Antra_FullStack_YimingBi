import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryIndexComponent } from './category-index/category-index.component';
import { CategoryAddComponent } from './category-add/category-add.component';
import { CategoryEditComponent } from './category-edit/category-edit.component';
import { CategoryRoutingModule } from './category-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CategoryService } from 'src/services/category.service';



@NgModule({
  declarations: [
    CategoryIndexComponent,
    CategoryAddComponent,
    CategoryEditComponent
  ],
  imports: [
    CommonModule,
    CategoryRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
  ],
  providers: [
    CategoryService
  ]
})
export class CategoryModule { }
