
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import { LoginFormComponent } from './login-form/login-form.component';
import { NavComponent } from './nav/nav.component';
import { RegisterComponent } from './register/register.component'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MainPageComponent } from './main-page/main-page.component';
import { ClassroomComponent } from './classroom/classroom.component';
import { ListTanarokComponent } from './list-tanarok/list-tanarok.component';
import { LogoutComponent } from './logout/logout.component';
import { CellComponent } from './cell/cell.component';
import { StudentListComponent } from './student-list/student-list.component';
import { StudentStatisticComponent } from './student-statistic/student-statistic.component';
import { ClassStatisticComponent } from './class-statistic/class-statistic.component';
import { ClassListComponent } from './class-list/class-list.component';
import { AdminComponent } from './admin/admin.component';
import { OraCreateComponent } from './ora-create/ora-create.component';
import { StudentToClassComponent } from './student-to-class/student-to-class.component';
import { AdminModifyComponent } from './admin-modify/admin-modify.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginFormComponent,
    NavComponent,
    RegisterComponent,
    MainPageComponent,
    ClassroomComponent,
    ListTanarokComponent,
    LogoutComponent,
    CellComponent,
    StudentListComponent,
    StudentStatisticComponent,
    ClassStatisticComponent,
    ClassListComponent,
    AdminComponent,
    OraCreateComponent,
    StudentToClassComponent,
    AdminModifyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
