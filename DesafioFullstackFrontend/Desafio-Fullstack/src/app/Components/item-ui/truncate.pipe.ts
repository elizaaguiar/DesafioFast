import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'truncate' })
export class TruncatePipe implements PipeTransform {
  transform(description: string | null | undefined, limit: number = 20): string {
    if (!description) return '';
  
    return description.length > limit ? description.substring(0, limit) + '...' : description;
  }
}