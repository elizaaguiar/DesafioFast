import { Component, inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AttendanceService } from '../../Services/attendance.services';
import { Collaborator } from '../../Models/collaborator.model';
import { tap } from 'rxjs';
import { ItemUi } from '../item-ui/item-ui';

@Component({
  selector: 'app-attendance',
  imports: [ItemUi],
  templateUrl: './attendance.html',
  styleUrl: './attendance.scss'
})
export class Attendance implements OnInit {
  route = inject(ActivatedRoute)
  guid!: string;
  collaborators: Collaborator[] = [];
  attendanceService = inject(AttendanceService);
  attendanceState = inject(AttendanceService);
  attendances = this.attendanceService.attendances;
  constructor() { }

  ngOnInit(): void {
    this.guid = this.route.snapshot.paramMap.get('guid')!;
    this.getWorkshopAttendances(this.guid);
  }
  getWorkshopAttendances(guid: string) {
    this.attendanceService.getAttendance(guid).pipe(tap((response: Collaborator[]) => {
      this.collaborators = response
    })).subscribe();
  }
}
