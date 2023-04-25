import { TestBed } from '@angular/core/testing';

import { LoginAuthServiceService } from './login-auth-service.service';

describe('LoginAuthServiceService', () => {
  let service: LoginAuthServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LoginAuthServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
