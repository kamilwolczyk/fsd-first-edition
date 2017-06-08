import { ButtonConfiguration } from '../shared/button/models/buttonConfiguration';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  myFirstActionConfiguration: ButtonConfiguration;

  constructor() { }

  ngOnInit() {
    this.myFirstActionConfiguration = new ButtonConfiguration('Akcja 1');
  }

  whenChildNotifyMe(message: string) {
    alert(message);
  }

}
