import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Ccmp2Component } from './ccmp2.component';

describe('Ccmp2Component', () => {
  let component: Ccmp2Component;
  let fixture: ComponentFixture<Ccmp2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Ccmp2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Ccmp2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
