import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Region } from 'src/entities/region';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-region-add',
  templateUrl: './region-add.component.html',
  styleUrls: ['./region-add.component.scss']
})
export class RegionAddComponent implements OnInit {

  regionForm: FormGroup;
  insertSuccessful: boolean = false;
  region:Region  = {
    id: 0,
    name: ''
  }
  
  constructor(private builder: FormBuilder,
    private regionService:RegionService) {
    this.regionForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
      }
    );
  }

  ngOnInit(): void {
  }

  insertRegion() {
    //console.log(this.customerForm.value)
    this.region.name = this.regionForm.value["name"];
    
    this.regionService.insertRegion(this.region).subscribe((d: any) => {
      this.insertSuccessful = true;
    });
  }
}
