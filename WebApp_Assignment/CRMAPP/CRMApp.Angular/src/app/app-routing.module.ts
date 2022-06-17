import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProductIndexComponent } from './product/product-index/product-index.component';
import { ProductAddComponent } from './product/product-add/product-add.component';
import { ProductEditComponent } from './product/product-edit/product-edit.component';
import { NotFoundPageComponent } from './not-found-page/not-found-page.component';

const routes: Routes = [
  { path: '', component: ProductIndexComponent },

  { path: 'product', component: ProductIndexComponent },
  { path: 'product/index', component: ProductIndexComponent },
  { path: 'product/add', component: ProductAddComponent },
  { path: 'product/edit/:id', component: ProductEditComponent },
  
  { path: '**', component: NotFoundPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
