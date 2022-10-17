import { Component, OnInit } from '@angular/core';
import { Student } from 'app/models/student.model';
import { StudentsService } from 'app/services/students.service';


@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit {

  students: Student[] = [];
  constructor(private studentsService: StudentsService) { }

  ngOnInit(): void {
    this.studentsService.getAllStudents()
    .subscribe({
      next: (students) => {
        this.students = students;
      },
      error: (response) => {
        console.log(response);
      }
    });
    
  }

}
