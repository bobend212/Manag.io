import { UserProject } from './userProject';

export interface User {
    id: number;
    username: string;
    firstName: string;
    lastName: string;
    email: string;
    phone: string;
    hireDate: Date;
    gender: string;
    jobTitle: string;
    userProjects?: UserProject[];
}
