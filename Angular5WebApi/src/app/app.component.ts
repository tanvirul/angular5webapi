import { Component,OnInit } from '@angular/core';
import { AppDataService } from './app.service';
@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1>`,
})
export class AppComponent implements OnInit {
    name = 'Angular';
    constructor(public dataService: AppDataService) {
       
    }

    ngOnInit() {
        this.loadPage();
    }
    private loadPage() {
        this.dataService.getDashBoardViews().subscribe((data: any) => {

            this.name = data[0];
            
        });
    }
}
