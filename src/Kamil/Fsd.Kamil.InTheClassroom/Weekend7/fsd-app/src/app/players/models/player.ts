export interface IPlayer {
  getFullName(): string;
  introduce(): string;
  play(): string;
}

export abstract class PlayerBase {
  constructor(private firstName: string, private lastName: string, private playerLevel: PlayerLevel) { }

  getFullName(): string {
    return `${this.firstName} ${this.lastName}`;
  }
}
