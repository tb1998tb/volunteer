import { TestBed } from '@angular/core/testing';

import { PossibleScheduleForVolunteerServiceService } from './possible-schedule-for-volunteer-service.service';

describe('PossibleScheduleForVolunteerServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PossibleScheduleForVolunteerServiceService = TestBed.get(PossibleScheduleForVolunteerServiceService);
    expect(service).toBeTruthy();
  });
});
