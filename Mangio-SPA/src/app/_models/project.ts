import { UserProject } from './userProject';

export interface Project {
    id: number;
    number: string;
    name: string;
    dateAdded: Date;
    status: string;
    isFinished: boolean;
    userProjects?: UserProject[];
}
