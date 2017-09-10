import { Component, OnInit } from '@angular/core';

//import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';

import { Country } from './groupkt.model';
import { GroupktService } from './groupkt.service';
import { AlertService } from '../../core/alert.service';


@Component({
  selector: 'app-country-search',
  templateUrl: './country-search.component.html',
  styleUrls: ['./country-search.component.css'],
  providers: [GroupktService],
})
export class CountrySearchComponent implements OnInit {

  items: Country[];

  constructor(private service: GroupktService, private alertService: AlertService) { }

  private searchTermStream = new Subject<string>();

  ngOnInit() {
    this.getAllCountries();
  }

  reset() {
    this.items = [];
    this.alertService.clearMessage();
  }

  getAllCountries() {
    this.reset();
    this.service.getAllCountries()
      .subscribe(
      value => {
        //console.log(value.RestResponse.result);
        if (value.RestResponse.result) {
          this.items = value.RestResponse.result;
        }
        else {
          //console.log(value.RestResponse.messages[1]);
          this.alertService.sendErrorMessage(value.RestResponse.messages[1]);
        }
      },
      error => {
        //console.log(error);
        this.alertService.sendErrorMessage(error);
      });
  }

  getCountryByAlpha3Code(code: string) {
    if (code.length != 3)
      return;
    this.reset();
    this.service.getCountryByAlpha3Code(code)
      .subscribe(
      value => {
        //console.log(value.RestResponse.result);
        if (value.RestResponse.result) {
          this.items = [value.RestResponse.result];
        }
        else {
          //console.log(value.RestResponse.messages[1]);
          this.alertService.sendErrorMessage(value.RestResponse.messages[1]);
        }
      },
      error => {
        //console.log(error);
        this.alertService.sendErrorMessage(error);
      });
  }

  searchCountries(text: string) {
    if (text.length <= 1)
      return;
    this.reset();
    this.service.searchCountries(text)
      .subscribe(
      value => {
        //console.log(value.RestResponse.result.length);
        if (value.RestResponse.result && value.RestResponse.result.length > 0) {
          this.items = value.RestResponse.result;
        }
        else {
          //console.log(value.RestResponse.messages[1]);
          this.alertService.sendErrorMessage(value.RestResponse.messages[1]);
        }
      },
      error => {
        //console.log(error);
        this.alertService.sendErrorMessage(error);
      });
  }

}