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
import {MatTableModule} from '@angular/material/table';
import { NewEntryComponent } from './new-entry/new-entry.component';

//Forms
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    EntriesComponent,
    HeaderComponent,
    FooterComponent,
    NewEntryComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,

    //material design
    BrowserAnimationsModule,
    MatButtonModule,
    MatTableModule,

    //Forms
    

    AppRouterModule

  ],
  providers: [EntryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
