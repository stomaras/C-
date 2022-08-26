import { Component, OnInit } from '@angular/core';
import {trainers} from './trainerMockup';
import { Trainer } from './trainerModel';

@Component({
  selector: 'app-trainer',
  templateUrl: './trainer.component.html',
  styleUrls: ['./trainer.component.css']
})
export class TrainerComponent implements OnInit {

  Trainers:Array<Trainer> = trainers;// Available in html



  constructor() { }

  ngOnInit(): void {
  }

}
