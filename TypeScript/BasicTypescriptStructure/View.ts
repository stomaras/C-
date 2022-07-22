import {  Index } from "./Controller";
import { Student } from "./Models";

function PrintStudents(){
    let students = Index(65);

    for (const stu of students) {
        console.log(stu.name + " " + stu.score);
    }
}

PrintStudents();