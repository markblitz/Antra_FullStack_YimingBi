import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperEditComponent } from './shipper-edit.component';

describe('ShipperEditComponent', () => {
  let component: ShipperEditComponent;
  let fixture: ComponentFixture<ShipperEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperEditComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShipperEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
