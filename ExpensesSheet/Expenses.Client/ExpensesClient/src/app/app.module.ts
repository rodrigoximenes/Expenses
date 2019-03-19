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
import {MatButtonModule,MatTableModule,
   MatInputModule, MatCardModule,
    MatSelectModule, MatToolbarModule,
  MatDialogModule, MatListModule} from '@angular/material';
import { NewEntryComponent } from './new-entry/new-entry.component';

//Forms
import { ReactiveFormsModule } from '@angular/forms';
import { UpdateEntryComponent } from './update-entry/update-entry.component';
import { DeleteEntryComponent } from './delete-entry/delete-entry.component';

@NgModule({
  declarations: [
    AppComponent,
    EntriesComponent,
    HeaderComponent,
    FooterComponent,
    NewEntryComponent,
    UpdateEntryComponent,
    DeleteEntryComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,

    //material design
    BrowserAnimationsModule,
    MatButtonModule,
    MatTableModule,
    MatInputModule, 
    MatCardModule,
    MatSelectModule,
    MatToolbarModule,
    MatDialogModule,
    MatListModule,

    //Forms
    ReactiveFormsModule,

    AppRouterModule

  ],
  entryComponents:[UpdateEntryComponent],
  providers: [EntryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
