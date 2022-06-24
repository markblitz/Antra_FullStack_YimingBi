import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Region } from 'src/entities/region';
import { RegionService } from 'src/services/region.service';

@Component({
  selector: 'app-region-index',
  templateUrl: './region-index.component.html',
  styleUrls: ['./region-index.component.scss']
})
export class RegionIndexComponent implements OnInit {

  regions: Region[] = [];

  constructor(private regionService: RegionService,
    private router: Router) { }

  ngOnInit(): void {
    this.getRegions();
  }
  getRegions() {
    this.regionService.getAllRegion().subscribe(
      (data) => { this.regions = data }
    );
  }

  deleteRegion(id: number) {
    this.regionService.deleteRegion(id).subscribe(
      (d: any) => { this.getRegions() }
    );
  }

  editRegion(id: number) {
    this.router.navigate(['/region/edit/' + id]);
  }

}
