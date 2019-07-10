import { Time } from "@angular/common";

export class VolunteerSchedule {
    constructor(
        public id:number,
        public weekDay:number,
        public FromHour:Time,
        public toHour:Time,
        public volunteerToGroupId:number,
        public comment:string
    ){}
}
