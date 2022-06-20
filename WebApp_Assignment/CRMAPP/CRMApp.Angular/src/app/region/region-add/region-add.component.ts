import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { region } from 'src/entities/region';

@Component({
  selector: 'app-region-add',
  templateUrl: './region-add.component.html',
  styleUrls: ['./region-add.component.scss']
})
export class RegionAddComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  region:region={
    name: ''
  }

  insertRegion(form:NgForm){
    console.log(form.value)
  }
}
