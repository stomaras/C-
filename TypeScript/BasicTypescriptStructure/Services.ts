import { Student } from "./Models";
import { students } from "./Database";


export function GetStudents(): Array<Student>{
    return students;
}