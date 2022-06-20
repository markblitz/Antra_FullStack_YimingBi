import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperIndexComponent } from './shipper-index.component';

describe('ShipperIndexComponent', () => {
  let component: ShipperIndexComponent;
  let fixture: ComponentFixture<ShipperIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperIndexComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShipperIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
