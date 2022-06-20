import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-region-index',
  templateUrl: './region-index.component.html',
  styleUrls: ['./region-index.component.scss']
})
export class RegionIndexComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  regions=[
    {id:1, name:"demo1"},
    {id:2, name:"demo2"},
    {id:3, name:"demo3"},
    {id:4, name:"demo4"}
  ]

}
