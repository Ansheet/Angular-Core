import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EmployeeserviceService } from '../employeeservice.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(private service: EmployeeserviceService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    debugger;
    if (form != undefined)
      form.resetForm();
    this.service.formData = {
      EmployeeID: null,
      FullName: '',
      Position: '',
      Mobile: ''
    }

    this.service.refreshList();
  }

  onSubmit(form: NgForm) {
    this.service.postEmployee(form.value).subscribe(res => {
      this.resetForm(form);
    });
  }

}
