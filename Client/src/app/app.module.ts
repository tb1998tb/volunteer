import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { FooterComponent } from './components/footer/footer.component';
import { MainComponent } from './components/main/main.component';
import { HeaderComponent } from './components/header/header.component';
import {UserService} from './shared/services/user.service';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './components/login/login.component';
import { AccountComponent } from './components/account/account.component';
import { PossibleScheduleForVolunteerComponent } from './components/possible-schedule-for-volunteer/possible-schedule-for-volunteer.component';
import{FormsModule,ReactiveFormsModule}from '@angular/forms';
import { NewGroupComponent } from './components/new-group/new-group.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    MainComponent,
    HeaderComponent,
    LoginComponent,
    AccountComponent,
    PossibleScheduleForVolunteerComponent,
    NewGroupComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
    
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
