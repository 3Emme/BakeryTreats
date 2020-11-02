# __Factory__

#### __An application which a user can use to manage engineers and machinery. October 23, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's 12th week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:

The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Project Objectives:

  * Does at least one of your classes have all CRUD methods implemented in your app? [Complete]
  * Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it? [Complete]
  * Are users able to register, log in and log out with Identity? [Complete] 
  * Is Create, Update and Delete functionality limited to authenticated users? [Complete]
  * Is the project in a polished, portfolio-quality state? [Complete]
  * Was required functionality in place by the 5:00pm Friday deadline? [Complete]
  * Does the project demonstrate all of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology? [Complete]

## Previous Objectives

For reference, here are the previous weeks' objectives:
  * Project uses two or more controllers. [Complete]
  * GET and POST requests/responses are used successfully. [Complete]
  * MVC routes follow RESTful conventions. [Complete]
  * Logic is easy to understand. [Complete]
  * Build files are included in .gitignore file and are not be tracked by Git [Complete]
  * Code and Git documentation follows best practices (descriptive variables names, proper indentation and spacing, separation between front and back-end logic, detailed commit messages in the correct tense, and a well-formatted README). [Complete]

## Specs

  1.[X] Treat index and Flavor index and create views. 
    * Input:
    * Output:

  2.[X] Treat and Flavor detail views.
    * Input:
    * Output:

  3.[X] Treat and Flavor edit views.
    * Input:
    * Output:

  4.[X] Treat and Flavor join tables with addTreat and addFlavor views.
    * Input:
    * Output:

  5.[X] Removal for Treats, Flavors, and their joins.
    * Input:
    * Output:
  
  6.[X] Splashpage for all Treats and Flavors.
    * Input:
    * Output:

  7.[X] Identity inclusion.
    * Input:
    * Output:
  
  8.[X] Authentication added to all CUD; leaving only R for un-authed users.
    * Input:
    * Output:

## Setup/Installation Requirements

* First, recreate the database schema by connecting to a local instance within MySql Workbench (instal information can be found here if you have not already done so https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)

* Then, to run the application:
* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/BakeryTreats", then press enter_
* _locate and open directory on desktop named "BakeryTreats" with your console of choice_
* _If necessary, update the appsettings.json file with your personal mysql username/password:_
  * {"ConnectionStrings": {"DefaultConnection": "Server=localhost;Port=3306;database=bakery_treats;uid={YOUR USERNAME};pwd={YOUR USERNAME}"}
* _(in console) locate and move to the directory inside called OrderTrack_
* _(in console) run $dotnet restore_
* _(in console) run $dotnet build_
* _(in console) run $dotnet ef database update_
* _(in console) run $dotnet run_

## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

  * .NET Core
  * ASP .NET MVC
  * Entity Framework
  * Identity
  * MySQL


### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.