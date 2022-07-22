import { Student } from "./Models";
import { GetStudents } from "./Services";

export function Index(score?: number): Array<Student>
{
    let students = GetStudents();//promise

    let filteredStudents = students.filter(x =>x.score > 69);
    return filteredStudents;
    
}