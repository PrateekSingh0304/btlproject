import { Injectable } from '@angular/core';
import {HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Center } from './Models/Center';

@Injectable({
  providedIn: 'root'
})
export class DataServiceService {

  public API = 'http://localhost:51993/api';
  constructor(private http: HttpClient) { 

  }

  
  

  getAllCenters(): Observable<Array<Center>>{
    
    return this.http.get<Array<Center>>(this.API + '/Center/GetAllCenters');
  }
}
