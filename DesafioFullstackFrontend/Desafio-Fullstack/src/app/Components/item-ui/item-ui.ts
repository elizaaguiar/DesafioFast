import { DatePipe } from '@angular/common';
import { Component, input, Pipe } from '@angular/core';
import { TruncatePipe } from './truncate.pipe';

@Component({
  selector: 'app-item-ui',
  imports: [DatePipe, TruncatePipe],
  templateUrl: './item-ui.html',
  styleUrl: './item-ui.scss'
})
export class ItemUi {
  title = input<string>();
  name = input.required<string>();
  description = input<string>();
  executionDate = input<Date>();
}
