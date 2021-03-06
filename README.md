# <img src="https://i.ibb.co/3TqB32g/Copy-of-Animal-Shelter-API-1.png" alt="Copy-of-Animal-Shelter-API-1" border="0"></a>

## 🚩 Table of Contents

- [Description](#-description)
- [Requirements](#-requirements)
- [Setup/Instructions](#-setup)
- [Postman](#-postman-installation-&-configuration)
- [JWT Instructions](#-json-web-token-instructions)
- [End Points](#-Endpoints)
- [Technologies](#-Technologies)
- [Bugs](#-Known-Bugs)
- [Contact](#-contact)
- [License](#-license)
<br>
<br>

## Description

The Animal Shelter API is built using C#/.NET. Once a user aquires a token they will have the ability to view current animals/shelters, update/add listings, edit specific animals or shelters, and also delete listings.

<br>

## Requirements

| Name | Description |
| :--- | :--- |
| [.NET Core 2.2](https://github.com/nhn/tui.editor/tree/master/apps/jquery-editor) | [Framework](https://dotnet.microsoft.com/) used in this project |
| [MySQL For Mac](https://dev.mysql.com/downloads/file/?id=484914) | [](https://reactjs.org/) Open Source [DataBase](https://www.mysql.com/)  |
| [MySQL For Windows](https://dev.mysql.com/downloads/file/?id=484919) | [](https://reactjs.org/) Open Source [DataBase](https://www.mysql.com/)  |
| [Visual Studio Code](https://code.visualstudio.com/) | [](https://reactjs.org/) Source-Code Editor  |
| [MySQL Workbench](https://www.mysql.com/products/workbench/) | [Tool](https://www.mysql.com/products/workbench/) to Visualize Data  |
| Click [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to get help with SQL 
<br>

## Setup
1) Create a directory called AnimalShelter.Solution then navigate to it
```sh
$ mkdir AnimalShelter.Solution
```

1) Clone this projects GitHub Repository into a local directory 

```sh
$ git clone https://github.com/smoody0208/AnimalShelter.Solution.git
```
2) In your terminal enter the following code to navigate to the correct directory and open the project

```sh
$ cd AnimalShelter.Solution
$ code .
```
3) Once the project is open you can enter the following into the terminal
```sh
$ dotnet restore
$ dotnet build
$ dotnet ef database update
```
4) Next update the appsettings.json file to look like this:

```
{
  "AppSettings": {
    "Secret": "shhhhhhhhhhhhhhhhhhhhhhhhhhhh"
  },

  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=spencer_moody;uid=root;pwd=epicodus;"
  }
}
```

4) Your application should now be built and have the correct database structure in place to run this application. Next we will run the program with the following code
```sh
$ dotnet watch run
```

## Postman Installation & Configuration
Postman is a tool which enables people to test calls to APIs. Follow these steps to get this program up and running.

1) Download [Postman](https://www.postman.com/downloads/)
2) Once you open Postman the first thing you will need to do is get your authorization token.

## JSON Web Token Instructions 
(Needed for all GET/POST requests)
1) In Postman enter `http://localhost:5000/users/authenticate` 
2) Next click the drop down menu and select "POST"
3) Then select "Body", then "raw" and click the dropdown menue and choose JSON and enter the following in the Body:

```
{
  "username": "Admin",
  "password": "Admin"
}
```

4) Click Send, your login information and Token will be displayed below

5) To use the provided Token for various Post/Get requests, click on the "Authorization" tab, next in the dropdown menue change the authorization type to "Bearer Token".

6) Then enter your token into the provided field.

7) Now you will have complete access to the API.

## Endpoints
| Endpoint | Method
| --- | --- |
| /api/shelters | GET |
| /api/shelters | POST |
| /api/shelters/{id} | GET |
| /api/shelters/{id} | PUT |
| /api/shelters/{id} | DELETE |
| /api/animals | GET |
| /api/animals | POST |
| /api/animals/{id} | GET |
| /api/animals/{id} | PUT |
| /api/animals/{id} | DELETE |

## Technologies

* C#
* .NET Core
* MVC
* Git
* JWT
* MySQL

## Known Bugs

_No known bugs at this time.

## Contact

Contact : [Spencer Moody](spencer.moody@outlook.com)_

## License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)