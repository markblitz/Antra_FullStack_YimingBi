import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-category-index',
  templateUrl: './category-index.component.html',
  styleUrls: ['./category-index.component.scss']
})
export class CategoryIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  categories=[
    {id: 1, name:"demo1", description:""},
    {id: 2, name:"demo2", description:""},
    {id: 3, name:"demo3", description:""},
    {id: 4, name:"demo4", description:""},
  ]
}
