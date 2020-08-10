import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { UsersComponent } from './users/users.component';
import { UserDetailComponent } from './user-detail/user-detail.component';

export const appRoutes: Routes = [
    { path: 'users/register', component: RegisterComponent },
    { path: 'users', component: UsersComponent },
    { path: 'users/:id', component: UserDetailComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];