import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { UsersComponent } from './users/users.component';
import { UserDetailComponent } from './user-detail/user-detail.component';
import { ProjectComponent } from './project/project.component';
import { ProjectDetailComponent } from './project-detail/project-detail.component';
import { UserEditComponent } from './user-edit/user-edit.component';
import { UserEditResolver } from './_resolvers/user-edit.resolver';
import { NewProjectComponent } from './new-project/new-project.component';

export const appRoutes: Routes = [
    { path: 'users/register', component: RegisterComponent },
    { path: 'users', component: UsersComponent },
    { path: 'projects', component: ProjectComponent },
    { path: 'new-project', component: NewProjectComponent },
    { path: 'users/:id', component: UserDetailComponent },
    { path: 'user/edit', component: UserEditComponent, resolve: { user: UserEditResolver } },
    { path: 'projects/:id', component: ProjectDetailComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];