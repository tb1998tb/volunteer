import { Component, OnInit } from '@angular/core';
import { Users } from 'src/app/shared/models/users';
import { UserService } from 'src/app/shared/services/user.service';



@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
ngOnInit(){}
 
user:Users=new Users(1);
constructor(private userService:UserService) { }

account(){
  this.userService.account(this.user).subscribe((x)=>{
    if (x != null) {
      alert('success');

    }
    else
      alert('unsuccesful');
} );
}


}

