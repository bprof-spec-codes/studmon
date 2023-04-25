import { ListTanarokModule } from './list-tanarok/list-tanarok.module';
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

@NgModule({
  declarations: [
    AppComponent,
    LoginFormComponent,
    NavComponent,
    RegisterComponent,
    MainPageComponent,
    ClassroomComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ListTanarokModule,
    FormsModule,
    ReactiveFormsModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
