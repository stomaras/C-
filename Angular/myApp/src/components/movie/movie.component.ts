import { Component, OnInit } from '@angular/core';
import {movies} from './hollywoodDatabase';
import {IMovie} from './hollywoodModels';
import { ITableSettings, TableSettings } from './tableSettings';

@Component({
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css']
})

// let never inside classes
export class MovieComponent implements OnInit {

  //CSS Attributes
  Settings:ITableSettings = TableSettings;
  ImageWidth = 60;
  BorderRadius = 30;

  PriceIsHidden:boolean = true;
  TogglePrice(){
    this.PriceIsHidden = !this.PriceIsHidden;
    console.log(this.PriceIsHidden);
  }

  // i do this property to become undefined value Arithmos!:value

  Arithmos : number = 5;







  Movies:Array<IMovie> = movies;

  constructor() { }

  // we get due to implements OnInit Interface
  ngOnInit(): void {
  }

}
