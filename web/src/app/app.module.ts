import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { UserInputComponent } from './user-input/user-input.component';
import { OutputComponent } from './output/output.component';
import { DataService } from './services/data.service';
import { SortingServiceService } from './services/sorting-service.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    UserInputComponent,
    OutputComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [DataService, SortingServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
