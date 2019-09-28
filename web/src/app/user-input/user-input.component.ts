import { Component, OnInit } from '@angular/core';
import { SortingServiceService } from '../services/sorting-service.service';
import { DataService } from '../services/data.service';
import { isNumber } from 'util';

@Component({
  selector: 'app-user-input',
  templateUrl: './user-input.component.html',
  styleUrls: ['./user-input.component.css']
})
export class UserInputComponent implements OnInit {


  constructor(private sortingService: SortingServiceService, private data: DataService) { }

  // Values from user binded with form
  userInput = '';
  sortType = 0;
  valueType = 0;


  ngOnInit() {
  }


  sort() {
    // split the user input into small elemnts
    const arr = this.userInput.split(',');

    // mapping elements if they are integer or string
    const array = arr.map(element => {
      let x;
      if (Number(element)) {
        x = parseInt(element);
      }
      return x || element.toLowerCase().trim();
    });

    // calling the sort method of service to send data
    this.sortingService.sort(array, this.sortType, this.valueType).subscribe(stepsData => {
      // sharing stepsData with multiple components through service
      this.data.changeSortingSteps(stepsData);
    });
  }

}
