import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListTanarokComponent } from './list-tanarok/list-tanarok.component';
import { CommonModule } from "@angular/common";

const routes: Routes = [
  {component: ListTanarokComponent, path: ''}
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
