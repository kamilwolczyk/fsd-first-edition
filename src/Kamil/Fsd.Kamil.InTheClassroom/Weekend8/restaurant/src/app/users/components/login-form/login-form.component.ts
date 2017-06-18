import { Component, OnInit } from '@angular/core';
import { User } from "app/users";

interface LoginFormData {
  login: string;
  password: string;
  email: string;
}

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  user: User;
  isLogged: boolean;
  error: string;

  ngOnInit() {
  }

  login(formData: LoginFormData): void {
    if (!this.verifyFormData(formData)) {
      this.error = 'Invalid login or password';
      return;
    }
    this.setUser(formData);
    this.error = null;
    this.isLogged = true;
  }

  logout() {
    this.user = new User();
    this.isLogged = false;
    this.error = null;
  }

  private verifyFormData(formData: LoginFormData) {
    return (formData.login == 'jan' && formData.password == 'dupa');
  }

  private setUser(formData: LoginFormData): void {
    this.user = new User();
    this.user.login = formData.login;
    this.user.password = formData.password;
    this.user.email = formData.email;
  }
}
