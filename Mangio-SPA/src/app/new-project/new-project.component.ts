import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Project } from '../_models/project';
import { AlertifyService } from '../_services/alertify.service';
import { ProjectService } from '../_services/project.service';

@Component({
  selector: 'app-new-project',
  templateUrl: './new-project.component.html',
  styleUrls: ['./new-project.component.css']
})
export class NewProjectComponent implements OnInit {

  constructor(private prjectService: ProjectService, private fb: FormBuilder, private alertify: AlertifyService, private router: Router) { }

  newProjectForm: FormGroup;
  project: Project;

  ngOnInit() {
    this.createNewProjectForm();
  }

  createNewProjectForm() {
    this.newProjectForm = this.fb.group({
      number: ['', Validators.required],
      name: ['', Validators.required],
      status: ['', Validators.required]
    });
  }

  addNewProject() {
    if (this.newProjectForm.valid) {
      this.project = Object.assign({}, this.newProjectForm.value);
      this.prjectService.addProject(this.project).subscribe(
        () => {
          this.alertify.success(this.project.number + ' ' + this.project.name + ' successfully added!');
        },
        error => {
          this.alertify.error(error);
        }
      );
    }
    console.log("new project added");
  }

}
