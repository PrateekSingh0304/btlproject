import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataServiceService } from './data-service.service';
import { CenterListComponent } from './center-list/center-list/center-list.component';
import {HttpClientModule } from '@angular/common/http';
import {FormsModule} from '@angular/forms'


@NgModule({
  declarations: [
    AppComponent,
    CenterListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
   ],
  providers: [DataServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
