import {Trainer} from './trainerModel';

let tr1:Trainer = {
    name: 'Hector',
    salary: 50000
}


let tr2:Trainer = {
    name:"Mpampis",
    salary:4000
}


let tr3:Trainer = {
    name:"Tomy",
    salary:12000,
    birthday: new Date(1987,5,17)
}

export let trainers:Array<Trainer> = [tr1,tr2,tr3];


