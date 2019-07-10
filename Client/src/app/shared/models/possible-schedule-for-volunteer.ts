import { Time } from "@angular/common";

export class PossibleScheduleForVolunteer {
 id :number;
 public weekDay:number;
 public fromHour :Time;
 public toHour :Time;
 public volunteerToGroupId :number;
 userId:number;
    constructor(id:number,userId:number){
    this.id=id;
    this.userId=userId;
    
    
}
}
