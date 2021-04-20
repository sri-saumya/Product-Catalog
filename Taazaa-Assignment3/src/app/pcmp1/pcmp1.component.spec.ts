import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Pcmp1Component } from './pcmp1.component';

describe('Pcmp1Component', () => {
  let component: Pcmp1Component;
  let fixture: ComponentFixture<Pcmp1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Pcmp1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Pcmp1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
