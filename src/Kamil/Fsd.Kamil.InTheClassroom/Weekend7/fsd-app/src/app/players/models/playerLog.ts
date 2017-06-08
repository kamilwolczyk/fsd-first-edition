import { IPlayer } from './';

export class PlayerLog {
  createdOn: Date;
  createdOnString: string;

  constructor(public player: IPlayer, public actionMessage: string) {
    this.createdOn = new Date();
    this.createdOnString = this.getDateTimeString(this.createdOn);
  }

  private getDateTimeString(date: Date): string {
    return `${date.getHours()} : ${date.getMinutes()} : ${date.getSeconds()}`;
  }
}
