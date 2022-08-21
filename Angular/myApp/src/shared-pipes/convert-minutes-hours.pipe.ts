import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
  name: 'convertMinutesHours' // | convertMinutesHours
})
export class ConvertMinutesHoursPipe implements PipeTransform {

  transform(value:number): string { // timi 200
    
    var totalTimeInMinutes = value;
    var hour = Math.floor(totalTimeInMinutes / 60); //1h
    var minutes = totalTimeInMinutes - (hour * 60);
    
    return `${hour}h ${minutes}m`;
    
    // 3h 20m
  }

}
