

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Users } from '../models/users'


@Injectable({
    providedIn: 'root',
})
export class UserService {
    url = 'http://localhost:53098/';
    user: Users;
    constructor(private http: HttpClient) {
        setInterval(() => {
            ///כאן לעשות פונקציה למתחברת לwebapiומקבלת את 
        }, 180000);

    }
    login(mail, password) {
        return this.http.get(this.url + 'api/user/login?mail=' + mail + '&password=' + password);
    }
    account(user: Users) {
        return this.http.post(this.url + 'api/user/account', user);

    }
}