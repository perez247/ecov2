import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivateIdeaFeedsComponent } from './private-idea-feeds.component';

describe('PrivateIdeaFeedsComponent', () => {
  let component: PrivateIdeaFeedsComponent;
  let fixture: ComponentFixture<PrivateIdeaFeedsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrivateIdeaFeedsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrivateIdeaFeedsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
