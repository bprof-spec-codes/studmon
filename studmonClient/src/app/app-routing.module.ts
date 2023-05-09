import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListTanarokComponent } from './list-tanarok/list-tanarok.component';
import { LoginFormComponent } from './login-form/login-form.component';
import { CommonModule } from "@angular/common";
import { RegisterComponent } from './register/register.component';
import { MainPageComponent } from './main-page/main-page.component';
import { ClassroomComponent } from './classroom/classroom.component';
import { LogoutComponent } from './logout/logout.component';

const routes: Routes = [
  {component: LoginFormComponent, path: ''},
  {component: LogoutComponent, path: 'logout'},
  {component: ListTanarokComponent, path: 'tanarok'},
  {component: RegisterComponent, path: 'register'},
  {component: MainPageComponent, path: 'mainpage'},
  {component: ClassroomComponent, path: 'classroom'},
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
