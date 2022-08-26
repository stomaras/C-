import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'addDashBetween' // | addDashBetween
})
export class AddDashBetweenPipe implements PipeTransform {

  transform(keimeno:string): string {// is pipe get something and return something else...
    return keimeno.replace(" "," - ");
  }

}
