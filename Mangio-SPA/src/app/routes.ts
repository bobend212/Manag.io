import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { UsersComponent } from './users/users.component';
import { UserDetailComponent } from './user-detail/user-detail.component';
import { ProjectComponent } from './project/project.component';

export const appRoutes: Routes = [
    { path: 'users/register', component: RegisterComponent },
    { path: 'users', component: UsersComponent },
    { path: 'projects', component: ProjectComponent },
    { path: 'users/:id', component: UserDetailComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];