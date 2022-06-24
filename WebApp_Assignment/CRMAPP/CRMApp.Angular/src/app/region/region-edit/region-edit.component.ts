import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Region } from 'src/entities/region';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-region-edit',
  templateUrl: './region-edit.component.html',
  styleUrls: ['./region-edit.component.scss']
})
export class RegionEditComponent implements OnInit {

  regionForm: FormGroup;
  editSuccessful: boolean = false;
  editId: number = 0;
  region: Region = {
    id: 0,
    name: ''
  }

  constructor(private activatedRoute: ActivatedRoute,
    private builder: FormBuilder,
    private regionService: RegionService) {
    activatedRoute.params.subscribe(d => { this.editId = d["id"] });
    this.regionForm = builder.group(
      {
        'name': new FormControl(null, [Validators.required]),
      }
    );
    this.getCustomer();
  }

  ngOnInit(): void {
  }

  getCustomer(){
    this.regionService.getRegionById(this.editId).subscribe(data=>{
      this.regionForm.patchValue(data);
    });
  }

  saveRegion() {
    //console.log(this.customerForm.value)
    this.region.id = this.editId;
    this.region.name = this.regionForm.value["name"];

    this.regionService.updateRegion(this.region).subscribe((d: any) => {
      this.editSuccessful = true;
    });
  }
}
