# <span style="color:#0ec2b8">_Travel API app_</span>

#### _Travel API app_
#### _Initialization Date: 01/21/2021_

#### By _**Nataliya Zhuravleva, Constantine Yakubovski**_

## <span style="color:#0ec2b8">Description</span>

_The API that functions as a archive for the reviews to help travelers to be familiar with particular destination. This application is built utilizing C# ASP.NET Core, its ORM Entity, MySQL Database (and Workbench) and RESTful principles. The user is able to see the in-use version of the API when using Postman/Swagger._  

## <span style="color:#0ec2b8">Setup/Installation Requirements</span>

### <span style="color:#0ec2b8">Required Technologies (see install instructions below)</span>
* _C# .NET Core Ver 2.2.0_
* _MySQL Ver 8.0.15 & MySQL Workbench_
* _Swagger Ver 13.10.1_
* _Modern Web Broswer_
* _Text Editor (e.g.VisualStudio Code)_

### <span style="color:#0ec2b8">.NET Installation</span> 

#### <span style="color:#c4f4ef">Mac</span> 

1. _Download this [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) . Clicking this link will prompt a `.pkg file` download from `Microsoft`._
2. _Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests._ 
3. _Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`. You should see something like this in response: `2.2.105. This means both .NET and C# are successfully installed`._

#### <span style="color:#c4f4ef">Windows</span> 
Note on Windows Versions
These Windows instructions assume you're using Windows 10. If you currently run Windows 7 or Windows 8, you may have a free upgrade available.
If you are not running Windows 10 (and cannot or do not plan to upgrade), specific installation steps may differ. 
#### Installation Steps:
1. _Download either the the 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft._
2. _Open the file and follow the steps provided by the installer for your OS._
3. _Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `version numbers do not need to be the same: 2.2.105`_<br>
_This means .NET and C# are installed and your computer recognizes the dotnet command._

### <span style="color:#0ec2b8">MySQL Installation</span>
#### <span style="color:#c4f4ef">Mac</span> 
1. _Download the MySQL Community Server `.dmg file` from the [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). Click the `download` icon. Use the `No thanks, just start my download link.`_
2. _Follow along with the Installer until you reach the `Configuration` page. Once you've reached `Configuration`, select or set the following options (use default if not specified):_
    * _Use `Legacy Password Encryption`._
    * _Set password to `epicodus`._
    * _Click `Finish`._
    * _Open the terminal and enter the command echo `'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in `.bash_profile`, which is where our terminal is configured._
    * _Type in source `~/.bash_profile` (or restart the terminal) in order to actually verify that MySQL was installed._
3. _Verify MySQL installation by opening terminal and entering the command `mysql -uroot -pepicodus`. You'll know it's working and connected if you gain access and see the MySQL command line. If it's not working, you'll likely get a `-bash: mysql: command not found error`._
4. _You can exit the mysql program by entering `exit`._
5. _Download the MySQL Workbench `.dmg file` from the [MySQL Workbench page](https://dev.mysql.com/downloads/file/?id=484391). Use the `No thanks, just start my download link`._
6. _Install `MySQL Workbench` to Applications folder._
7. _Open `MySQL Workbench` and select the `Local instance 3306 server`. You will need to enter the password `epicodus`. If it connects, you're all set._

#### <span style="color:#c4f4ef">Windows</span> 
1. _Download the `MySQL Web Installer` from the [MySQL Downloads page](https://dev.mysql.com/downloads/file/?id=484919). Use the `No thanks, just start my download link`._
2. _Follow along with the installer:
    * _Click `Yes` if prompted to update._
    * _Accept license terms._
    * _Choose `Custom setup` type._
    * _When prompted to `Select Products and Features`, choose the following:_
        * _MySQL Server 8.0.19 (This will be under `MySQL Servers > MySQL Server > MySQL Server 8.0`)_
        * _MySQL Workbench 8.0.19 (This will be under `Applications > MySQL Workbench > MySQL Workbench 8.0`)_
    * _Select `Next`, then `Execute`. Wait for download and installation. (This can take a few minutes.)_
    * _Advance through Configuration as follows:_
        * _High Availability set to `Standalone`._
        * _Defaults are OK under Type and Networking._
        * _`Authentication Method set` to Use Legacy Authentication Method._
        * _Set password to `epicodus`._
        * _Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options `Configure MySQL Server as a Windows Service` and `Start the MySQL Server at System Startup`. Under Run Windows Service as..., the `Standard System Account` should be selected._
    * _Complete Installation process._
3. _Add the MySQL environment variable to the System PATH. You must include MySQL in the System Environment Path Variable. This is its own multi-step process:_
    * _Open the Control Panel and visit System and `Security > System`. Select `Change Settings` and a pop-up window will display. Select the tab `Advanced` and select the `Environment Variables` button._
    * _Within the System Variables navigator window, select PATH..., click `Edit...`, and then `New`._
    * _Add the exact location of your MySQL installation, and click OK. (This location is likely `C:\Program Files\MySQL\MySQL Server 8.0\bin`, but may differ depending on your specific installation.)_
4. _Verify installation by opening Windows PowerShell and entering the command `mysql -uroot -pepicodus`. You'll know it's working and connected if you gain access and see MySQL's command line. You can exit the mysql program by entering exit._
5. _Open MySQL Workbench and select the `Local instance 3306 server` (it may have a different name). You will need to enter the password `epicodus`. If it connects, you're all set._

### <span style="color:#0ec2b8">Install Postman (optional)</span>
Download and install `Postman` from the [Postman page](https://www.postman.com/downloads/).

### <span style="color:#0ec2b8">Packages To Install:</span>
_In the command line run the following commands to install packages:
1. _$ `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`_
2. _$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`_
2. _$ `dotnet add package NSwag.AspNetCore --version 13.10.1`_


### <span style="color:#0ec2b8">Cloning the project</span>
1. _Navigate to my [Travel.Solution repo](https://github.com/faustlarsen/Travel.Solution) at https://github.com/faustlarsen/Travel.Solution_ to view the project files and commits.
2. _Click on the green button labeled `Code`_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command `git clone https://github.com/faustlarsen/Travel.Solution`.
4. _Navigate to the folder `/Travel` to see coding._
6. _To use this application you will need to install .NET. Please, see instructions below._

### <span style="color:#0ec2b8">Downloading the project</span>
1. _Navigate to my [Travel.Solution repo](https://github.com/faustlarsen/Travel.Solution) at https://github.com/faustlarsen/Travel.Solution_ to view the project files and commits.
2. _Click on the green button labeled `Code`_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command `git clone https://github.com/faustlarsen/Travel.Solution`.

### <span style="color:#0ec2b8">App Settings</span>
1. _Open in the `Travel/` directory the file named `appsettings.json`_
2. _Change the server, port, and user id as necessary. Replace `YourPassword` with relevant MySQL password (set at installation of MySQL)._
```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=travel;uid=root;pwd=YourPassword;"
  }
}
```

### <span style="color:#0ec2b8">Import Database Structure with Entity Framework Core</span>
1. _Navigate to the `Travel` directory in your terminal._
2. _Run the command `dotnet ef database update` which will use the mirgrations folder to create the MySQL Database using Entity Framework Core._
3. _(_OPTIONAL_) If you need to make adjustments to the database, use the command `dotnet ef migrations add <NameOfNewMigration>` and then run `dotnet ef database update` again to apply the changes._

### <span style="color:#0ec2b8">Import Database Structure with MySQL Workbench</span>
1. _Open MySQL Workbench and enter your password._
2. _Go to the nav bar at the top, click on `Server > Data Import`._
3. _Use the the option `Import from Self-Contained File`._
4. _Set the Default Target Schema or create a new schema._
5. _Select all Schema Objects you wish to import._
6. _At the bottom, ensure the option Dump Structure and Data is selected._
7. _Click `Start Import`._

### <span style="color:#0ec2b8">Running Program</span> 
#### <span style="color:#c4f4ef">Run Application</span>

1. _Use `travel.sql` file to access database_ 
2. _Navigate to the `Travel/` folder in the command line._
3.  _Run the following command: $ `dotnet restore`_
4. _Run the following command: $ `dotnet build`_
5. _Run the following command to execute this compiled code: $ `dotnet run`_

#### <span style="color:#c4f4ef">Launch the API</span>
1. _Navigate to Travel.Solution/Teavel directory using the MacOS Terminal (e.g. cd Desktop/Travel.Solution/Travel)._
2. _Run the command `dotnet run` to have access to the API in Postman or browser._
3. _If you use browser, open the [Swagger UI](http://localhost:5000/swagger/index.html#/Reviews) to view and test the different routes of this API!


## <span style="color:#0ec2b8">API Documentation</span>
Explore the API endpoints in Postman or a browser.
### <span style="color:#0ec2b8">End Points</span>

Base URL: https://localhost:5000
#### <span style="color:#c4f4ef">HTTP Request Structure</span>
```
- GET /api/reviews
- POST /api/reviews
- GET /api/reviews/{id}
- PUT /api/reviews/{id}
- DELETE /api/reviews/{id}
```
#### <span style="color:#c4f4ef">Example Query</span>

```
http://localhost:5000/api/Reviews/2
```
#### <span style="color:#c4f4ef">Sample JSON Response</span>


```
{
"reviewId": 2,
"country": "USA",
"city": "Los Angeles, CA",
"reviewText": "Dirty city",
"author": "Pamela Anderson",
"rating": 4
}
```
### <span style="color:#0ec2b8">Here is an example how to use Swagger</span>

Open URL: http://localhost:5000/swagger/index.html#/Reviews

1. Click Review
2. Click Get
3. Click Try it out


[![Image from Gyazo](https://i.gyazo.com/110bfcd3b75bf7e81d5705462b11bee8.gif)](https://gyazo.com/110bfcd3b75bf7e81d5705462b11bee8)


4. Type Mexico
5. Click Execute
6. Enjoy

[![Image from Gyazo](https://i.gyazo.com/5c24d2f6f4eaada62940e583218feb8b.gif)](https://gyazo.com/5c24d2f6f4eaada62940e583218feb8b)



## <span style="color:#0ec2b8">Known Bugs</span>

_No known bags_

## <span style="color:#0ec2b8">Support and contact details</span>

_If you have any questions, ideas or concerns, please, contact us:_
* Nataliya Zhuravleva at [natalindria@gmail.com](mailto:natalindria@gmail.com)_
* Constantine Yakubovski at [faustlarsen@gmail.com](mailto:faustlarsen@gmail.com)_


## <span style="color:#0ec2b8">Technologies Used</span>

* _C#_
* _.NET_
* _MySQL_
* _MySQL Workbench_
* _Swagger_
* _VisualStudio Code_
* _Git_
* _GitHub_



### <span style="color:#0ec2b8">License</span> 

*This software is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license*

Copyright (c) 2020 **_Nataliya Zhuravleva, Constantine Yakubovski_**
