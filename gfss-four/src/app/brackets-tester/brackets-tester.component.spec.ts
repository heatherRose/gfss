import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BracketsTesterComponent } from './brackets-tester.component';

describe('BracketsTesterComponent', () => {
  let component: BracketsTesterComponent;
  let fixture: ComponentFixture<BracketsTesterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BracketsTesterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BracketsTesterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
