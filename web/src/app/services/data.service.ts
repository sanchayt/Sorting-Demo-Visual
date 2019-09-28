import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private sortingStepSource = new BehaviorSubject(new Array<string>());
  sortingStep = this.sortingStepSource.asObservable();

  constructor() { }

  changeSortingSteps(steps: Array<string>) {
    this.sortingStepSource.next(steps);
  }

}
