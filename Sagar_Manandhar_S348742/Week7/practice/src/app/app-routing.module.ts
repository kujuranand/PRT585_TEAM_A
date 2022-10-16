import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddLecturerComponent } from './components/lecturers/add-lecturer/add-lecturer.component';
import { EditLecturerComponent } from './components/lecturers/edit-lecturer/edit-lecturer.component';
import { LecturersListComponent } from './components/lecturers/lecturers-list/lecturers-list.component';

const routes: Routes = [
  {
    path: '',
    component: LecturersListComponent
  },
  {
    path: 'lecturers',
    component: LecturersListComponent
  },
  {
    path: 'lecturers/add',
    component: AddLecturerComponent 
  },
  {
    path: 'lecturers/edit/:id',
    component: EditLecturerComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
