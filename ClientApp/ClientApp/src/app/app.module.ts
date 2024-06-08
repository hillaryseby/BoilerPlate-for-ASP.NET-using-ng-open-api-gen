import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClientModule, HttpHeaderResponse } from '@angular/common/http';
import { ApiModule } from 'OpenApiGen/api.module';
import { NavRoutes } from 'app/NavRoutes';
import { AddTodoListComponent } from './add-todo-list/add-todo-list.component';

const env = {
  apiUrl : 'http://localhost:50834'
}
export function ApiGetEndPoint() {
return {
  rootUrl:
  env.apiUrl
}
}
@NgModule({
  declarations: [
    AppComponent,
    AddTodoListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ApiModule.forRoot(ApiGetEndPoint())
    
  ],
  providers: [NavRoutes],
  bootstrap: [AppComponent]
})
export class AppModule { }
