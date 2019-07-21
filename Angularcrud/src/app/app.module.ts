import { BrowserModule } from '@angular/platform-browser';  
import { NgModule, LOCALE_ID } from '@angular/core';  
import { EmployeeService } from './employee.service';  
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  
import { HttpClientModule, HttpClient } from '@angular/common/http';  
import {  
  MatButtonModule, MatMenuModule, MatDatepickerModule,MatNativeDateModule , MatIconModule, MatCardModule, MatSidenavModule,MatFormFieldModule,  
  MatInputModule, MatTooltipModule, MatToolbarModule, MAT_DATE_LOCALE  
} from '@angular/material';  
import { MatRadioModule } from '@angular/material/radio';  
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';  
  
import { AppRoutingModule } from './app-routing/app-routing.module';  
import { AppComponent } from './app.component';  
import { EmployeeComponent } from './employee/employee.component'; 
import { CurrencyPipe } from '@angular/common';
@NgModule({  
  declarations: [  
    AppComponent,  
    EmployeeComponent  
  ],  
  imports: [  
    BrowserModule,  
    FormsModule,  
    ReactiveFormsModule,  
    HttpClientModule,  
    BrowserAnimationsModule,  
    MatButtonModule,  
    MatMenuModule,  
    MatDatepickerModule,  
    MatNativeDateModule,  
    MatIconModule,  
    MatRadioModule,  
    MatCardModule,  
    MatSidenavModule,  
    MatFormFieldModule,  
    MatInputModule,  
    MatTooltipModule,  
    MatToolbarModule,  
    AppRoutingModule  
  ],  
  providers: [HttpClientModule, CurrencyPipe, EmployeeService,MatDatepickerModule,{provide: LOCALE_ID, useValue: 'en-GB' },{provide: MAT_DATE_LOCALE, useValue: 'en-GB'}],  
  bootstrap: [AppComponent]  
})  
export class AppModule { } 
