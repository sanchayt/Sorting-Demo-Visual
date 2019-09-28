import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SortingServiceService {

  url = 'http://localhost:49805/api/sorting';

  constructor(private http: HttpClient) { }

  // HTTP Post request to sort input
  sort(array: any[], sType: number, valueType: number): Observable<any> {
    const data = {
      sortType : sType,
      type : valueType,
      arr : array
    };

    return this.http.post(this.url  + '/sortArray', data );
  }

}
