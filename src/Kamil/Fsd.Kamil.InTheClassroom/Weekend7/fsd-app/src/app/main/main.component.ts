import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  names: string[];

  ngOnInit(): void {
    this.names = [
      'Kamil',
      'Michał',
      'Łukasz',
      'Maciek'
    ];
  }

  actionClick(numerElementu: number) {

  }
}
