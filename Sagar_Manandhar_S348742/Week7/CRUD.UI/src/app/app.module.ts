import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LecturersListComponent } from './components/lecturers/lecturers-list/lecturers-list.component';
import { AddLecturerComponent } from './components/lecturers/add-lecturer/add-lecturer.component';
import { FormsModule } from '@angular/forms';
import { EditLecturerComponent } from './components/lecturers/edit-lecturer/edit-lecturer.component';

@NgModule({
  declarations: [
    AppComponent,
    LecturersListComponent,
    AddLecturerComponent,
    EditLecturerComponent
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
