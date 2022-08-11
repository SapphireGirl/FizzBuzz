## Capital Services Technical Assessment

Here is the process I did to create these 4 project.
Each project except for the Database project has a Requirements.md file

1.  For Requirement 1a.  FizzBuzz I created the console App.
	To set up the string for the FizzBuzz I used a ternary.  
	I could have used just if statements or created a Divisor Strategy Pattern
	but I can refactor for that type of pattern.

	I set this as the Startup Project and used the debugger to test.

2.  For Requirement 1b, I Created the FizzBuzz.Database project just to house the sql scripts
	I also created the FizzBuzz.Core project.  The goal for the FizzBuzz.Core project was to ultimately create 
	2 repositories, 1 for Entity Framework and 2 for Dapper.  Unfortunately I ran out of time to 
	create the Dapper Repository.
	I created a service to use the EF Repository to call the Stored Procedure.  I am using 
	.NET Core 6 and we can talk about that decision.  EF has removed the methods from the 
	Database Facade that originally called Raw SQL and Stored Procedures in .NET 6 so more 
	investigation on how to call the Stored Procedure is still needed including configuring EF
	to use the connection string for my SQL Server db.


	For Requirement 2 I created the FizzBuzz.Web project.  This project has the home controller
	that has the 2 methods.  Just to be quick I populated the ViewModel with a list of users
	and then call the method to seed the users in the controller method.

	I believe it is important to stay up with .NET technology and this is why I was using
	Entity Framework 6.  I believe that last time I used EF was in .NET framework.

	Time spend on these projects:  I work during the day so I had lunch and after work to work
	on this project.  Aprox 10 hours.

	I has been since 2014 that I have used ASP.MVC so I have to refresh my recollection.
	I also need to add a .gitignore and push this to a github repository.

	Thank you for your time
