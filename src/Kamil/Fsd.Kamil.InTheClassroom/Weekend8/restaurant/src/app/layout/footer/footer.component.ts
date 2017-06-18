import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  author: string;
  year: number;

  ngOnInit() {
    this.author = 'Kamil Wołczyk';
    this.year = new Date().getFullYear();
  }

}
