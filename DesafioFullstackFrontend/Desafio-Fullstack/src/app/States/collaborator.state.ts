import { Injectable, signal } from '@angular/core';
import { toObservable } from '@angular/core/rxjs-interop';
import { Collaborator } from '../Models/collaborator.model';

@Injectable({
  providedIn: 'root'
})
export class Collaboratortate {
  private _collaborator = signal<(Collaborator[])>([]);
  public collaboratorObservable = toObservable(this._collaborator);
  public collaborator = this._collaborator.asReadonly();

  addCollaborator(collaborator: Collaborator) {
    this._collaborator.update((collaborators: Collaborator[]) => [...collaborators, collaborator]);
  }
  removeCollaborator() {
    const lastUpdate = this.collaborator().pop();
  }
}
