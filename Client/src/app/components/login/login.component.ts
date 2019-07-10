import { Component, OnInit } from '@angular/core';
import { UserService } from '../../shared/services/user.service';
import { Users } from '../../shared/models/users';
import { NgModule } from '@angular/core';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  ngOnInit(){}

  
  userlogin:Users=new Users(1);

  constructor(private userService: UserService) { }
  login() {
    this.userService.login(this.userlogin.mail,this.userlogin.password).subscribe((x:Users) => {
      if (x != null) {
        this.userService.user=x;
        alert('success');

      }
      else
        alert('unsuccesful');
    });
  }
  
  
}
