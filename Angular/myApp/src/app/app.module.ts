import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { StudentComponent } from 'src/components/student/student.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TrainerComponent } from '../components/student/trainer/trainer.component';
import { MovieComponent } from '../components/movie/movie.component';

import {FormsModule} from "@angular/forms";
import { AddDashBetweenPipe } from 'src/shared-pipes/add-dash-between.pipe';
import { ConvertMinutesHoursPipe } from 'src/shared-pipes/convert-minutes-hours.pipe';
// inputs, checkboxes, radioBox, must declare on imports

@NgModule({
  declarations: [
    AppComponent,
    StudentComponent,
    TrainerComponent,
    MovieComponent,
    AddDashBetweenPipe,
    ConvertMinutesHoursPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
