import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { TaskDto } from 'OpenApiGen/models';
import { TaskService } from 'OpenApiGen/services';
import { lastValueFrom } from 'rxjs';
import { NavRoutes } from './NavRoutes';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'ClientApp';
  

  constructor(private task : TaskService,
    private route :Router){
    
  }
  async ngOnInit() {
     this.task.apiTaskGet().subscribe((response)=>{
          console.log(response);
     });
  }

  Clicked(){
  this.route.navigate([NavRoutes.prefixSlash(NavRoutes.Gotopage)]);
  }

}
