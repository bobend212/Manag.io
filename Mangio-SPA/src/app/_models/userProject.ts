import { User } from './user';
import { Project } from './project';

export interface UserProject {
    userId: number;
    projectId: number;
    user: User;
    project: Project
    projectNumber: string;
    projectName: string;
    isFinished: boolean;
    firstName: string;
    lastName: string;
}
