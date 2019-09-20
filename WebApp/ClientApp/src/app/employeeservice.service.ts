import { Injectable } from '@angular/core';
import { Employee } from './models/employee';
import { HttpClient } from '@angular/common/http';
import { debug } from 'util';

@Injectable({
  providedIn: 'root'
})
export class EmployeeserviceService {
  formData: Employee;
  list: Employee[];
  readonly rootUrl = 'http://localhost:65056';
  constructor(private http: HttpClient) { }


  postEmployee(formData: Employee) {
    debugger;
    return this.http.post(this.rootUrl + '/api/Employee/Create', formData);
  }
  refreshList() {
    this.http.get(this.rootUrl + '/api/Employee/GetAll')
      .toPromise()
      .then(res => this.list = res as Employee[]);
  }




}
