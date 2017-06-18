import { Component, OnInit } from '@angular/core';
import { Observable, Subject, BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    console.log('test');
    let stringStream = new BehaviorSubject<string>('');
    stringStream.next('To jest komunikat, który nie bedzie widać');
    stringStream.next('To jest komunikat, który nie bedzie widać');
    stringStream.next('To jest komunikat, który nie bedzie widać');

    stringStream.subscribe({
      next: (value: string) => { console.log(value); },
      error: (value: any) => { console.log(value); },
      complete: () => { },
    });
    stringStream.next('Komunikat');
    stringStream.complete();
    stringStream.next('gówno');

    let x = Observable.from([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    x.subscribe((value: number) => {
      console.log(value);
    }, (error: string) => {
      console.log('Błąd');
    }, () => { console.log('Koniec') }
    )
  }
}
