import { async, ComponentFixture, TestBed, inject } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController, } from '@angular/common/http/testing';
import { HttpClientModule, HttpClient, HttpParams, HttpErrorResponse } from "@angular/common/http";

import { GroupktService } from './groupkt.service';

describe('GroupktService', () => {

  beforeEach(() => TestBed.configureTestingModule({
    imports: [HttpClientTestingModule],
    providers: [GroupktService]
  }));

  it('should list the countries', () => {
    let service = TestBed.get(GroupktService);
    let http = TestBed.get(HttpTestingController);

    let actualCountries = [];
    service.getAllCountries()
      .subscribe(
      value => {
        //console.log(value);
        actualCountries = value;
      },
    );

    let countryBaseUrl = 'http://xinkejun.azurewebsites.net/country/';
    const expectedCountries = [{ name: 'India' }];
    http.expectOne(countryBaseUrl + '/get/all').flush(expectedCountries);

    //console.log(actualCountries);
    //console.log(expectedCountries);
    expect(actualCountries).toEqual(expectedCountries);

  });

});
