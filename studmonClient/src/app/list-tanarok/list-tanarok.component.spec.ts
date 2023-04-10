import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListTanarokComponent } from './list-tanarok.component';

describe('ListTanarokComponent', () => {
  let component: ListTanarokComponent;
  let fixture: ComponentFixture<ListTanarokComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListTanarokComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListTanarokComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
