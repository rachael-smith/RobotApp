# RobotApp
An app that allows a user to:
- Create robots 
- Edit robots
- View leaderboads
- Have robots perform chores
## Stack
- Front end: Razor Script, CSS, Jquery
- API: .Net Core
- Data: SQLite
## How To Run
1. Clone Repository
2. Open Project in Visual Studio 
3. Restore Project NuGet Dependencies
    -   Right click Solution
    -   Find and select "Restore Nuget Packages"
 4. Configure Projects for Run (must set the API project due to SQLite db)
    -   Right click "RobotApp.API" project
	    - Find and select "Properties"
	    - On the lefthand nav bar find and select "Debug"
	    - Set Profile to "RobotApp.API"
	    - Set Launch to "Project"
	    - Save and close that file
5.  Set Startup Projects
	- Find and select "Properties"
	    - Select "Multiple Startup Projects"
	    - Set the "RobotApp.API" to "Start"
	    - Set the "RobotApp.WebApp" to "Start"
    #### Note: db is included (didn't add seeding to the project so included db to allow people to run)
## Run
Press F5 or the "Start" button in Visual Studio after following the steps above
## Libraries Used
- Bootstrap
- Notify.js
- Jquery
