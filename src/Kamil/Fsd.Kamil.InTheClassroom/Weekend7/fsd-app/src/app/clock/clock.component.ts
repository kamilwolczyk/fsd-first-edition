import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clock',
  templateUrl: './clock.component.html',
  styleUrls: ['./clock.component.css']
})
export class ClockComponent implements OnInit {
  clockString: string;

  ngOnInit() {
    this.clockString = this.getTimeString();
    setInterval(() => {
      this.clockString = this.getTimeString();
    }, 1000);
  }

  private getTimeString(): string {
    const now = new Date();
    return `${now.getHours()} : ${now.getMinutes()} : ${now.getSeconds()}`;
  }
}
