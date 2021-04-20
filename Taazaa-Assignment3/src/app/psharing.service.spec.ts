import { TestBed } from '@angular/core/testing';

import { PsharingService } from './psharing.service';

describe('PsharingService', () => {
  let service: PsharingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PsharingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
