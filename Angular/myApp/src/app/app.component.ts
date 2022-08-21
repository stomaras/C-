import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  name:string = "Makis";
  salary:number = 20000;

  print():string{
    return `i am ${this.name}`
  }
}
