import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SupplierResponse } from 'src/entities/ResponseModel/supplierResponse';
import { SupplierService } from 'src/services/supplier.service';

@Component({
  selector: 'app-supplier-index',
  templateUrl: './supplier-index.component.html',
  styleUrls: ['./supplier-index.component.scss']
})
export class SupplierIndexComponent implements OnInit {

  suppliers: SupplierResponse[] = [];

  constructor(private supplierService: SupplierService,
    private router: Router) { }

  ngOnInit(): void {
    this.getSuppliers();
  }
  getSuppliers() {
    this.supplierService.getAllSupplier().subscribe(
      (data) => { this.suppliers = data }
    );
  }

  deleteSupplier(id: number) {
    this.supplierService.deleteSupplier(id).subscribe(
      (d: any) => { this.getSuppliers() }
    );
  }

  editSupplier(id: number) {
    this.router.navigate(['/supplier/edit/' + id]);
  }

}
