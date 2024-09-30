Hello!

To setup this app, please ensure you have the .NET Core SDK installed. https://dotnet.microsoft.com/en-us/download
Thereafter, you can either 
	1) manually run the "update-database" PMC command to seed the database in MS SQL Server;
	2) or you can restore the "Docs\FoodDb.BAK" backup database to your instance.
	
Before you build and execute the console application, 
	please remember to go to the "(4. Presentation)\MetroFibre\appsettings.json" file, and update your local connectionstring in property:
	"ConnectionStrings": {
		"FoodDbConnection": "{Your ConnectionString Here}"
	}
	
Once done, please ensure the "(4. Presentation)\MetroFibre" project is set as the Startup project and build and run the application.

Thank you kindly for this opportunity.
