import { Injectable, signal } from '@angular/core';
import { toObservable } from '@angular/core/rxjs-interop';
import { Workshop } from '../Models/workshop.model';

@Injectable({
  providedIn: 'root'
})
export class WorkshopState {
  private _workshops = signal<(Workshop[])>([]);
  public workshopObservable = toObservable(this._workshops);
  public workshop = this._workshops.asReadonly();

  addWorkshop(workshop: Workshop) {
    this._workshops.update((workshops: Workshop[]) => [...workshops, workshop]);
  }
  removeWorkshop(guid: string) {
    const lastUpdate = this.workshop().filter(workshop => workshop.guid !== guid);
  }
}
