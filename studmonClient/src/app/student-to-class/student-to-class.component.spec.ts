import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentToClassComponent } from './student-to-class.component';

describe('StudentToClassComponent', () => {
  let component: StudentToClassComponent;
  let fixture: ComponentFixture<StudentToClassComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentToClassComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentToClassComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
