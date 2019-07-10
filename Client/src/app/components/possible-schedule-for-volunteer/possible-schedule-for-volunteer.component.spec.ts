import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PossibleScheduleForVolunteerComponent } from './possible-schedule-for-volunteer.component';

describe('PossibleScheduleForVolunteerComponent', () => {
  let component: PossibleScheduleForVolunteerComponent;
  let fixture: ComponentFixture<PossibleScheduleForVolunteerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PossibleScheduleForVolunteerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PossibleScheduleForVolunteerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
