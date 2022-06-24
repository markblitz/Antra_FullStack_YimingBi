import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Shipper } from 'src/entities/shipper';
import { ShipperService } from 'src/services/shipper.service';

@Component({
  selector: 'app-shipper-index',
  templateUrl: './shipper-index.component.html',
  styleUrls: ['./shipper-index.component.scss']
})
export class ShipperIndexComponent implements OnInit {

  shippers: Shipper[] = [];

  constructor(private shipperService: ShipperService,
    private router: Router) { }

  ngOnInit(): void {
    this.getShippers();
  }
  getShippers() {
    this.shipperService.getAllShipper().subscribe(
      (data) => { this.shippers = data }
    );
  }

  deleteShipper(id: number) {
    this.shipperService.deleteShipper(id).subscribe(
      (d: any) => { this.getShippers() }
    );
  }

  editShipper(id: number) {
    this.router.navigate(['/shipper/edit/' + id]);
  }


}
