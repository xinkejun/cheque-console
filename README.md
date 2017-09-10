# Technical Test Project

This project is for technical test only.

## Technical points

1. Application is written in Visual Studio(WebAPI) and VSCode(Angular)
1. Bootstrap for UI.
1. Typescript as programming language.
1. Karma and Jasmine as unit test framework

## Check test result directly

please visit below url to check the full result
> http://xinkejun.azurewebsites.net/technical-test/country-search

## How to set up back-end (Web API) locally

Create new website and map local path "\Iasset\WebAPI" to the site root, then create new site port for this site(e.g. 8080)

## How to set up the front-end locally

Install Node.js and npm if they are not already on your machine.
Verify that you are running at least node 6.9.x and npm 3.x.x by running node -v and npm -v in a terminal/console window. Older versions produce errors, but newer versions are fine.

Then install the Angular CLI globally.(please wait for several minutes)
```
npm install -g @angular/cli
```
Clone the repository from GitHub
```
git clone https://github.com/xinkejun/technical-test.git technical-test
```
Launch below command for dev server.
```
cd technial-test
npm install (please wait for several minutes)
npm start
```

Change WebAPI base url path in file groupki.service.ts
By default the base url is http://xinkejun.azurewebsites.net/country/
please change it to backend url.

Navigate to `http://localhost:4235/`. The app will automatically reload if you change any of the source files.

## Unit Test
There is basic test case in file \technial-test\iasset\iasset.spec.ts
