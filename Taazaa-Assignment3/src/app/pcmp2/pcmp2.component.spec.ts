import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Pcmp2Component } from './pcmp2.component';

describe('Pcmp2Component', () => {
  let component: Pcmp2Component;
  let fixture: ComponentFixture<Pcmp2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Pcmp2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Pcmp2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
