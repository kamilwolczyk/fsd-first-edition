import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderTableComponent } from './orderTable.component';

describe('OrderComponent', () => {
  let component: OrderTableComponent;
  let fixture: ComponentFixture<OrderTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrderTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrderTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
