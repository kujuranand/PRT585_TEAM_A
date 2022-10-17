import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddSubjectComponent } from './components/subjects/add-subject/add-subject.component';
import { EditSubjectComponent } from './components/subjects/edit-subject/edit-subject.component';
import { SubjectsListComponent } from './components/subjects/subjects-list/subjects-list.component';

const routes: Routes = [
  {
    path: '',
    component: SubjectsListComponent
  },
  {
    path: 'subjects',
    component: SubjectsListComponent
  },
  {
    path: 'subjects/add',
    component: AddSubjectComponent 
  },
  {
    path: 'subjects/edit/:id',
    component: EditSubjectComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
