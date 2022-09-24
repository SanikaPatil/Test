Information About Project :

-Created an Application to read database and get values for Temperature, Wight and Distance and Convert those values from Imperial to Metric and Vice versa
-Created this application using .Net 6.0 (which is the latest version)
-Used NugetPackages like Microsoft.EntityFrameworkCore.SqlServer,Newtonsoft.Json and Swashbuckle.AspNetCore
-Used Xunit for executing testcases and intslled Moq package for mocking

Instructions :

Set MMS_Test as startup project and press F5 to execute

Database Details :
An SQL DataBase MMS_Project was created
Connection String is given in appsettings.json
Table by the name MetricTable was created
	- Couluns : Sr_No,Temperature,Distance,Weight
	- Sr_No is primary key
	- All columns Do Not Allow Nulls
	