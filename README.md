# Cheque Console

This project is for Deepend techniquie test.

## Technical points

- Angular 4 as code scaffoding.
- Typescript as programming language.
- Bootstrap for css.
- No CMS in this test project.

## How to set up the development environment

Install Node.js and npm if they are not already on your machine.
Verify that you are running at least node 6.9.x and npm 3.x.x by running node -v and npm -v in a terminal/console window. Older versions produce errors, but newer versions are fine.

Then install the Angular CLI globally.(please wait for several minutes)
```
npm install -g @angular/cli
```
Clone the repository from GitHub
```
git clone https://github.com/xinkejun/cheque-console.git cheque-console
```
Launch below command for dev server.
```
cd cheque-console
npm install (please wait for several minutes)
npm start
```
Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## How to check core functionalities

To change the cheque data source, please change file \src\app\shared\in-memory-data.service.ts

The "cheque amount to words" function locate in \src\app\cheques\shared\cheque.service.js