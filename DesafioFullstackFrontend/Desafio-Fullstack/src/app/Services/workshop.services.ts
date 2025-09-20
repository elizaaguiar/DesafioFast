import { HttpClient } from '@angular/common/http';
import { Injectable, signal } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { Workshop } from '../Models/workshop.model';

@Injectable({
  providedIn: 'root'
})
export class WorkshopService {
  private apiUrl = 'http://localhost:5278/api/workshops'
  private _workshops = signal<Workshop[] | null>(null);
  public workshops = this._workshops.asReadonly();


  constructor(private http: HttpClient) { }
  getWorkshops() {
    return this.http.get<Workshop[]>(this.apiUrl).pipe(
      tap(
        (response: Workshop[]) => {
          this._workshops.set(response);
        }
      ));
  }
  getWorkshop(guid: string) {
    const url = this.apiUrl + `/${guid}`;
    return this.http.get<Workshop>(url);
  }
  getWorkshopByGuid(guid: string): Observable<Workshop> {
    const url = `${this.apiUrl}/${guid}`;
    return this.http.get<Workshop>(url);
  }
  createWorkshop(workshops: Workshop): Observable<Workshop> {
    return this.http.post<Workshop>(this.apiUrl, workshops);
  }
  updateWorkshop(workshops: Workshop): Observable<Workshop> {
    const url = `${this.apiUrl}/${workshops.guid}`;
    return this.http.put<Workshop>(url, workshops);
  }
  deleteWorkshop(guid: string): Observable<void> {
    const url = `${this.apiUrl}/${guid}`;
    return this.http.delete<void>(url);
  }
}
