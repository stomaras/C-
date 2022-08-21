import {Component} from '@angular/core'







@Component(
    {
        selector:"app-student",
        templateUrl:'./student.component.html',
        styleUrls:['./student.component.css']
    }
)

// Get Actions Methods as in c# and give in html
export class StudentComponent{
    name:string = "Hector";
    score:number = 99;
    age:number = 35;


    getBirthday(){
        return new Date().getFullYear() - this.age;
    }

    

}