import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OraCreateComponent } from './ora-create.component';

describe('OraCreateComponent', () => {
  let component: OraCreateComponent;
  let fixture: ComponentFixture<OraCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OraCreateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OraCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
