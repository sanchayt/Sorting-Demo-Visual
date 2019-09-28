import { Component, OnInit } from '@angular/core';
import { DataService } from '../services/data.service';

// ElementObj representing all the individual element and its length
class ElementObj {
  name: any;
  length: string;

}

@Component({
  selector: 'app-output',
  templateUrl: './output.component.html',
  styleUrls: ['./output.component.css']
})
export class OutputComponent implements OnInit {

  // Array of all the steps taken to sort the given array
  sortingSteps: Array<string>;

  loadingBarLength = '0%';
  // Contains all the elements name or value
  elements: any[];

  // Contains all the ElementObj which is created above
  elementsLength: ElementObj[];

  constructor(private data: DataService) { }


  ngOnInit() {
    // listening to any change in sorted steps result provided on user input
    this.data.sortingStep.subscribe(steps => {
      this.sortingSteps = steps;

      // creating delay to present all values in order
      this.sortingSteps.map((el, i, arr) => {
        setTimeout(() => {
          this.split(el);
          // loading bar length change based on number of steps
          this.loadingBarLength = (100 * ((i + 1) / arr.length)) + '%';

        }, i * 1000);
      });
    });
  }

  // this method split a singular step into individual elements and provides length required for bars
  split(step: string) {
    this.elements = step.split(',');

    // Element is number then bar length calculated respective to highest integer
    if (Number(this.elements[0])) {

      this.elementsLength = this.elements.map((e, i, arr) => {
        const max = Math.max(...arr);

        const value = (100 * (e / max)) + '%';

        return {name: e, length: value};
      });
      // Element is string then bar length calculated based on first character
    } else {
      this.elementsLength = this.elements.map((e, i, arr) => {
        const firstCharacter = e.charCodeAt(0) - 96;

        const value = (100 * ( firstCharacter / 26)) + '%';

        return {name: e, length: value};
      });
    }
  }
}
