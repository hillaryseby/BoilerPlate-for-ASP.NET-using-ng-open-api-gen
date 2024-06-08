import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavRoutes } from 'app/NavRoutes';
import { AddTodoListComponent } from './add-todo-list/add-todo-list.component';

const routes: Routes = [
  {
    
path :NavRoutes.Gotopage,
component : AddTodoListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
