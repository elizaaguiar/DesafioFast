import { HttpClient } from '@angular/common/http';
import { Injectable, signal } from '@angular/core';
import { Workshop } from '../Models/workshop.model';
import { Collaborator } from '../Models/collaborator.model';

@Injectable({
  providedIn: 'root'
})
export class AttendanceService {
  private apiUrl = 'http://localhost:5278/api/attendance'
  private _attendance = signal<Collaborator[] | null>(null);
  public attendances = this._attendance.asReadonly();

  constructor(private http: HttpClient) { }
  getAttendance(guid: string) {
    const url = this.apiUrl + `/${guid}`;
    return this.http.get<Collaborator[]>(url);
  }
}
