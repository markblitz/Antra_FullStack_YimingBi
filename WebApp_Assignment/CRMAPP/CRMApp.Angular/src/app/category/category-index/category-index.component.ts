import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from 'src/entities/category';
import { CategoryService } from 'src/services/category.service';


@Component({
  selector: 'app-category-index',
  templateUrl: './category-index.component.html',
  styleUrls: ['./category-index.component.scss']
})
export class CategoryIndexComponent implements OnInit {

  categories: Category[] = [];

  constructor(private categoryService: CategoryService,
    private router: Router) { }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories() {
    this.categoryService.getAllCategory().subscribe(
      (data) => { this.categories = data }
    );
  }

  deleteCategory(id: number) {
    this.categoryService.deleteCategory(id).subscribe(
      (d: any) => { this.getCategories() }
    );
  }

  editCategory(id:number){
    //console.log(id)
    this.router.navigate(['/category/edit/'+id]);
  }

}
