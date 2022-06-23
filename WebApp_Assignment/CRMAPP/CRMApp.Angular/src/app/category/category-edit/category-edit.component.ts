import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Category } from 'src/entities/category';
import { CategoryService } from 'src/services/category.service';

@Component({
  selector: 'app-category-edit',
  templateUrl: './category-edit.component.html',
  styleUrls: ['./category-edit.component.scss']
})
export class CategoryEditComponent implements OnInit {

  categoryForm: FormGroup;
  editId: number = 0;
  editSuccessful: boolean = false;

  editCategory: Category = {
    id: 0,
    name: '',
    description: ''
  }

  constructor(private activatedRoute: ActivatedRoute,
    private categoryService: CategoryService,
    builder: FormBuilder) {
    activatedRoute.params.subscribe(d => { this.editId=d["id"] });
    this.categoryForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'description': new FormControl(null)
      }
    );
    this.getCategory();
  }

  ngOnInit(): void {
    
  }

  getCategory() {
    this.categoryService.getCategoryById(this.editId).subscribe(d => {
      this.categoryForm.patchValue(d);
    });
  }

  saveCategory() {
    this.editCategory.id = this.editId;
    this.editCategory.name = this.categoryForm.value["name"];
    this.editCategory.description = this.categoryForm.value["description"];
    this.categoryService.updateCategory(this.editCategory).subscribe((d) => {
      this.editSuccessful = true;
    });
  }

}
