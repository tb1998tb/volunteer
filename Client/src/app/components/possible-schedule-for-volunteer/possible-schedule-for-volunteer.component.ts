import { Component, OnInit } from '@angular/core';
import{PossibleScheduleForVolunteer}from '../../shared/models/possible-schedule-for-volunteer';
import{PossibleScheduleForVolunteerServiceService}from '../../shared/services/possible-schedule-for-volunteer-service.service';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-possible-schedule-for-volunteer',
  templateUrl: './possible-schedule-for-volunteer.component.html',
  styleUrls: ['./possible-schedule-for-volunteer.component.css']
})
export class PossibleScheduleForVolunteerComponent implements OnInit {

  PossibleScheduleForVolunteer:PossibleScheduleForVolunteer=new PossibleScheduleForVolunteer(0,this.userServ.user.id);

  constructor(private PossibleScheduleForVolunteerService:PossibleScheduleForVolunteerServiceService,private userServ:UserService ){}

  ngOnInit() {
  }

  addPossibleScheduleForVolunteer()
  {
    
    this.PossibleScheduleForVolunteerService.addPossibleScheduleForVolunteer(this.PossibleScheduleForVolunteer);
  }
}

  

