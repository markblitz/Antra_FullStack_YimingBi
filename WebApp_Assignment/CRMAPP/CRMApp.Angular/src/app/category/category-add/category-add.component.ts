import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Category } from 'src/entities/category';

@Component({
  selector: 'app-category-add',
  templateUrl: './category-add.component.html',
  styleUrls: ['./category-add.component.scss']
})
export class CategoryAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  category:Category={
    name:"",
    description:""
  }

  insertCategory(form:NgForm){
    console.log(form.value)
  }
}
