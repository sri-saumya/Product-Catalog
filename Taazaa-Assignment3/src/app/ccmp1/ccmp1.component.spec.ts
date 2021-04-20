import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Ccmp1Component } from './ccmp1.component';

describe('Ccmp1Component', () => {
  let component: Ccmp1Component;
  let fixture: ComponentFixture<Ccmp1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Ccmp1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Ccmp1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
