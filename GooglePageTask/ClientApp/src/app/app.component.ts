import { Component } from '@angular/core';
import { DisplaySuggestionService } from './display-suggestion.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'app';
    searchedText = "";
    mockedDataUrl = 'http://337f1a08.ngrok.io/api/values';
    

    constructor(private http: HttpClient) { }

    //sendSearchString(): void {
    //    this.searchedText;
    //    console.log(this.searchedText);
    //}

    sendSearchString(): Observable<any> {
        console.log(this.searchedText);
         const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
        return this.http.get<any>("http://337f1a08.ngrok.io/api/values");
    }  
}  
  


 
