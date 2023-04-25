import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListTanarokComponent } from './list-tanarok/list-tanarok.component';
import { LoginFormComponent } from './login-form/login-form.component';
import { CommonModule } from "@angular/common";
import { RegisterComponent } from './register/register.component';

const routes: Routes = [
  {component: LoginFormComponent, path: ''},
  {component: ListTanarokComponent, path: 'tanarok'},
  {component: RegisterComponent, path: 'register'}
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
