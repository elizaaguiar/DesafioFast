import { Routes } from '@angular/router';
import { Workshops } from './Components/workshops/workshops';
import { Collaborators } from './Components/collaborators/collaborators';
import { Attendance } from './Components/attendance/attendance';

export const routes: Routes = [
    {   
        path: "", redirectTo: "workshops", pathMatch: "full"
    },
    {
        path: "workshops", component: Workshops
    },
    {
        path: "workshops/:guid", component: Attendance
    },
    {
        path: "collaborators", component: Collaborators
    }
];
