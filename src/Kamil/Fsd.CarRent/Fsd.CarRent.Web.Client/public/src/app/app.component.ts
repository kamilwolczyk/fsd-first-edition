import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';

class CarSummary {
  id: number;
  producer: string;
  model: string;
  price: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'app';

  constructor(private httpService: Http) { }

  ngOnInit(): void {
    this.httpService.get('/api/cars/summary-list')
      .subscribe((response: Response) => {
        console.log(response);
      });
  }
}
