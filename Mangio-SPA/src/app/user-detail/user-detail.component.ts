import { Component, OnInit } from '@angular/core';
import { User } from '../_models/user';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { Project } from '../_models/project';
import { UserProject } from '../_models/userProject';

@Component({
  selector: 'app-user-detail',
  templateUrl: './user-detail.component.html',
  styleUrls: ['./user-detail.component.css']
})
export class UserDetailComponent implements OnInit {
  user: User;

  constructor(private userService: UserService, private alertify: AlertifyService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.loadUser();
  }

  loadUser() {
    this.userService.getUser(+this.route.snapshot.params['id']).subscribe((user: User) => {
      this.user = user;
    }, error => {
      this.alertify.error(error);
    })
  }

}
