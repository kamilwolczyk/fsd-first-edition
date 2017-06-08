
import { Component, OnInit } from '@angular/core';
import { PlayerLog } from 'app/players/models';

@Component({
  selector: 'app-player-log',
  templateUrl: './player-log.component.html',
  styleUrls: ['./player-log.component.css']
})
export class PlayerLogComponent implements OnInit {
  logs: PlayerLog[];

  ngOnInit() {
    this.logs = [];
  }

  logPlayerAction(log: PlayerLog) {
    this.logs.unshift(log);
  }
}
