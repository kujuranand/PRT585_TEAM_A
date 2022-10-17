import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SubjectsListComponent } from './components/subjects/subjects-list/subjects-list.component';
import { AddSubjectComponent } from './components/subjects/add-subject/add-subject.component';
import { FormsModule } from '@angular/forms';
import { EditSubjectComponent } from './components/subjects/edit-subject/edit-subject.component';

@NgModule({
  declarations: [
    AppComponent,
    SubjectsListComponent,
    AddSubjectComponent,
    EditSubjectComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
