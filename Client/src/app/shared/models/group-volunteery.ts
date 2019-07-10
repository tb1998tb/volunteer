import { Time } from "@angular/common";

export class GroupVolunteery {
    constructor(
        public id:number,
        public nameGroup :string,
        public sum_hour_in_night:number,
        public sum_hour_volunteering_for_week:number,
        public managerId:number,
        public from_hour_in_night:Time,
        public to_hour_in_night:Time

    ){}
}
