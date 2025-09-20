import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { BaseUI } from "./Components/base-ui/base-ui";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, BaseUI],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('Desafio-Fullstack');
}
