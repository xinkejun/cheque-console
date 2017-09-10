import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpErrorResponse } from "@angular/common/http";

import { Country } from './groupkt.model';

interface SingleCountryResponse {
    RestResponse: {
        messages: string;
        result: Country;
    };
}

interface MultipleCountryResponse {
    RestResponse: {
        messages: string;
        result: Country[];
    };
}

@Injectable()
export class GroupktService {

    private countryBaseUrl = 'http://xinkejun.azurewebsites.net/country/';

    constructor(private http: HttpClient) { }

    getAllCountries() {
        return this.http.get<MultipleCountryResponse>(this.countryBaseUrl + '/get/all')
    }

    getCountryByAlpha3Code(code: string) {
        return this.http.get<SingleCountryResponse>(this.countryBaseUrl + '/get/iso3code/' + code)
    }

    searchCountries(text: string) {
        return this.http.get<MultipleCountryResponse>(this.countryBaseUrl + '/search?text=' + text)
    }

}