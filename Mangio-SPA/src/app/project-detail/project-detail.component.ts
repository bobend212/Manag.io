import { Component, OnInit } from '@angular/core';
import { Project } from '../_models/project';
import { ProjectService } from '../_services/project.service';
import { AlertifyService } from '../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { UserService } from '../_services/user.service';
import { User } from '../_models/user';

@Component({
  selector: 'app-project-detail',
  templateUrl: './project-detail.component.html',
  styleUrls: ['./project-detail.component.css']
})
export class ProjectDetailComponent implements OnInit {
  project: Project;
  user: User;

  constructor(private projectService: ProjectService, private alertify: AlertifyService, private route: ActivatedRoute, private userService: UserService) { }

  ngOnInit() {
    this.loadProject();
    this.loadUser();
  }

  loadProject() {
    this.projectService.getProject(+this.route.snapshot.params['id']).subscribe((project: Project) => {
      this.project = project;
    }, error => {
      this.alertify.error(error);
    })
  }

  loadUser() {
    this.userService.getUser(+this.route.snapshot.params['id']).subscribe((user: User) => {
      this.user = user;
    }, error => {
      this.alertify.error(error);
    })
  }

}
