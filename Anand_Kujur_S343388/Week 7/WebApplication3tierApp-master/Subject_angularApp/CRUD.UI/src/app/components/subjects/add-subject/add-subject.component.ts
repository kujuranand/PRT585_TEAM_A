import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'src/app/models/subject.model';
import { SubjectsService } from 'src/app/services/subjects.service';

@Component({
  selector: 'app-add-subject',
  templateUrl: './add-subject.component.html',
  styleUrls: ['./add-subject.component.css']
})
export class AddSubjectComponent implements OnInit {

  addSubjectRequest: Subject = {
    id: '',
    code: '',
    name: '',
    semester: 0,
  };

  constructor(private subjectService: SubjectsService, private router: Router) { }

  ngOnInit(): void {
  }

  addSubject() {
    this.subjectService.addSubject(this.addSubjectRequest)
    .subscribe({
      next: (subject) => {
        this.router.navigate(['subjects']);
      }
    });
  }

}
