import { HttpClient } from '@angular/common/http';
import { Injectable, signal } from '@angular/core';
import { Observable, tap } from 'rxjs';
import { Collaborator } from '../Models/collaborator.model';

@Injectable({
  providedIn: 'root'
})
export class CollaboratorService {
  private apiUrl = 'http://localhost:5278/api/collaborators'
  private _collaborators = signal<Collaborator[] | null>(null);
  public collaborators = this._collaborators.asReadonly();


  constructor(private http: HttpClient) { }
  getCollaborators() {
    return this.http.get<Collaborator[]>(this.apiUrl).pipe(
      tap(
        (response: Collaborator[]) => {
          this._collaborators.set(response);
        }
      ));
  }
  getCollaborator(guid: string) {
    const url = this.apiUrl + `/${guid}`;
    return this.http.get<Collaborator>(url);
  }
   getCollaboratorByGuid(guid: string): Observable<Collaborator> {
    const url = `${this.apiUrl}/${guid}`;
    return this.http.get<Collaborator>(url);
  }
  createCollaborator(collaborators:Collaborator): Observable<Collaborator> {
    return this.http.post<Collaborator>(this.apiUrl, collaborators);
  }
  updateCollaborator(collaborators: Collaborator): Observable<Collaborator> {
    const url = `${this.apiUrl}/${collaborators.name}`;
    return this.http.put<Collaborator>(url, collaborators);
  }
  deleteCollaborator(guid: string): Observable<void> {
    const url = `${this.apiUrl}/${guid}`;
    return this.http.delete<void>(url);
  }
}
