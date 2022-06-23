import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Category } from 'src/entities/category';
import { CategoryService } from 'src/services/category.service';

@Component({
  selector: 'app-category-add',
  templateUrl: './category-add.component.html',
  styleUrls: ['./category-add.component.scss']
})
export class CategoryAddComponent implements OnInit {

  categoryForm: FormGroup;
  category: Category = {
    id: 0,
    name: '',
    description: ''
  }
  insertSuccessful: boolean = false;

  constructor(private builder: FormBuilder,
    private categoryService: CategoryService) {
    this.categoryForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
        'description': new FormControl(null)
      }
    );
  }

  ngOnInit(): void {
  }

  insertCategory() {
    //console.log(this.categoryForm.value);
    this.category.name = this.categoryForm.value["name"];
    this.category.description = this.categoryForm.value["description"];
    this.categoryService.insertCategory(this.category).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }
}
