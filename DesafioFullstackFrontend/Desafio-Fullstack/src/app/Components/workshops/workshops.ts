import { Component, inject, OnInit } from '@angular/core';
import { WorkshopService } from '../../Services/workshop.services';
import { WorkshopState } from '../../States/workshop.state';
import { switchMap, tap } from 'rxjs';
import { Workshop } from '../../Models/workshop.model';
import { CollaboratorService } from '../../Services/collaborator.services';
import { DatePipe } from "@angular/common";
import { AttendanceService } from '../../Services/attendance.services';
import { Collaborator } from '../../Models/collaborator.model';
import { Router } from '@angular/router';
import { ItemUi } from '../item-ui/item-ui';

@Component({
  selector: 'app-workshops',
  imports: [ItemUi],
  templateUrl: './workshops.html',
  styleUrl: './workshops.scss'
})
export class Workshops implements OnInit {
  workshopService = inject(WorkshopService);
  workshopState = inject(WorkshopState);
  workshops = this.workshopService.workshops;
  attendanceService = inject(AttendanceService);
  attendances = this.attendanceService.attendances;
  route = inject(Router);

  constructor() { }
  ngOnInit(): void {
    this.workshopService.getWorkshops().subscribe();
  }
  navigateToAttendance(guid: string){
    this.route.navigate([
      '/workshops', guid
    ])
  }
}
