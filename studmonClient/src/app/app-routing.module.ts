import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListTanarokComponent } from './list-tanarok/list-tanarok.component';
import { LoginFormComponent } from './login-form/login-form.component';
import { CommonModule } from "@angular/common";
import { RegisterComponent } from './register/register.component';
import { MainPageComponent } from './main-page/main-page.component';
import { ClassroomComponent } from './classroom/classroom.component';
import { LogoutComponent } from './logout/logout.component';
import { StudentStatisticComponent } from './student-statistic/student-statistic.component';
import { ClassListComponent } from './class-list/class-list.component';
import { ClassStatisticComponent } from './class-statistic/class-statistic.component';
import { AdminComponent } from './admin/admin.component';
import { OraCreateComponent } from './ora-create/ora-create.component';
import { ApiService } from './app.service';
import { StudentToClassComponent } from './student-to-class/student-to-class.component';

const routes: Routes = [
  {component: LoginFormComponent, path: ''},
  {component: LogoutComponent, path: 'logout', canActivate: [ApiService]},
  {component: ListTanarokComponent, path: 'tanarok', canActivate: [ApiService]},
  {component: RegisterComponent, path: 'register'},
  {component: MainPageComponent, path: 'mainpage', canActivate: [ApiService]},
  {component: ClassroomComponent, path: 'classroom/:id/:alkalom', canActivate: [ApiService]},
  {component: StudentStatisticComponent, path: 'studentstatistic', canActivate: [ApiService]},
  {component: ClassListComponent, path: 'classes', canActivate: [ApiService]},
  {component: ClassStatisticComponent, path: 'classstatistic', canActivate: [ApiService]},
  {component: AdminComponent, path: 'admin', canActivate: [ApiService]},
  {component: OraCreateComponent, path: 'oracreate', canActivate: [ApiService]},
  {component: StudentToClassComponent, path: 'studentToClass/:id', canActivate: [ApiService]}
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
