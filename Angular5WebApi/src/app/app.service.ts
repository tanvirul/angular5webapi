import { Injectable } from '@angular/core';
import { HttpClientModule, HttpClient, HttpResponse } from '@angular/common/http';
import { Observable, Subject } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

@Injectable()
export class AppDataService {

    constructor(private _http: HttpClient) {
    }

    getDashBoardViews(): Observable<any> {
        return this._http.get("http://localhost:62118/api/books/GetAllBooks");
    }
    private extractData(res: any) {
        return res;
    }

    private handleError(error: any) {
        let errMsg = (error.message) ? error.message :
            error.status ? `${error.status} - ${error.statusText}` : 'Server error';
        console.error(errMsg);
        return Observable.throw(errMsg);
    }
}