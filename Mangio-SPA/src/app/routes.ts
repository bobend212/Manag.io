import { Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { UsersComponent } from './users/users.component';

export const appRoutes: Routes = [
    { path: 'users/register', component: RegisterComponent },
    { path: 'users', component: UsersComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];