import { TestBed } from '@angular/core/testing';

import { TanarokService } from './tanarok.service';

describe('TanarokService', () => {
  let service: TanarokService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TanarokService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
