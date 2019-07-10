import { Injectable } from '@angular/core';
import{PossibleScheduleForVolunteer}from '../models/possible-schedule-for-volunteer';
import{HttpClient}from'@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class PossibleScheduleForVolunteerServiceService {
  url='http://localhost:53098/';
  constructor(private http:HttpClient){}
  addPossibleScheduleForVolunteer(PossibleScheduleForVolunteer:PossibleScheduleForVolunteer)
  {
return this.http.post(this.url+'api/user/addPossibleScheduleForVolunteer',PossibleScheduleForVolunteer);
  }
  
}






    