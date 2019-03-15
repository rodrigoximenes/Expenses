import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { EntriesComponent } from './entries/entries.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';

//Services
import { EntryService } from './entry.service';
import { AppRouterModule } from './app-router-module';
import { HttpClientModule } from '@angular/common/http';

//Material Design
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule} from '@angular/material';

@NgModule({
  declarations: [
    AppComponent,
    EntriesComponent,
    HeaderComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,

    //material design
    BrowserAnimationsModule,
    MatButtonModule,

    AppRouterModule

  ],
  providers: [EntryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
