import { Component, inject } from '@angular/core';
import { CollaboratorService } from '../../Services/collaborator.services';
import { Collaborator } from '../../Models/collaborator.model';
import { ItemUi } from '../item-ui/item-ui';

@Component({
  selector: 'app-collaborators',
  imports: [ItemUi],
  templateUrl: './collaborators.html',
  styleUrl: './collaborators.scss'
})
export class Collaborators {
  collaboratorService = inject(CollaboratorService);
  collaborators = this.collaboratorService.collaborators;

  constructor() { }
  ngOnInit(): void {
    this.collaboratorService.getCollaborators().subscribe();
  }
}

