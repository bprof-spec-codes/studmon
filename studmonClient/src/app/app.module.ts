import { ListTanarokModule } from './list-tanarok/list-tanarok.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http'

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ListTanarokModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
