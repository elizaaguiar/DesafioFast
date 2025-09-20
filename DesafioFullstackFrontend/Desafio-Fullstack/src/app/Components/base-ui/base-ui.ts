import { Component, inject, OnInit } from '@angular/core';
import { ItemUi } from '../item-ui/item-ui';
import { Router } from '@angular/router';

@Component({
  selector: 'app-base-ui',
  imports: [],
  templateUrl: './base-ui.html',
  styleUrl: './base-ui.scss'
})
export class BaseUI{
  route = inject(Router);

  constructor(){}

  navigateTo(route: '/collaborators' | '/workshops'){
    this.route.navigate([
      route
    ])
  }
}
