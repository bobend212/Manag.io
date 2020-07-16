import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  loginMode = false;

  constructor() { }

  ngOnInit() {
  }

  loginToggle() {
    this.loginMode = !this.loginMode;
  }

  cancelLoginMode(loginMode: boolean) {
    this.loginMode = loginMode;
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

}
