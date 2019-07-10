import { Time } from "@angular/common";

export class VolunteerTiming {
    constructor(
       public id:number,
       public groupVolunteerId:number,
       public fromHour:Time,
       public toHour:Time,
       public weekday:number
    ){}
}

