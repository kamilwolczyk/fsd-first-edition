import { Component, OnInit } from '@angular/core';

interface LoginFormData {
  login: string;
  password: string
}

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  loginText: string;
  password: string;
  private allowance: boolean;

  constructor() { }

  ngOnInit() {
    // this.allowance = Boolean(false);
  }

  logIn(formData: LoginFormData, form:any): void {
    // console.log('Log In')
    if (formData.login === 'Login' && formData.password === 'Pass') {
      this.allowance = true;
    }
  }

  logOut(): void {
    this.allowance = false;
  }
  checkPermissions(): Boolean {
    return this.allowance;
  }

}
