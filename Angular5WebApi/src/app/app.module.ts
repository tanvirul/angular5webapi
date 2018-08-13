import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

import { AppDataService } from './app.service';
@NgModule({
    imports: [
        BrowserModule,
        HttpClientModule],
  declarations: [ AppComponent ],
    bootstrap: [AppComponent],
    providers: [AppDataService]
})
export class AppModule { }
