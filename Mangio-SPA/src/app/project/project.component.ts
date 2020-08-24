import { Component, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ProjectService } from '../_services/project.service';
import { Project } from '../_models/project';
import { AlertifyService } from '../_services/alertify.service';
import { Table } from 'primeng/table';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {
  projects: Project[];

  @ViewChild('dt') table: Table;
  statuses: any[];

  constructor(private http: HttpClient, private projectService: ProjectService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadProjects();

    this.statuses = [
      { label: 'Completed', value: 'Completed' },
      { label: 'In Progress', value: 'In Progress' }
    ];
  }

  // getProjects() {
  //   this.http.get("http://localhost:5000/projects").subscribe(response => {
  //     this.projects = response;
  //   }, error => {
  //     console.log(error);
  //   });
  // }

  loadProjects() {
    this.projectService.getProjects().subscribe((projects: Project[]) => {
      this.projects = projects;
    }, error => {
      this.alertify.error(error);
    });
  }

  onRepresentativeChange(event) {
    this.table.filter(event.value, 'representative', 'in')
  }

}
